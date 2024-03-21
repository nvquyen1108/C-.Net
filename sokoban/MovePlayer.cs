using System;
namespace DayThung{
    class MovePlayer : Program{
        public static bool PlayerMoveLeft(int x, int y,int[,] map){
            if(map[y,x-1] == 0){
                if(map[y,x] == 3){
                    map[y,x] = 3;
                    map[y,x-1] = 4;
                    Console.CursorLeft = x-1;
                    Console.CursorTop = y;
                    Console.Write((char)2);
                    return true;
                }else if(map[y,x] == 4){
                    map[y,x] = 0;
                    map[y,x-1] = 4;
                    Console.CursorLeft = x-1;
                    Console.CursorTop = y;
                    Console.Write((char)2);
                    return true;
                }
            }
            return true;
        }
        public static bool PlayerMoveRight(int x, int y, int[,] map){
            if(map[y,x+1] == 0){
                if(map[y,x] == 3){
                    map[y,x] = 3;
                    map[y,x+1] = 4;
                    Console.CursorLeft = x+1;
                    Console.CursorTop = y;
                    Console.Write((char)2);
                    return true;
                }else if(map[y,x] == 4){
                    map[y,x] = 0;
                    map[y,x+1] = 4;
                    Console.CursorLeft = x+1;
                    Console.CursorTop = y;
                    Console.Write((char)2);
                    return true;
                }
            }
            return true;
        }
        public static bool PlayerMoveUp(int x, int y, int[,] map){
            if(map[y-1,x] == 0){
                if(map[y,x] == 3){
                    map[y,x] = 3;
                    map[y-1,x] = 4;
                    Console.CursorLeft = x;
                    Console.CursorTop = y-1;
                    Console.Write((char)2);
                    return true;
                }else if(map[y,x] == 4){
                    map[y,x] = 0;
                    map[y-1,x] = 4;
                    Console.CursorLeft = x;
                    Console.CursorTop = y-1;
                    Console.Write((char)2);
                    return true;
                }
            }
            return true;
        }
        public static bool PlayerMoveDown(int x, int y, int[,] map){
            if(map[y+1,x] == 0){
                if(map[y,x] == 3){
                    map[y,x] = 3;
                    map[y+1,x] = 4;
                    Console.CursorLeft = x;
                    Console.CursorTop = y+1;
                    Console.Write((char)2);
                    return true;
                }else if(map[y,x] == 4){
                    map[y,x] = 0;
                    map[y+1,x] = 4;
                    Console.CursorLeft = x;
                    Console.CursorTop = y+1;
                    Console.Write((char)2);
                    return true;
                }
            }
            return true;
        }


    }
}