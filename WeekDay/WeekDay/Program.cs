using System;
class Program {
  static void Main (string[] args){
    
    //Declare variables
    int day;
    
    //Set variables
    day = DayCheck("Please enter the day as a number between 1 and 7.");
    
    //Convert
    switch (day)
    {
        case 1:
            Console.WriteLine("The day is Monday.");
            break;
        case 2:
            Console.WriteLine("The day is Tuesday.");
            break;
        case 3:
            Console.WriteLine("The day is Wednesday.");
            break;
        case 4:
            Console.WriteLine("The day is Thursday.");
            break;
        case 5:
            Console.WriteLine("The day is Friday.");
            break;
        case 6:
            Console.WriteLine("The day is Saturday.");
            break;
        case 7:
            Console.WriteLine("The day is Sunday.");
            break;
        default:
            break;
    }
  }
    static int DayCheck(string prompt){

        //Declare Variables
        string DayIn;
        int DayOut;

        do {
            Console.WriteLine(prompt);
            DayIn = Console.ReadLine()?.Trim() ?? String.Empty;
            if (int.TryParse(DayIn, out DayOut) && DayOut >= 1 && DayOut <= 7){
                break;
            } else {
                Console.WriteLine("Please enter a valid number between 1 and 7.");
            }
        } while (true);
        return DayOut;
    }
}