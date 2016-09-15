using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Robot
    {
        
        public string robotName;
        public string robotSpeech;
        
        

        public Robot()
        {

        }  
        public string GetRobotName()
        {
            Console.WriteLine("Give me a name for your robot: ");
            robotName = Console.ReadLine();
            return robotName;
        }
        public void GetRobotSpeech()
        {
            
        }
    }
}
