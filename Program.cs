int v = Convert.ToInt32(Console.ReadLine());
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int elimentyes = 0,elimentno = 0;
foreach(int eliment in array)
{
    if(eliment % 2 == 1)
{
    Console.WriteLine($"{eliment}");
    elimentyes++;

}

}

foreach(int eliment in array)

   if(eliment % 2 == 0)
{   
   Console.WriteLine($"{eliment}");
   elimentno++;
}

if(elimentyes>= elimentno)
Console.WriteLine("yes");
else
Console.WriteLine("no");