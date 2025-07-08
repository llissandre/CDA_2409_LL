using System;

namespace FR_1913_JeuDeHasard
{
    public class CarteAJouerNombre : CarteAJouer, IComparable<CarteAJouerNombre>
    {
        public CarteAJouerNombre(int valeur, Couleur couleur) : base(couleur)
        {
            if(valeur<0 || valeur>10)
            {
                throw new ArgumentOutOfRangeException("Une carte doit avoir une valeur de 1 à 10");
            }
            Valeur = valeur;
        }
        public int Valeur
        {
            get; private set;
        }
        public override string ToString()
            => $"{ Valeur } de { Couleur }";

        public int CompareTo(CarteAJouerNombre autre)
            => Valeur - autre.Valeur;
    }
}
