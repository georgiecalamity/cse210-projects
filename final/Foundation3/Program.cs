using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("3985 Johnstown Road", "Hickory Hills", "IL", "USA");
        Address address2 = new Address("3953 Little Street", "Youngstown", "OH", "USA");
        Address address3 = new Address("4379 Sardis Station", "Meadville", "PA", "USA");

        Event lecture = new Lecture("Tech Innovators Summit", "Explore the latest advancements in technology with leading innovators.", address1, "10/15/2023", "2:00pm", "Elon Musk");
        lecture.SetCapacity(500);
        Event reception = new Reception("John and Emily's Engagement Party", "Celebrate the engagement of John and Emily with friends and family.", address2, "11/20/2024", "4:00pm");
        Event outdoor = new Outdoor("Community Wellness Day", "Join local residents for a day dedicated to health and wellness activities.", address3, "6/10/2024", "9:00am", "Sunny");

         
        Console.WriteLine("Short Descriptions:");
        Console.WriteLine(lecture.ShortDescription());
        Console.WriteLine(reception.ShortDescription());
        Console.WriteLine(outdoor.ShortDescription());

        Console.WriteLine("\nStandard Details:");
        Console.WriteLine(lecture.StandardDetails()+"\n");
        Console.WriteLine(reception.StandardDetails()+"\n");
        Console.WriteLine(outdoor.StandardDetails()+"\n");
        
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lecture.FullDetails()+"\n");
        Console.WriteLine(reception.FullDetails()+"\n");
        Console.WriteLine(outdoor.FullDetails()+"\n");
    }
}