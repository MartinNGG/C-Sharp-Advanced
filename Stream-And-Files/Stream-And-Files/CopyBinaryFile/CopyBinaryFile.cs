using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyBinaryFile
{
    class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            var fileStream = new FileStream("../../binary.png", FileMode.Open);
            var newFile = new FileStream("../../newBinary.png", FileMode.Create);
            using (fileStream)
            using (newFile)
            {
                byte[] buffer = new byte[4096];
                while (true)
                {
                    int readBytes = fileStream.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }
                    newFile.Write(buffer, 0, readBytes);
                }
            }


        }
    }
}
