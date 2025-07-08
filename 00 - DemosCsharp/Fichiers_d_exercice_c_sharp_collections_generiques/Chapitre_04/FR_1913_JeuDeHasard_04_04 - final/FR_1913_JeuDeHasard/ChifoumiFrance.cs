using System.Collections.Generic;

namespace FR_1913_JeuDeHasard
{
    class ChifoumiFrance : IComparer<Chifoumi>
    {
        public int Compare(Chifoumi moi, Chifoumi lui)
        {
            var combinaisons = new Dictionary<(Chifoumi moi, Chifoumi lui), int>()
            {
                { (Chifoumi.Ciseaux, Chifoumi.Pierre ), -1 },
                { (Chifoumi.Ciseaux, Chifoumi.Papier ),  1 },
                { (Chifoumi.Ciseaux, Chifoumi.Ciseaux),  0 },

                { (Chifoumi.Papier , Chifoumi.Pierre ),  1 },
                { (Chifoumi.Papier , Chifoumi.Papier ),  0 },
                { (Chifoumi.Papier , Chifoumi.Ciseaux), -1 },

                { (Chifoumi.Pierre , Chifoumi.Pierre ),  0 },
                { (Chifoumi.Pierre , Chifoumi.Papier ), -1 },
                { (Chifoumi.Pierre , Chifoumi.Ciseaux),  1 }
            };
            return (int)combinaisons[(moi, lui)];
        }
    }
}
