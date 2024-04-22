Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");


//dev rep

Console.WriteLine("Введитте свое ФИО");

string fullName = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Green;
Console.Write(fullName.Split()[0]);
Console.ResetColor();

Console.Write(" ");

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write(fullName.Split()[1]);
Console.ResetColor();

Console.Write(" ");