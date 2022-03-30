/**       
 *--------------------------------------------------------------------
 * 	   File name: {Homework6}
 * //	Project name: {Homework6.cs}
 *--------------------------------------------------------------------
 * Author’s name and email:	 {Issiah Goodman goodmania@etsu.edu}				
 *          Course-Section: {csci 1250 001}
 *           Creation Date:	 {3/23/2022}		
 * -------------------------------------------------------------------
 */


ShowCharacter("" , 0);
 Console.WriteLine("Your total value is " + CalculateRetail());
for(int i = 80; i <= 100; i++)
{
    Console.WriteLine(Celsius(i));
}
IsPrime(0);

static void ShowCharacter(string word , int pos)
{
    Console.WriteLine("Enter a word");
    word = Console.ReadLine();

    Console.WriteLine("Enter the character position you wish to see");
    pos = Convert.ToInt32(Console.ReadLine());
 

    Console.WriteLine("The letter you are trying to see is " + word[pos-1]);
}


static double CalculateRetail()
{
Console.WriteLine("Enter a wholesale cost.");
    double cost = Convert.ToDouble (Console.ReadLine());

 Console.WriteLine("Enter the mark up");
    double markup = Convert.ToDouble (Console.ReadLine());

    return(cost + ((markup / 100) * cost));
}


static double Celsius(int fahrenheit)
{
   return ((5.0/9.0) * (fahrenheit - 32.0));  
}


static void IsPrime(int n)
{
    Console.WriteLine("Enter a number");
    n = Convert.ToInt32(Console.ReadLine());
    int x = 0;
    for(int i = 1; i <= n; i++)
    {
        if (n % i == 0)
        {
        x++;
        }
    }
    if (x==2)
    {
        Console.WriteLine($"{n} is a prime number.");
    }
    else if (x != 2)
    {
        Console.WriteLine($"{n} is not a prime number.");
    }

}

//static void IsPrime()
//{
//    if()
  //  {

    //}
   // else if()
    //{

    //}
    //else
    //{

    //}
//}



 //Console.WriteLine(CalculateRetail());



//static double CalculateRetail()
//{
//Console.WriteLine("Enter a wholesale cost.");
 //   double cost = Convert.ToDouble (Console.ReadLine());
//
// Console.WriteLine("Enter the mark up");
 //   double markup = Convert.ToDouble (Console.ReadLine());
//
//return(cost + ((markup / 100) * cost));
//}


  //if(thing > word.Length)
   // {
  //      Console.WriteLine("You are wrong go home.");
  //  }
  //  else if(thing<=0)
 //   {
 //       Console.WriteLine("you fricken loser");
 //   }
//    else
//    {
//        Console.WriteLine(word[thing-1]);
 //   }