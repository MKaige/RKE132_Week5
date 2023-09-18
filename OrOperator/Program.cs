// Math >=90; OR Chemistry >=90
// math && chem || math && bio || chem && bio >90


int math, bio, chem;

Console.WriteLine("Enter your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter you Biology result:");
bio = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result:");
chem = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chem >= 90) || (math >= 90 && bio >=90) || (chem >= 90 && bio >=90) )
{
    Console.WriteLine("Congrants, you got accepted!");
}
else
{
    Console.WriteLine("Sorry, you didn't pass");
}


