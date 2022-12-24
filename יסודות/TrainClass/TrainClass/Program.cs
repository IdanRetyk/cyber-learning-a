using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Train t1 = new Train(1, "TelAviv");
            Train t2 = new Train(2, "Nemal Ashdod");

            Console.WriteLine(t1);
            Console.WriteLine(t2);

            Console.WriteLine("\nStart T1 -------------------");

            t1.AddKm(10);
            t1.SetCurrentStation("Rishon");
            t1.AddKm(34);
            t1.SetCurrentStation("Yavne");
            t1.AddKm(20);
            t1.SetCurrentStation("Gedera");

            if (t1.MaintenanceNeeded())
                t1.DoMaintenance();

            Console.WriteLine(t1);


            Console.WriteLine("\nStart T2 -------------------");
            int days = 1000;

            for (int i = 0; i < days; i++)
            {
                t2.AddKm(20);
                t2.SetCurrentStation("Rechovot");
                t2.AddKm(10);
                t2.SetCurrentStation("Nes Ziyona");
                t2.AddKm(30);
                t2.SetCurrentStation("Lod");
                t2.AddKm(70);
                t2.SetCurrentStation("Ashdod");


                if (t2.MaintenanceNeeded())
                {
                    int km = t2.DoMaintenance();
                    Console.WriteLine("   ---> Maintenance done for train id " + t2.GetId() + " at " + km + " KM");
                }
            }


            Console.WriteLine(t2);



            Console.ReadLine();

        }
    }
}
