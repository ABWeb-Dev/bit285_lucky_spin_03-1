using System;
namespace LuckySpin.Models
{
    public class Spin
    {

        Random random = new Random();
        private int a,b,c,luck; //instance variables

        //TODO: Create public getter and setter for Luck, referencing the instance variable
       
        public int Luck
        {
            get { return luck = new Random().Next(0, 9) ; }
            set { }
        }

        //TODO: Create public getters for Random numbers, refernencing their instance variable
        public int A {
            get
            {

                return a = new Random().Next(0,9);
            }
        }
        public int B {
            get
            {

                return b = new Random().Next(0, 9);
            }
        }
        public int C
        {
            get
            {

                return c = new Random().Next(0, 9);
            }
        }

        //TODO: Create a public getter that makes the decision to display the image or not by returning "block" or "none" for the Razor templates CSS
        public string Display
        {
            get
            {
                return (a == luck || b == luck || c == luck) ? "block" : "none";
            }
        }
    }
    
}
