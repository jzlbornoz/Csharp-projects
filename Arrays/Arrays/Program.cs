string[] coffeTypes;
float[] coffePrices;

coffeTypes = new string[] { "Expreso", "Large", "Medium", "Blackie" };
coffePrices = new float[] { 1.2f, 2.2f, 1.9f, 1.4f };

for (int i = 0; i < coffeTypes.Length; i++)
{
    Console.WriteLine(coffeTypes[i] + " " + coffePrices[i] + "$");
}
