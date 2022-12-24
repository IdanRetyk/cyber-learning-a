using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainClass
{
    class Train
    {
        private int id;
        private string location;
        private int totalKm;
        private int currKm;
        private int overallCount;


        public Train(int id, string location)
        {
            this.id = id;
            this.location = location;
            this.totalKm = 0;
            this.currKm = 0;
            this.overallCount = 0;
        }

        public int GetId()
        {
            return this.id;
        }

        public string GetLocation()
        {
            return this.location;
        }

        public int GetTotalKm()
        {
            return this.totalKm;
        }

        public int GetCurrKm()
        {
            return this.currKm;
        }

        public int GetOverallCount()
        {
            return this.overallCount;
        }

        public void SetCurrentStation(string l)
        {
            this.location = l;
        }


        public void AddKm(int kmToAdd)
        {
            this.totalKm = kmToAdd;
            this.currKm = kmToAdd;
        }

        public bool MaintenanceNeeded()
        {
            return currKm > 100000;
        }

        public int DoMaintenance()
        {
            int holder = currKm;
            currKm = 0;
            overallCount++;
            return holder;
        }

        public override string ToString()
        {
            return $"id: {id}, location: {location}, total km: {totalKm}, current km: {currKm}, overall count:{overallCount}";
        }




    }
}
