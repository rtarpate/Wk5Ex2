internal class Program
{
    //creates list for contaxt information
    static Dictionary<string, double> contacts = new Dictionary<string, double>();

    static void Main(string[] args)
    {
        //decalres variable for selection
        int selection = 0;

        //uses loop that repeats forever
        while (true)
        {

            //outputs line of text
            Console.WriteLine("Contact system");

            //promts user input for use selection
            Console.WriteLine(" choose an option \n " +
                "1: add a contact \n " +
                "2: remove a contact \n " +
                "3: search for a contact \n " +
                "4: display all contacts \n " +
                "5: exit ");

            //collect and converts user input
            selection = Convert.ToInt32(Console.ReadLine());

            //uses switch and user input to select what method to use
            switch (selection)
            {
                case 1:
                    //process to add contact
                    AddContact();
                    break;
                case 2:
                    //process to remove contact
                    RemoveContact();
                    break;
                case 3:
                    //process to search for a contact
                    SearchContact();
                    break;
                case 4:
                    //process to display all contacts
                    DisplayContact();
                    break;
                case 5:
                    //process to exit loop
                    return;

                default:
                    //outputs that use input was invalid
                    Console.WriteLine(" invalid input ");
                    break;

            }
        }
    }

    //method to add contacts
    static void AddContact()
    {
        //promts user input
        Console.WriteLine(" Enter a contacts name ");

        //collects user input
        string name = Console.ReadLine();

        //promt user input
        Console.WriteLine(" enter a contact phone number ");

        //collects and converts user input
        double Pnumber = Convert.ToInt32(Console.ReadLine());

        //adds new contact to list
        contacts.Add(name, Pnumber);

        //outputs that a new contact has been added
        Console.WriteLine(" a new contact has been added ");

    }

    
    //method to remove a contact
    static void RemoveContact()
    {
        //promt user input
        Console.WriteLine(" Enter a contacts name  ");

        //collects user input
        string name = Console.ReadLine();

        //uses if statment to search contact list
        if (contacts.ContainsKey(name))
        {
            //removes contact form the list
            contacts.Remove(name);

            //outputs that the contact has been removed
            Console.WriteLine(" contact " + name + " has been removed ");
        }
        else
        {
            //outputs if contact wasnt found in the list
            Console.WriteLine(name + " contact that was entered is not in the list ");
        }





    }

   
    //method for seach for contacts
    static void SearchContact()
    {
        //promts user inputs
       Console.WriteLine(" enter a number to search contact list ");

        //collects and converts user input
       double Pnumber2 = Convert.ToInt32(Console.ReadLine());

        //declares variable for count
        int count = 0;

        //uses foreach to search the contact list
       foreach (KeyValuePair<string, double> pair in contacts)
       {
            //sreaches list to see if it can find if user input is in list
            if(pair.Value == Pnumber2)
            {
                //outputs if search was found
                Console.WriteLine(pair.Key + " - " + pair.Value);
                count++;
            }
       }

        if (count == 0)
        {
            //outputs if no match was found
            Console.WriteLine(" there is no matching entry in the list ");
        }

    }

    
    //method to display all contacts
    static void DisplayContact()
    {
        //outputs text line
        Console.WriteLine(" the full list of contacts ");

        //uses foreach for each enter in the lists
        foreach ( KeyValuePair<string, double> contact in contacts )
        {
            //outputs the entires in the list
            Console.WriteLine(" : " + contact.Key + " : " + contact.Value);
        }

    }
}


