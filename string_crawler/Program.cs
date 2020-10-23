using System;

namespace string_crawler
{
    class Program
    {

        static void Main(string[] args)
        {


            string paragraph = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

            string converted_paragraph = paragraph.ToLower();

            Console.WriteLine("What word do you want to search for? ");
            string userInput = Console.ReadLine();

            string converted_userInput = userInput.ToLower();
            //string modified_str = paragraph;

            if (converted_paragraph.Contains(converted_userInput))
            {
                // var set to count number of user input occurences
                int at = 0;
                int end = converted_paragraph.Length;
                int start = 0;
                int count;
                
                Console.WriteLine("Your word " + userInput + " is in the paragraph at index ");

                // while loop to print out all occurences of a user input word
                while ((start <= end) && (at > -1))
                {
                    count = end - start;
                    at = converted_paragraph.IndexOf(converted_userInput, start, count);
                    if (at >= 0) {
                    string modified_str = paragraph.Remove(at,userInput.Length);
                    Console.WriteLine(modified_str);
                    }
                    if (at == -1) break;
                    Console.WriteLine(at);
                    start = at + 1;
                    
                }
            }else
            {
                Console.WriteLine("Your word " + userInput + " was not in the paragraph.");
            }
            

        }

    }
}

