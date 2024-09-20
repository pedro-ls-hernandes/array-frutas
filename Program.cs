//Defining array values
string[] fruits = new string[] { "Apple", "Banana", "Orange", "Grappe", "Mango", "Pear", "Avocado", "Papaya", "Peach", "Lemon" };

//Showing the second and last fruit
Console.WriteLine($"{fruits[1]} e {fruits[8]}");

fruits[2] = "Kiwi";
fruits[9] = "Strawberry";

//Showing all fruits
for (int i = 0; i < fruits.Length; i++)
{
    Console.WriteLine($"{i + 1} {fruits[i]}");
}

//Counting all the fruits
int total = 0;
total = fruits.Count();
Console.WriteLine(total);

//Ordering the elements in the array by alphabetical order
var orderedFruits = fruits.OrderBy(p => fruits).ToList();
Array.Sort(fruits);

//Ordering the elements in the array by reverse alphabetical order
foreach (string fruta in fruits.Reverse())
{
    Console.WriteLine(fruta);
}