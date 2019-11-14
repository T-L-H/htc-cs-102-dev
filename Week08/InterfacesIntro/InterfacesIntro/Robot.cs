using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InterfacesIntro
{
   public class Robot : ISpeaker
    {
        public int Height
        {
            get { return 5; }
        }
        public string Name
        { 
            get; set; 
        }

        public int SerialNumber
        {
            get; set;

        }

        public int Weight
        {
            get; set;
        }
        public Robot(string name, int serialNumber, int weight)
        {
            Name = name;
            SerialNumber = serialNumber;
            Weight = weight;
        }

        public void SayName()
        {
            MessageBox.Show("Hello, I am a robot. My name is " + Name + "and my serial number is " + SerialNumber);
        }

        public void Speak()
        {
            MessageBox.Show("Beep Boop.");
        }
    }
}
