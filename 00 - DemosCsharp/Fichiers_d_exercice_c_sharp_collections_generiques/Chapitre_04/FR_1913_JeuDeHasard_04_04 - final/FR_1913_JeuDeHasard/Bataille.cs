using System;
using System.Collections.Generic;

namespace FR_1913_JeuDeHasard
{
    class Bataille : IComparer<CarteAJouer>
    {
        public int Compare(CarteAJouer moi, CarteAJouer lui)
        {
            bool figureVsNombre = !moi.GetType().Equals(lui.GetType());

            return moi is CarteAJouerFigure
                ? figureVsNombre ? 1 : Comparer<CarteAJouerFigure>(moi, lui)
                : figureVsNombre ? -1 : Comparer<CarteAJouerNombre>(moi, lui);
        }
        private int Comparer<T>(CarteAJouer moi, CarteAJouer lui) where T : CarteAJouer, IComparable<T>
            => ((T)moi).CompareTo((T)lui);
    }
}
