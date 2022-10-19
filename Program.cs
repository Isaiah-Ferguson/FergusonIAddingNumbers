//Isaiah Keith Ferguson
//10/18/2022
//adding numbers
//We will be prompting the user for 2 numbers, if entered correctly
//we will add them together and display the resolt.
//Peer reviewed by:

Console.Clear();
double num1 = 0;
double num2 = 0;
string terminate = "";
double total = 0;
bool truenum1 = true;
bool truenum2 = true;

while(terminate != "end"){
    Console.WriteLine("We will be addition on 2 numbers!");
    Console.WriteLine("");
    Console.WriteLine("Enter your 1st number.");

string numberOne = Console.ReadLine();
truenum1 = double.TryParse(numberOne, out num1);

Console.WriteLine("Enter your 2nd number.");
string numberTwo = Console.ReadLine();
truenum2 = double.TryParse(numberTwo, out num2);

if(truenum1 == true && truenum2 == true){

total = num1 + num2;

 Console.WriteLine("Your Total is  " + (num1 + num2));
}else
{
    Console.WriteLine("Those aren't numbers you knuckhead!");
}

Console.WriteLine("To terminate the program type 'End'or press 'enter' to replay.");
terminate = Console.ReadLine().ToLower();
} 
