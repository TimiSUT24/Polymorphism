
namespace Polymorphism
{   
    //Base class Geometry
    public class Geometry   
    {
        public Geometry()
        {

        }
        //Uses virtual so we can override the base class method this also demonstrates polymorphism. 
        public virtual double Area()
        {
            return Area();  

        }
    }
    //Derived class 
    public class Rectangle : Geometry
    {
        public double Width { get; set; } 
        public double Length { get; set; } 
        
        public Rectangle()
        {
            Width = 4;
            Length = 8;
        }
        //Here i use override which overrides the base method. 
        public override double Area()
        {
            
            return Width * Length; 
            
        }

    }
    //Derived class
    public class Circle : Geometry
    {
        public double Radius { get; set; }
       
        public Circle()
        {
            Radius = 5;
            
        }
        //Overrides
        public override double Area()
        {
            return 3.14 * Radius * Radius; 
        }
    }
    //Derived class
    public class Square : Geometry
    {
        public double Length { get; set; }
        
        public Square()
        {
            Length = 5;
            
        }
        //Overrides
        public override double Area()
        {
            return Length * Length;
        }
    }
}
