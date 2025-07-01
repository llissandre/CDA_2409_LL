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

/*
var res = from p in parents
          join e in enfants on p.id equals e.parentId into ge
		  where ge.Count() > 0
		  select new { parent = p.nom, enfants = ge.Select(e => e.nom).ToArray() };

var res = from p in parents
          from e in enfants
		  select new { parent = p.nom, enfant = e.nom };
		  
var res = from p in parents
          from e in enfants
		  where p.id != e.parentId
		  select new { parent = p.nom, enfant = e.nom };

var res = from p in parents
		  where !(from e in enfants select e.parentId).Contains(p.id)
		  select p.nom;
*/

var res = from p in parents
          let eIds = from e in enfants select e.parentId
          where !eIds.Contains(p.id)
		  select p.nom;

res.Dump();