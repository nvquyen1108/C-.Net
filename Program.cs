#define countss
using System;
using System.ComponentModel.Design;


namespace DayThung{
    class Program {
        
        public static int playerX = 0;
        public static int playerY = 0;
        public static bool IsGame = true;
        public static void Menu(int x){
            Console.Clear();
            Console.CursorLeft = x +6;
            Console.CursorTop = 0;
            Console.WriteLine(">> Press Enter: PlayGame");
            Console.CursorLeft = x + 6;
            Console.WriteLine($"Press any key to Quit Game");
        }
        static void Main(){
            Console.CursorVisible = false;
            InitGame initGame = new InitGame();

            Menu(0);
            while(IsGame){
                initGame.SelectMap();
            }
        }
    }
}