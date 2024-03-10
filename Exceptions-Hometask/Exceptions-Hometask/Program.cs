


//2) Ededin faktorilalini tapan method yazmaq. Eger menfi eded daxil edilibse custom exception cixarsin.


using Exceptions_Hometask.Controllers;
using Exceptions_Hometask.Exceptions;
using Exceptions_Hometask.Models;
using Exceptions_Hometask.Services;

string Factorial(int num)
{
    try
    {
        int factorial = 1;

        for (int i = 1; i <= num; i++)
        {          
                factorial *= i;
        }
        if (num < 0 )
        {
            throw new CustomMinusFactorialExceptions("Number cannot be minus");

        }

        return factorial.ToString();

    }
    catch (Exception ex)
    {
         
       
        return ex.Message;

    }
}


//var res1 = Factorial(5);
//Console.WriteLine(res1);

//var res2 = Factorial(-4);
//Console.WriteLine(res2);





//3) Login ucun custom exception yazib isdifade etmek. Eger email ve yaxud password
//    sehvdirse custom exception istifade edin.
//    Models, Services, Controller folderleriniz olacaq. Service mentiqi ile yazirsiz. 


//// ?????????????????????????????????-------------------

//AccountController accountController = new AccountController();
//Console.WriteLine(accountController.Login());










//4) Bir custom exception classi yaradin. 
//    Login olan zaman passwordun simvollarinin sayi 6-dan kicikdirse exception cixarsin. 


string CheckPasswordLength(string password)
{
    try
    {
       
        if (password.Length < 6 )
        {
            throw new CustomExceptionPasswordLength("Password 6 simvoldan qisadir");
        }
        return password;
    }
    catch (Exception ex)
    {

        return ex.Message;
    }
}


//var pass = CheckPasswordLength("12345");
//Console.WriteLine(pass);




