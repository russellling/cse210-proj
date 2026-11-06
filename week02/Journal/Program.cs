using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;
        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    // 1. Get random prompt
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    // 2. Automatically capture the date and time
                    string dateText = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                    // 3. Create entry and add to journal
                    Entry newEntry = new Entry
                    {
                        _date = dateText,
                        _promptText = prompt,
                        _entryText = response
                    };

                    theJournal.AddEntry(newEntry);
                    Console.WriteLine();
                    break;

                case "2":
                    theJournal.DisplayAll();
                    break;

                case "3":
                    Console.Write("What is the filename? ");
                    string loadFileName = Console.ReadLine();
                    theJournal.LoadFromFile(loadFileName);
                    break;

                case "4":
                    Console.Write("What is the filename? ");
                    string saveFileName = Console.ReadLine();
                    theJournal.SaveToFile(saveFileName);
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please try again.\n");
                    break;
            }
        }
    }
}