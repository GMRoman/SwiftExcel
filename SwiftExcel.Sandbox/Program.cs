﻿using System.Collections.Generic;

namespace SwiftExcel.Sandbox
{
    internal class Program
    {
        private static void Main()
        {
            //Fill excel document with test data 100 rows x 10 columns
            using (var ew = new ExcelWriter("C:\\temp\\test.xlsx"))
            {
                for (var row = 1; row <= 100; row++)
                {
                    for (var col = 1; col <= 10; col++)
                    {
                        ew.Write($"row:{row}-col:{col}", col, row);
                    }
                }

                ew.Save();
            }


            //Set custom sheet name and define columns width
            var sheet = new Sheet
            {
                Name = "Monthly Report",
                ColumnsWidth = new List<double> { 10, 12, 8, 8, 35 }
            };
            using (var ew = new ExcelWriter("C:\\temp\\test.xlsx", sheet))
            {
                for (var row = 1; row <= 100; row++)
                {
                    for (var col = 1; col <= 10; col++)
                    {
                        ew.Write($"row:{row}-col:{col}", col, row);
                    }
                }

                ew.Save();
            }
        }
    }
}