using System;
using ClassLibraryExercices;
using FluentAssertions;

namespace Jeu1.UnitTests
{

    [TestClass]
    public class JeuTests
    {
        [TestMethod]
        [Description("Etant donn� un tour de jeu, j'ai un lancer sup�rieur au second, " +
            "alors le r�sultat est gagn� avec un point sans perdre de points de vie")]
        public void Tour_AvecUnDeSuperieurAuSecond_RetourneGagneAvecUnPointEtSansPerdreDePointsDeVie()
        {
            // Arrange
            Jeu jeu = new Jeu();

            // Act
            var resultat = jeu.Tour(6, 1);

            // Assert
            if (resultat != Resultat.Gagne)
                Assert.Fail();
            if (jeu.Heros.Points != 1)
                Assert.Fail();
            if (jeu.Heros.PointDeVies != 15)
                Assert.Fail();
        }

        [TestMethod]
        [Description("Etant donn� un tour de jeu, j'ai un lancer �gal au second, " +
            "alors le r�sultat est gagn� avec un point sans perdre de points de vie")]
        public void Tour_AvecUnDeEgalAuSecond_RetourneGagneAvecUnPointEtSansPerdreDePointsDeVie()
        {
            // Arrange
            Jeu jeu = new Jeu();

            // Act
            var resultat = jeu.Tour(5, 5);

            // Assert
            if (resultat != Resultat.Gagne)
                Assert.Fail();
            if (jeu.Heros.Points != 1)
                Assert.Fail();
            if (jeu.Heros.PointDeVies != 15)
                Assert.Fail();
        }

        [TestMethod]
        [Description("Etant donn� un tour de jeu, j'ai un lancer inf�rieur au second, " +
            "alors le r�sultat est perdu, sans points et en perdant deux points de vie")]
        public void Tour_AvecUnDeInferieurAuSecond_RetournePerduAvecZeroPointEtEnPerdantDeuxPointsDeVie()
        {
            // Arrange
            Jeu jeu = new Jeu();

            // Act
            var resultat = jeu.Tour(2, 4);

            // Assert
            if (resultat != Resultat.Perdu)
                Assert.Fail();
            if (jeu.Heros.Points != 0)
                Assert.Fail();
            if (jeu.Heros.PointDeVies != 13)
                Assert.Fail();
        }
    }
}