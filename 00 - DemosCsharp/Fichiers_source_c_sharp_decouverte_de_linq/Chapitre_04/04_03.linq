<Query Kind="Statements" />

var parents = new [] {
	new {nom = "Martin",  ville = "Nantes", id = 1},
	new {nom = "Paul",    ville = "Nantes", id = 2},
	new {nom = "Anne",    ville = "Graz",   id = 3},
	new {nom = "Sylvie",  ville = "Graz",   id = 4},
};

//var res = parents.ElementAtOrDefault(4);
//var res = parents.OrderByDescending(p => p.id).First();
//var res = parents.Last();
//var res = parents.Last(p => p.ville == "Graz");
//var res = parents.LastOrDefault(p => p.ville == "San Francisco");
var res = parents.SingleOrDefault(p => p.ville == "Shmutz");
		  
res.Dump();
