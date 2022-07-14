// See https://aka.ms/new-console-template for more information
using Playground;

var q = new ConstructBinaryTreefromPreorderandInorderTraversal();
var payload = new int[]  { 3, 9, 20, 15, 7 };
var payload2 = new int[]  { 9, 3, 15, 20, 7 };
q.BuildTree(payload, payload2);