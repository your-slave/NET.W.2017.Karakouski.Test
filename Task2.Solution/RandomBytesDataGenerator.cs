using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Solution
{
    public class RandomBytesDataGenerator : RandomDataGenerator
    {
        public override string WorkingDirectory => "Files with random bytes";

        public override string FileExtension => ".bytes";

        public override byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }
    }
}
