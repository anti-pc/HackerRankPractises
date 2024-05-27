using HackerRank.Week1;
using System.Collections.Generic;


// SparseArrays

List<string> strings = Console.ReadLine().TrimEnd().Split(' ').ToList();
List<string> queries = Console.ReadLine().TrimEnd().Split(' ').ToList();


List<int> result = SparseArrays.matchingStrings(strings, queries);

result.ForEach(i => Console.Write("{0}\t", i));
/*

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



