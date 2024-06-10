using HackerRank.Week1;
using System.Collections.Generic;


// DiagonalDifference

List<List<int>> matrix = new List<List<int>>
{
    new List<int> { 11, 2, 4 },
    new List<int> { 4, 5, 6 },
    new List<int> { 10, 8, -12 }
};

int result = DiagonalDifference.diagonalDifference(matrix);
Console.WriteLine("Absolute diagonal difference: " + result);

/*

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



