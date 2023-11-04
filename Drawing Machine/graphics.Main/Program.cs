//Fernando 03/14/2023
using graphics;

List<IGraphic2D> shapes = new List<IGraphic2D> 
{
    // new Circle(10, 10, 5) { BackgroundColor = ConsoleColor.DarkYellow, DisplayChar = ' ' },
    // new Circle(8, 10, 1m) { BackgroundColor = ConsoleColor.White, ForegroundColor = ConsoleColor.Gray, DisplayChar = '.' },
    // new Circle(12, 10, 1m) { BackgroundColor = ConsoleColor.White, ForegroundColor = ConsoleColor.Gray, DisplayChar = '.' },
    // new Circle(8, 10, 0.5m) { BackgroundColor = ConsoleColor.Blue, ForegroundColor = ConsoleColor.DarkBlue, DisplayChar = '.' },
    // new Circle(12, 10, 0.5m) { BackgroundColor = ConsoleColor.Blue, ForegroundColor = ConsoleColor.DarkBlue, DisplayChar = '.' },
    // new Rectangle(8, 13, 4, 0.5m) { ForegroundColor = ConsoleColor.DarkGray, DisplayChar = 'v' },
    // new Rectangle(8, 16, 4, 10) { ForegroundColor = ConsoleColor.DarkGreen, DisplayChar = '#' },
   
    new Rectangle(16, 2, 26, 3) {BackgroundColor = ConsoleColor.DarkYellow, DisplayChar = ' '  },
     new Rectangle(10, 5, 40, 3) {BackgroundColor = ConsoleColor.DarkYellow, DisplayChar = ' '  },
          new Rectangle(22, 2.5m, 20, 2) {BackgroundColor = ConsoleColor.Cyan, DisplayChar = ' '  },
          new Circle(20,11,3.6m) {BackgroundColor = ConsoleColor.DarkGray, DisplayChar = ' '  },
          new Circle(40,11,3.6m) {BackgroundColor = ConsoleColor.DarkGray, DisplayChar = ' '  },
            new Circle(30,3,0.5m) {BackgroundColor = ConsoleColor.Green, DisplayChar = ' '  },


};


Console.Clear();
AbstractGraphic2D.Display(shapes);