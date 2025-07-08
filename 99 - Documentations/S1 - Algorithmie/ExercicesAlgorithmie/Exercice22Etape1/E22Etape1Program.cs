string FizzBuzz = "FizzBuzz";
string Fizz = "Fizz";
string Buzz = "Buzz";

for (int NombresListes = 1; NombresListes <= 100; NombresListes++)
{
    int Modulo3 = NombresListes % 3;
    int Module5 = NombresListes % 5;

    //les multiples de cinq et de trois sont remplacés par FizzBuzz
    if ((Modulo3 == 0) && (Module5 == 0))
    {
        Console.WriteLine(FizzBuzz);
    }

    //les multiples de trois sont remplacés par Fizz
    else if (Modulo3 == 0)
    {
        Console.WriteLine(Fizz);
    }

    //les multiples de cinq sont remplacés par Buzz
    else if (Module5 == 0)
    {
        Console.WriteLine(Buzz);
    }

    //le nombre sera affiché s'il n'est ni multiple de 3 ni multiple de 5.
    else
    {
        Console.WriteLine(NombresListes);
    }
}