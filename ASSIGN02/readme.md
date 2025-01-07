# Assignment

In this assignment, you will be creating a simple calculator as a cross-platform console application. C# is a .NET (dotnet) language, and the command line can be used to create a starter project, the parent solution, even `.gitignore` and `.editorconfig` files.

The organizational hierarchy of any C# app starts with the solution file (with an `.sln` file extension) which references, or logically contains, one or more project files (with the `.csproj` file extension) which references, or logically contains, one or more documents—code files (with the `.cs` file extension) which contain your C# code.

## Create your project

Once you have successfully cloned your assignment repository from GitHub to a local folder, use the following commands to create your new console app named `Client` in a subfolder named `Client`. Once you have your first project, you can create your `Calculator` solution and add your `Client` project to it.

```text
# Create a new solution and project in one step
dotnet new sln -n Calculator
dotnet new console -n Calculator -o Calculator

# Add the project to the solution
dotnet sln Calculator.sln add Calculator/Calculator.csproj

# Add a .gitignore file (built-in template)
dotnet new gitignore

# Add an .editorconfig file (built-in template)
dotnet new editorconfig
```

Let's define some of these important terms. Organizing code files can be as important as organizing code syntax. Understanding your options and how to use them will help you succeed.

### Terms

| Term | Description  
|-|-  
| **Solution** | A `.sln` file organizes projects.  
| **Project** | A `.csproj` file organizes documents, dependencies, & settings.  
| **Document** | A `.cs` file containing C# code, for example `Program.cs`.  
| **.gitignore** | This specifies which files/folders Git should ignore.  
| **.editorconfig** | This defines coding styles and formatting rules for the solution.  

## Test your project

By default, a new console app simply writes "Hello, World!" to the screen. We can use the dotnet command line to restore, build, and run your project. If successful, you should see `Hello, World!`, and we can start customizing the code in `Program.cs`. Use these commands to restore, build, and run your app:

```text
# Restore dependencies for the project
dotnet restore

# Build the project into an executable
dotnet build

# Run the project to execute the code
dotnet run --project Calculator
```

### Terms

| Term | Description  
|-|-  
| **Restore** | Downloads and prepares dependencies for the project.  
| **Build** | Compiles the project into an executable format.  
| **Run** | Executes the compiled project.  

## Commit your changes

Git is our source control management tool. It works at the command line, but also in the IDE (VS Code). For now, use the command line to commit your changes—the new project you created—and push them back up to your GitHub repository.

```text
# Stage all changes
git add .

# Commit the changes with a message
git commit -m "Add Calculator project"

# Push the changes to the remote repository
git push
```

### Terms

| Term | Description  
|-|-  
| **Git** | A version control system to track changes to code.  
| **GitHub** | A website providing free `Git` services.  
| **Repository** | A collection of files and history tracked by Git.  
| **Commit** | A saved snapshot of changes in the repository.  
| **Push** | Sends committed changes to a remote repository.  

## Customize your workspace

In VSCode, your workspace includes the root folder and all its subfolders. You can set up VSCode to treat every workspace the same or configure each workspace independently. Let’s make a workspace change and ensure your console app launches in an external terminal.

### Steps

By completing these steps, VSCode will be configured to always use the external terminal when you debug your console app.

1. Open VSCode with the command `code .`  
1. Use the keyboard shortcut `Ctrl+,`.  
1. Switch the tab from `User` to `Workspace`.  
1. Navigate to settings by pressing `Ctrl+,`.  
1. Use the search bar to find "Csharp debug console".  
1. Select `externalTerminal`.  

### Terms

| Term | Description  
|-|-  
| **Workspace** | The root folder and subfolders in your current project.  
| **Terminal** | A command-line interface to run commands.  **(external)** A terminal window opened outside of VSCode. **(integrated)** The built-in terminal embedded in VSCode.  

## Debug your project

Inside VSCode, C# projects and solutions are managed using the **C# Dev Kit**, a free extension available in the VSCode marketplace. Once installed, it recognizes any `.csproj` or `.sln` file in your workspace and launches the **Solution Explorer**, allowing you to navigate the hierarchy of your solution. It also enables debugging, testing, and C# syntax highlighting.

### Steps

By completing these steps, your app will be configured for debugging.

1. Open the command palette with `Ctrl+Shift+P` and select **"Open Solution"**. VSCode will search for and open the `.sln` file in your workspace.  
1. Press `Ctrl+Shift+E` to ensure the Explorer tab is open. Expand the **Solution Explorer** section to view your solution’s structure.  
1. Open `Program.cs` and set a breakpoint by clicking in the left margin next to the line of code or pressing `F9` to toggle a breakpoint. Set it at the first line inside the `Main` method for easy debugging.  
1. If the **Calculator** project appears in the Solution Explorer, open the command palette and select **".NET: Generate Assets for Build and Debug"**. This will create `tasks.json` and `launch.json` files in the `/.vscode` folder.  
1. Press `F5` to start debugging. VSCode will automatically build and run your app, attaching itself as the debugger.  
1. An external terminal should launch, and the debugger will pause at your breakpoint, allowing you to inspect variables and step through the code.  
1. Press `Shift+F5` to stop debugging. This will terminate the debugging session and close the external terminal. Alternatively, click the **Stop** button (a red square) in the Debug toolbar at the top of the window.  

### Terms

| Term              | Description  
|-|-  
| **Command Palette** | A VSCode tool accessed with `Ctrl+Shift+P` to run commands or search for features.  
| **Debug**          | The process of running your code while pausing at breakpoints to inspect behavior and fix issues.  

## Commit your changes

Since you are in VSCode, let’s use the IDE to commit and push your changes. The built-in Git integration in VSCode simplifies the process and reduces errors.

### Steps

By completing these steps, your updates will be saved locally and synchronized with the remote repository on GitHub.

1. Open the **Source Control** tab in VSCode by clicking the Git icon in the Activity Bar on the left (or press `Ctrl+Shift+G`).  
1. Stage your changes by clicking the **+** icon next to the files listed under **Changes** or by clicking **Stage All Changes**.  
1. Enter a meaningful commit message in the text box at the top, such as "Update Calculator project with debugging setup".  
1. Click the checkmark icon to commit your changes.  
1. If your repository is connected to GitHub, click **Sync Changes** in the status bar or the "…​" menu at the top right and select **Push** to upload your changes to the remote repository.  

### Terms

| Term | Description  
|-|-  
| **Stage** | The process of selecting specific changes to include in the next commit.  
| **Sync** | Pushes your local commits to the remote repository and fetches any changes from others.  