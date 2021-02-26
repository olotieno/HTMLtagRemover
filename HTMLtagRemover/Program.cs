using System;
using System.Text;
using System.IO; 

namespace HTMLtagRemover
{
    class Program
    {
        private const string InputFileName = "Problem1.html";
        private const string Charset = "windows - 1251"; 

        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            StreamReader reader = new StreamReader(InputFileName);
            String reader; 

            if(!File.Exists(InputFileName) == null)
            {

                Console.WriteLine("File" + InputFileName + "does not exist"); 
            }
           
        }
    }
}
