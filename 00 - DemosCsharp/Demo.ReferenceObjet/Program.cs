namespace Demo.ReferenceObjet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Passage par valeur et/ou par référence (objets)");

            Personne A = new Personne(18);

            Console.WriteLine("A: " + A.age);

            Toto(A);

            Console.WriteLine("A: " + A.age);

            /*Personne C = A;
            C.age = 42;
            Console.WriteLine("A: " + A.age);
            Console.WriteLine("C: " + C.age);*/

        }

        static void Toto(Personne B)
        {
            B.age++;

            Console.WriteLine("B: " + B.age);
        }
    }
}
