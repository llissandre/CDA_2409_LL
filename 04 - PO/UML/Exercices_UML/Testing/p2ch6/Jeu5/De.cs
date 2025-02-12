﻿using System;

namespace Jeu5
{
    public class De : ILanceurDeDe
    {
        private Random random;

        public De()
        {
            random = new Random();
        }

        public int Lance()
        {
            return random.Next(1, 7);
        }
    }
}
