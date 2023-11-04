// namespace MyApp // Note: actual namespace depends on the project name.
// {
//     public class SquareRoom
//     {
//         public Coordenate[] Coordenates;
//         public int Height;
//         public int Base;

//         private int _indexSelectedCoordenate;

//         public int Area;
//         private Coordenate _currentCoordenate;
//         private Coordenate _lastCoordenate;

//         public int IndexSelectedCoordenate
//         {
//             get
//             {
//                 EnsureLogicalSelectionDisplay();
//                 return _indexSelectedCoordenate;
//             }
//         }

       

//         public SquareRoom(int height, int @base)
//         {
//             Height = height;
//             Base = @base;
//             Area = Base * Height;
//             _indexSelectedCoordenate = 0;
//             _currentCoordenate = new Coordenate(1, 1);
//             _lastCoordenate= new Coordenate(Base, Height);
//             Coordenates = new Coordenate[Area];

//             CreateSquareRoom();
//         }
//         public void EnsureLogicalSelectionDisplay()
//         {
//             if (_indexSelectedCoordenate >= Coordenates.Length)
//             {
//                 if (_indexSelectedCoordenate == Coordenates.Length)
//                 {
//                     if (_currentCoordenate.Row==Base)
//                     _indexSelectedCoordenate = 0;
                  
//                     else
//                     _indexSelectedCoordenate = (_indexSelectedCoordenate - Area) + 1;
//                 }
                
//                 if (_indexSelectedCoordenate > Coordenates.Length)
//                 {
//                     if (IsInLastColumn(_currentCoordenate))
//                     {
//                         _indexSelectedCoordenate=0;
//                     }
//                     else
//                     {
//                     _indexSelectedCoordenate = (_indexSelectedCoordenate - Area) + 1;
//                     }
//                 }
//             }
//             if (_indexSelectedCoordenate <= -1)
//             {
                
//                 if (_indexSelectedCoordenate == -1)
//                 {
//                     if (_currentCoordenate.Row==Height)
//                     {
//                         _indexSelectedCoordenate=Area-2;
//                     }
//                      else
//                     _indexSelectedCoordenate = Coordenates.Length - 1;
//                 }
//                 if (_indexSelectedCoordenate < -1)
//                 {
//                     if (IsInFirstColumn(_currentCoordenate))
//                     {
//                         _indexSelectedCoordenate=Area-1;
//                     }
//                     _indexSelectedCoordenate=(_indexSelectedCoordenate + Area)-1;
//                 }
//             }
//         }
//         public void CreateSquareRoom()
//         {
//             int currentRow = 1;
//             int currentColumn = 1;

//             for (int x = 0; x < Area; x++)
//             {
//                 if (currentRow > Base)
//                 {
//                     currentColumn++;
//                     currentRow = 1;
//                 }
//                 Coordenates[x] = new Coordenate(currentRow, currentColumn);
//                 currentRow++;
//             }
//         }
//         private bool IsInLastColumn(Coordenate coordenate)
//         {
//           return coordenate.Row==Base;
//         }
//          private bool IsInFirstColumn(Coordenate coordenate)
//         {
//           return coordenate.Row==1;
//         }
//         private bool IsInLastRow(Coordenate coordenate)
//         {
//             return coordenate.Column==Height;
//         }
//         private void DisplaySquareRoom()
//         {

//             int numvberOfRow = 1;
//             for (int x = 0; x < Coordenates.Length; x += Base, numvberOfRow++)
//             {
//                 DisplayRow(x, numvberOfRow);
//                 Console.Out.NewLine = "\r\n\r\n";
//                 WriteLine(" ");
//             }
//         }

//         private void DisplayRow(int index, int numvberOfRow)
//         {

//             for (int x = index; x < Base * numvberOfRow; x++)
//             {
//                 if (IndexSelectedCoordenate == x)
//                 {
//                     ForegroundColor = ConsoleColor.Green;
//                    _currentCoordenate= Coordenates[x];
//                 }
//                 Write(Coordenates[x].ToString() + "  ");
//                 ResetColor();
//             }
//         }
//         public void Display()
//         {
//             while (true)
//             {
//                 Clear();
//                 DisplaySquareRoom();
//                 DisplayCurrentCoordenate();
//                 ConsoleKey key = ReadKey().Key;
//                 if (key == ConsoleKey.RightArrow)
//                 {
                  
//                     _indexSelectedCoordenate++;
//                 }
//                 if (key == ConsoleKey.LeftArrow)
//                 {
                    
//                     _indexSelectedCoordenate--;
//                 }
//                 if (key == ConsoleKey.UpArrow)
//                 {
                 
//                     _indexSelectedCoordenate -= Height;
//                 }
//                 if (key == ConsoleKey.DownArrow)
//                 {
             
//                     _indexSelectedCoordenate += Height;
//                 }


//             }
//         }
//         public void DisplayCurrentCoordenate()
//         {
//             ForegroundColor=ConsoleColor.DarkBlue;
//             Write("Current Coordenate: ");
//             ResetColor();
//             WriteLine(_currentCoordenate.ToString());
//         }

//     }

// }
