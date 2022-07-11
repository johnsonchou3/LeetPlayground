// See https://aka.ms/new-console-template for more information
using Playground;

var q = new SortedList<int, int>();
q.Add(3, 5);
q.Add(1, 300000);
q.Add(22, 3);
// 用前面排, 前面是Key
Console.WriteLine(q.ElementAt(0));