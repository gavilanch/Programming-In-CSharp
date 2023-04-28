using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal interface IFileStorage
    {
        string Save(string file);
        void Delete(string fileURL);
        string Edit(string fileURL, string file)
        {
            Delete(fileURL);
            return Save(file);
        }
    }
}
