using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to The Journal Program!");

        int choice = 0;
        PromtGanarator promtGanarator = new PromtGanarator();
        JournalNoteHendler hendler = new JournalNoteHendler();
        JournalNote journal = new JournalNote("My Journal");

        do 
        {
            Console.Write(@"
Please select one of the following choices:
1. Write
2. Display
3. Load
4. Save
5. Find an Entry
6. Quit
What would you like to do? ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1) {
                string promt = promtGanarator.generatePromt();
                Console.WriteLine(promt);
                string answer = Console.ReadLine();

                journal.AddEntry(answer, promt);
            }
            else if (choice == 2) 
            {
                journal.DisplayEntries();
            }
            else if (choice == 3)
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();

                journal = hendler.ReadJournalFromFile(filename);
            }
            else if (choice == 4)
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();

                hendler.SaveInFile(filename, journal);
            }
            else if (choice == 5)
            {
                Console.WriteLine("What is the entry date? (ex. yyyy/MM/dd)");
                string date = Console.ReadLine();

                List<NoteEntry> notes = journal.FindEntryByDate(date);
                notes.ForEach(it => Console.WriteLine($"it.Display()\n"));
            }

        } while(choice != 6);
    }
}

