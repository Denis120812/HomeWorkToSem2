/* Задача 1: 
Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.



void MultipleNumber (int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        System.Console.WriteLine($"Да, число {num} одновременно кратное 7 и 23");
    }
    else
    {
       System.Console.WriteLine($"Нет, число {num} одновременно некратное 7 и 23"); 
    }
}

System.Console.WriteLine("Input number:  ");
int num = Convert.ToInt32(Console.ReadLine());

MultipleNumber(num); */

/* Задача 2: 
Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
в которой находится эта точка.

void FindCoordinates (int x, int y)
{
    
     if (x > 0 && y > 0)
    {
        System.Console.WriteLine("1");
    }
    if (x < 0 && y > 0)
    {
        System.Console.WriteLine("2");
    }
    if (x < 0 && y < 0)
    {
        System.Console.WriteLine("3");
    }
    if (x > 0 && y < 0)
    {
        System.Console.WriteLine("4");
    }
}

System.Console.WriteLine("Input coordinate x:  ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Input coordinate y:  ");
int y = Convert.ToInt32(Console.ReadLine());

FindCoordinates(x, y); */


/* Задача 3: 
Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
и показывает наибольшую цифру числа. */

/* void MaxDigit (int numb)
{
    int firstDigit = numb / 10;
    int secondDigit = numb % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    System.Console.WriteLine(maxDigit);
}

System.Console.WriteLine("Input digit (10-99):  ");
int dig = Convert.ToInt32(Console.ReadLine());

MaxDigit(dig); */

/* Задача 4: 
Напишите программу, которая на вход принимает натуральное число N, 
а на выходе показывает его цифры через запятую. */

System.Console.WriteLine("Input number:  ");
int num = Convert.ToInt32(Console.ReadLine());

AllDigits(num);


void AllDigits (int number) 
{
    if (number < 10)
    {
        System.Console.WriteLine(number);
    }
    else 
        {
            while (number > 0)
            {
                int currentDigit = number % 10; 
                number /= 10;
                
                 if (number > 10)
                {
                    System.Console.Write(currentDigit + ",");       
                }
                else
                {
                    System.Console.Write(currentDigit);
                }
            }
        }
}


 
// Не пойму работу этого кода, (взял у вас)он не верно работает. Прошу подробно разобрать на следующем семинаре.