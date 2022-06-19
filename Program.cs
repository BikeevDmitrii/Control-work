static void SelectArr()
{
    string[] array = new string[] { "колобок", "уж", "ёрш", "гипотоламус", "кукушка", "мышь", "lan", "15", ":-)" };
    int z = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            z++;
        }
    }
    string[] array2 = new string[z];
    z = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[z] = array[i];
            z++;
        }
    }
    Console.Write("[");
    for (int j = 0; j < array2.Length; j++)
    {
        Console.Write("'"+ array2[j] +"'"+ ", ");
    }
    Console.Write("]");
}
SelectArr();