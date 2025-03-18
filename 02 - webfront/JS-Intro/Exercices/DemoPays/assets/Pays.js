export class Pays 
{
    static regexNomPays = /^[a-zA-Z]{4,}$/;

    constructor(codePays, nomPays) {
        
        if(codePays.length != 2) { 
            throw new Error('Le code pays doit contenir exactement 2 caractères');
        }

        if(!Pays.regexNomPays.test(nomPays)) { 
            throw new Error('Le nom du pays ne doit contenir que des lettres et doit contenir au moins 4 lettres.')
        }

        this.codePays = codePays.toUpperCase();
        this.nomPays = nomPays.charAt(0).toUpperCase() + nomPays.slice(1).toLowerCase();
    }
}
