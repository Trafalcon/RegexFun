using System.Collections.Generic;

namespace RegexFun
{
    public class FileFormatter
    {
        public LinkedList<string> FormatColumnNames(LinkedList<string> commandsToBeFormatted) //ApplicationNumber
        {

            return commandsToBeFormatted;
        }

        public LinkedList<string> FormatAtSignColumnNames(LinkedList<string> commandsToBeFormatted) //@ApplicationNumber
        {

            return commandsToBeFormatted;
        }

        public LinkedList<string> FormatSqlColumnNames(LinkedList<string> commandsToBeFormatted) //ApplicationNumber BIGINT
        {

            return commandsToBeFormatted;
        }

        public LinkedList<string> FormatCommandOne(LinkedList<string> commandsToBeFormatted) //command.Parameters.Add("ApplicationNumber", SqlDbType.BigInt);
        {

            return commandsToBeFormatted;
        }

        public LinkedList<string> FormatCommandTwo(LinkedList<string> commandsToBeFormatted) //command.Parameters["ApplicationNumber"].Value = ccCustInfo.ApplicationNumber;
        {

            return commandsToBeFormatted;
        }
    }
}
