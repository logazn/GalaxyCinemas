using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using Common;
using System.Data.Common;

namespace GalaxyCinemas
{
    public class SessionImporter : BaseImporter
    {
        public SessionImporter(string filename) : base(filename)
        {
        }

        /// <summary>
        /// Import session file. Filename has been provided in the constructor.
        /// </summary>
        public override void Import(object o)
        {
            // Initialise progress to zero for progress bar.
            Progress = 0f;
            ImportResult results = new ImportResult();
            try
            {
                // Read file
                string fileData = null;
                using (StreamReader reader = File.OpenText(fileName))
                {
                    fileData = reader.ReadToEnd();
                }
                string[] lines = fileData.Replace("\r\n", "\n").Replace("\r", "\n").Split('\n'); // To deal with Windows, Mac and Linux line endings the same.

                   String firstLine = lines[0];

                String[] columns = firstLine.Split(',');

                if (columns.Length != 4)
                {
                    lines[0] = "";
                }
                // Check if first line is column names.
                

                // Line count and line numbers to allow progress tracking.
                int lineCount = lines.Length;
                int lineNum = 1;

               

                foreach (string line in lines)
                {
                    // Check whether we need to stop after importing each line.
                    if (Stop)
                    {
                        return;
                    }

                    try
                    {
                        // Just to make it slow enough to testing stopping functionality.
                        Thread.Sleep(500);

                        // Update progress of import.
                        Progress = Progress / lineCount;
                        RaiseProgressChanged();



                        // Skip blank lines
                        if (line.Equals(null))
                        {
                            continue;
                        }
                        if (line != null)
                        {
                            results.TotalRows++;
                        }

                        // Break up line by commas, each item in array will be one column.
                        columns = line.Split(',');


                        // Check the format of data, and update ImportResult accordingly.
                        // Check session ID.

                        int sessionID = 0;
                        if (!int.TryParse(columns[0].Trim(), out sessionID))
                        {
                            results.FailedRows++;
                            results.ErrorMessages.Add(string.Format("Line {0}: sessionid is not a number.", lineNum));
                            continue;
                        }

                        // Check cinema number.
                        byte cinemaNumber = 0;
                        if (!byte.TryParse(columns[3].Trim(), out cinemaNumber) )
                        {
                            results.FailedRows++;
                            results.ErrorMessages.Add(string.Format("Line {0}: cinemanumber is not a number.", lineNum));
                            continue;
                        }
                      
                     

               
                        // Check session date/time.
                        DateTime sessionDate = DateTime.MinValue;
                        if (!DateTime.TryParse(columns[2].Trim(), out sessionDate))
                        {
                            results.FailedRows++;
                            results.ErrorMessages.Add(string.Format("Line{0}: Session date is not a date/time", lineNum));
                            continue;
                        }





                        int.TryParse(columns[1],  out int movieID);


                        // Insert/update DB if okay.
                     //  int movieID = columns[1].Trim();
                        Session sessionToUpdate;
                        sessionToUpdate = DataLayer.DataLayer.GetSessionByID(sessionID);
                        if (sessionToUpdate.Equals(null))
                        {
                            Session sessionToAdd = new Session();
                            sessionToAdd.SetMovieId(movieID);
                            sessionToAdd.SetSessionDate(sessionDate);
                            sessionToAdd.SetSessionId(sessionID);
                            sessionToAdd.SetCinemaNumber(cinemaNumber);
                            DataLayer.DataLayer.AddSession(sessionToAdd);
                        }
                        else
                        { //update session

                          // sessionToUpdate. = title;
                            sessionToUpdate.SetMovieId(movieID);
                            sessionToUpdate.SetSessionDate(sessionDate);
                            sessionToUpdate.SetSessionId(sessionID);
                            sessionToUpdate.SetCinemaNumber(cinemaNumber);
                            DataLayer.DataLayer.UpdateSession(sessionToUpdate);
                        }
                        results.ImportedRows++;














                    }
                    catch (DbException dbx)
                    {
                        Console.WriteLine(dbx);
                        results.FailedRows++;
                        results.ErrorMessages.Add(string.Format("Line {0}: Database error occurred updating data.", lineNum));
                    }
                    finally
                    {
                        lineNum++;
                    }
                }
            }
            catch (System.IO.IOException)
            {
                results.ErrorMessages.Add("Error occurred opening file. Please check that the file exists and that you have permissions to open it.");
            }
            catch (Exception)
            {
                results.ErrorMessages.Add("An unknown error occurred during importing.");
            }
            finally
            {
                // Do callback to end import.
                RaiseCompleted(results);
            }

        
        }

    }
}
