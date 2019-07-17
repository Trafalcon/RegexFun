using System.Collections.Generic;
using System.IO;

namespace RegexFun
{
    public class FileWriter
    {
        private StreamWriter _fileWriter;

        public void WriteColumnNames(List<string> formattedCommands)
        {
            _fileWriter = new StreamWriter("/Output/ColumnNames.txt");
            var _lineCount = formattedCommands.Count - 1;

            for(var i = 0; i <= _lineCount; i++)
            {
                _fileWriter.WriteLine($"{formattedCommands[i]}, ");

                if (i % 5 == 0 && i != 0)
                {
                    _fileWriter.WriteLine();
                }

            }

            _fileWriter.Close();
        }

        public void WriteAtSignColumnNames(List<string> formattedCommands)
        {
            _fileWriter = new StreamWriter("/Output/AtSignColumnNames.txt");
            var _lineCount = formattedCommands.Count - 1;

            for (var i = 0; i <= _lineCount; i++)
            {
                _fileWriter.WriteLine($"@{formattedCommands[i]}, ");

                if (i % 5 == 0 && i != 0)
                {
                    _fileWriter.WriteLine();
                }

            }

            _fileWriter.Close();
        }

        public void WriteSqlColumnNames(List<string> formattedCommands)
        {
            _fileWriter = new StreamWriter("/Output/SqlColumnNames.txt");
            var _lineCount = formattedCommands.Count - 1;

            //Write This Bitch

            _fileWriter.Close();
        }

        public void WriteCommandOne(List<string> formattedCommands)
        {
            _fileWriter = new StreamWriter("/Output/CommandOne.txt");
            var _lineCount = formattedCommands.Count - 1;

            //Write This Bitch

            _fileWriter.Close();
        }

        public void WriteCommandTwo(List<string> formattedCommands)
        {
            _fileWriter = new StreamWriter("/Output/CommandTwo.txt");
            var _lineCount = formattedCommands.Count - 1;

            //Write This Bitch

            _fileWriter.Close();
        }
    }
}
