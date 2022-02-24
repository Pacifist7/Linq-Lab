//LAB 31 - LINQ part 1/2
//Task: Use Linq to search the following collections.

//Build Specifications:
//
//Assume we have the following collections: 
int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

List<Student> students = new List<Student>();
students.Add(new Student("Jimmy", 13));
students.Add(new Student("Hannah", 21));
students.Add(new Student("Justin", 30));
students.Add(new Student("Sarah", 53));
students.Add(new Student("Hannibal", 15));
students.Add(new Student("Phillip", 16));
students.Add(new Student("Maria", 63));
students.Add(new Student("Abe", 33));
students.Add(new Student("Curtis", 10));

//Make a Student class with the following properties: 
//	Name
//    Age 

//Answer the following questions: 

// For nums: 
//1) Find the Minimum value 
var minimumValue = nums.Min();
Console.WriteLine(minimumValue);

//2) Find the Maximum value
var maximumValue = nums.Max();
Console.WriteLine(maximumValue);

//3) Find the Maximum value less than 10000
var maxLess = nums.Where(x => x < 10000).Max();
Console.WriteLine(maxLess);

//4) Find all the values between 10 and 100
var valuesBetween = nums.Where(x => x > 10 && x < 100);
Console.WriteLine(String.Join(",", valuesBetween));

//5) Find all the Values between 100000 and 999999 inclusive 
var valuesBetween2 = nums.Where(x => x > 100000 && x <= 999999);
Console.WriteLine(String.Join(",", valuesBetween2));


//6) Count all the even numbers 
var evenNumbers = nums.Where(x => x % 2 == 0);
Console.WriteLine(String.Join(" , ", evenNumbers));






