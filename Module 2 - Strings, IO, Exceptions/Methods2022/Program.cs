using Methods2022;


// Variable declarations
const decimal TAX_RATE = 0.07m;
// Calculate book tax
decimal bookPrice = 25.99m;
decimal bookTax;
bookTax = Helpers.CalculateTax(bookPrice, TAX_RATE);
Console.Write("Book tax is: ");
Helpers.DisplayCurrency(bookTax);
Console.WriteLine();
// Calculate meal tax
decimal mealPrice = 12.39m;
decimal mealTax;
mealTax = Helpers.CalculateTax(mealPrice, TAX_RATE);
Console.Write("Meal tax is: ");
Helpers.DisplayCurrency(mealTax);