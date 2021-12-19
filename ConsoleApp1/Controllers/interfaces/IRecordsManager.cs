using ConsoleApp1.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controllers.interfaces
{
    public interface IRecordsManager
    {
        string load(List<string> recordSrings);
        void display();

        Record GetRecord(int id);
    }
}
