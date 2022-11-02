using System;

public class Calculator {

    public float Operations(float a, float b, float c)
    {
        if (a == 1)
        {
            float result = b + c;
            return result;
        }
        else if (a == 2)
        {
            float result = b * c;
            return result;
        } else
        {
           if (a > b)
            {
                float result = a / b;
                return result;
            } else
            {
                float result = b / a;
                return result;
            }
        }
        return 0;
    }
    public static void Main()
    {
        Calculator calculator = new Calculator();

        Console.WriteLine("Bienvenido");
        Console.WriteLine(" 1: Suma \n 2: Multiplicacion \n 3: Divicion");
        int switchCase = Convert.ToInt32(Console.ReadLine());
        switch(switchCase)
        {
            case 1:
                Console.WriteLine("Ingresa la primera cantidad: ");
                float number1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la segunda cantidad: ");
                float number2 = float.Parse(Console.ReadLine());
                float result = calculator.Operations(1 ,number1, number2);
                Console.WriteLine($"Resultado: {result}");
                break;
            case 2:
                Console.WriteLine("Ingresa la cantidad: ");
                float numberA = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la segunda cantidad: ");
                float numberB = float.Parse(Console.ReadLine());
                float resultMult = calculator.Operations( 2 ,numberA, numberB);
                Console.WriteLine($"Resultado: {resultMult}");
                break;
            case 3:
                Console.WriteLine("Ingresa la cantidad: ");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la segunda cantidad: ");
                float b = float.Parse(Console.ReadLine());
                float resultDiv = calculator.Operations(3, a, b);
                Console.WriteLine($"Resultado: {resultDiv}");
                break;
        }
    }
}