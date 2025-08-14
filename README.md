# 📝 To-Do List Application (Beginner C# Console App)

A simple beginner-friendly **C# console application** that allows users to manage a to-do list.
Users can **add**, **remove**, and **view** tasks until they choose to exit.

---

## 📌 Features
- **Add a task** to the list.
- **Remove a task** by number.
- **View all tasks** currently in the list.
- **Exit** the application when done.

---

## 🛠️ How It Works
1. The program starts by displaying a welcome message.
2. A menu is shown with options:
   - `1` → Add a task
   - `2` → Remove a task
   - `3` → View all tasks
   - `e` → Exit
3. The user enters their choice, and the program performs the selected action.
4. The menu repeats until the user enters `e`.

---

## 🚀 How to Run
### **Using Visual Studio**
1. Clone this repository:
   ```bash
   git clone https://github.com/SOMNATH0904/ToDoList.git
   ```
2. Open the `.sln` file in **Visual Studio**.
3. Press **F5** or click **Run**.

### **Using .NET CLI**
1. Clone the repository:
   ```bash
   git clone https://github.com/SOMNATH0904/ToDoList.git
   cd ToDoList
   ```
2. Run the application:
   ```bash
   dotnet run
   ```

---

## 💻 Example Usage
```
Welcome to the To-Do List Application!
What would you like to do?
Enter 1: To add a task to the list.
Enter 2: To remove a task from the list.
Enter 3: To view all tasks in the list.
Enter e to exit the application.
1
Please enter the name of the task you want to add:
Buy groceries
Task added to the list.
```

---

## 📂 Project Structure
```
ToDoList/
│-- Program.cs      # Main application code
│-- .gitignore      # Git ignore rules
│-- csharp.csproj # Project file
│-- csharp.sln    # Solution file
```
