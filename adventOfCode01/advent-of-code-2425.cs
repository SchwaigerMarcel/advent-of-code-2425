using System;

string input;
int[] list1 = new int[6];
int[] list2 = new int[6];


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
Console.WriteLine($"|{list1[0]} - {list2[0]}| = {Math.Abs(list1[0] - list2[0])}");
Console.WriteLine($"|{list1[1]} - {list2[1]}| = {Math.Abs(list1[1] - list2[1])}");
Console.WriteLine($"|{list1[2]} - {list2[2]}| = {Math.Abs(list1[2] - list2[2])}");
Console.WriteLine($"|{list1[3]} - {list2[3]}| = {Math.Abs(list1[3] - list2[3])}");
Console.WriteLine($"|{list1[4]} - {list2[4]}| = {Math.Abs(list1[4] - list2[4])}");
Console.WriteLine($"|{list1[5]} - {list2[5]}| = {Math.Abs(list1[5] - list2[5])}");