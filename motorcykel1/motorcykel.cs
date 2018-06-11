using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motorcykel1
{
    class motorcykel
    {
        public motorcykel()
        { }

        public Boolean startet;

        public int Rpm { get; set; }

        public int gear { get; set; }

        public string name { get; set; }

        public double speed { get; set; }


        public Boolean nystartet
        {
            get { return startet; }
            set
            {
                if (startet == true)
                {

                    Rpm = 1000;


                }


            }

        }

        public int mitgear
        {
            get { return gear; }
            set { gear = value; }

        }
        public int mitrpm
        {
            get { return Rpm; }
            set
            {
                if (startet == true && Rpm < 8000)                           //(value >= 1001 || value <= 8000)
                {
                    Rpm = value;

                }
                else if (value < 1000 && Rpm < 1000)
                {
                    startet = false;

                }
                

            }

        }
        public void start()  //skal returnere værdien 
        {
            if (!startet)
            {
                startet = true;
                Rpm = 1000;
                gear = 0;

            }
            
        }
        public void stop()
        {
            if (startet == true)
            {
                startet = false;
                Rpm = 0;
                gear = 0;


            }

        }
        
        public double getspeed()
        {
            speed = Rpm * gear / 200;
            return speed;
        }
        //public double hastighed { get; set; }
        public void shiftgearup()
        {
            if (gear < 5 && startet == true)
            {
                gear++;
                
            }
            
        }
        public shiftgeardown(int g)  //bruges til at sætte gearet ned hvis det er for højt
        {
            if (g < gear && g > 0)
            {
                gear = g;
                
            }

        }
        public int getgear()
        {
            return gear;

        }
        
        


        public motorcykel(Boolean isstarted, int Rmp1, int gear1, string name1, double gethastighed)
        {
            startet = isstarted;
            Rpm = Rmp1;
            gear = gear1;
            name = name1;
            // = gethastighed;


        }
        public virtual string fuldtmotorcykel()
        {
            return startet + " " + Rpm + " " + gear + " " + name + " " + speed;


        }

        //gear =gear++;
        




    }
}
