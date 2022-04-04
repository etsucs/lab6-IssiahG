/**       
 *--------------------------------------------------------------------
 * 	   File name: {Homework7}
 * //	Project name: {Homework7.cs}
 *--------------------------------------------------------------------
 * Author’s name and email:	 {Issiah Goodman goodmania@etsu.edu}				
 *          Course-Section: {csci 1250 001}
 *           Creation Date:	 {4/3/2022}		
 * -------------------------------------------------------------------
 */

//CountSheep(0);

//static void CountSheep(int sheep)
//{
//    Console.WriteLine("How many sheep are there?");
//     sheep = Convert.ToInt32(Console.ReadLine());
//
//        for(int i = 1; i <= sheep; i++)
//        {
//            Console.WriteLine((sheep/sheep) + " sheep");
//        }
//}

CountSheep(0);
XO("");

static void CountSheep(int allMySheep)
{
    Console.Write("How many sheep are there: ");
   allMySheep = Convert.ToInt32(Console.ReadLine());
        for (var i = 1; i <= allMySheep; i +=1)
        {
          Console.WriteLine(i + " sheep, "); 
        }

}

static void XO(string love)
{
    Console.WriteLine("Enter any combination of X and O: ");
   
    love = Console.ReadLine();

    love = love.ToLower();
    
    string[] x = love.Split("x");
        
      string[] o = love.Split("o");

    if(x.Length == o.Length)
    {
      Console.WriteLine("True");
    }
    else if(x.Length != o.Length)
    {
            Console.WriteLine("False");
    }
}