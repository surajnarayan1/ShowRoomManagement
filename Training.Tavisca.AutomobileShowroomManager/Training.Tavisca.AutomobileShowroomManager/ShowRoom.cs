using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Tavisca.AutomobileShowroomManager
{
    public class ShowRoom
    {


        public List<Automobile> automobiles = new List<Automobile>();

        public bool AutomobileAvailablity(string name)
        {
            foreach (Automobile autoMobile in automobiles)
            {
                if (autoMobile.Name == name)
                {
                    automobiles.Remove(autoMobile);// so that after booking it can be removed from the list;
                    return true;
                }
            }
            return false;


        }
        public void AddAutomobile(Automobile automobile)
        {
            automobiles.Add(automobile);



        }

        public void RemoveAutomobile(Automobile automobile)
        {

            automobiles.Remove(automobile);


        }






    }
}
