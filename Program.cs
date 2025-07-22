class A
{
    static DateTime dateTime1 = DateTime.Now;
   static  DateTime dateTime2 = DateTime.Now;
    public static void TimeIf(string name)
    {
        dateTime1 = DateTime.Now;
        if (name == "yashwanth")
        {
            dateTime2 = DateTime.Now;
        }
        else if (name == "srinivas")
        {
            dateTime2 = DateTime.Now;
        }
        else if (name == "rohit")
        {
            dateTime2 = DateTime.Now;
        }
        else if (name == "karthik")
        {
            dateTime2 = DateTime.Now;
        }
        else if (name == "naresh")
        {
            dateTime2 = DateTime.Now;
        }
        else if (name == "sohail")
        {
            dateTime2 = DateTime.Now;
        }
        else if (name == "puja")
        {
            dateTime2 = DateTime.Now;
        }
        else
        {
            Console.WriteLine("Invalid name provided.");
        }
    }
    
    public static void TimeSwitch(string name)
    {
        dateTime1 = DateTime.Now;
        switch (name)
        {
            case "yashwanth":
                dateTime2 = DateTime.Now;
                break;
            case "srinivas":
                dateTime2 = DateTime.Now;
                break;
            case "rohit":
                dateTime2 = DateTime.Now;
                break;
            case "karthik":
                dateTime2 = DateTime.Now;
                break;
            case "naresh":
                dateTime2 = DateTime.Now;
                break;
            case "sohail":
                dateTime2 = DateTime.Now;
                break;
            case "puja":
                dateTime2 = DateTime.Now;
                break;
            default:
                Console.WriteLine("Invalid name provided.");
                break;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        TimeIf(name);
       

        Console.WriteLine($"Time taken for {name} is: {(dateTime2 - dateTime1)}");
        name=Console.ReadLine();
        TimeSwitch(name);
        Console.WriteLine($"Time taken for {name} is: {(dateTime2 - dateTime1)}");
    }
}