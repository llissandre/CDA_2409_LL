<Query Kind="Statements" />

var parents = new [] {
	new {nom = "Martin",  ville = "Nantes", id = 1},
	new {nom = "Paul",    ville = "Nantes", id = 2},
	new {nom = "Anne",    ville = "Graz",   id = 3},
	new {nom = "Sylvie",  ville = "Graz",   id = 4},
	new {nom = "Adrien",  ville = "Nantes", id = 4},
};

//var res = parents.Where(p => p.ville == "Graz");
//var res = parents.Take(1);
//var res = parents.TakeWhile(p => p.ville == "Graz");
//var res = parents.Skip(2);
var res = parents.SkipWhile(p => p.ville != "Graz");
		  
res.Dump();
res.GetType().Dump();
