using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            IFileHelper _fileHelper;
            try
            {
                _fileHelper = new FileHelper(new FileDetails(), args);
                Console.WriteLine("Searching File version...............................");
                Console.WriteLine(_fileHelper.GetVersion());
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Searching File Size..................................");
                Console.WriteLine(_fileHelper.GetFileSize());
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _fileHelper = null;
            }
        }
    }
}
