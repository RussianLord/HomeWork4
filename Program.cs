void HW1()
{
    Console.WriteLine("После вводе числа А и числа В программа возводит число А в степень В");
    Console.WriteLine("Введиче число А...");
    int numA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введиче число B...");
    int numB = Convert.ToInt32(Console.ReadLine());
    int numP = 1;
    vizov1(numA, numB, numP);
}

void vizov1(int numA, int numB, int numP)
{
    if (numA == 0 && numB ==0)
    {
        Console.WriteLine("Введённое число и степень равно нулю!");
    }
    else if(numA == 0 || numB ==0)
    {
        Console.WriteLine("Введённое число или степень равно нулю!");
    }
    for (int i = 1; i <= numB; i++)
    {
        numP = numP * numA;
    }
    Console.WriteLine($"Число А = {numA} в степени B = {numB} равняется... {numA}^{numB} = {numP}");
}

void HW2()
{
    Console.WriteLine("Введите число, чтобы получить результат сложения его цифр...");
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    int changenum = number;
    int sum = 0;
    vizov2(number, changenum, sum);
}

void vizov2(int number, int changenum, int sum)
{
    while(changenum > 0)
    {
        int temp = changenum % 10;
        sum = sum + temp;
        changenum = changenum / 10;
    }
    Console.WriteLine($"Сумма цифр из числа {number} равна {sum}");
}

void HW3()
{
    Console.WriteLine("Введите размер массива...");
    int sizemas = Convert.ToInt32(Console.ReadLine());
    int[] massiv = new int[sizemas];
    ZapolnMassiv(massiv);
    SortMassiv(massiv);
}

void ZapolnMassiv(int[] massiv)
{
    Console.WriteLine("\t\t" + "Оригинальный массив");
    Console.Write("[" + "\t");
    Random rnumber = new Random();    
    for(int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = rnumber.Next(-10, 10);  
        Console.Write(massiv[i] + "\t");           
    }
    Console.Write("]");
    Console.WriteLine("");
    
}

void SortMassiv(int[] massiv)
{
    Console.WriteLine("\t\t" + "Отсортированный массив");
    Console.Write("[" + "\t");
    for(int i = 0; i < massiv.Length; i++)
    {
        int temp;
        for(int j = i + 1; j < massiv.Length; j++)
        {
            if(massiv[i] > massiv[j])
            {
                temp = massiv[i];
                massiv[i] = massiv[j];
                massiv[j] = temp;
            }
        }
        Console.Write(massiv[i] + "\t");   
    }   
    Console.Write("]");
}


// HW1();
// HW2();
// HW3();

