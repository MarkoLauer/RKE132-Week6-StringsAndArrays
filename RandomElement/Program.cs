string[] snacks = { "sushi", "pizza", "burger", "chicken wings", "asian takeaways" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonoght we are gonig to eat {snacks[randomIndex]}");

string[] colors = { "red", "green", "blue", "pink", "yellow" };
Random rnd = new Random();
string randomColor = colors[rnd.Next(0, colors.Length)];

Console.WriteLine($"You should wear {randomColor} today.");

