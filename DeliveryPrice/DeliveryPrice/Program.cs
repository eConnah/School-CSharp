using System;
class Program {
  static void Main (string[] args){
    
    int Price;
    string UserInput = string.Empty;
    bool DayDelivery;

    Price = GetPrice("Enter the price of your order: ");
    UserInput = GetDayDelivery("Would you like next day delivery for £5? Yes or No: ");

    if (UserInput == "Yes"){
      DayDelivery = true;
    } else {
      DayDelivery = false;
    }
    if (Price >= 15 ){
      if (DayDelivery == true){
        Console.WriteLine($"Your order is £{Price} and you chose £5 next day delivery, resulting in a total of £" + (Price + 5));
      }  else {
        Console.WriteLine($"Your order is £{Price} and you didn't buy next day delivery, resulting in a total of £{Price}");
      }
    } else {
      if (DayDelivery == true){
        Console.WriteLine($"Your order is £{Price} and you chose £5 next day delivery, resulting in a total of £" + (Price + 5));
      }  else {
        Console.WriteLine($"Your order is £{Price} and you didn't buy next day delivery, resulting in a total of £" + (Price + 3.5));
      }
    }
  }
  static string GetDayDelivery(string prompt){
    
    string BoolInput = string.Empty;

    do {
      Console.WriteLine(prompt);
      BoolInput = Console.ReadLine()?.Trim() ?? String.Empty;
      if (BoolInput != "Yes" && BoolInput != "No"){
        Console.WriteLine("The only accepted values are Yes and No.");
      }
    } while (BoolInput != "Yes" && BoolInput != "No");
    return BoolInput;
  }
  static int GetPrice(string prompt){

    string PriceIn;
    int PriceOut;

    do {
        Console.WriteLine(prompt);
        PriceIn = Console.ReadLine()?.Trim() ?? String.Empty;
        if (int.TryParse(PriceIn, out PriceOut)){
            break;
        } else {
            Console.WriteLine("Please enter a valid number.");
        }
    } while (true);
    return PriceOut;
}
}