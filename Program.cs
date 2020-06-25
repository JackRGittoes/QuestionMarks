using System;

class Program
{
    public static string QuestionsMarks(string str)
    {
        bool position = false;
        int number = 0;

        foreach (char i in str)
        {
           number++;
           position =  Position(number, i);
           if (number == 3 && position == false)
            {
                number = 0;
            }
           else if (position == true)
            {
                return position.ToString().ToLower();
            }
        }
        return position.ToString().ToLower();


    }
    public static bool Position(int number, char letter)
    {

        if (letter == '?' && number == 3)
        {    
            return true;
        }
        return false;   
    }

    static void Main()
    {
        // keep this function call here
        Console.WriteLine(QuestionsMarks(Console.ReadLine()));

    }

}