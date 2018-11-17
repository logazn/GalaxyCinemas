using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using Common;
namespace GalaxyCinemas
{
    public class MovieImporter : BaseImporter
    {
        public MovieImporter(string filename) : base(filename)
        {

        }


        /// <summary>
        /// Import movie file. Filename has been provided in the constructor.
        /// </summary>
        public override void Import(object o)
        {
            ImportResult results = new ImportResult();

            Progress = 0;// Initialise progress to zero for progress bar.

            try
            {
                // Read file
                string fileData = null;
                using (StreamReader reader = File.OpenText(fileName))
                {
                    // Read file  using ReadToEnd
                    String line = reader.ReadToEnd();
                }
                string[] lines = fileData.Replace("\r\n", "\n").Replace("\r", "\n").Split('\n'); // To deal with Windows, Mac and Linux line endings the same.

                // Check if first line is column names.
                String firstLine = lines[0];

                String[] columns = firstLine.Split(',');

                if (columns.Length != 2)
                {
                    lines[0] = "";
                }





                // Line count and line numbers to allow progress tracking.
                int lineCount;
                lineCount = lines.Length;
                int lineNum = 1;


                List<Movie> movies = DataLayer.DataLayer.GetAllMovies();

                // Get all movies.


                foreach (string line in lines)
                {
                    try
                    {

                        // Check whether we need to stop after importing each line.
                        if (Stop)
                        {
                            return;
                        }


                        // Just to make it slow enough to test stopping functionality.
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
                        if (columns.Length != 2)
                        {
                            results.FailedRows++;
                            results.ErrorMessages.Add(string.Format("Line {0}: Wrong number of columns.", lineNum));
                            continue;
                        }

                        // Check the format of data, and update ImportResult accordingly.
                        int movieID = 0;
                        if (!int.TryParse(columns[0], out movieID))
                        {
                            results.FailedRows++;
                            results.ErrorMessages.Add(string.Format("Line {0}: MovieID is not a number.", lineNum));
                            continue;
                        }
                        String title;
                        title = columns.ToString();
                        title = title.Trim();

                        if (title == null)
                        {
                            results.FailedRows++;
                            results.ErrorMessages.Add(string.Format("Line {0}: title is empty", lineNum));

                            continue;
                        }




                        // Insert/update DB if okay.
                        Movie movieToUpdate = movies.Where(m => m.movieId == movieID).FirstOrDefault();
                        
                        if (movieToUpdate == null)
                        {
                            Movie movieToAdd = new Movie(); //{
                              //  SetMovieId(movieID), title = title
                            //};
                            movieToAdd.SetMovieId(movieID);
                            movieToAdd.SetTitle(title);
                            DataLayer.DataLayer.AddMovie(movieToAdd);
                        }
                        else
                        {

                            movieToUpdate.SetTitle(title);
                            movieToUpdate.SetMovieId(movieID);
                          //  movieToUpdate title = title;
                          
                            DataLayer.DataLayer.UpdateMovie(movieToUpdate);
                        }
                        results.ImportedRows++;


                    }
                    finally
                    {
                        lineNum++;
                    }

                }


            }
            catch (System.IO.IOException ex)
            {
                results.ErrorMessages.Add("format expection");
                Console.WriteLine(ex);
                results.FailedRows++;
            }
            catch(Exception e )
            {
                Console.WriteLine(e);
                results.FailedRows++;
              //  results.ErrorMessages.Add("Exception occurred ");
            }
            finally
            {
                RaiseCompleted(results);

            }
            

    }
    }
}
