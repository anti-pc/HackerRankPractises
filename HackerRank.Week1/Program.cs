using HackerRank.Week1;


// PlusMinus
int n = Convert.ToInt32(Console.ReadLine().Trim());

List<int> arrPlusMinus = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

PlusMinus.plusMinus(arrPlusMinus);



// MiniMaxSum
List<int> arrMiniMaxSum = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

MiniMaxSum.miniMaxSum(arrMiniMaxSum);