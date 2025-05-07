//нахождение суммы четных чисел в массиве
int[] myArray = { 4, 7, 79, 49, 88, 43, 6, 52, 9 };

int result = 0;

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] % 2 == 0)
    {
        result += myArray[i];
    }
}
Console.WriteLine("Сумма четных чисел равна: " + result);
Console.ReadLine();
