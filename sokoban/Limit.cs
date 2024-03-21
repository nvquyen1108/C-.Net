using System;
namespace DayThung{
    class Limit : Program{
        public static bool PlayerLimit(int x, int y, int[,] map){
            if(map[y,x] != 1){
                return true;
            }else return false;
        }

    }
}