using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Memory
{
    class LoadSave
    {
        private static string fileData = "";
        public static string[,] GetSavefileData()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()), "saves");
            if (openFileDialog.ShowDialog() == true)
            {
                fileData = File.ReadAllText(openFileDialog.FileName);

                fileData = fileData.Replace('\n', '\r');

                //Split lines into string
                string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

                //Get total rows and columns
                int totalRows = lines.Length;
                int totalCols = lines[0].Split(';').Length;

                //Make new 2d array
                string[,] resultVals = new string[totalRows, totalCols];

                //Place data in array
                for (int row = 0; row < totalRows; row++)
                {
                    string[] line_r = lines[row].Split(';');

                    for (int col = 0; col < totalCols; col++)
                    {
                        resultVals[row, col] = line_r[col];
                    }
                }

                return resultVals;
            }
            else
            {
                return null;
            }
        }
    }
}
