
while (true) {
    Console.WriteLine("Who would like a new hobby?");
    string name = Console.ReadLine();
    var rand = new Random();
    var res = rand.Next(0, 6);
    if (res == 0)
    {
        Console.WriteLine($"Drumroll, please! {name} has taken up professional cloud-watching. They're reaching for the sky, one cumulus at a time!");
    }
    else if (res == 1)
    {
        Console.WriteLine($"Hold onto your spoons! {name} is now a cereal box collector extraordinaire. They're crunching numbers on the rarest flakes!");
    }
    else if (res == 2)
    {
        Console.WriteLine($"Hold onto your irons! {name} is now an extreme ironer, tackling creases on mountaintops!");
    }
    else if (res == 3)
    {
        Console.WriteLine($"Get ready to get wet and woven! {name} is now diving into competitive underwater basket weaving!");
    }
    else if (res == 4)
    {
        Console.WriteLine($"Thumb war, anyone? {name} is now a pro thumb wrestler, ready for any challenge!");
    }
    else if (res == 5)
    {
        Console.WriteLine($"Cheese lovers unite! {name} has mastered cheese sculpting. Say cheese, it's art!");
    }
}