<Query Kind="Statements" />

var l1 = new List<string>() { "un", "deux", "trois" };
var l2 = new List<string>() { "trois", "quatre", "cinq" };

var res = l1
	//.Union(l2)
	//.Except(l2)
	//.Intersect(l2)
	.Concat(l2)
	.ToArray();

res.Dump();