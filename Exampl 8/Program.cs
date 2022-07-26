int[] number = { 5,5,5,5,5,5};
_number (number);
static void _number ( int[] ints)
{
    int length = (ints.Length ) / 2;
    int[] firstHalf = ints.Take(length).ToArray();
    int sum = firstHalf.Sum();
    Console.WriteLine("Сумма элементов: " + sum);
    int[] secondHalf = ints.Skip(length).ToArray();
    int sum2 = secondHalf.Sum();
    Console.WriteLine("Сумма элементов: " + sum2);
    if (sum2 == sum)
    {
        Console.WriteLine(" Cумма чисел первой половины массива равна сумме второй половины массива");
    }
    else
    {
        Console.WriteLine("Cумма чисел первой половины массива не равна сумме второй половины массива");
    }
}
