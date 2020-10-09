using System;
using System.IO.Compression;

namespace Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"D:\ZipFileDemo", @"D:\ZipFileDemoCreation\MyZipFile.zip");
            ZipFile.ExtractToDirectory(@"D:\ZipFileDemoCreation\MyZipFile.zip", @"D:\ZipFileDemoResult");
        }
    }
}
