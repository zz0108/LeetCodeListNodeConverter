// See https://aka.ms/new-console-template for more information


using LeetCodeListNodeConverter;

//ListNode基本用法，他是個擴充方法，所以直接呼叫就好
// var nums = new[] { 2, 3, 4, 5, 6, 7, 8, 9 };
// var l1 = nums.ConverterToListNode();

//TreeNode基本用法，他是個擴充方法，所以直接呼叫就好
// var nums1 = new int?[] { 2, 1, 3 };
// var tree = nums1.ConverterToTreeNode();

// var nums2 = new int?[] { 1,null,3,2 };
// var tree1 = nums2.ConverterToTreeNode();

var num1 = "123456555";
var num2 = "123456789";

var a = SubSolution.SubStrings(num1, num2);
Console.WriteLine(a);

