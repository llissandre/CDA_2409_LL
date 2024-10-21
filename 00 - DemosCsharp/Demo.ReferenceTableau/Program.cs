namespace Demo.ReferenceTableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Passage par valeur et/ou par référence (tableaux)");

            int[] A = [1, 2, 3, 4];

            Titi(A);

            for(int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("A[" + i + "] = " + A[i]);
            }

        }

        static void Tata(int[] B)
        {
            B = [9, 8, 7];
        }

        static void Titi(int[] B)
        {
            for(int i = 0; i < B.Length; i++)
            {
                B[i] = B[i] * 2;
            }            
        }
    }
}
