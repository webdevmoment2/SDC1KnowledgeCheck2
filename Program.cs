

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Object2>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var object2 = new Object2();

    Console.WriteLine("Enter the value for Object Name");
    object2.Name = Console.ReadLine();

    Console.WriteLine("Enter the value for Object Description");
    object2.Description = Console.ReadLine();

    recordList.Add(object2);
}

// Print out the list of records using Console.WriteLine()
Console.WriteLine(recordList.ToString());