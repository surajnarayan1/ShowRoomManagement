using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Tavisca.AutomobileShowroomManager
{
    public class ShowRoomManager
    {
       long revenue;

        public List<Automobile> automobiles;
       
        ShowRoom showroom;



        public ShowRoomManager()
        {
            automobiles = new List<Automobile>();
            showroom = new ShowRoom();

        }
        public void SellVechile(Automobile automobile)
        {
            double taxPercentage = 0.12;
            var availability = showroom.AutomobileAvailablity("HondaCity");
            if (availability == true)
            {
                revenue = automobile.Price + (long)(automobile.Price * taxPercentage);
            }

        }



        //Taking Assumption of charging Rs1000 for every hour
        public void RentVechiles(Automobile automobile, int time)
        {
            var availability = showroom.AutomobileAvailablity("Audi");
            if (availability == true)
            {
                revenue = revenue + time * 1000;
            }



        }
        public void MaintenanceService(String Service)
        {
            if (Service == "PartialRepairBody")
            {
                long charges = 5000;
                revenue = revenue + charges;

            }
            if (Service == "painting&Washing")
            {
                long charges = 2000;
                revenue = revenue + charges;
            }


        }
        public void TestDrive(Automobile automobile )
        {
            revenue = 0 + revenue;
            automobiles.Remove(automobile);



        }
     







    }





 }

 

