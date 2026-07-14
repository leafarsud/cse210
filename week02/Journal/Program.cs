using System;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        Menu menu = new Menu();
        PromptGenerator baseWrite = new PromptGenerator();

        int option = 0;

        while (option !=5)
        {
            menu.ExibirMenu();

            Console.WriteLine("");
            Console.WriteLine("What would you like to do (1-5)?");

            string question = Console.ReadLine();
            option = int.Parse(question);
            

            if (option == 1)
            {
                 Entry textEntry = new Entry();

                string textPrompt = baseWrite.GetPrompt();
                Console.WriteLine(textPrompt);
                string account = Console.ReadLine();
                textEntry._data = DateTime.Now.ToString("dd-MM-yyyy");
                textEntry._promptText = textPrompt;
                textEntry._entryText = account;
                // textEntry.Display();

                myJournal.addEntry(textEntry);
                                       
            }
            
            else if (option == 2)
            {
                Console.WriteLine("--- MEU DIÁRIO ---");
                myJournal.DisplayJounal();    
            }
        }

    }
}