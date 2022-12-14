using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActuatingForce
{ 


    public class testGraphTimer
    {
        
        private static System.Timers.Timer tmrDistance;
        private static System.Timers.Timer tmrForce;
        Random random= new Random();
        double valX = -0.2;

        public testGraphTimer()
        { 
            tmrDistance = new System.Timers.Timer(100);
            tmrDistance.Elapsed += OnTimeDistance;
            tmrDistance.AutoReset = true;
            tmrDistance.Enabled = true;

            tmrForce = new System.Timers.Timer(300);
            tmrForce.Elapsed += OnTimeForce;
            tmrForce.AutoReset = true;
            tmrForce.Enabled = true;
        } 

        private void OnTimeDistance(object sender, EventArgs e)
        {
            if (valX >= 200) valX = -0.2;
            
            valX = valX + 0.2;
        }


        private void OnTimeForce(object sender, EventArgs e)
        {

        }
    }


}
