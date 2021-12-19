using ConsoleApp1.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data_Access_Layer.implementations
{
    public class RecordDataResolver : IRetrieveRecords
    {
        private Dictionary<int, Record> recordsDict = null;

        public RecordDataResolver()
        {
            recordsDict = new Dictionary<int, Record>();
        }

        public Dictionary<int, Record> getRecords()
        {
            return this.recordsDict;
        }

        public bool addRecord(Record record)
        {
            this.recordsDict.Add(record.UniqueID, record);
            return true;
        }
    }
}
