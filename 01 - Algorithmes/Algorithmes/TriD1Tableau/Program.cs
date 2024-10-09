// See https://aka.ms/new-console-template for more information

int[] tableau;
int temp;
int temp2;
int i1=0;
int i2=0;

tableau = [128, 64, 8, 512, 16, 32, 256];

//for (int i = 0; i < 1; i++)
//{
temp = tableau[i1];
temp2 = tableau[i1];
Console.WriteLine(temp);

for (int j = 1; j < tableau.Length; j++)
{
    if (tableau[j] < temp && tableau[j] < temp2)
    {
        temp2 = tableau[j];
        i2 = j;
    }
}
//}

tableau[i2] = temp;
tableau[i1] = temp2;


foreach (int i in tableau)
{
    Console.Write(i);
}