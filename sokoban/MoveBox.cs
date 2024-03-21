using System;
namespace DayThung{
    class MoveBox : Program{
        public static bool PlayerMoveToBoxLeft(int x, int y, int[,] map){
            if(map[y,x-1] == 2){
                if(map[y,x-2] == 0){
                    if(map[y,x] == 3){
                        map[y,x] = 3;
                        map[y,x-1] = 4;
                        map[y,x-2] = 2;
                        Console.CursorLeft = x-2;
                        Console.CursorTop = y;
                        Console.Write("#");
                        return true;
                    }else{

                        map[y,x] = 0;
                        map[y,x-1] = 4;
                        map[y,x-2] = 2;
                        Console.CursorLeft = x-2;
                        Console.CursorTop = y;
                        Console.Write("#");
                        return true;
                    }
                }else if(map[y,x-2] == 1){
                    return false;
                }else if(map[y,x-2] == 2){
                    return false;
                }else if(map[y,x-2] == 3){
                    if(map[y,x] == 3){
                        map[y,x] = 3;
                        map[y,x-1] = 4;
                        map[y,x-2] = 5;
                        Console.CursorLeft = x-2;
                        Console.CursorTop = y;
                        Console.Write("v");
                        return true;
                    }else{
                        map[y,x] = 0;
                        map[y,x-1] = 4;
                        map[y,x-2] = 5;
                        Console.CursorLeft = x-2;
                        Console.CursorTop = y;
                        Console.Write("v");
                        return true;
                    }
                }else if(map[y,x-2] == 5){
                    return false;
                }else{
                    return false;
                }
            }
            return true;
        }
        public static bool PlayerMoveToBoxRight(int x, int y, int[,] map){
            if(map[y,x+1] == 2){
                if(map[y,x+2] == 0){
                    if(map[y,x] == 3){
                        map[y,x] = 3;
                        map[y,x+1] = 4;
                        map[y,x+2] = 2;
                        Console.CursorLeft = x+2;
                        Console.CursorTop = y;
                        Console.Write("#");
                        return true;
                    }else{
                    map[y,x] = 0;
                    map[y,x+1] = 4;
                    map[y,x+2] = 2;
                    Console.CursorLeft = x+2;
                    Console.CursorTop = y;
                    Console.Write("#");
                    return true;
                    }
                }else if(map[y,x+2] == 1){
                    return false;
                }else if(map[y,x+2] == 2){
                    return false;
                }else if(map[y,x+2] == 3){
                    if(map[y,x] == 3){
                        map[y,x] = 3;
                        map[y,x+1] = 4;
                        map[y,x+2] = 5;
                        Console.CursorLeft = x+2;
                        Console.CursorTop = y;
                        Console.Write("v");
                        return true;
                    }else{
                        map[y,x] = 0;
                        map[y,x+1] = 4;
                        map[y,x+2] = 5;
                        Console.CursorLeft = x+2;
                        Console.CursorTop = y;
                        Console.Write("v");
                        return true;
                    }
                }else if(map[y,x+2] == 5){
                    return false;

                }else{
                    return false;
                }
            }
            return true;
        }
        public static bool PlayerMoveToBoxUp(int x, int y, int[,] map){
            if(map[y-1,x] == 2){
                if(map[y-2,x] == 0){
                    if(map[y,x] == 3){
                        map[y,x] = 3;
                        map[y-1,x] = 4;
                        map[y-2,x] = 2;
                        Console.CursorLeft = x;
                        Console.CursorTop = y-2;
                        Console.Write("#");
                        return true;
                    }else{
                        map[y,x] = 0;
                        map[y-1,x] = 4;
                        map[y-2,x] = 2;
                        Console.CursorLeft = x;
                        Console.CursorTop = y-2;
                        Console.Write("#");
                        return true;
                    }
                }else if(map[y-2,x] == 1){
                    return false;
                }else if(map[y-2,x] == 2){
                    return false;
                }else if(map[y-2,x] == 3){
                    if(map[y,x] == 3){
                        map[y,x] = 3;
                        map[y-1,x] = 4;
                        map[y-2,x] = 5;
                        Console.CursorLeft = x;
                        Console.CursorTop = y-2;
                        Console.Write("v");
                        return true;
                    }else{
                        map[y,x] = 0;
                        map[y-1,x] = 4;
                        map[y-2,x] = 5;
                        Console.CursorLeft = x;
                        Console.CursorTop = y-2;
                        Console.Write("v");
                        return true;
                    }
                }else if(map[y-2,x] == 5){
                    return false;
                }else{
                    return false;
                }
            }
            return true;
        }
        public static bool PlayerMoveToBoxDown(int x, int y, int[,] map){
            if(map[y+1,x] == 2){
                if(map[y+2,x] == 0){
                    if(map[y,x] == 3){
                        map[y,x] = 3;
                        map[y+1,x] = 4;
                        map[y+2,x] = 2;
                        Console.CursorLeft = x;
                        Console.CursorTop = y+2;
                        Console.Write("#");
                        return true;
                    }else{
                        map[y,x] = 0;
                        map[y+1,x] = 4;
                        map[y+2,x] = 2;
                        Console.CursorLeft = x;
                        Console.CursorTop = y+2;
                        Console.Write("#");
                        return true;
                    }
                }else if(map[y+2,x] == 1){
                    return false;
                }else if(map[y+2,x] == 2){
                    return false;
                }else if(map[y+2,x] == 3){
                    if(map[y,x] == 3){
                        map[y,x] = 3;
                        map[y+1,x] = 4;
                        map[y+2,x] = 5;
                        Console.CursorLeft = x;
                        Console.CursorTop = y+2;
                        Console.Write("v");
                        return true;
                    }else{
                        map[y,x] = 0;
                        map[y+1,x] = 4;
                        map[y+2,x] = 5;
                        Console.CursorLeft = x;
                        Console.CursorTop = y+2;
                        Console.Write("v");
                        return true;
                    }
                }else if(map[y+2,x] == 5){
                    return false;
                }else{
                    return false;
                }
            }
            return true;
        }

    }
}