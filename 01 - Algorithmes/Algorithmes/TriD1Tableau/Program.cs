// See https://aka.ms/new-console-template for more information

int[] tableau;
int j;
int temp;
int temp2;

tableau = [128, 64, 8, 512, 16, 32, 256];

//for (int i = 0; i < 1; i++)
//{
temp = tableau[0];
Console.WriteLine(temp);

for (int i2 = 1; i2 < tableau.Length; i2++)
{
    if (tableau[i2] < temp)
    {

    }
}
//}

foreach (int i in tableau)
{
    Console.Write(i);
}