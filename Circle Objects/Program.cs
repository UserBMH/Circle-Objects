

using Circle_Objects;
double userRadius = 0;
string input2 = "";
bool loop = true;
bool loop2 = true;
int z = 0;
Circle myCircle = new Circle(0);

do
{
    do
    {
        Console.WriteLine("Please enter a radius number...");
        string input = (Console.ReadLine());


        if (double.TryParse(input, out userRadius))
        {

            z++;
            myCircle.radius = userRadius;
            
            loop = false;
            Console.WriteLine($"The circumference is {myCircle.CalculateCircumference()}");
            Console.WriteLine($"The area is {myCircle.CalculateArea()}");

            Console.WriteLine();
            Console.WriteLine("Want to enter another radius? Y or N");
            input2 = Console.ReadLine();

            if (input2.ToLower() == "y")
            {

            }
            else
            {
                Console.WriteLine("uhhh bye...");
                Console.WriteLine($"Circles built {z}");
                loop2 = false;
            }
        }
        else
        {

            Console.WriteLine("Error not a number!");
            Console.WriteLine();
        }



    }
    while (loop == true);



    
}
while (loop2 == true);
