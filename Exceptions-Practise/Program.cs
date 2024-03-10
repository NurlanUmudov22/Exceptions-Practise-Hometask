
using Exceptions_Practise.Helpers.Exceptions;

void Calculate()
{
    bool isCorrectCalculate = true;

	try
	{
		int a = 5;
		int b = 0;
		var result = a / b;
		Console.WriteLine(result);

		//int[] arr = { 1, 2, 3, 4 };

		//arr[5] =1 00;


	}
	catch (Exception ex )
	{
      isCorrectCalculate = false;
	}
	finally 
	{
      SendMessage(isCorrectCalculate);
	}
}


//Calculate();





void SendMessage(bool isCorrectCalculate)
{
	if (isCorrectCalculate)
	{
        Console.WriteLine("Your message successfully");
    }
	else
	{
        Console.WriteLine("Your message failed");
    }
}




string GetById(int? id)
{
	try
	{
		if (id == null)
		{
			//throw new ArgumentNullException(nameof(id));
			throw new CustomArgumentNullException("Argument cannot be null");
		}


		//ArgumentNullException.ThrowIfNull(nameof(id));

		return "Kamran bey";
	}
	catch (Exception ex)
	{
		return ex.Message;
	}
}

var result = GetById(null);
Console.WriteLine(result);














