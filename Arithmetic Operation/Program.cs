using Arithmetic_Operation;

Arithmetic operation= new Arithmetic();
int x=18,y=3;
Console.WriteLine($"The sum of {x} and {y} is {operation.Sum(x,y)}");
Console.WriteLine($"The subtraction of {x} and {y} is {operation.Subtract(x, y)}");
Console.WriteLine($"The division of {x} and {y} is {operation.Divide(x, y)}");
Console.WriteLine($"The multiplication of {x} and {y} is {operation.Multiply(x, y)}");
Console.WriteLine($"The modulo division of {x} and {y} is {operation.ModuloDivision(x, y)}");
Console.WriteLine(operation.CheckEvenOdd(4));
