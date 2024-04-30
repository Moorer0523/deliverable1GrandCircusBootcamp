int sodaStock = 100;
int sodaRestock = 40;

int chipStock = 40;
int chipRestock = 20;

int candyStock = 60;
int candyRestock = 40;


Console.WriteLine("How many sodas have been sold today? " + sodaStock + " in stock");
string sodaInput = Console.ReadLine();
int sodaSold = int.Parse(sodaInput);

if (sodaSold > sodaStock)
{
    Console.WriteLine("Too high.");
}
else
{
    sodaStock -= sodaSold;
}
Console.WriteLine("Current soda stock is: " + sodaStock);

Console.WriteLine("How many chips have been sold today " + chipStock + " in stock");
string chipInput = Console.ReadLine();
int chipSold =  int.Parse(chipInput);

if (chipSold > chipStock)
{
    Console.WriteLine("Too high.");
}
else
{
    chipStock -= chipSold;
}
Console.WriteLine("Current chip stock is: " + chipStock);

Console.WriteLine("How many chips have been sold today " + candyStock + " in stock");
string candyInput = Console.ReadLine();
int candySold = int.Parse(candyInput);

if (candySold > candyStock)
{
    Console.WriteLine("Too high.");
}
else
{
    candyStock -= candySold;
}
Console.WriteLine("Current candy stock is: " + candyStock);

Console.WriteLine("Thank you for inputting the sales for the day. Any items requiring a restock will be displayed below: ");

if (sodaStock <= sodaRestock)
Console.WriteLine("Soda needs to be restocked. Current value: " + sodaStock + ".");
if (chipStock <= chipRestock)
Console.WriteLine("Chips need to be restocked. Current value: " + chipStock + ".");
if (candyStock <= candyRestock)
Console.WriteLine("Candy needs to be restocked. Current value: " + candyStock + ".");