#### 1. Donner nom, job, numéro et salaire de tous les employés, puis seulement des employés du département 10
>```code
>db.emp.find({}, {ename:1, job:1, _id:1, sal:1})
>```
>```code
>db.emp.find({deptno: 10}, {ename:1, job:1, _id:1, sal:1})
>```
---


#### 2. Donner nom, job et salaire des employés de type MANAGER dont le salaire est supérieur à 2800
>~~~json
>db.emp.find({job: "MANAGER", sal: {$gt: 2800}}, {_id:0, ename:1, job:1, sal:1})
>~~~
---

#### 3.  Donner la liste des MANAGER n'appartenant pas au département 30
>```json
>db.emp.find({job: "MANAGER", deptno: {$ne: 30}}, {_id:0, ename:1, job:1, sal:1})
>```
---

#### 4. Liste des employés de salaire compris entre 1200 et 1400
>```json
>db.emp.find({sal: {$gt: 1200, $lt: 1400}}, {_id:0, ename:1, job:1, sal:1})
>```
---

#### 5. Liste des employés des départements 10 et 30 classés dans l'ordre alphabétique
>```json
>db.emp.find({deptno: {$eq: 10, $eq: 30}}, {_id:0, ename:1, job:1, sal:1}).sort({ename:1})
>```
---

#### 6. Liste des employés du département 30 classés dans l'ordre des salaires croissants
>```json
>db.emp.find({deptno: {$eq: 30}}, {_id:0, ename:1, job:1, sal:1}).sort({sal:1})
>```
---

#### 7. Liste de tous les employés classés par emploi et salaires décroissants
>```json
>db.emp.find({}, {_id:0, ename:1, job:1, sal:1}).sort({job:-1}, {sal:-1})
>```
---

#### 8. Liste des différents emplois
>```json
>db.emp.distinct("job")
>```
>```json
>db.emp.aggregate([{$group: {_id: {Emploi: "$job"}}}])
>```
>``` json
>db.emp.aggregate([{$group: {_id: "$job"}}, {$project: {_id:0, Emploi: "$_id"}}])
>```
---

#### 9. Donner le nom du département où travaille ALLEN
>```json
>db.emp.find({ename: "ALLEN"}, {_id:0, dname:1})
>```
---

#### 10. Liste des employés avec nom du département, nom, job, salaire classés par noms de départements et par salaires décroissants
>```json
>db.emp.find({}, {_id:0, dname:1, ename:1, job:1, sal:1}).sort({dname:-1, sal:-1})
>```
---

#### 11. Liste des employés vendeurs (SALESMAN) avec affichage de nom, salaire, commissions, salaire + commissions
>```json
>db.emp.aggregate([{$match: {job: "SALESMAN"}}, {$project: {_id:0, ename:1, sal:1, comm:1, "Revenu total": {$add: ["$sal", "$comm"]}}}])
>```
>```json
>db.emp.find({job: "SALESMAN"}, {_id:0, ename:1, sal:1, comm:1, "Revenu total": {$add: ["$sal", "$comm"]}})
>```
---

#### 12. Donner le salaire le plus élevé par département
>```json
>db.emp.aggregate([{$group: {_id: "$dname", "Salaire max": {$max: "$sal"}}}])
>```
>```json
>db.emp.aggregate([{$group: {_id: {Département: "$dname"}, "Salaire max": {$max: "$sal"}}}])
>```
>```json
>db.emp.aggregate([{$group: {_id: "$dname", "Salaire max": {$max: "$sal"}}}, {$project: {_id:0, "Département": "$_id", "Salaire max":1}}])
>```
---

#### 13. Donner département par département masse salariale, nombre d'employés, salaire moyen par type d'emploi
>```json
>db.emp.aggregate([
>{$group: {
>	_id: "$dname",
>	"Salaires": {$sum: "$sal"},
>	"Commissions": {$sum: "$comm"},
>	"Nombre d'employés": {$sum:1},
>	"SM": {$avg: "$sal"}
>	}
>},
>{$project:
>	{
>	_id:0,
>	"Département": "$_id",
>	"Masse salariale": {$add: ["$Salaires", "$Commissions"]},
>	"Salaires":1,
>	"Commissions":1,
>	"Nombre d'employés":1,
>	"Salaire moyen par département": {$round: ["$SM", 2]}
>	}
>}
>])
>```

>```json
>db.emp.aggregate([
>{$group: {
>	_id: {
>		Département: "$dname",
>		Emploi: "$job"
>	},
>	"Salaires": {$sum: "$sal"},
>	"Commissions": {$sum: "$comm"},
>	"Nombre d'employés": {$sum:1},
>	"SM": {$avg: "$sal"}
>	}
>},
>{$project:
>	{
>	_id:0,
>	"Masse salariale": {$add: ["$Salaires", "$Commissions"]},
>	"Salaires":1,
>	"Commissions":1,
>	"Nombre d'employés":1,
>	"Salaire moyen": {$round: ["$SM", 2]}
>	}
>}
>])
>```
