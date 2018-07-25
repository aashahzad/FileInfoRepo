using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirdPartyTools;

namespace FileData.Tests
{
    [TestClass]
    public class FileDataUnitTests
    {
        [TestMethod]
        public void Test__Get_File_Version_Pass()
        {
            // arrange

            string[] args = new string[] { "-v", "c:\testFile"};
            IFileHelper _fileHelper = new FileHelper(new FileDetails(), args);

            // act
            string result = string.Empty;
            try
            {
                result = _fileHelper.GetVersion();
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Error");
            }
            //assert
            Assert.AreEqual(result.Contains("Error"), false);
        }

        [TestMethod]
        public void Test__Get_File_Version_Fail()
        {
            // arrange

            string[] args = new string[] { "-v1", "c:\testFile" };
            IFileHelper _fileHelper = new FileHelper(new FileDetails(), args);

            // act
            string result = string.Empty;
            try
            {
                result  = _fileHelper.GetVersion();
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Error");
            }
            //assert
            Assert.AreEqual(result.Contains("Error"), false);
        }

        [TestMethod]
        public void Test__Get_File_Size_Pass()
        {
            // arrange

            string[] args = new string[] { "-s", "c:\testFile" };
            IFileHelper _fileHelper = new FileHelper(new FileDetails(), args);

            // act
            string result = string.Empty;
            try
            {
                result = _fileHelper.GetFileSize();
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Error");
            }
            //assert
            Assert.AreEqual(result.Contains("Error"), false);
        }

        [TestMethod]
        public void Test__Get_File_Size_Fail()
        {
            // arrange

            string[] args = new string[] { "-s1", "c:\testFile" };
            IFileHelper _fileHelper = new FileHelper(new FileDetails(), args);

            // act
            string result = string.Empty;
            try
            {
                result = _fileHelper.GetFileSize();
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Error");
            }
            //assert
            Assert.AreEqual(result.Contains("Error"), false);
        }

    }
}
