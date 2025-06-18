using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Console.Clear();
        menu.MakeMenu();
    }
}