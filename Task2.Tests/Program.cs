using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Solution;

namespace Task2.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            IRandomDataGenerator randomDataChar = new RandomCharsDataGenerator();
            IRandomDataGenerator randomDataByte = new RandomBytesDataGenerator();
            RandomFileGenerator randomFileChar = new RandomFileGenerator(randomDataChar);
            randomFileChar.GenerateFiles(5, 10);
            RandomFileGenerator randomFileByte = new RandomFileGenerator(randomDataByte);
            randomFileByte.GenerateFiles(20, 10);
        }
    }
}
