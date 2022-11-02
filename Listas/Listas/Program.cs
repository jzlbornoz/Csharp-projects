
List<string> pastasList = new List<string>();

pastasList.Add("cinco pastas");
pastasList.Add("cuatro pizzas");
pastasList.Add("cinco aguas");
pastasList.Add("dos jugos");
pastasList.Add("cinco cocas");

for(int i = 0; i < pastasList.Count; i++)
{
    Console.WriteLine(i + ". " + pastasList[i]);
}
//pastasList.Remove("cinco pastas");
pastasList.RemoveAt(0);

for (int i = 0; i < pastasList.Count; i++)
{
    Console.WriteLine(i + ". " + pastasList[i]);
}

Random rnd = new Random();
Console.WriteLine($"{rnd.Next(12, 230)}");

for (int i = 0; i < rnd.Next(12, 150); i++)
{
    Console.WriteLine(i);
}


