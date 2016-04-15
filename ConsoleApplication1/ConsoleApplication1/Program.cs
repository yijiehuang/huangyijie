using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeDataAndDoc
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFileName = "defaultInput.txt";
            string inputFileName2 = "defaultInput2.txt";
            string outputFileName = "defaultOutput.txt";
            if (args.Length == 6)
            {
                if (string.Compare(args[0], "-i") == 0)
                    inputFileName = args[1];
                if (string.Compare(args[0], "-t") == 0)
                    inputFileName2 = args[1];
                if (string.Compare(args[0], "-r") == 0)
                    outputFileName = args[1];
                if (string.Compare(args[2], "-i") == 0)
                    inputFileName = args[3];
                if (string.Compare(args[2], "-t") == 0)
                    inputFileName2 = args[3];
                if (string.Compare(args[2], "-r") == 0)
                    outputFileName = args[3];
                if (string.Compare(args[4], "-i") == 0)
                    inputFileName = args[5];
                if (string.Compare(args[4], "-t") == 0)
                    inputFileName2 = args[5];
                if (string.Compare(args[4], "-r") == 0)
                    outputFileName = args[5];

            }//设置参数。并可以交换顺序
            using (StreamReader inputFile = new StreamReader(inputFileName))
            using (StreamReader inputFile2 = new StreamReader(inputFileName2))
            using (StreamWriter outputFile = new StreamWriter(outputFileName))
            {
                funciton(inputFile, inputFile2, outputFile);
            }
        }

        public static void funciton(TextReader inputFile, TextReader inputFile2, TextWriter outputFile)
        {
            string line;
            string line2;
            string line3;
            string line4; //test
            line = inputFile.ReadLine();
            line2 = inputFile2.ReadLine();
            line3 = inputFile2.ReadLine();
            line4 = inputFile2.ReadLine();
            string[] s = line2.Split(new char[3] { '$', '}', '{' });//分割字符串
                string[] s1 = line.Split(new char[] { '\t' });//分割字符串
                string outputLine = s1[0] + s[3] + s1[1] + s[6] + s1[2] + s[9];
                Console.WriteLine(outputLine);
                Console.WriteLine(line3);
                Console.WriteLine(line4);
                outputFile.WriteLine(outputLine);
                outputFile.WriteLine(line3);
                outputFile.WriteLine(line4);//调整格式，并输出
        }
    }
}

