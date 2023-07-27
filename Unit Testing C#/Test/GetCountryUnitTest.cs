namespace Unit_Testing_C_.Test;

public class GetCountryUnitTest
{
	public static void GetCountryUnitTestReturn()
	{
		try
		{
			//Arrange
			int num = 0;
			Country country = new Country();
			//Act
			string result = country.GetCountry(num);

			//Assert
			if (result == "Bangladesh")
			{
				Console.Write("unit Test Pass");
			}
			else
			{
				Console.Write("unit test Failed");
			}

		}
		catch (Exception ex)
		{
			Console.WriteLine(ex);
		}

	}
}
