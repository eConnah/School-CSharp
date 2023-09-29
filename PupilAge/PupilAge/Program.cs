using System;
class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Please input the pupil's age: ");
    int PupilAge;
    PupilAge = Convert.ToInt32(Console.ReadLine());
    if (PupilAge > 10 & PupilAge < 19){
      Console.WriteLine("Pupil age is valid.");
    } else {
      Console.WriteLine("Age is invalid.");
    }
  }
}