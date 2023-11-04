//Fernando Munoz and Andres Eguez: LAST CLASS
//Fernando Munoz
using System;
using static System.Console;
using static System.ConsoleColor;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Detail> details = new List<Detail>();
            List<Task> tasks = new List<Task>();
            ToDoList toDoList = new ToDoList(tasks, 0);

            while (true)
            {
                Clear();
                bool displayOrNot = false; //display or not the information within the brackets about how many
                if (tasks.Count == 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("No tasks have been added yet");
                    ResetColor();
                    DisplayInstructions();
                }
                else
                {
                    DisplayTasks(toDoList, tasks, displayOrNot);

                }
                ResetColor();
                Write("Press a key: ");
                ConsoleKey key = ReadKey().Key;

                if (key == ConsoleKey.Enter)
                {
                    AddNewTask(tasks, toDoList, displayOrNot);
                }
                if (tasks.Count > 0 && key == ConsoleKey.Spacebar)
                {
                    toDoList.Toggle();

                }
                if (key == ConsoleKey.DownArrow)
                {
                    toDoList.Next();
                }
                if (key == ConsoleKey.UpArrow)
                {
                    toDoList.Previous();
                }
                if (key == ConsoleKey.Tab)
                {
                    DisplayInstructions();
                }
                if (tasks.Count > 0 && key == ConsoleKey.E)
                {
                    toDoList.EditName(GetTaskName(tasks, toDoList.SelectedIndex));
                }
                if (tasks.Count > 1 && key == ConsoleKey.LeftArrow)
                {
                   
                    toDoList.SwapPrevious();
                    
                }
                if (tasks.Count > 1 && key == ConsoleKey.RightArrow)
                {
                    toDoList.SwapNext();
                }
                if (tasks.Count > 0 && key == ConsoleKey.Delete)
                {
                    toDoList.Delete();
                }
               
            }
        }
        static void AddNewTask(List<Task> tasks, ToDoList toDoList, bool displayOrNot)
        {
            while (true)
            {
                ResetColor();
                Clear();
                DisplayTasks(toDoList, tasks, displayOrNot);
                Write("New Task: ");
                string? newtask = ReadLine();
                toDoList.Insert(newtask);
                break;
            }
        }
        static void DisplayInstructions()
        {
            ResetColor();
            WriteLine("----------------------------");
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Instructions: ");
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("Enter: Add new Task");
            WriteLine("SPACE: toggle completion of selected task/detail");
            WriteLine("↕: select task/detail");
            WriteLine("↔: reorder task");
            WriteLine("TAB`: show/hide help");
            WriteLine("e: edit title/detail");
            WriteLine("Del: Delete a task");

        }
        static void DisplayTasks(ToDoList toDoList, List<Task> tasks, bool displayOrNot)
        {

            while (true)
            {
                Clear();
                ForegroundColor = ConsoleColor.DarkYellow;
                WriteLine("Tasks");
                ResetColor();
                WriteLine("-------------------------------------");
                bool displaycolor = false;
                bool displayarrow = false;
                bool displayBracketContent = false;

                for (int x = 0; x < tasks.Count; x++)
                {
                    DisplaySelectorConditionTasks(x, toDoList, displayarrow, displaycolor);
                    DisplayBracketStatusTasks(toDoList, tasks, displayBracketContent, displayOrNot, x);
                    WriteLine($" {toDoList.Tasks[x].Name}");
                }
                break;
            }
        }
     
        public static void DisplaySelectorConditionTasks(int x, ToDoList toDoList, bool displayarrow, bool displaycolor)
        {
            if (x == toDoList.SelectedIndex)
            {
                displayarrow = true;
                displaycolor = true;
            }
            else
            {
                displayarrow = false;
                displaycolor = false;
            }
            if (displayarrow)
            {
                Write("=>");
            }
            else
            {
                Write("  ");
            }
            if (displaycolor)
            {
                ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                ResetColor();
            }
        }
        
        static void DisplayBracketStatusDetails(List<Detail> details, bool displaystatus, int x)
        {

            if (details[x].Completionstatus == CompletionStatus.Finished)
            {
                displaystatus = true;
            }
            else if (details[x].Completionstatus == CompletionStatus.NotDone)
            {
                displaystatus = false;
            }
            if (displaystatus)
            {
                Write(" [X]");
            }
            else
            {
                Write(" [ ]");
            }
        }
        static void DisplayBracketStatusTasks(ToDoList toDoList, List<Task> tasks, bool displayBracketContent, bool displayOrNot, int x)
        {
            if (displayOrNot == true)
            {

                if (x == toDoList.SelectedIndex)
                {
                    displayBracketContent = true;
                }
                else
                {
                    displayBracketContent = false;
                }

                if (displayBracketContent == true)
                {
                    Write($"[{toDoList.Tasks[x].Progress()}/{toDoList.Tasks[x].Length()}]");
                }
                else
                {
                    Write("[   ]");
                }
            }
            else
            {
                if (tasks[x].Completionstatus == CompletionStatus.NotDone)
                    Write("[   ]");
                else
                {
                    Write("[ X ]");
                }
            }
        }
        static string GetTaskName(List<Task> tasks, int index)
        {
            while (true)
            {
                WriteLine(" ");
                ForegroundColor = ConsoleColor.DarkGreen;
                Write($"Current task: ");
                ForegroundColor = ConsoleColor.DarkGray;
                WriteLine(tasks[index].Name);
                ForegroundColor = ConsoleColor.Magenta;
                Write("New name: ");
                ResetColor();
                string? newname = ReadLine();
                return newname;
            }
        }
    }

    public class Detail
    {
        private string _description;
        private CompletionStatus _completionStatus;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        public CompletionStatus Completionstatus
        {
            get
            {
                return _completionStatus;
            }
            set
            {
                _completionStatus = value;
            }
        }
        public Detail(string description, CompletionStatus status)
        {
            _description = description;
            _completionStatus = status;
        }
    }
    public class Task
    {
        private string _name;
        private List<Detail> _details;
        private int _selectedindex;
        private CompletionStatus _completionStatus;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public List<Detail> Details
        {
            get => _details;
            set => _details = value;
        }
        public int Index
        {
            get => _selectedindex;
            set => _selectedindex = value;
        }
        public CompletionStatus Completionstatus
        {
            get
            {
                return _completionStatus;
            }
            set
            {
                _completionStatus = value;
            }
        }
        public Task(string name, List<Detail> details, CompletionStatus completionStatus, int index)
        {
            _name = name;
            _details = details;
            _selectedindex = index;
        }
        public void Previous()
        {
            if (_selectedindex == 0)
            {
                _selectedindex = _details.Count - 1;
            }
            else
            {
                _selectedindex--;
            }
        }
        public void Next()
        {
            if (_selectedindex == _details.Count - 1)
            {
                _selectedindex = 0;
            }
            else
            {
                _selectedindex++;
            }
        }
        public int Progress()
        {
            int progress = 0;
            for (int x = 0; x < _details.Count; x++)
            {
                if (_details[x].Completionstatus == CompletionStatus.Finished)
                {
                    progress++;
                }
            }
            return progress;
        }
        public int Length()
        {

            return _details.Count;
        }
        public void Insert(Detail detail)
        {
            _details.Add(detail);
        }
        public void EditName(string name)
        {
            _details[_selectedindex].Description = name;
        }
        public void Toggle()
        {
            if (_details[_selectedindex].Completionstatus == CompletionStatus.NotDone)
            {
                _details[_selectedindex].Completionstatus = CompletionStatus.Finished;
            }
            else if (_details[_selectedindex].Completionstatus == CompletionStatus.Finished)
            {
                _details[_selectedindex].Completionstatus = CompletionStatus.NotDone;
            }
        }

    }
    public class ToDoList
    {
        private List<Task> _tasks;
        private CompletionStatus _completionStatus;
        private int _selectedIndex;

        public List<Task> Tasks
        {
            get { return _tasks; }
            set { _tasks = value; }
        }
        public int SelectedIndex
        {
            get { return _selectedIndex; }

        }
        public ToDoList(List<Task> tasks, int index)
        {
            _tasks = tasks;
            _selectedIndex = index;
        }
        public void Previous()
        {
            if (_selectedIndex == 0)
            {
                _selectedIndex = _tasks.Count - 1;
            }
            else
            {
                _selectedIndex--;
            }
        }
        public void Next()
        {
            if (_selectedIndex == _tasks.Count - 1)
            {
                _selectedIndex = 0;
            }
            else
            {
                _selectedIndex++;
            }
        }
        public int Progress()
        {
            int progress = 0;
            for (int x = 0; x < _tasks.Count; x++)
            {
                if (_tasks[x].Progress() == _tasks[x].Length())
                {
                    progress++;
                }
            }
            return progress;
        }
        public int Length()
        {

            return _tasks.Count;
        }
        public void Insert(string task)
        {

            List<Detail> detailnull = new List<Detail>();
            Task newtask = new Task(task, detailnull, CompletionStatus.NotDone, 0);
            _tasks.Add(newtask);
        }
        public void EditName(string name)
        {
            _tasks[_selectedIndex].Name = name;
        }
        public void Toggle()
        {
            if (_tasks[_selectedIndex].Completionstatus == CompletionStatus.NotDone)
            {
                _tasks[_selectedIndex].Completionstatus = CompletionStatus.Finished;
            }
            else if (_tasks[_selectedIndex].Completionstatus == CompletionStatus.Finished)
            {
                _tasks[_selectedIndex].Completionstatus = CompletionStatus.NotDone;
            }
        }
        public void SwapPrevious()
        {
            if (_selectedIndex == 0)
            {
                Task taskswappedin0 = _tasks[0];
                Task taskswappedinlast = _tasks[_tasks.Count - 1];
                _tasks[_selectedIndex] = taskswappedinlast;
                _tasks[_tasks.Count - 1] = taskswappedin0;
                 _selectedIndex=_tasks.Count-1;
            }
            else
            {
                Task taskswapped1 = _tasks[_selectedIndex];
                Task taskswapped2 = _tasks[_selectedIndex - 1];
                _tasks[_selectedIndex] = taskswapped2;
                _tasks[_selectedIndex - 1] = taskswapped1;
                _selectedIndex--;
            }
        }
        public void SwapNext()
        {
            if (_selectedIndex == _tasks.Count - 1)
            {
                Task taskswappedinlast = _tasks[_selectedIndex];
                Task taskswappedin0 = _tasks[0];
                _tasks[_selectedIndex] = taskswappedin0;
                _tasks[0] = taskswappedinlast;
                _selectedIndex=0;
            }
            else
            {
                Task taskswapped1 = _tasks[_selectedIndex];
                Task taskswapped2 = _tasks[_selectedIndex + 1];
                _tasks[_selectedIndex] = taskswapped2;
                _tasks[_selectedIndex + 1] = taskswapped1;
                 _selectedIndex++;
            }
        }
        public void Delete()
        {
            _tasks.RemoveAt(_selectedIndex);
        }
    }
    public class ToDoListApp
    {
        private bool _showhelp;
        private ToDoList _tasks;

        private bool _quit;

        private bool _insertMode;

        public bool Showhelp
        {
            get { return _showhelp; }
        }

    }
    public enum CompletionStatus
    {
        NotDone, Finished
    }

}
