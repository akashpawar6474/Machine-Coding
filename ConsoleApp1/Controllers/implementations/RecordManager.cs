using ConsoleApp1.Controllers.interfaces;
using ConsoleApp1.Data_Access_Layer;
using ConsoleApp1.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controllers.implementations
{
    public class RecordManager : IRecordsManager
    {
        IRetrieveRecords recordResolver = null;
        public RecordManager(IRetrieveRecords resolver)
        {
            this.recordResolver = resolver;
        }
        public void display()
        {
            /*graze over dictionary and print it in the list*/
            Dictionary<int, Record> recordDict = this.recordResolver.getRecords();
            int count = 0;
            foreach (var record in recordDict)
            {
                Console.WriteLine("record details for record no " + Convert.ToString(count));
                Console.WriteLine("Name " + record.Value.Name+" size "+Convert.ToString(record.Value.Size));
                count++;
            }
        }

        public Record GetRecord(int id)
        {
            /*
             return records from dictionary
             */
            Dictionary<int, Record> recordDict = this.recordResolver.getRecords();
            Record record = null;
            recordDict.TryGetValue(id,out record);
            return record;
        }

        public string load(List<string> recordSrings)
        {
            /*
             1.we will graze over strings.
            2.create record object and add to dictionary
             */
            foreach (string record in recordSrings)
            {
                string[] recordArr = record.Split(',');
                Record newRecord = new Record();
                newRecord.Name = recordArr[0];
                newRecord.UniqueID = Convert.ToInt32(recordArr[1]);
                newRecord.Size = Convert.ToInt32(recordArr[2]);
                this.recordResolver.addRecord(newRecord);
            }
            return "data saved successfully";
        }
    }
}
