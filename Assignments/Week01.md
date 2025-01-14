# Week 01

## Universal Acceptance Criteria

1. You must understand every single line of your solution.
1. Your code must compile and run without errors.
1. You must turn in your repository URL in Brightspace.

## Assignment Acceptance Criteria

1. Prompt the user for their first name using `Console.ReadLine()`. 
1. Prompt the user for their last name using `Console.ReadLine()`. 
1. Concatenate their first & last: `Tim Valley` using string interpolation.
1. Prompt the user for their birth year using `Console.ReadLine()`.
1. Calculate the user's age from their birth year: '25'.
1. Update `SayHello()` to accept 2 parameters: `(string name, int age)`.
1. Write to the console a message like "Hello, Tim! Your age is 25": `Console.WriteLine()`.
1. Colorize the output with a blue background & yellow foreground: `ConsoleColor`.
1. After output, restart the question sequence in an easy-to-use loop. 

## Bonus Acceptance Criteria

1. Clear the console before final output. 
1. Place "menu" logic in the `Console.Library` project. 
1. Add error handling if the user enters blank for their name.
1. Add error handling if the user enters a non-number for their birth year.

## Getting Started

### Clone Your Repository  
1. **Clone with Git**  
   Replace `<repository-url>` with your GitHub repository URL:  
   ```bash
   git clone <repository-url>
   cd <repository-folder>
   ```  

2. **Check Status**  
   Ensure your repository is clean:  
   ```bash
   git status
   ```  

### Create Your Project  
1. **Create Solution & Project**  
   ```bash
   dotnet new sln -n Client  
   dotnet new console -n Client -o Client  
   dotnet sln Client.sln add Client/Client.csproj  
   ```  

2. **Add Configuration Files**  
   ```bash
   dotnet new gitignore  
   dotnet new editorconfig  
   ```  

### Test Your Project  
1. **Restore, Build & Run**  
   ```bash
   dotnet restore  
   dotnet build  
   dotnet run --project Client  
   ```  

### Debug in VSCode  
1. Open VSCode: `code .`  
2. Configure `ctrl+,`: "csharp.debug.console" → `externalTerminal`.  
3. Generate C# assets: `.NET: Generate Assets for Build and Debug`.  
4. Start debugging with `F5`.  

### Add Client.Library Class Library  
1. **Create & Add Class Library**  
   ```bash
   dotnet new classlib -n Client.Library -o Client.Library  
   dotnet sln Client.sln add Client.Library/Client.Library.csproj  
   dotnet add Client/Client.csproj reference Client.Library/Client.Library.csproj  
   ```  

2. **Restore & Build**  
   ```bash
   dotnet restore  
   dotnet build  
   ```  

### Rename and Edit Class1.cs  
1. Rename `Client.Library/Class1.cs` to `Greeting.cs`.  
2. Open `Greeting.cs` and replace the content with:  
   ```csharp
   namespace Client.Library;

   public class Greeting
   {
       public static string SayHello(string name)
       {
           return $"Hello, {name}!";
       }
   }
   ```  

### Update Program.cs to Use Library  
1. Open `Client/Program.cs`.  
2. Replace the content with:  
   ```csharp
   using Client.Library;

   Console.WriteLine(Greeting.SayHello("World"));
   Console.ReadKey();
   ```  

3. **Run Updated Code**  
   ```bash
   dotnet run --project Client  
   ```  

### Commit Your Changes  
1. Stage changes: `git add .`  
2. Commit: `git commit -m "Add Client.Library, rename Class1 to Greeting, and integrate with Client"`  
3. Push: `git push`.  

