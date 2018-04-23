using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Solution
{
    public abstract class RandomDataGenerator
    {
        public abstract string WorkingDirectory { get; }
        public abstract string FileExtension { get; }
       
        public abstract byte[] GenerateFileContent(int contentLength);
    }
}
