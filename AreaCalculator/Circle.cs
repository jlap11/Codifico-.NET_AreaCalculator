namespace AreaCalculator
{
    public class Circle : Figure
    {
        public double Radio { get; set; }
        public override string ObtainResponse()
        {
            return "The area of the circle is " + CalculateArea().ToString() + ".";
        }


        //Calculate the area of a circle apliyng the formule : 𝜋𝑟2
        public override double CalculateArea()
        {
            double calculated;
            
            calculated = Radio * Radio * 3.1415;

            return calculated;
        }

        
    }
}
