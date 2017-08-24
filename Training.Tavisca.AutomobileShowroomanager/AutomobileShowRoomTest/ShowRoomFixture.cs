using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Training.Tavisca.AutomobileShowroomManager;

namespace AutomobileShowRoomTest
{
    [TestClass]
    public class ShowRoomFixture
    {
        [TestMethod]
        public void Check_If_Particular_Automobile_Is_Present()
        {
            Automobile automobile = new Automobile();
            automobile.ColorChoice = Color.Black;
            automobile.Name = "Hondacity";
            automobile.Price = 1000000;
            automobile.ModelNo = "IVtechCity";
            automobile.Millege = "25kmpl";
            automobile.EngineType = "4 stroke";
            ShowRoom showroom = new ShowRoom();
            showroom.AddAutomobile(automobile);
            ShowRoomManager showroomManager = new ShowRoomManager();
            try
            {
                var automobiles = showroom.GetAutomobileIfPresent("HondaCity").Name;

            }
            catch
            {
                Assert.Fail();
            }

           


        }
    }
}
