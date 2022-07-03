// See https://aka.ms/new-console-template for more information
using Playground;

var q = new CheckifThereIsaValidParenthesesStringPath();
var payload = new char[][] 
{
    new char[] {'(','(','('},
    new char[] {')','(',')'},
    new char[] {'(','(',')'},
    new char[] {'(','(',')'}
};
Console.WriteLine(q.HasValidPath_DP(payload));
