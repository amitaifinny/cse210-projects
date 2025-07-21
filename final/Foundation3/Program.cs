using System;

class Program
{
    static void Main(string[] args)
    {
        Address byuiAddress = new Address("525 S Center St", "Rexburg", "ID", "USA");
        Lecture lectureEvent = new Lecture(
            "Navigating AI in the Modern Workplace",
            "A discussion on the ethical considerations and practical applications of artificial intelligence in various professional fields.",
            "August 15, 2025",
            "7:00 PM",
            byuiAddress,
            "Dr. Emily Chen",
            300);

        Console.WriteLine("--- Lecture Event Details ---");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lectureEvent.ListStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(lectureEvent.ListShortDetails());
        Console.WriteLine("-----------------------------");


        Address receptionAddress = new Address("500 S 2nd E", "Rexburg", "ID", "USA");
        Reception receptionEvent = new Reception(
        "Alumni Networking Mixer",
        "An evening to connect with fellow BYU-Idaho alumni and faculty.",
        "September 20, 2025",
        "6:30 PM",
        receptionAddress,
        "alumni.rsvp@byui.edu");

        Console.WriteLine("--- Reception Event Details ---");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(receptionEvent.ListStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(receptionEvent.ListShortDetails());
        Console.WriteLine("-----------------------------");


        Address parkAddress = new Address("City Park Drive", "Rexburg", "ID", "USA");
        OutdoorGather outdoorGatheringEvent = new OutdoorGather(
        "Summer Community Picnic",
        "Join us for a fun-filled afternoon with games, food trucks, and live music for the whole family!",
        "July 27, 2025",
        "12:00 PM",
        parkAddress,
        "Sunny with a high of 85°F, light breeze");
        
        Console.WriteLine("--- Outdoor Gathering Event Details ---");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(outdoorGatheringEvent.ListStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(outdoorGatheringEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(outdoorGatheringEvent.ListShortDetails());
        Console.WriteLine("-----------------------------");

    }
}