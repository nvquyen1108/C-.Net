using System;
namespace DayThung{
    class PrintMap : Program{
        public void DrawMap(int[,] maps){
            
            for(int i=0;i<maps.GetLength(1);i++){
                for(int j=0;j<maps.GetLength(0);j++){
                    Console.CursorLeft = i;
                    Console.CursorTop = j;
                    if(maps[j,i] == 1){
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write((char)166);
                        Console.BackgroundColor = ConsoleColor.Black;
                    }else if(maps[j,i] == 2){
                        Console.Write("#");
                    }else if(maps[j,i] == 3){
                        Console.Write("o");
                    }else if(maps[j,i] == 4){
                        playerX = i;
                        playerY = j;
                        Console.Write((char)2);
                    }else if(maps[j,i] == 5){
                        Console.Write("v");
                    }
                }
            }
        }
        public void DrawPlayer(){
            Console.CursorLeft = playerX;
            Console.CursorTop = playerY;
            Console.Write((char)2);
        }
        public void HidePlayer(int[,] maps){
            Console.CursorLeft = playerX;
            Console.CursorTop = playerY;
            if(maps[playerY,playerX] == 3){
                Console.Write("o");
            }else{
                maps[playerY,playerX] = 0;
                Console.Write(" ");
            }
            Console.CursorVisible = false;
        }
    }
}