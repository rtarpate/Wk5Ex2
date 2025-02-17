internal class Program
{
    static Dictionary<string, double> contacts = new Dictionary<string, double>();

    static void Main(string[] args)
    {
        int selection = 0;

        while (true)
        {

            Console.WriteLine("Contact system");

            Console.WriteLine(" choose an option \n " +
                "1: add a contact \n" +
                "2: remove a contact \n" +
                "3: search for a contact \n" +
                "4: display all contacts \n " +
                "5: exit ");

            selection = Convert.ToInt32(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    AddContact();
                    break;
                case 2:
                    RemoveContact();
                    break;
                case 3:
                    SearchContact();
                    break;
                case 4:
                    DisplayContact();
                    break;
                case 5:
                    return;

                default:
                    break;

            }
        }
    }

    
    static void AddContact()
    {
        Console.WriteLine(" Enter a contacts name ");

        string name = Console.ReadLine();

        Console.WriteLine(" enter a contact phone number ");

        double Pnumber = Convert.ToInt32(Console.ReadLine());

        contacts.Add(name, Pnumber);

        Console.WriteLine(" a new contact has been added ");

    }

    
    static void RemoveContact()
    {
        Console.WriteLine(" Enter a contacts name  ");

        string name = Console.ReadLine();

        if (contacts.ContainsKey(name))
        {

            contacts.Remove(name);

            Console.WriteLine(" contact " + name + " has been removed ");
        }
        else
        {
            Console.WriteLine(name + " contact that was entered is not in the list ");
        }





    }

    
    static void SearchContact()
    {
        
       Console.WriteLine(" enter a number to search contact list ");

       double Pnumber2 = Convert.ToInt32(Console.ReadLine());

        int count = 0;
       foreach (KeyValuePair<string, double> pair in contacts)
       {
            if(pair.Value == Pnumber2)
            {
                Console.WriteLine(pair.Key + " - " + pair.Value);
                count++;
            }
       }

        if (count == 0)
        {
            Console.WriteLine(" there is no matching entry in the list ");
        }

    }

    
    static void DisplayContact()
    {

        Console.WriteLine(" the full list of contacts ");

        foreach ( KeyValuePair<string, double> contact in contacts )
        {

            Console.WriteLine(" : " + contact.Key + " : " + contact.Value);
        }

    }
}


