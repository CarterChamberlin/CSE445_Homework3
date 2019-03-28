using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;

namespace FileUploadService
{

    public class Service1 : IService1
    {
        /*public string StoreFile(string filePath)
        {
            
            string newFilePath = @"C:\Users\carte\OneDrive - Arizona State University\School\CSE 445\Homeworks\Homework 3\Part 1\UploadedFiles\" + filePath.Substring(filePath.LastIndexOf('\\') + 1);
            using (FileStream fStream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[fStream.Length];
                int numberOfBytesToRead = (int)fStream.Length;
                int numberOfBytesRead = 0;
                while (numberOfBytesToRead > 0)
                {
                    int i = fStream.Read(bytes, numberOfBytesRead, numberOfBytesToRead);

                    if (i == 0)
                        break;

                    numberOfBytesRead += i;
                    numberOfBytesToRead -= i;
                }

                numberOfBytesToRead = bytes.Length;

                using (FileStream fStreamNew = new FileStream(newFilePath, FileMode.Create, FileAccess.Read))
                {
                    fStreamNew.Write(bytes, 0, numberOfBytesToRead);
                }
            }

            return newFilePath;
        }*/
        public string StoreFile(string filePath)
        {

            string newFilePath = @"C:\Users\carte\OneDrive - Arizona State University\School\CSE 445\Homeworks\Homework 3\Part 1\UploadedFiles\" + filePath;

            return newFilePath;
        }
    }
}
