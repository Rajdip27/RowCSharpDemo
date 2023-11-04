 using HR.Project;

 Employee emp = new Employee(456454545,2000,1000,500);
emp.Id=1001;
emp.Name="Raja";
emp.Phone="413145415";
emp.Email="aba@Gmail.com";
emp.Department="IT";
emp.Designation="Hr";

Console.Write(emp.Salary());
//Console.Write(emp.Id);
//Console.Write(emp.Name);
//Console.Write(emp.Phone);
//Console.Write(emp.Email);
//Console.Write(emp.Department);
//Console.Write(emp.Designation);

Console.ReadKey(true);