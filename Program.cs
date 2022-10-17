//Isaiah Keith Ferguson
//10/17/2022
//adding numbers

Console.Clear();
int num1 = 0;
int num2 = 0;
string terminate = "";
int total = 0;
bool truenum1 = true;
bool truenum2 = true;

while(terminate != "end"){
    Console.WriteLine("Please enter numbers");
    Console.WriteLine("Enter your 1st number.");

string numberOne = Console.ReadLine();
truenum1 = Int32.TryParse(numberOne, out num1);

Console.WriteLine("Enter your 2nd number.");
string numberTwo = Console.ReadLine();
truenum2 = Int32.TryParse(numberTwo, out num2);

if(truenum1 == true && truenum2 == true){

total = num1 + num2;

 Console.WriteLine("the sum of these whole numbers is " + (num1 + num2));
}else
{
    Console.WriteLine("Those aren't numbers.");
}

 Console.WriteLine("To terminate the program type 'End'");
terminate = Console.ReadLine().ToLower();
} 
