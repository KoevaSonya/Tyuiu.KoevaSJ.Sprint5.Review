using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.KoevaSJ.Sprint5.Review.V24.Lib;

namespace Tyuiu.KoevaSJ.Sprint5.Review.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            string path = @"C:\Users\sonya\source\repos\Tyuiu.KoevaSJ.Sprint5.Review\Tyuiu.KoevaSJ.Sprint5.Review.V24\bin\Debug\OutPutFileTask7V24.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
