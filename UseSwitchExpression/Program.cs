int number = Convert.ToInt32( Console.ReadLine());

// switch (number) 
// {
//    case 1: 
//        Console.WriteLine("One");
//        break;
//        case 2: Console.WriteLine("Two");
//        break;
//    case 3:
//        Console.WriteLine("Three");
//        break;
//    case 4:
//        Console.WriteLine("Foure");
//        break;
//    case 5:
//        Console.WriteLine("Five");
//        break;
//    default: Console.WriteLine("Default Case");
//        break;
//}




var data = number switch { 1 => "One",2=>"two",3=>"Three",_=>"Default Case" };
Console.WriteLine(data);
