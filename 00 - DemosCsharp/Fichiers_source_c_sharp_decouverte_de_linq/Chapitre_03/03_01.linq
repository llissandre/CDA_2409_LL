<Query Kind="Statements" />

var l1 = new List<string>() { "un", "deux", "trois" };
var l2 = new List<string>() { "trois", "quatre", "cinq" };

var res = l1
	.Zip(
		l2, 
		(v1, v2) => String.Format("{0} et {1}", v1, v2)
		)
	.ToArray();

res.Dump();