using AreaCalculator;

Console.WriteLine("Welcome to Area Calculator App!");
Console.WriteLine("Please put 1 to calculate the area of a circle or 2 to calculate the area of a rectangle.");
int figure = 0;

//Receive the type of figure 1 for circle, 2 for rectangle
try
{
    figure = Convert.ToInt32(Console.ReadLine());
    
}
catch (Exception ex)
{ 
    Console.WriteLine("The type of data entered does not correspond to a valid option. \n" + ex.ToString()); 
}

//Validate the type of figure.
if (figure != 1)
{
    if (figure != 2)
    Console.WriteLine("You have entered an incorrect option.");
}

switch(figure)
{
    //Calculate the area of a circle.
    #region CalculateCircle
    case 1:
        Circle objCircle = new Circle();
        Console.WriteLine("Please, put the radio of the circle.");
        try
        {
            objCircle.Radio = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
        }
        catch (Exception ex)
        {
            Console.WriteLine("The type of data entered does not correspond to a valid value. \n" + ex.ToString());
        }
        Console.WriteLine(objCircle.ObtainResponse());
    break;
    #endregion

    //Calculate the area of a rectangle.
    #region CalculateRectangle
    case 2:
        Rectangle objRectangle = new Rectangle();
        
        try
        {
            Console.WriteLine("Please, put the base of the rectangle.");
            objRectangle.Base = Convert.ToDouble(Console.ReadLine().Replace(".",","));

            Console.WriteLine("Please, put the height of the rectangle.");
            objRectangle.Height = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
        }
        catch (Exception ex)
        {
            Console.WriteLine("The type of data entered does not correspond to a valid value. \n" + ex.ToString());
        }
        Console.WriteLine(objRectangle.ObtainResponse());
        break;
    #endregion
}

//By Jose Luis Avila 20/04/2022