using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningConsole.ClassFolders
{
    public static class Jumoke
    {
        private static void MyBioGraphy()
        {
            var thePersonName = "Oluwatosin";
            Console.WriteLine($"Name: My name is {thePersonName}");
            Console.WriteLine("Month of Birth : Nov 15 ");
            Console.WriteLine();

            
        }


        public static void GetMyBioGraphy()
        {
            MyBioGraphy();
        }
    }
}

