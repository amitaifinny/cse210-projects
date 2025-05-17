using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal!");

        Menu menu = new Menu();

        menu.MakeMenu();
    }
}

//For the stretch challenge, I exceeded the requirements by adding a unique word generator class. I added a new option to the menu. The user can select 2 to see a unique word with its definition. This could help the user to spice up their journal entry and use a new, unique word if they would like. Or it could just be a fun thing they could do, if they wanted to deepen their vocabulary.