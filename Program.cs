/* string[] fraudlentOrderIDs = new string[3];


fraudlentOrderIDs[0] = "A123";
fraudlentOrderIDs[1] = "B456";
f eraudlentOrderIDs[2] = "C789";

 */
string[] fraudlentOrderIDs = { "A123", "B456", "C780" };
Console.WriteLine($"First: {fraudlentOrderIDs[0]}");
Console.WriteLine($"First: {fraudlentOrderIDs[1]}");
Console.WriteLine($"First: {fraudlentOrderIDs[2]}");

fraudlentOrderIDs[0] = "A123";

Console.WriteLine($"Reaassing first : {fraudlentOrderIDs[0]}");

Console.WriteLine($"There are {fraudlentOrderIDs.Length}  fraudulent  orders  to process ");
