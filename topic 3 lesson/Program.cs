namespace topic_3_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // jonathan
            string myName, myEyes, myTeeth, myHair;
            int myAge, myHeight, myWeight;
            Console.WriteLine();
            myName = "jonathan gaboury";
            myAge = 15;
            myHeight = 70;  // inches
            myWeight = 150; // pounds
            myEyes = "green";
            myTeeth = "white";
            myHair = "dirty blond";
            Console.WriteLine();
            Console.WriteLine("Let's talk about" + myName + " . ");
            Console.WriteLine("He's" + myHeight + "inches tall.");
            Console.WriteLine("He's" + myWeight + "pounds heavy.");
            Console.WriteLine("actually, thats not that heavy");
            Console.WriteLine("He's got" + myEyes + "eyes and" + myHair + "hair");
            Console.WriteLine("His teeth are usually" + myTeeth + "depending on the coffee.");
            Console.WriteLine() ;
            Console.WriteLine("if i add " +myAge + "," + myHeight + ", and " + myWeight + " I get " + (myAge + myHeight + myWeight) + ".");
            Console.WriteLine() ;
            string name = "jonathan";
            Console.WriteLine(name);
            name = "jon";
            Console.WriteLine(name);
            Console.WriteLine();
            int myNumber = 15;
            Console.WriteLine(myNumber);
            Console.WriteLine();
            myNumber = 20;
            Console.WriteLine(myNumber);
            Console.WriteLine();
            double height = 1.62;
            Console.WriteLine(height);
        }
    }
}
