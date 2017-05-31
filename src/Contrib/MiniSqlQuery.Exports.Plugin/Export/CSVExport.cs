using System;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Windows.Forms;
using MiniSqlQuery.Core;

namespace MiniSqlQuery.Exports.Plugin.Export
{
	public class CSVExport
	{
		#region Delegates

		public delegate void WrittenData(string text);

		#endregion

		public static event WrittenData OnWrittenData;

		public static void ExportToCSV(IApplicationServices services, DataTable source, string fileName,
		                               bool fileNamesFirstRow, string delim, string quoting, string trimming,
		                               bool dumpAll, string sql)
		{
			// Create the CSV file to which grid data will be exported.
			StreamWriter sw = new StreamWriter(fileName, false);
			if (dumpAll)
			{
				DbConnection conn = services.Settings.GetOpenConnection();
				DbCommand cmd = conn.CreateCommand();
				cmd.CommandText = sql;
				cmd.CommandTimeout = 0;
				DbDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					int iQuoting;
					int iColCount = 0;
					if (quoting == "Never")
					{
						iQuoting = 0;
					}
					else if (quoting == "Always")
					{
						iQuoting = 2;
					}
					else
					{
						iQuoting = 1;
					}
					if (fileNamesFirstRow)
					{
    					iColCount = reader.FieldCount;
						for (int i = 0; i < iColCount; i++)
						{
							CsvWrite(sw, reader.GetName(i), iQuoting, delim);
							if (i < iColCount - 1)
							{
								sw.Write(delim);
							}
							if (OnWrittenData != null)
							{
								OnWrittenData(string.Format("Wrote column name {0}", i));
							}
						}
						sw.Write(sw.NewLine);
						if (OnWrittenData != null)
						{
							OnWrittenData("Wrote filednames row..");
						}
					}
					// Now write all the rows.
					int counter = 0;
					while (reader.Read())
					{
						for (int i = 0; i < iColCount; i++)
						{
						    object datatemp;
							try {
						    	datatemp = reader[i];
							}
						    catch (Exception e)
						    {
						    	datatemp = DBNull.Value;
    						    if (OnWrittenData != null)
						        {
						    	    OnWrittenData(string.Format("Exception caught on row {0}", counter) + e.Message);
    						    }
						    }
							if (!Convert.IsDBNull(datatemp))
							{
   					            string rawdata = datatemp.ToString();
  			                    if ((trimming == "Left") || (trimming == "Both"))
						        {
						            rawdata = rawdata.TrimStart();
						        }
					                if ((trimming == "Right") || (trimming == "Both"))
						        {
						            rawdata = rawdata.TrimEnd();
						        }
 					            CsvWrite(sw, rawdata, iQuoting, delim);
							}
							else
    						{
						        CsvWrite(sw, "", iQuoting, delim);
						    }
							if (i < iColCount - 1)
							{
								sw.Write(delim);
							}
						}
						sw.Write(sw.NewLine);
						counter++;
						if (OnWrittenData != null)
						{
							OnWrittenData(string.Format("Wrote row {0}", counter));
						}
					}
				}
				sw.Close();
				if (OnWrittenData != null)
				{
					OnWrittenData("Finished exporting CSV file to " + fileName);
				}
				reader.Close();
				cmd.Dispose();
			}
			else
			{
				// First we will write the headers.
				DataTable dt = source;
				int iColCount = dt.Columns.Count;
				int iQuoting;
				if (quoting == "Never")
				{
					iQuoting = 0;
				}
				else if (quoting == "Always")
				{
					iQuoting = 2;
				}
				else
				{
					iQuoting = 1;
				}
	
				if (fileNamesFirstRow)
				{
					for (int i = 0; i < iColCount; i++)
					{
						CsvWrite(sw, dt.Columns[i].ColumnName, iQuoting, delim);
						if (i < iColCount - 1)
						{
							sw.Write(delim);
						}
						if (OnWrittenData != null)
						{
							OnWrittenData(string.Format("Wrote column name {0}", i));
						}
					}
					sw.Write(sw.NewLine);
					if (OnWrittenData != null)
					{
						OnWrittenData("Wrote filednames row..");
					}
				}
				// Now write all the rows.
				int counter = 0;
				foreach (DataRow dr in dt.Rows)
				{
					for (int i = 0; i < iColCount; i++)
					{
						if (!Convert.IsDBNull(dr[i]))
						{
   					        string rawdata = dr[i].ToString();
  			                if ((trimming == "Left") || (trimming == "Both"))
						    {
						        rawdata = rawdata.TrimStart();
						    }
					        if ((trimming == "Right") || (trimming == "Both"))
						    {
						        rawdata = rawdata.TrimEnd();
						    }
 					        CsvWrite(sw, rawdata, iQuoting, delim);
						}
						else
						{
						    CsvWrite(sw, "", iQuoting, delim);
						}
						if (i < iColCount - 1)
						{
							sw.Write(delim);
						}
					}
					sw.Write(sw.NewLine);
					counter++;
					if (OnWrittenData != null)
					{
						OnWrittenData(string.Format("Wrote row {0}", counter));
					}
				}
				sw.Close();
				if (OnWrittenData != null)
				{
					OnWrittenData("Finished exporting CSV file to " + fileName);
				}
			}
		}

		/// <summary>
		/// Perform a CSV compliant wtrite of <paramref name="text"/> to the <paramref name="sw"/>.
		/// Handles commas, quotes and newlines.
		/// </summary>
		/// <param name="sw">The writer.</param>
		/// <param name="text">The text.</param>
		private static void CsvWrite(TextWriter sw, string text, int quoting, string delim)
		{
			if (text != null)
			{
				if (quoting == 0)  // no quoting selected
				{
					sw.Write(text);
				}
				else
				{
					bool needsQuotes = false;
					// if the data contains a double quote, the delimeter, a carriage return
                    // or a line feed then we need to double quote it.					
					if (text.Contains("\"") || text.Contains(delim) || text.Contains("\n") || text.Contains("\r"))
					{
						needsQuotes = true;
						// replace any single double quote in the data with two double quotes
						text = text.Replace("\"", "\"\"");
					}
					// if we are doing When Needed quoting (and we needed to) or Always quoting
					// then we surround the data in double quotes
					if (needsQuotes || (quoting == 2))
					{
						// surround entire field in quotes
						text = string.Concat("\"", text, "\"");
					}
					sw.Write(text);
				}
			}
			else
			{
				if (quoting == 2) // always double quote selected
				{
				    // surround entire field in quotes
					text = string.Concat("\"", "\"");
					sw.Write(text);
				}
			}
		}
	}
}