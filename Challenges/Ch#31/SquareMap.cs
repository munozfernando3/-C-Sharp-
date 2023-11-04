namespace Map // Note: actual namespace depends on the project name.
{
    public class SquareMap
    {
        public Room[] Rooms;
        public int Side;

        public bool hasTheKey = false;
        private int _indexSelectedRoom;

        public int Area;
        private Room _currentRoom;
        private Room _exitRoom;
        private int _exitRoomIndex;


        public int IndexSelectedRoom
        {
            get
            {
                EnsureIsNotOutOfRange();
                return _indexSelectedRoom;
            }
        }

        public Room CurrentRoom { get => _currentRoom; set => _currentRoom = value; }

        public SquareMap(int side)
        {
            Side = side;
            Area = Side * Side;
            _indexSelectedRoom = 0;
            _currentRoom = new Room(1, 1, Area);
            Rooms = new Room[Area];
            CreateSquareMap();
        }
        private void CreateSquareMap()
        {
            int currentRow = 1;
            int currentColumn = 1;

            for (int x = 0; x < Area; x++)
            {
                if (currentColumn > Side)
                {
                    currentRow++;
                    currentColumn = 1;
                }
                Rooms[x] = new Room(currentRow, currentColumn, Area);
                currentColumn++;
            }
            AddSpecialRooms();
            _exitRoomIndex = GetExitIndex();
            _exitRoom = Rooms[_exitRoomIndex];
        }
        private void AssignFountainOfObjects()
        {
            Random random = new Random();
            Rooms[random.Next(1, Area)].TypeOfRoom = new KeyRoom();
        }
        private void AddSpecialRooms()
        {
            EnsureTrapsAreNotNextToEntrance();
            AssignFountainOfObjects();
            AssignExit();
            AssignWarningRooms();
        }
        private void AssignWarningRooms()
        {
            for (int x = 0; x < Rooms.Length; x++)
            {
                if (IsTrapRoom(Rooms[x]))
                {
                    if (!IsInTheEdge(x))
                    {
                        AssignEastWarningRoom(x, Rooms[x]);
                        AssignNorthWarningRoom(x, Rooms[x]);
                        AssignWestWarningRoom(x, Rooms[x]);
                        AssignSouthWarningRoom(x, Rooms[x]);
                    }
                    if (IsInFirstColumn(Rooms[x]))
                    {
                        AssignEastWarningRoom(x, Rooms[x]);

                        if (!IsInLowerLeftCorner(Rooms[x]) && !IsInUpperLeftCorner(Rooms[x]))
                        {
                            AssignNorthWarningRoom(x, Rooms[x]);
                            AssignSouthWarningRoom(x, Rooms[x]);
                        }
                    }
                    if (IsInLastColumn(Rooms[x]))
                    {
                        AssignWestWarningRoom(x, Rooms[x]);

                        if (!IsInLowerRightCorner(Rooms[x]) && !IsInUpperRightCorner(Rooms[x]))
                        {
                            AssignNorthWarningRoom(x, Rooms[x]);
                            AssignSouthWarningRoom(x, Rooms[x]);
                        }
                    }
                    if (IsInFirstRow(Rooms[x]))
                    {
                        AssignSouthWarningRoom(x, Rooms[x]);

                        if (!IsInUpperLeftCorner(Rooms[x]) && !IsInUpperRightCorner(Rooms[x]))
                        {
                            AssignWestWarningRoom(x, Rooms[x]);
                            AssignEastWarningRoom(x, Rooms[x]);
                        }
                    }
                    if (IsInLastRow(Rooms[x]))
                    {
                        AssignNorthWarningRoom(x, Rooms[x]);

                        if (!IsInLowerLeftCorner(Rooms[x]) && !IsInLowerRightCorner(Rooms[x]))
                        {
                            AssignWestWarningRoom(x, Rooms[x]);
                            AssignEastWarningRoom(x, Rooms[x]);
                        }
                    }

                }
            }
        }
        private void AssignEastWarningRoom(int index, Room room)
        {
            if (IsEmptyRoom(Rooms[index + 1]))
            {
                Rooms[index + 1].TypeOfRoom = new EmptyRoom("warning");
            }
        }
        private void AssignWestWarningRoom(int index, Room room)
        {
            if (IsEmptyRoom(Rooms[index - 1]))
            {
                Rooms[index - 1].TypeOfRoom = new EmptyRoom("warning");
            }
        }
        private void AssignNorthWarningRoom(int index, Room room)
        {
            if (IsEmptyRoom(Rooms[index - Side]))
            {
                Rooms[index - Side].TypeOfRoom = new EmptyRoom("warning");
            }
        }
        private void AssignSouthWarningRoom(int index, Room room)
        {
            if (IsEmptyRoom(Rooms[index + Side]))
            {
                Rooms[index + Side].TypeOfRoom = new EmptyRoom("warning");
            }
        }
        public void AssignExit()
        {
            while (true)
            {
                Random random = new Random();
                int assignedRoom = random.Next(1, Area);
                while (!IsInTheEdge(assignedRoom))
                {
                    assignedRoom = random.Next(1, Area);
                }
                if (Rooms[assignedRoom].TypeOfRoom.GetType() != typeof(KeyRoom))
                {
                    Rooms[assignedRoom].TypeOfRoom = new ExitRoom();
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        public int GetNumberOfTrapRooms()
        {
            int numberOfTrapRooms = 0;
            foreach (Room room in Rooms)
                if (room.TypeOfRoom.GetType() == typeof(Trap))
                {
                    numberOfTrapRooms++;
                }
            return numberOfTrapRooms;
        }
        private int GetExitIndex()
        {
            int exitIndex = 0;
            for (int x = 0; x < Rooms.Length; x++)
            {
                if (Rooms[x].TypeOfRoom.GetType() == typeof(ExitRoom))
                {
                    exitIndex = x;
                }
            }
            return exitIndex;
        }
        private void EnsureTrapsAreNotNextToEntrance()
        {
            if (Rooms[1].TypeOfRoom.GetType() == typeof(Trap))
            {
                Rooms[1].TypeOfRoom = new EmptyRoom();
            }
            if (Rooms[Side].TypeOfRoom.GetType() == typeof(Trap))
            {
                Rooms[Side].TypeOfRoom = new EmptyRoom();
            }
        }
        private void EnsureTrapsAreNotNextToExit()
        {
            if (Rooms[_exitRoomIndex].TypeOfRoom.GetType() == typeof(Trap))
            {
                Rooms[1].TypeOfRoom = new EmptyRoom();
            }
            if (Rooms[Side].TypeOfRoom.GetType() == typeof(Trap))
            {
                Rooms[Side].TypeOfRoom = new EmptyRoom();
            }
        }
        private void DisplaySquareMap()
        {

            int numvberOfRow = 1;
            for (int x = 0; x < Rooms.Length; x += Side, numvberOfRow++)
            {
                DisplayRow(x, numvberOfRow);
                Console.Out.NewLine = "\r\n\r\n";
                WriteLine(" ");
            }
        }

        private void DisplayRow(int index, int numvberOfRow)
        {

            for (int x = index; x < Side * numvberOfRow; x++)
            {
                if (IndexSelectedRoom == x)
                {
                    ForegroundColor = Rooms[x].TypeOfRoom.Color;
                }
                Write(Rooms[x].Draw() + "  ");
                ResetColor();
            }
        }
        public void Display()
        {
            EnsureIsNotOutOfRange();
            DisplaySquareMap();
            DisplayCurrentRoom();
            DisplayStatusMessage(_indexSelectedRoom);
            DisplayConfirmation();
        }
        public void MoveEast()
        {
            _currentRoom.Column++;
            _indexSelectedRoom++;
        }
        public void MoveWest()
        {
            _currentRoom.Column--;
            _indexSelectedRoom--;
        }
        public void MoveNorth()
        {
            _currentRoom.Row--;
            _indexSelectedRoom -= Side;
        }
        public void MoveSouth()
        {
            _currentRoom.Row++;
            _indexSelectedRoom += Side;
        }
        private void DisplayCurrentRoom()
        {
            ForegroundColor = ConsoleColor.DarkBlue;
            Write("Current Room at: ");
            ResetColor();
            WriteLine(_currentRoom.ToString());
        }
        private void DisplayStatusMessage(int room)
        {
            ForegroundColor = Rooms[room].TypeOfRoom.Color;
            WriteLine(Rooms[room].TypeOfRoom.Name);
            ResetColor();
            WriteLine(Rooms[room].TypeOfRoom.Text);
        }

        private void EnsureIsNotOutOfRange()
        {
            if (IsOutOfIndex())
            {
                WriteLine("You cannot move past the end of the Map ");
                if (_currentRoom.Column == Side + 1)
                {
                    _currentRoom.Column = Side;
                    _indexSelectedRoom -= 1;
                }
                if (_currentRoom.Column == 0)
                {
                    _currentRoom.Column = 1;
                    _indexSelectedRoom += 1;
                }
                if (_currentRoom.Row == 0)
                {
                    _currentRoom.Row = 1;
                    _indexSelectedRoom += Side;
                }
                if (_currentRoom.Row == Side + 1)
                {
                    _currentRoom.Row = Side;
                    _indexSelectedRoom -= Side;
                }
            }
        }
        private void DisplayConfirmation()
        {
            if (hasTheKey)
            {
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine("Congrats! You have the key. Now find the EXIT!");
                ResetColor();
            }
            else
            {
                ForegroundColor = ConsoleColor.DarkGray;
                WriteLine("Find the chocolate key!");
                ResetColor();
            }
        }
        private bool IsOutOfIndex()
        {
            return (_currentRoom.Row > Side || _currentRoom.Row < 1) || (_currentRoom.Column > Side || _currentRoom.Column < 1);
        }
        private bool IsInLastColumn(Room Room)
        {
            return Room.Column == Side;
        }
        private bool IsInFirstColumn(Room Room)
        {
            return Room.Column == 1;
        }
        private bool IsInLastRow(Room Room)
        {
            return Room.Row == Side;
        }
        private bool IsInFirstRow(Room Room)
        {
            return Room.Row == 1;
        }
        private bool IsInCorner(Room Room)
        {
            return ((Room.Row == 1 && Room.Column == 1) || (Room.Row == Side && Room.Column == Side) || (Room.Row == 1 && Room.Column == Side) || (Room.Row == Side && Room.Column == 1));
        }
        private bool IsInUpperLeftCorner(Room room)
        {
            return (room.Row == 1 && room.Column == 1);
        }
        private bool IsInLowerLeftCorner(Room room)
        {
            return (room.Row == Side && room.Column == 1);
        }
        private bool IsInLowerRightCorner(Room room)
        {
            return (room.Row == Side && room.Column == Side);
        }
        private bool IsInUpperRightCorner(Room room)
        {
            return (room.Row == 1 && room.Column == Side);
        }
        private bool IsTrapRoom(Room room)
        {
            return room.TypeOfRoom.GetType() == typeof(Trap);
        }
        private bool IsInTheEdge(int x)
        {
            return IsInLastColumn(Rooms[x]) || IsInFirstColumn(Rooms[x]) || IsInLastRow(Rooms[x]) || IsInFirstRow(Rooms[x]);
        }
        // private bool AreAdjacent(Room room, Room roomAdjacent)
        // {
        //     if (IsInLowerLeftCorner(room))
        //     {
        //         return AreNorthAdjacent(room, roomAdjacent) || AreEastAdjacent(room, roomAdjacent);
        //     }
        //     else if (IsInUpperLeftCorner(room))
        //     {
        //         return AreSouthAdjacent(room, roomAdjacent) || AreEastAdjacent(room, roomAdjacent);
        //     }
        //      else if (IsInUpperRightCorner(room))
        //     {
        //         return AreSouthAdjacent(room, roomAdjacent) || AreWestAdjacent(room, roomAdjacent);
        //     }
        //     else if (IsInLowerRightCorner(room))
        //     {
        //         return AreNorthAdjacent(room, roomAdjacent) || AreWestAdjacent(room, roomAdjacent);
        //     }
           
        //      else
        //             {
        //                 return AreNorthAdjacent(room, roomAdjacent)|| AreSouthAdjacent(room, roomAdjacent)|| AreWestAdjacent(room, roomAdjacent)|| AreEastAdjacent(room, roomAdjacent);
        //             }
        // }
        // private bool AreNorthAdjacent(Room room, Room roomAdjacent)
        // {
        //     return room.Index - Side == roomAdjacent.Index;
        // }
        // private bool AreSouthAdjacent(Room room, Room roomAdjacent)
        // {
        //     return room.Index + Side == roomAdjacent.Index;
        // }
        // private bool AreEastAdjacent(Room room, Room roomAdjacent)
        // {
        //     return room.Index + 1 == roomAdjacent.Index;
        // }
        // private bool AreWestAdjacent(Room room, Room roomAdjacent)
        // {
        //     return room.Index - 1 == roomAdjacent.Index;
        // }


        public bool IsEmptyRoom(Room room)
        {
            return room.TypeOfRoom.GetType() == typeof(EmptyRoom);
        }
        public bool Complete()
        {
            if (IsInExit() && hasTheKey)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void TakeKey()
        {
            if (IsInKeyRoom())
            {
                hasTheKey = true;
            }
        }
        public bool IsInExit()
        {
            return Rooms[_indexSelectedRoom].TypeOfRoom.GetType() == typeof(ExitRoom);
        }
        public bool IsInKeyRoom()
        {
            return Rooms[_indexSelectedRoom].TypeOfRoom.GetType() == typeof(KeyRoom);
        }
        public bool Loose()
        {
            return Rooms[_indexSelectedRoom].TypeOfRoom.GetType() == typeof(Trap);
        }

    }

}
