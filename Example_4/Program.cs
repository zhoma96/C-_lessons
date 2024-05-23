Console.Write("Please, Enter Your name: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha") // ToLower - Brings all to lower case.
{
    Console.WriteLine("Woow, this Masha. Welcome");
}
else
{
    Console.Write("Hi, " + username);
}