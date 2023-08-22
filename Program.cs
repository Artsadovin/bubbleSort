namespace BubbleSort;
using System;
using System.Collections.Generic;

public class BubbleSortSolution
{
    public static void Main(string[] args)
    {
        Console.Write("Введите числа для сортировки: ");
        string? numsLine = Console.ReadLine();
        List<int> nums = lineToList(numsLine);
        if(nums.Count == 0){
            Console.WriteLine("Список чисел пуст");
        }
        else{
            nums = bubbleSort(nums);
            Console.Write("Результат сортировки: ");
            printList(nums);
        }
        

    }

    public static List<int> lineToList(string? line)
    {
        List<int> numList = new List<int>();

        string[] numsStr = line.Split(' ');
        int num;
        foreach (string numStr in numsStr)
        {
            bool successParse = int.TryParse(numStr, out num);
            if (successParse)
            {
                numList.Add(num);
            }
        }

        return numList;
    }

    public static List<int> bubbleSort(List<int> list)
    {
        int temp;
        for (int i = 0; i <= list.Count - 2; i++)
        {
            for (int j = 0; j <= list.Count - 2; j++)
            {
                if (list[j] > list[j + 1])
                {
                    temp = list[j + 1];
                    list[j + 1] = list[j];
                    list[j] = temp;
                }
            }
        }
        return list;
    }

    public static void printList(List<int> list)
    {
        foreach (int listItem in list)
        {
            Console.Write($"{listItem} ");
        }
    }
}