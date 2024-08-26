string[] snacks = { "sushi", "pizza", "burger", "chicken wings" };

int randomIndex = new Random().Next(0, snacks.Length);

Console.WriteLine($"Tonight we are going to eat {snacks[randomIndex]}.");