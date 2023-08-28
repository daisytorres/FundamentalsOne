// See https://aka.ms/new-console-template for more information


//--------------------------------------------------------------------------------------------------------------------------------
//Create a loop that prints all values from 1-255.

for(int i=1; i<=225; i++)
{
    Console.WriteLine(i);
}

can also be:
for(int i=1; i<226; i++)
{
    Console.WriteLine(i);
}



//--------------------------------------------------------------------------------------------------------------------------------
//Create a new loop that generates 5 random numbers between 10 and 20.

Random rand = new Random(); //create an instance of rand
for(int i=0; i<=5; i++)
{
    Console.WriteLine(rand.Next(10,21); //second value is always going to be exclusive so go up one in second parameter
}



//--------------------------------------------------------------------------------------------------------------------------------
//Modify the previous loop to add the random values together and print the sum after the loop finishes.

Random rand = new Random();
int sum = 0; //need to keep track of what is happening while loop is running

for(int i=0; i<=5; i++)
{
    sum+=(rand.Next(10,21)); 
}
Console.WriteLine(sum);



//--------------------------------------------------------------------------------------------------------------------------------
// Create a new loop that prints all values from 1 to 100 that are divisible by 3 OR 5, but NOT both.

for(int i=1; i<=100; i++)
{
    if(i % 3 == 0 && i % 5 == 0)
    {
        continue; //skip over this for now, 
    }
        if(i % 3 == 0 || i % 5 == 0) //now that we know which ones are divisble by both, can see which ones fall under the values we don't want to skip
    {
        Console.WriteLine(i);
    }
}
//if we switched the order, we would not get what we want. Should be what should be excluded and then what should be included



//--------------------------------------------------------------------------------------------------------------------------------
//Modify the previous loop to print "Fizz" for multiples of 3 and "Buzz" for multiples of 5.

for(int i=1; i<=100; i++)
{
    if(i % 3 == 0 && i % 5 == 0)
    {
        continue; //still only want the ones that are divisible by 3 and 5, so keep this first half
    }
    if(i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz"); //should be just ("Fizz"), but adding the value to make sure it is counting correctly
    }
        if(i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
}



//--------------------------------------------------------------------------------------------------------------------------------
// Modify the previous loop once more to now also print "FizzBuzz" for numbers that are multiples of both 3 and 5.

//removing the continue would print values that hit all 3, 3 times because it is not skipping the if statements
//ex:
//90 - FizzBuzz
//90 - Fizz
//90 - Buzz
for(int i=1; i<=100; i++)
{
    if(i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }
    if(i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz"); 
    }
        if(i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
}

//to fix this, change to else if:
for(int i=1; i<=100; i++)
{
    if(i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }
    else if(i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz"); 
    }
    else if(i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
}

