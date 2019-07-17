using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RegexFun
{
    public class FileReader
    {
        private StreamReader _fileReader;
        private List<string> _commandsToBeFormatted;
               
        public List<string> ReadListFromFile()
        {
            _fileReader = new StreamReader($"/Input/Input.txt");
            _commandsToBeFormatted = new List<string>();

            _commandsToBeFormatted.Add(_fileReader.ReadLine());
            while (!_fileReader.EndOfStream)
            {
                _commandsToBeFormatted.Add(_fileReader.ReadLine());
            }

            return _commandsToBeFormatted;
        }
    }
}
