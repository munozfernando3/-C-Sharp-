global using static System.Console;
using System;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coordenate coordenate = new Coordenate(0, 0);
            Coordenate coordenate1 = new Coordenate(1, 0);
        }
    }
    public struct Coordenate
    {
        public Coordenate(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public int Row { get; }
        public int Column { get; }


        public override string ToString()
        {
            return $"({Column}, {Row})";
        }
        public bool IsAdjacent(Coordenate coordenate)
        {
            if (!IsInTheSameColumn(coordenate) && !IsInTheSameRow(coordenate))
            {
                return false;
            }
            else if (IsInTheSameColumn(coordenate) && IsInTheSameRow(coordenate))
            {
                return false;
            }
            else
            {
                if (IsInTheSameColumn(coordenate))
                {
                    if (IsNorthAdjacent(coordenate) || IsSouthAdjacent(coordenate))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (IsInTheSameRow(coordenate))
                {
                    if (IsWestAdjacent(coordenate) || IsEastAdjacent(coordenate))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
        public bool IsInTheSameRow(Coordenate coordenate)
        {
            return coordenate.Row == Row;
        }
        public bool IsInTheSameColumn(Coordenate coordenate)
        {
            return coordenate.Column == Column;
        }
        public bool IsNorthAdjacent(Coordenate coordenate)
        {
            return coordenate.Row + 1 == Row;
        }
        public bool IsSouthAdjacent(Coordenate coordenate)
        {
            return coordenate.Row - 1 == Row;
        }
        public bool IsWestAdjacent(Coordenate coordenate)
        {
            return coordenate.Column - 1 == Column;
        }
        public bool IsEastAdjacent(Coordenate coordenate)
        {
            return coordenate.Column + 1 == Column;
        }
    }
    public class Room
    {
        public Coordenate[] _coordenates;
        public int Heigh;
        public int Base;

        public Room( int heigh, int @base)
        {
            Heigh = heigh;
            Base = @base;
        }
      
    }

}


