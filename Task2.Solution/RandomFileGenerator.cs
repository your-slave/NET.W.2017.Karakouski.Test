using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Solution
{
    public class RandomFileGenerator
    {
        private readonly RandomDataGenerator randomDataGenerator;

        public RandomFileGenerator(RandomDataGenerator randomDataGenerator)
        {
            this.randomDataGenerator = randomDataGenerator;
        }

        public void GenerateFiles(int filesCount, int contentLength)
        {
            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = randomDataGenerator.GenerateFileContent(contentLength);

                var generatedFileName = $"{Guid.NewGuid()}{randomDataGenerator.FileExtension}";

                this.WriteBytesToFile(generatedFileName, generatedFileContent);
            }
        }

        private void WriteBytesToFile(string fileName, byte[] content)
        {
            if (!Directory.Exists(randomDataGenerator.WorkingDirectory))
            {
                Directory.CreateDirectory(randomDataGenerator.WorkingDirectory);
            }

            File.WriteAllBytes($"{randomDataGenerator.WorkingDirectory}//{fileName}", content);
        }
    }
}
