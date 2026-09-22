using System;

class Program
{

    static void Main(string[] args)
    {
        string book = "Omni";
        int chapter = 1;
        int verse = 26;
        string text = "And now, my beloved brethren, I would that ye should come unto Christ, who is the Holy One of Israel, and partake of his salvation, and the power of his redemption. Yea, come unto him, and offer your whole souls as an offering unto him, and continue in fasting and praying, and endure to the end; and as the Lord liveth ye will be saved.";
        string option = "";



        Reference reference = new Reference(book, chapter, verse);
        Scripture scripture = new Scripture(reference, text);

        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompleteHidden() == true)
            {
                break;
            }

            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");

            option = Console.ReadLine();
            if (option.ToLower() == "quit")
            {
                break;
            }
            else if (option == "")
            {
                scripture.HideRandomWords(3);

            }
        } while (option != "quit");
    }
}