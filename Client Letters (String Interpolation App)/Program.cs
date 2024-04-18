string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

string comparisonMessage = "Dear ";
comparisonMessage = string.Format("{0}{1}", comparisonMessage, customerName);

Console.WriteLine(comparisonMessage.PadRight(16, ','));
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
Console.WriteLine($"Currently, you own {currentShares:N3} shares at a return of {currentReturn:P2}.");
Console.WriteLine($"Our new product, Glorious Future offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.");
Console.WriteLine("\nHere's a quick comparison: \n");

currentProduct = ($"{currentProduct.PadRight(20)}");
currentProduct += ($"{currentReturn:P2}".PadRight(9));
currentProduct += ($"{currentProfit:C}".PadRight(9));

newProduct = ($"\n{newProduct.PadRight(20)}");
newProduct += ($"{newReturn:P2}".PadRight(9));
newProduct += ($"{newProfit:C}".PadRight(9));

Console.WriteLine("{0}{1}", currentProduct, newProduct);
