using System;

namespace Class_work_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string HeroName = "Superman";
            double Heroheight = 188.5;
            int HeroAge = 36;
            string HeroSuperPower = "laser eyes";

            string VillanName = "Joker";
            double villanheight = 184.7;
            int VillanAge = 32;
            string VillanSuperPower = "Mind controling";

            int AgeDifference = HeroAge - VillanAge;
            Console.WriteLine("The Hero name is " + HeroName + " his hieght is " + Heroheight + " he is " + HeroAge + " years old and his super power is " + HeroSuperPower);
            Console.WriteLine("The Villan name is " + VillanName + " his hieght is " + villanheight + " he is " + VillanAge + " years old and his super power is " + VillanSuperPower);
            Console.WriteLine("The age diffrance between the hero and the villan is " + AgeDifference);

            // bouns 

            double heroheight = Heroheight + 5;
            string villansuperpower = "none";

            Console.WriteLine("the new hero height is " + heroheight);
            Console.WriteLine("the villan new super power is " + villansuperpower);



        }
    }
}
