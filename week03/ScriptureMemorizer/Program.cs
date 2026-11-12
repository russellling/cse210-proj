// EXCEEDING REQUIREMENTS:
// 1. Program works with a library of scriptures instead of just one.
// 2. Chooses a scripture at random to present to the user.
// 3. HideRandomWords() only selects from words that are not already hidden (stretch challenge).

class Program
{
    static void Main(string[] args)
    {
        // Library
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new References("John", 3, 16), "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life"),
            new Scripture(new References("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding in all thy ways acknowledge him and he shall direct thy paths"),
            new Scripture(new References("1 Nephi", 3, 7), "And it came to pass that I Nephi said unto my father I will go and do the things which the Lord hath commanded for I know that the Lord giveth no commandments unto the children of men save he shall prepare a way for them that they may accomplish the thing which he commandeth them"),
            new Scripture(new References("Doctrine and Covenants", 6, 36), "Look unto me in every thought doubt not fear not")
        };

        // Pick one at random
        Random rand = new Random();
        Scripture scripture = scriptures[rand.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompleteHidden())
            {
                Console.WriteLine("\nAll words are hidden. Great job memorizing!");
                break;
            }

            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}