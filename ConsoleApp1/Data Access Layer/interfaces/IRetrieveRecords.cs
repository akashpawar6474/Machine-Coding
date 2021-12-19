using ConsoleApp1.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data_Access_Layer
{
    public interface IRetrieveRecords
    {
        Dictionary<int, Record> getRecords();
        bool addRecord(Record record);
    }
}
