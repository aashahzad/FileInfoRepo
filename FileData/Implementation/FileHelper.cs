using FileData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
    public class FileHelper : IFileHelper
    {
        private string[] _args;
        private FileDetails _fileDetails;


        public FileHelper()
        {

        }
        public FileHelper(FileDetails fileDetails, string[] args)
        {
            _args = args;
            _fileDetails = fileDetails;
        }
        /// <summary>
        /// Get File version information
        /// </summary>
        /// <param name="args"></param>
        public string GetVersion()
        {
            string[] versionKeyWords = new string[] { "-v", "–v", "--v", "/v", "--version" };
            try
            {
                if (ValidateData(versionKeyWords))
                {
                    return string.Format("File Version: {0}", _fileDetails.Version(_args[1].Replace("’", "")));
                }
            }
            catch (Exception ex)
            {
                return string.Format("Error:{0}", ex.Message);
            }
            return string.Empty;
        }

        /// <summary>
        /// Get File Size Information
        /// </summary>
        public string GetFileSize()
        {
            string[] versionKeyWords = new string[] { "-s", "–s", "--s", "/s", "--size" };
            try
            {
                if (ValidateData(versionKeyWords))
                {
                    return string.Format("File Size: {0}", _fileDetails.Size(_args[1].Replace("’", "")));
                }
            }
            catch (Exception ex)
            {
                return string.Format("Error:{0}", ex.Message);
            }
            return string.Empty;
        }

        #region Private Methods

        private bool ValidateData(string[] searchKeywordArray)
        {
            if (_args.Length > 1)
            {
                var paramSearched = _args[0].Replace("‘", "");
                var fileName = _args[1].Replace("’", "");
                if (searchKeywordArray.Contains(paramSearched.ToLower()))
                {
                    return true;
                }
                else
                    throw new Exception("searched keyword not found");
            }
            else
            {
                throw new Exception("Invalid Array Arguments");
            }
            return true;
        }
        #endregion
    }
}
