using System.Globalization;

string input = "this is a sample string";
TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
string titleCase = textInfo.ToTitleCase(input);
Console.WriteLine(titleCase);//output :This Is A Sample String
Console.ReadKey(true);
