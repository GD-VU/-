Console.Clear();
int ind = 0;
int max = 0;
Console.Write("Введите количество гирь: ");
//string numbers = 
int numbers = Convert.ToInt32(Console.ReadLine());
int[] Giri = new int [numbers];
while (ind < numbers)
{
    Giri[ind] = new Random().Next(1,1000);
    if (Giri[ind]>max) max = Giri[ind];
    Console.WriteLine(Giri[ind]);
    ind = ind + 1;
}
Console.Write("max = ");
Console.WriteLine(max);