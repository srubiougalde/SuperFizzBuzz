# SuperFizzBuzz
Fizzbuzz program with some variations

## Get source code and setup environment
1. Install `git`. Instruction can be found here: `https://git-scm.com/`.
2. Install `.net core`. Download recommended version from `https://dotnet.microsoft.com/download` and install it.
  * It is optional to install `Visual Code`. You can download it from `https://dotnet.microsoft.com/download`.
3. Checkout project from git repository: `> git clone https://github.com/srubiougalde/SuperFizzBuzz.git`.

_______________________

## FizzBuzz
### The Basics
Classic fizzbuzz output is typically described as “Write a program that prints the numbers from 1 to 100. But for multiples of 3, print “Fizz” instead of the number. For multiples of 5, print “Buzz”. For Multiples of 3 and 5, print “FizzBuzz”. Typical fizzbuzz output looks like:
1
2
Fizz
4
Buzz
…
88
89
FizzBuzz
91
….
…and so on. But that’s way too simple!
### Requirements
1.	Develop a class library called SuperFizzBuzz that can do the following:
  * Can produce fizzbuzz output for a user-supplied range of numbers – e.g., from 2 to 35, or from 1 to 1,000,000,000, or from -1 to -35, etc.
  * Can produce output for a user supplied set of integers, even if they’re not sequential.
  * Can generate tokens other than “Fizz” and “Buzz” and can evaluate division by numbers other than 3 and 5. Maybe a user wants to test division by 4, 13, and 9, and output “Frog”, “Duck,” and “Chicken” for them (e.g., in this case, 52 would ouput “FrogDuck”, 36 would output “FrogChicken”, 468 would output “FrogDuckChicken”, etc.)
2.	Using your SuperFizzBuzz class, to solve the classic FizzBuzz problem as described above in “The Basics”.
3.	Demonstrate advanced usage of SuperFizzBuzz that performs the following:
  * Print the numbers from -12 through 145.
  * For multiples of 3, print “Fizz”
  * For Multiples of 7, print “Buzz”
  * For Multiples of 38, print “Bazz”
  * Print the appropriate combination of tokens for any number that matches more than one of those rules
4.	In your solution, include tests for your SuperFizzBuzz class and any other related classes you develop.
### Implementation details
- Use of Visual Code and .Net Core to create the projects. This could also be done with Visual Studio but was not my choise, the projects also can be added to a Visual Studio Solution (.sln)
- The console application has a default entry, a further improve of it will be to handle consoline line or file inputs.
- The main algorithm traverse the sequence of elements by using the factor we are looking for the tokens. For the classic fizzbuzz iterates sequence in multiples of 3 and 5 so in that way is not needed to iterate the entire array. A possible improve could be traversing the array at same time from the start number and the end number on the sequence so will reduce half of the operations.
- Requeriments mention SuperFizzBuzz can produce output even if the input is not in sequence, so the ClassicFizzBuzz has the regular implementation that validate the input is a valid sequence but for SuperFizzBuzz the implementation will order the input numbers.
- To handle different tokens, BaseFizzBuzz consructor can be overrided so KeyPairValue property can be defined for the child classes.
- Print method of current implementation has to traverse all the numbers in the sequence in order to print the number, this is the method with worse performance in this program.
- Instead of creating two Console app as in the requeriments both are handled in one Console App. I created a factory class to be able to determine what implementation we want to be instantiated.
## Serve the application
1. Open a command line. This could be done in Visual Code Terminal or any other terminal.
2. Move to the project directory.
    * `> cd SuperFizzBuzz`
3. Run `> dotnet run --project .\src\ConsoleApp\ConsoleApp.csproj` to run the console app project. You will see the output of the evaluation of 1 to 100 using ClassicFizzBuzz and second output evaluated using SuperFizzBuzz for the case mentioned in the requirement 3.
## Run unit test
1. Open a command line. This could be done in Visual Code Terminal or any other terminal.
2. Move to the project directory.
    * `> cd SuperFizzBuzz`
3. Run `> dotnet test .\test\SuperFizzBuzzTest\SuperFizzBuzzTest.csproj` to execute the test cases. You will see the result of the test and all should pass. 
