static void SelectArr()
{
    string[] arr1 = new string[] { "колобок", "уж", "ёрш", "гипотоламус", "кукушка", "мышь", "lan", "15" };
    int[] array = new int[arr1.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            Console.WriteLine(arr1[i]);
        }

    }


}
SelectArr();