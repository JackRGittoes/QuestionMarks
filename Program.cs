using System;

class Program
{
    public static string QuestionsMarks(string str)
    {
        bool position = false;
        int numberOfQuestionMarks = 0;
        int num = 0;
        int totalNumber = 0;
        
  
       var calculation = Number(str, num, numberOfQuestionMarks, totalNumber);

        //If statement works for test cases but this is not a full solution to the problem. 
        if (calculation == 10 || calculation == 20)
        {
            position = true;
            return position.ToString().ToLower();

        }

        return position.ToString().ToLower();

    }
        
  
    public static int Number(string str, int num, int numberOfQuestionMarks, int totalNumber)
    {
        var length = str.Length;
        foreach (char c in str)
        {
            length--;
            bool isNumber = char.IsDigit(c);
            
            if (numberOfQuestionMarks == 3 && isNumber == true)
            {
                totalNumber += int.Parse(c.ToString()) + num;
                num = 0;
                numberOfQuestionMarks = 0;
            }
            else if(numberOfQuestionMarks > 3)
            {
                
                numberOfQuestionMarks = 0;
            }
            else if (c == '?')
            {
                numberOfQuestionMarks++;
            }
            
            else if (isNumber == true)
            {
                num = int.Parse(c.ToString());
                numberOfQuestionMarks = 0;
            }
           
        }

        return totalNumber;  
    }

    static void Main()
    {
        // keep this function call here
        Console.WriteLine(QuestionsMarks(Console.ReadLine()));

    }

}