Console.WriteLine ("Введите M чисел, через пробел или запятую:");
string a = Console.ReadLine();
int[] mass=Array.ConvertAll(a.Split(' ',','),int.Parse);
Console.WriteLine("Чисел больше нуля: "+CountBolsheNull(mass));
int CountBolsheNull(int[] array)
{
    int i=0,z=0;
    for (i=0;i<mass.Length;i++)
    {
        if (mass[i]>0)
        z++;
    }
    return z;
}