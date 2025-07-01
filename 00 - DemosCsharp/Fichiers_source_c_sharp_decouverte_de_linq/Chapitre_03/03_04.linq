<Query Kind="Statements" />

var parents = new [] {
	new {nom = "Martin",  id = 1},
	new {nom = "Paul",    id = 2},
	new {nom = "Anne",    id = 3},
	new {nom = "Sylvie",  id = 4},
};

var enfants = new [] {
	new {nom = "Rose",    parentId = 1},
	new {nom = "Mathieu", parentId = 1},
	new {nom = "Cerise",  parentId = 2}
};

parents.Dump();
enfants.Dump();

var res = from p in parents
          join e in enfants on p.id equals e.parentId
		  select new { parent = p.nom, enfant = e.nom };

res.Dump();

//var res = parents.Join(
//	enfants,
//	p => p.id,
//	e => e.parentId,
//	(p, e) => new { parent = p.nom, enfant = e.nom }
//);
//
//res.Dump();