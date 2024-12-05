using System;

string input;
int[] list1 = new int[6];
int[] list2 = new int[6];
int sum = 0;


Console.WriteLine("Enter first List");
for (int i = 0; i < 6; i++)
{
    Console.Write($"{i + 1}: ");
    input = Console.ReadLine();
    list1[i] = int.Parse(input);
}

Console.WriteLine("Enter second List");
for (int i = 0; i < 6; i++)
{
    Console.Write($"{i + 1}: ");
    input = Console.ReadLine();
    list2[i] = int.Parse(input);
}

Array.Sort(list1);
Array.Sort(list2);

Console.WriteLine("Sorted:");
for (int i = 0; i < 6; i++)
{
    Console.WriteLine($"|{list1[i]} - {list2[i]}| = {Math.Abs(list1[i] - list2[i])}");
    sum = sum + Math.Abs(list1[i] - list2[i]);
}
Console.WriteLine($"Difference = {sum}");