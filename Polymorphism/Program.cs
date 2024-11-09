//Tim Petersen SUT24

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates object references from Geometry class that points to objects of each derived class.
            Geometry circle = new Circle();
            Geometry rectangle = new Rectangle();
            Geometry square = new Square();

            //Creates a list and adds the objects references that i created. 
            List<Geometry> objects = new List<Geometry>() { circle, square, rectangle };
                 
            //Loops through the list and print out the name of each object and the area. This demonstrate polymorphism. 
            foreach (Geometry area in objects)
            {
                Console.WriteLine($"Area of {area.GetType().Name}: {area.Area()}");               
            }
            
           
        }
    }
}
