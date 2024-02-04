// MIS 3013 001
// Feb 5, 2024
// Helen Sniezek
// 113552793

// if else statements
//if (condition) // ; no ; here
//{
//    // branch 1
//}
//else
//{
//    // branch 2;
//}// ; not neccessary
// This is the next line of if else statement

double grade;
grade = 80.6;

Console.Write("Please input a grade: ");

string gradeStr;
gradeStr=Console.ReadLine();

grade=Convert.ToDouble(gradeStr);

if (grade>=90) 
{
    // A
    Console.WriteLine("It is A!");
}
else // else means grade is < 90
{
    // not A
    Console.WriteLine("It is NOT A!");
}