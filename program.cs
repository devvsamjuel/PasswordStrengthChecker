using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
			int minLength=10;
      /*bool uppercase, lowercase, 
      digits, specialChars;*/
      Console.WriteLine("Enter Password:");
      string userInput=Console.ReadLine();
      int score=0;
      
      if (userInput.Length>=minLength)
      {
        score++;
      }
      if(Tools.Contains(userInput,"ABCDEFGHIJKLMNOPQRSTUVWXYZ"))
      {
        score++;
      }
      if(Tools.Contains(userInput,"abcdefghijklmnopqrstuvwxyz"))
      {
        score++;
      }
       if(Tools.Contains(userInput,"0123456789"))
       {
        score++;
      }
      if(Tools.Contains(userInput,"<>,.?/:;'')({[]}|\\!@#$%^&*~`+-=_")){
        score++;
      }
     if ((userInput=="password")||(userInput=="1234"))
      {
        score=0;
      }
      Console.WriteLine($"score:{score}");
      
      switch(score){
        case 0: Console.WriteLine("Your Password too predictable!");
        				break;
        case 1: Console.WriteLine("Your Password is weak!");
          			break;
        case 2: Console.WriteLine("Your Password is fairly strong");
          			break;
        case 3: Console.WriteLine("Your Password is strong");
          			break;
        case 4: case 5: Console.WriteLine("Your Password is very strong");
          break;
        default: Console.WriteLine("Please enter Password");
          break;   			
      }
      
      
    }
  }
}
