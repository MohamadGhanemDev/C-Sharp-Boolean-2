

string correctUsername = "user123";
string correctPassword = "password";

Console.Write("Enter the username: ");
string enteredUsrname = Console.ReadLine();

Console.Write("Enter the password: ");
string enteredPassword = Console.ReadLine();

bool isCorrectUsername = correctUsername == enteredUsrname;
bool isCorrectPassword = correctPassword == enteredPassword;


if (isCorrectUsername && isCorrectPassword)
{
    Console.WriteLine("Correct Cridentials, Successlly Logged in.");
}
else if (!isCorrectUsername)
{
        Console.WriteLine("InCorrect Username, Login Failed...!");
}
else if (!isCorrectPassword)
{
    Console.WriteLine("InCorrect Password, Login Failed...!");
}
else
{
    Console.WriteLine("InCorrect Cridentials, Login Failed...!");
}


/*

if (enteredUsrname == correctUsername && enteredPassword == correctPassword)
{
    Console.WriteLine("Correct Cridentials, Successlly Logged in.");
}else {

    Console.WriteLine("InCorrect Cridentials, Login Failed...!");
}

*/




