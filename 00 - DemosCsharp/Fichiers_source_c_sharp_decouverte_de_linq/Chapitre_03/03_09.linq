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

var res = from p in parents
          group p by p.ville into g
		  orderby g.Key
		  select new { ville = g.Key, parents = String.Join(",", g.Select(v => v.nom).ToList()) }; 

//var res = parents
//	.GroupBy(p => p.ville)
//	.OrderBy(g => g.Key)
//	.Select(g => new { cle = g.Key, valeurs = g.Count() });

res.Dump();