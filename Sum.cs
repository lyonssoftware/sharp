// C# summation of while loop integers
Using System;
class Sum
{
  static void Main(string[] args)
  {
    // ints to hold the number and sum
    int num, sum = 0, r;
    Console.WriteLine("Enter a Number : ");
    // read the int
    num = int.Parse(Console.ReadLine());
    // while loop
    while (num != 0)
    {
      // set r to the remainder
      r = num % 10;
      // set the new num
      num = num / 10;
      // calculate the new sum
      sum = sum + r;
    }
    // print the sum 
      Console.WriteLine("Sum of Digits of the Number : "+sum);
      Console.ReadLine();
  }
  // end of the program
}
