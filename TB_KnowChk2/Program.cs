
Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Cat>();
for (int i = 0; i < numberOfRecords; i++)
{
    var myClass = new Cat();

    Console.WriteLine("Enter the name of the cat:");
    myClass.Name = Console.ReadLine();

    Console.WriteLine("Enter the age of the cat:");
    myClass.Color = Console.ReadLine();



    recordList.Add(myClass);
}
foreach (var record in recordList)
{
    Console.WriteLine($"Name: {record.Name}, Age: {record.Color}");
}
