<Query Kind="Statements" />

var parents = new [] {
	new {nom = "Martin",  ville = "Nantes", id = 1},
	new {nom = "Paul",    ville = "Nantes", id = 2},
	new {nom = "Anne",    ville = "Graz",   id = 3},
	new {nom = "Sylvie",  ville = "Graz",   id = 4},
};

var enfants = new [] {
	new {nom = "Rose",    parentId = 1},
	new {nom = "Mathieu", parentId = 1},
	new {nom = "Cerise",  parentId = 2}
};

var res = (from p in parents
          orderby p.ville
		  select p.ville).Distinct().Count(); 

res.Dump();