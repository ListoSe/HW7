using HW7;

Arr a = new Arr(10);
Random rnd = new Random();

for (int i = 0; i < a.GetSize(); i++)
{
    a[i] = rnd.Next(0, 10);
}

a.Show();
//Task 1
/*
Console.WriteLine(a.Less(Convert.ToInt32(Console.ReadLine())));
Console.WriteLine(a.Greater(Convert.ToInt32(Console.ReadLine())));*/

//Task 2
//a.ShowEven();
//a.ShowOdd();

//Task 3
Console.WriteLine("count " + a.CountDistinct());
Console.WriteLine(a.EqualToValue(Convert.ToInt32(Console.ReadLine()))); 
