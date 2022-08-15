using MethodOverloadingExercise01;



Console.WriteLine("Hello, Enter the two numbers you'd like to add");
var inputOne = Methods.GetInput();
var inputTwo = Methods.GetInput();
Console.WriteLine(Methods.Add(inputOne, inputTwo));


Console.WriteLine("Now Enter two numbers with decimals you'd like to add");
var decimalOne = Methods.GetDoubleInput();
var decimalTwo = Methods.GetDoubleInput();
Console.WriteLine(Methods.Add(decimalOne, decimalTwo));


Console.WriteLine("Now lets count your money! \n"+"How Many One dollar bills do you have?");
var dollarBills = Methods.GetInput();

Console.WriteLine("Great! How many Five dollar bills do you have?");
var fiveBills = Methods.GetInput();

bool aboveOne;
    if (fiveBills == 0 && dollarBills == 1)
    {
         aboveOne = false;
    }
    else
    {
         aboveOne=true;
    }
Console.WriteLine(Methods.Add(dollarBills, fiveBills, aboveOne));