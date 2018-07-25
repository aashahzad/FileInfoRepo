using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    public interface IFileHelper 
    {
        string GetVersion();
        string GetFileSize();
    }
}
