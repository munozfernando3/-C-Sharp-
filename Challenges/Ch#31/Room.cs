namespace Map // Note: actual namespace depends on the project name.
{
    public class Room
    {

        public int Row { get; set; }
        public int Column { get; set; }
        public string Message { get; set; }
        public int Index { get; }
        public ConsoleColor ColorOfMessage { get; set; }
        public ITypeOfRoom TypeOfRoom { get; set; }

        public Room(int row, int column, int max)
        {
            Row = row;
            Column = column;
            AssignRandomType(max);

        }
        public void MakeItTrapRoom()
        {
            TypeOfRoom = new Trap();
        }
        public void AssignType(int max)
        {
            if (Row == 1 && Column == 1)
            {
                TypeOfRoom = new EntryCavern();
            }
            else
            {
                TypeOfRoom = new EmptyRoom();
            }
        }
        public void AssignRandomType(int max)
        {
            if (Row == 1 && Column == 1)
            {
                TypeOfRoom = new EntryCavern();
            }
            else
            {
                Random random = new Random();
                int randomNumber = random.Next(1, max);
                if (randomNumber % 2 == 0)
                {
                    if (randomNumber % 3 == 0)
                    {
                        TypeOfRoom = new Trap();
                    }
                    else
                    {
                        TypeOfRoom = new EmptyRoom();
                    }
                }
                else
                {
                    TypeOfRoom = new EmptyRoom();
                }
            }
        }


        public override string ToString()
        {

            return $"(Row: {Row}, Column: {Column})";
        }
        public string Draw()
        {

            return "?";
        }

        // public bool IsAdjacent(Room Room)
        // {
        //     if (!IsInTheSameColumn(Room) && !IsInTheSameRow(Room))
        //     {
        //         return false;
        //     }
        //     else if (IsInTheSameColumn(Room) && IsInTheSameRow(Room))
        //     {
        //         return false;
        //     }
        //     else
        //     {
        //         if (IsInTheSameColumn(Room))
        //         {
        //             if (IsNorthAdjacent(Room) || IsSouthAdjacent(Room))
        //             {
        //                 return true;
        //             }
        //             else
        //             {
        //                 return false;
        //             }
        //         }
        //         else if (IsInTheSameRow(Room))
        //         {
        //             if (IsWestAdjacent(Room) || IsEastAdjacent(Room))
        //             {
        //                 return true;
        //             }
        //             else
        //             {
        //                 return false;
        //             }
        //         }
        //         else
        //         {
        //             return false;
        //         }
        //     }
        // }
        // public Room GetNorthAdjacent()
        // {
        //     return new Room(Row, Column + 1, );
        // }
        // public Room GetSouthdjacent()
        // {
        //     return new Room(Row, Column - 1);
        // }
        // public Room GetEastdjacent()
        // {
        //     return new Room(Row + 1, Column);
        // }
        // public Room GetWestdjacent()
        // {
        //     return new Room(Row - 1, Column);
        // }
        // public bool IsInTheSameRow(Room Room)
        // {
        //     return Room.Row == Row;
        // }
        // public bool IsInTheSameColumn(Room Room)
        // {
        //     return Room.Column == Column;
        // }
        // public bool IsNorthAdjacent(Room Room)
        // {
        //     return Room.Row + 1 == Row;
        // }
        // public bool IsSouthAdjacent(Room Room)
        // {
        //     return Room.Row - 1 == Row;
        // }
        // public bool IsWestAdjacent(Room Room)
        // {
        //     return Room.Column - 1 == Column;
        // }
        // public bool IsEastAdjacent(Room Room)
        // {
        //     return Room.Column + 1 == Column;
        // }
    }
    public interface ITypeOfRoom
    {
        public string Name { get; }
        public ConsoleColor Color { get; }

        public string Text { get; }


    }
}