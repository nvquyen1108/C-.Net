using System;
namespace DayThung{
    class MoveDone : Program{
        public static bool PlayerMoveToDoneUp(int x, int y, int[,] map){
            if(map[y-1,x] == 5){
                if(map[y-2,x] == 0){
                    if(map[y,x] == 4){
                        map[y,x] = 0;
                        map[y-1,x] = 3;
                        map[y-2,x] = 2;
                        Console.CursorLeft = x;
                        Console.CursorTop = y-2;
                        Console.Write("#");
                        return true;
                    }else if(map[y,x] == 3){
                        map[y-1,x] = 3;
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
                    if(map[y,x] == 4){
                        map[y-1,x] = 3;
                        map[y-2,x] = 5;
                        Console.CursorLeft = x;
                        Console.CursorTop = y-2;
                        Console.Write("v");
                        return true;
                    }else if(map[y,x] == 3){
                        map[y-1,x] = 3;
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
        public static bool PlayerMoveToDoneDown(int x, int y, int[,] map){
            if(map[y+1,x] == 5){
                if(map[y+2,x] == 0){
                    if(map[y,x] == 4){
                        map[y,x] = 0;
                        map[y+1,x] = 3;
                        map[y+2,x] = 2;
                        Console.CursorLeft = x;
                        Console.CursorTop = y+2;
                        Console.Write("#");
                        return true;
                    }else if(map[y,x] == 3){
                        map[y+1,x] = 3;
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
                    if(map[y,x] == 4){
                        map[y+1,x] = 3;
                        map[y+2,x] = 5;
                        Console.CursorLeft = x;
                        Console.CursorTop = y+2;
                        Console.Write("v");
                        return true;
                    }else if(map[y,x] == 3){
                        map[y+1,x] = 3;
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
        public static bool PlayerMoveToDoneLeft(int x, int y, int[,] map){
            if(map[y,x-1] == 5){
                if(map[y,x-2] == 0){
                    if(map[y,x] == 4){
                        map[y,x] = 0;
                        map[y,x-1] = 3;
                        map[y,x-2] = 2;
                        Console.CursorLeft = x-2;
                        Console.CursorTop = y;
                        Console.Write("#");
                        return true;
                    }else if(map[y,x] == 3){
                        map[y,x-1] = 3;
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
                    if(map[y,x] == 4){
                        map[y,x-1] = 3;
                        map[y,x-2] = 5;
                        Console.CursorLeft = x-2;
                        Console.CursorTop = y;
                        Console.Write("v");
                        return true;
                    }else if(map[y,x] == 3){
                        map[y,x-1] = 3;
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
        public static bool PlayerMoveToDoneRight(int x, int y, int[,] map){
            if(map[y,x+1] == 5){
                if(map[y,x+2] == 0){
                    if(map[y,x] == 4){
                        map[y,x] = 0;
                        map[y,x+1] = 3;
                        map[y,x+2] = 2;
                        Console.CursorLeft = x+2;
                        Console.CursorTop = y;
                        Console.Write("#");
                        return true;
                    }else if(map[y,x] == 3){
                        map[y,x+1] = 3;
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
                    if(map[y,x] == 4){
                        map[y,x+1] = 3;
                        map[y,x+2] = 5;
                        Console.CursorLeft = x+2;
                        Console.CursorTop = y;
                        Console.Write("v");
                        return true;
                    }else if(map[y,x] == 3){
                        map[y,x+1] = 3;
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
    }
}