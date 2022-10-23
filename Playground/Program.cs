// See https://aka.ms/new-console-template for more information

using Playground;
using System.Net.Http.Json;
using System.Net.Security;

var x = new Russian_Doll_Envelopes();
// // Console.WriteLine(x.Demo(new []{6,5,4,3,2,1}, 2));
var y = new int[][]
{
    new int[] { 15, 8 },
    new int[] { 2, 20 },
    new int[] { 2, 14 },
    new int[] { 4, 17 },
    new int[] { 8, 19 },
    new int[] { 8, 9 },
    new int[] { 5, 7 },
    new int[] { 11, 19 },
    new int[] { 8, 11 },
    new int[] { 13, 11 },
    new int[] { 2, 13 },
    new int[] { 11, 19 },
    new int[] { 8, 11 },
    new int[] { 13, 11 },
    new int[] { 2, 13 },
    new int[] { 11, 19 },
    new int[] { 16, 1 },
    new int[] { 18, 13 },
    new int[] { 14, 17 },
    new int[] { 18, 19 }
};
var z = new LongestIncreasingSubsequence();
var t = y.OrderBy(x => x[1]).ThenBy(x => x[0]).Select(x => x[0]).ToArray();
Console.WriteLine(z.LengthOfLISOptimized(t));
Console.WriteLine(x.MaxEnvelopes(y));