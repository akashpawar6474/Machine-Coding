using ConsoleApp1.Controllers.implementations;
using ConsoleApp1.Controllers.interfaces;
using ConsoleApp1.Data_Access_Layer;
using ConsoleApp1.Data_Access_Layer.implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            IRetrieveRecords recordsResolver = new RecordDataResolver();
            IRecordsManager recordsManager = new RecordManager(recordsResolver);
            while (true)
            {
                Console.WriteLine(" Enter the preferences ");
                Console.WriteLine(" 1.Load the details ");
                Console.WriteLine(" 2.display the details ");
                Console.WriteLine(" 3.get specific details ");

                int no = Convert.ToInt32(Console.ReadLine());

                switch (no)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter no of details you want to enter ");
                            int noOfRecords = Convert.ToInt32(Console.ReadLine());
                            List<string> records = new List<string>();
                            for (int i = 0; i < noOfRecords; i++)
                            {
                                records.Add(Console.ReadLine());
                            }
                            Console.WriteLine(recordsManager.load(records));
                        }
                        break;
                    case 2:
                        {
                            recordsManager.display();
                        }
                        break;
                    case 3:
                        {
                            int key = Convert.ToInt32(Console.ReadLine());
                            recordsManager.GetRecord(key);
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("not valid choice");
                        }
                        break;


                }
            }
            Console.ReadLine();
        }
    }
}
