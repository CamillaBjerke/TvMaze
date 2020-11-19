using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using backend.models;

namespace backend
{
    public class TvMazeReports
    {
        public static void createTop10Report(List<TvMazeSeries> lstAllShowes)
        {
            string fileName = @"reports\Top10.txt";
            string showLine;
            int i = 1;

            List<String> lstTop10ToReport = new List<string>();

            lstAllShowes = lstAllShowes.OrderByDescending(p => p.Rating.Average).ToList();
            lstAllShowes = lstAllShowes.GetRange(0, 10);

            foreach (TvMazeSeries s in lstAllShowes)
            {
                showLine = i + ". rating: " + s.Rating.Average +  " " + s.Name;
                lstTop10ToReport.Add(showLine);
                i++;
            }
            createTextFileFromList(fileName, lstTop10ToReport);
        }

        public static void createSummaryReport(List<TvMazeSeries> lstAllShowes)
        {
            string fileName = @"reports\Summary.txt";
            string showLine;
            int i = 1;
            List<String> lstSummaryToReport = new List<string>();

            foreach (TvMazeSeries s in lstAllShowes)
            {
                showLine = s.Name + ";" + s.Network + ";" + s.Genres.ToString() + ";" + s._Embedded.Episodes.Count + ";"; // + s.Name; Finne ut hvem som er released
                lstSummaryToReport.Add(showLine);
                i++;
            }
            createTextFileFromList(fileName, lstSummaryToReport);
        }


        private static void createTextFileFromList(string fileName, List<String> lstToFile) 
        {
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                System.IO.File.WriteAllLines(fileName, lstToFile);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }
    }
}
