using csharp_oop_shop;

bool productFlag = false;
Console.Write("Vuoi inserire un prodotto? (si/no)");
string productFlagString = Console.ReadLine();
if(productFlagString == "NO" || productFlagString == "no" || productFlagString == "No")
{
	productFlag = true;
}
while (!productFlag)
{
	Prodotto prodotto = new Prodotto();

	prodotto.creaProdotto();

	Console.Write("Vuoi stampare il prodotto appena creato? ");
	string printProductString = Console.ReadLine();
	if(printProductString == "SI" || printProductString == "si" || productFlagString == "Si")
	{
		prodotto.printProduct();
	}

	Console.Write("Vuoi inserire un altro prodotto? (si/no))");
	productFlagString = Console.ReadLine();
	if (productFlagString == "NO" || productFlagString == "no" || productFlagString == "No")
	{
		productFlag = true;
	}
}