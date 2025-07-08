using System;

namespace FR_1913_JeuDeHasard
{
    public enum Figure
    {
        Valet,
        Dame,
        Roi,
        As
    }
    public class CarteAJouerFigure : CarteAJouer, IComparable<CarteAJouerFigure>
    {
        public CarteAJouerFigure(Figure figure, Couleur couleur) : base(couleur)
        {
            Figure = figure;
        }
        public Figure Figure
        {
            get; private set;
        }

        public override string ToString()
            => $"{ Figure } de { Couleur }";

        public int CompareTo(CarteAJouerFigure autre)
            => Figure - autre.Figure;
    }
}
