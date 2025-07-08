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
          join e in enfants on p.id equals e.parentId
		  select new { ville = p.ville, enfant = e.nom } into ve
		  group ve by ve.ville into g
		  select new { cle = g.Key, enfants = g.Select(e => e.enfant) };

//var res = from p in parents
//          join e in enfants on p.id equals e.parentId into ve
//		  where ve.Count() > 0
//		  select new { cle = p.ville, enfants = ve.Select(e => e.nom) };

res.Dump();