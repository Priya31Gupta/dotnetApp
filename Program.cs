string name = "priya";
float salary = 505.5F;   //need to add F after floating number
Console.WriteLine("name:"+name);
Console.WriteLine($"{name} is name, {salary} is salary");
int age = int.Parse(Console.ReadLine()); // need to parse to integer as input received from console is string
Console.Write("age:"+age);