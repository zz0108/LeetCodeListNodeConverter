// See https://aka.ms/new-console-template for more information


using LeetCodeListNodeConverter;

int[] nums = new[] { 2, 3, 4, 5, 6, 7, 8, 9 };


var l1 = nums.ConverterToListNode();

while (l1 != null)
{
    Console.WriteLine(l1.val);
    l1 = l1.next;
}

Console.ReadLine();
