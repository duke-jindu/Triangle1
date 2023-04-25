public class traingle
{
    public double Height;
    public double Base;
    public double Line;
    public int Angle;


    public double Threesides() //double Height, double Base, double Line)
    {
        Console.WriteLine("****************************************************");
        Console.WriteLine("CALCULATING THE THREE SIDES OF THE TRAINGLE");

        double Area, advg;

        Console.Write("enter height: ");
        Height = double.Parse(Console.ReadLine());

        Console.Write("enter base: ");
        Base = double.Parse(Console.ReadLine());

        Console.Write("enter line: ");
        Line = double.Parse(Console.ReadLine());

        advg = (Height * Base * Line) / 2;
        Area = (Math.Sqrt(advg * (advg - Height) * (advg - Base) * (advg - Line)));

        Console.WriteLine("the  area is {0}", Area);
        Console.ReadKey();


        return Area;


    }

    public double SideAltitude()
    {
        Console.WriteLine("****************************************************");
        Console.WriteLine("AREA OF A TRIANGLE");

        double Area;

        Console.Write("enter Heigth: ");
        Height = double.Parse(Console.ReadLine());

        Console.Write("enter Base: ");
        Base = double.Parse(Console.ReadLine());

        Area = (Height * Base) * 0.5;

        Console.WriteLine("the  area is {0}", Area);



        Console.ReadKey();
        return Area;


    }

    public double Angles()
    {
        Console.WriteLine("*****************************************************");
        Console.WriteLine("AREA WHEN ANGLE IS GIVEN");

        double Area;

        Console.Write("enter height: ");
        Height = double.Parse(Console.ReadLine());

        Console.Write("enter base: ");
        Base = double.Parse(Console.ReadLine());

        Console.Write("enter Angle: ");
        Angle = int.Parse(Console.ReadLine());

        Area = (Height * Base * Math.Sin(Angle)) / 2;


        Console.WriteLine("the  area is {0}", Area);

        Console.ReadKey();
        return Area;


    }
}

class program
{
    static void Main(string[] args)
    {
        traingle traingles = new traingle();

        //Console.Write("enter height: ");
        //traingles.Height = double.Parse(Console.ReadLine());

        //Console.Write("enter base: ");
        //traingles.Base = double.Parse(Console.ReadLine());

        // Console.Write("enter Line: ");
        //traingles.Line = double.Parse(Console.ReadLine());

        //Console.Write("enter Angle: ");
        //traingles.Angle = int.Parse(Console.ReadLine());

        int choice;
        do
        {
            Console.Clear();
            Console.WriteLine("Calculate the area of a triangle by given:");
            Console.WriteLine("1.Three side lengths.");
            Console.WriteLine("2.Length of one side and it's altitude.");
            Console.WriteLine("3.Length of two sides and the angle between them.");
            Console.WriteLine("4.Exit.");
            Console.Write("Enter choice from 1 to 4: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 2: traingles.SideAltitude(); break;
                case 3: traingles.Angles(); break;
                case 1: traingles.Threesides(); break;
            }

        }
        while (choice != 4);










    }
}
