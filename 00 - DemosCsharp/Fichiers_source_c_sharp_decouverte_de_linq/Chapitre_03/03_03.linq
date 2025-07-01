<Query Kind="Statements" />

var l1 = new List<string>() { "un", "deux", "trois" };
var l2 = new List<string>() { "trois", "quatre", "cinq" };

var res = l1
	.Join(
		l2,
		v1 => v1,
		v2 => v2,
		(v1, v2) => new { un = v1, deux = v2 }
	)
	.ToArray();

res.Dump();