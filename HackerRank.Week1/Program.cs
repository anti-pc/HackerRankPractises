using HackerRank.Week1;
using System.Collections.Generic;


// CountingSort
//List<int> numbers = new List<int>
//{
//    63, 25, 73, 1, 98, 73, 56, 84, 86, 57, 16, 83, 8, 25, 81, 56, 9, 53, 98, 67, 99, 12, 83, 89, 80, 91, 39, 86, 76, 85, 74, 39, 25, 90, 59, 10, 94, 32, 44, 3, 89, 30, 27, 79, 46, 96, 27, 32, 18, 21, 92, 69, 81, 40, 40, 34, 68, 78, 24, 87, 42, 69, 23, 41, 78, 22, 6, 90, 99, 89, 50, 30, 20, 1, 43, 3, 70, 95, 33, 46, 44, 9, 69, 48, 33, 60, 65, 16, 82, 67, 61, 32, 21, 79, 75, 75, 13, 87, 70, 33
//};

List<int> numbers = new List<int>
{
    63, 54, 17, 78, 43, 70, 32, 97, 16, 94, 74, 18, 60, 61, 35, 83, 13, 56, 75, 52, 70, 12, 24, 37, 17, 0, 16, 64, 34, 81, 82, 24, 69, 2, 30, 61, 83, 37, 97, 16, 70, 53, 0, 61, 12, 17, 97, 67, 33, 30, 49, 70, 11, 40, 67, 94, 84, 60, 35, 58, 19, 81, 16, 14, 68, 46, 42, 81, 75, 87, 13, 84, 33, 34, 14, 96, 7, 59, 17, 98, 79, 47, 71, 75, 8, 27, 73, 66, 64, 12, 29, 35, 80, 78, 80, 6, 5, 24, 49, 82
};


var result = CountingSort.countingSort(numbers);
foreach (int number in result)
{
    Console.Write(number + " ");
}

/*
// DiagonalDifference

List<List<int>> matrix = new List<List<int>>
{
    new List<int> { 11, 2, 4 },
    new List<int> { 4, 5, 6 },
    new List<int> { 10, 8, -12 }
};

int result = DiagonalDifference.diagonalDifference(matrix);
Console.WriteLine("Absolute diagonal difference: " + result);



// FlippingBits

long n = Convert.ToInt64(Console.ReadLine().Trim());
Console.WriteLine(FlippingBits.flippingBits(n));


// LonelyInteger

List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
Console.WriteLine(LonelyInteger.lonelyinteger(a));



// SparseArrays

List<string> strings = Console.ReadLine().TrimEnd().Split(' ').ToList();
List<string> queries = Console.ReadLine().TrimEnd().Split(' ').ToList();


List<int> result = SparseArrays.matchingStrings(strings, queries);

result.ForEach(i => Console.Write("{0}\t", i));


//TimeConversion

string s = Console.ReadLine();

string result = TimeConversion.timeConversion(s);

Console.WriteLine(result);



// MiniMaxSum
List<int> arrMiniMaxSum = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

MiniMaxSum.miniMaxSum(arrMiniMaxSum);


// PlusMinus
int n = Convert.ToInt32(Console.ReadLine().Trim());

List<int> arrPlusMinus = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

PlusMinus.plusMinus(arrPlusMinus);

*/



