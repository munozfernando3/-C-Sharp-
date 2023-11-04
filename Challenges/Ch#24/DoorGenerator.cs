using System;
using static System.Console;
using static System.ConsoleColor;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Clear();
            Door door = new Door("1234");
            while (true)
            {
                
                door.DisplayStatus();
               ConsoleKey key=ReadKey().Key;
               if (key==ConsoleKey.Enter)
               {
                door.ChangeSecurityStatus();
               }
               if (key==ConsoleKey.Spacebar)
               {
                door.ChangeStatus();
               }
               if (key==ConsoleKey.Backspace)
               {
                door.ChangePassword();
               }
            }


        }
        public static void ColorWriteLine(string text, ConsoleColor color)
        {
            ForegroundColor = color;
            WriteLine(text);
            ResetColor();
        }
        public static void ColorWrite(string text, ConsoleColor color)
        {
            ForegroundColor = color;
            Write(text);
            ResetColor();
        }
        public static void ColorWriteDescription(string header, string text, ConsoleColor color)
        {
            ForegroundColor = color;
            Write(header);
            ResetColor();
            WriteLine(text);
        }
    }

    public class Door
    {
        private Status _status;
        private string? _password;
        private ConsoleColor _statusColor;
        private bool _isLocked;
        public Status Status { get => _status; }
        public string? Password { get => _password; }
        public bool IsLocked { get => _isLocked; }
        public ConsoleColor StatusColor
        {
            get
            {
                if (_isLocked)
                {
                    return _statusColor = Red;
                }
                else
                {
                    return _statusColor = Green;
                }
            }
        }

        public Door(string password)
        {
            _password = password;
            _status=Status.Closed;
            _isLocked = true;

        }
        public void DisplayStatus()
        {
            Write("Status: ");
            Write(GetDoorStatus()+" ");
            Program.ColorWriteLine($"({GetDoorSecurityStatus()})", StatusColor);
        }
        public void ChangeSecurityStatus()
        {
            if (_isLocked==true)
            {
                Unlock();
            }
            else
            {
                Lock();
            }
        }
        public void ChangeStatus()
        {
            if (_status==Status.Opened)
            {
Close();
            }
            else
            {
                
                Open();
            }
        }
        public string GetDoorSecurityStatus()
        {
            if (!IsLocked)
            {
                return "Unlocked";
            }
            else
            {
                return "Locked";
            }
        }
        public string GetDoorStatus()
        {
            if (_status == Status.Closed)
            {
                return "Closed";
            }
            else
            {
                return "Opened";
            }
        }
        public void Open()
        {
            if (_status == Status.Closed && !IsLocked)
            {
                Clear();
                _status = Status.Opened;
            }
            else if (IsLocked)
            {
                IsNotUnlocked();
            }
        }
        public void Close()
        {
            if (_status == Status.Opened && !IsLocked)
            {
                Clear();
                _status = Status.Closed;
            }
            else if (IsLocked)
            {
                IsNotUnlocked();
            }

        }
        public void Lock()
        {
            if (_status == Status.Closed && !IsLocked)
            {
                Clear();
                _isLocked = true;
            }
            else if (_status == Status.Opened)
            {
                Clear();
                Program.ColorWriteLine("You need to close it first", Red);
            }
        }
        public void Unlock()
        {
            if (IsLocked)
            {
            if (AskForPassword() == _password)
            {
                Clear();
                _isLocked=false;
            }
            else
            {
                Clear();
                Program.ColorWriteLine("Incorrect Password", Red);
                Unlock();
            }
            }
            else
            {
                 Clear();
                Program.ColorWriteLine("The door is already UNLOCKED", Yellow);
            }
        }
        public void IsNotUnlocked()
        {
            Clear();
            Program.ColorWriteLine("You need to Unlock it first", Red);
            Unlock();
        }

        public string AskForPassword()
        {
            Write("Password: ");
            return ReadLine();
        }
        public void ChangePassword()
        {   
            if (AskForPassword()==_password)
            {
                Program.ColorWrite("New Password: ", Magenta);
                string? newPassword=ReadLine();
                _password=newPassword;
                Clear();
            }
            else
            {

                Clear();
                Program.ColorWriteLine("Incorrect Password", Red);
            }

        }

    }
    public enum Status
    {
        Opened, Closed,
    }
}
