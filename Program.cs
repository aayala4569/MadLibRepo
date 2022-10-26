//Angelica Ayala
//Mini Challenge #5 Mad Lib
//10/24/22
//-------Description-----------------
//declared a data type and variable fo my loop
//created a while loop
//In my while loo are my questions that will tell the story at the end
// at the bottom you will find my if statements if the play decides to play again



//Reviewed by: Patrick De Leon 
//Date: 10/25/22
//Review: So far everything works! But there is some missing data validation. There is a play again feature though which is great! Nice story.



bool playAgain = true;

while(playAgain == true)
{
string inStr;
Console.WriteLine("Enter an instrument");
inStr = Console.ReadLine();

int num;
Console.WriteLine("Enter a number");
num = Convert.ToInt32(Console.ReadLine());

string day;
Console.WriteLine("Enter a day");
day = Console.ReadLine();

string letTer;
Console.WriteLine("EntryPointNotFoundException a letter A-Z");
letTer = Console.ReadLine();

int numb;
Console.WriteLine("Enter a number.");
numb = Convert.ToInt32(Console.ReadLine());

int number;
Console.WriteLine("Enter a number.");
number = Convert.ToInt32(Console.ReadLine());

string adj;
Console.WriteLine("Enter an adjective.");
adj = Console.ReadLine();

string adje;
Console.WriteLine("Enter an adjective.");
adje = Console.ReadLine();

string fract;
Console.WriteLine("Enter a fraction.");
fract = Console.ReadLine();

string adJective;
Console.WriteLine("Enter an adjective.");
adJective = Console.ReadLine();

Console.WriteLine($"While I've stayed at home, I've practiced the {inStr} for {num} hours every {day}. My favorite key signature to play and practice in is {letTer}. It has {numb} flats and {number} sharps. I like this key signature because it is {adj} and {adje}. I've also gotten awesome at counting time signatures. The time signature I love is {fract}, because it {adJective} to count.");

Console.WriteLine("Would you like to play again?");


string userAns;
userAns =Console.ReadLine().ToUpper();

if(userAns == "Yes")
{
    playAgain = true;

}
else
{
    playAgain = false;
}
}
