namespace Demo.References
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // étudiez le code suivant et tentez de deviner la sortie du programme

            Console.WriteLine("Passage par valeur et/ou par référence");

            int A = 1;

            Toto(ref A);

            Console.WriteLine("A: " + A);

        }

        static void Toto(ref int B)
        {
            B = B + 1;

            Console.WriteLine("B: " + B);
        }
    }
}
