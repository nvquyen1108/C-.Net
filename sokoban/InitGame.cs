using System;
using System.Runtime.InteropServices;
namespace DayThung{
    class InitGame : Program{
        Game game = new Game();
        public void SelectMap(){
            Map.listMap.Add(Map.counts);
            Map newMap = new Map();
            if(Map.counts == 1){
                Map.listMap.Add(Map.counts);
                game.GameStart(newMap.map1);
                Map.counts++;
            }else if(Map.counts == 2){
                Map.listMap.Add(Map.counts);
                game.GameStart(newMap.map2);
                Map.counts++;
            }else if(Map.counts == 3){
                Map.listMap.Add(Map.counts);
                game.GameStart(newMap.map3);
                Map.counts++;
            }else if(Map.counts == 4){
                Map.listMap.Add(Map.counts);
                game.GameStart(newMap.map4);
                Map.counts++;
            }else if(Map.counts == 5){
                Map.listMap.Add(Map.counts);
                game.GameStart(newMap.map5);
                Map.counts++;
            }else if(Map.counts == 6){
                Map.listMap.Add(Map.counts);
                game.GameStart(newMap.map6);
                Map.counts++;
            }else if(Map.counts == 7){
                Map.listMap.Add(Map.counts);
                game.GameStart(newMap.map7);
                Map.counts++;
            }else if(Map.counts == 8){
                Map.listMap.Add(Map.counts);
                game.GameStart(newMap.map8);
                Map.counts++;
            }else if(Map.counts == 9){
                Map.listMap.Add(Map.counts);
                game.GameStart(newMap.map9);
                Map.counts++;
            }else if(Map.counts == 10){
                Map.listMap.Add(Map.counts);
                game.GameStart(newMap.map10);
                Map.counts++;
                Console.Clear();
                Console.WriteLine("Congratulations");
                IsGame = false;
            }
        }
        public void repeat(int[,] map){
            Map returnMap = new Map();
            PrintMap printMap = new PrintMap();

            Console.CursorLeft = 0;
            Console.CursorTop = map.GetLength(1);
            Console.WriteLine($"select number level: 1 -> {Map.listMap.Count}");

            ConsoleKey key = Console.ReadKey().Key;
            switch(key){
                case ConsoleKey.Enter:
                    IsGame = false;
                    break;
                case ConsoleKey.D1:
                    if(Map.listMap.Contains(1)){
                        Console.Clear();
                        Menu(map.GetLength(0));
                        Console.CursorLeft = 0;
                        Console.CursorTop = 0;
                        printMap.DrawMap(returnMap.map1);
                        Map.counts = 1;
                        // Menu(map.GetLength(0));
                        game.GameStart(returnMap.map1);
                    }else IsGame = false;
                    break;
                case ConsoleKey.D2:
                    if(Map.listMap.Contains(2)){
                        Console.Clear();
                        Menu(map.GetLength(0));
                        Console.CursorLeft = 0;
                        Console.CursorTop = 0;
                        printMap.DrawMap(returnMap.map2);
                        Map.counts = 2;
                        // Menu(map.GetLength(0));
                        game.GameStart(returnMap.map2);
                    }else IsGame = false;
                    break;
                case ConsoleKey.D3:
                    if(Map.listMap.Contains(3)){
                        Console.Clear();
                        Menu(map.GetLength(0));
                        Console.CursorLeft = 0;
                        Console.CursorTop = 0;
                        printMap.DrawMap(returnMap.map3);
                        Map.counts = 3;
                        // Menu(map.GetLength(0));
                        game.GameStart(returnMap.map3);
                    }else IsGame = false;
                    break;
                case ConsoleKey.D4:
                    if(Map.listMap.Contains(4)){
                        Console.Clear();
                        Menu(map.GetLength(0));
                        Console.CursorLeft = 0;
                        Console.CursorTop = 0;
                        printMap.DrawMap(returnMap.map4);
                        Map.counts = 4;
                        // Menu(map.GetLength(0));
                        game.GameStart(returnMap.map4);
                    }else IsGame = false;
                    break;
                case ConsoleKey.D5:
                    if(Map.listMap.Contains(5)){
                        Console.Clear();
                        Menu(map.GetLength(0));
                        Console.CursorLeft = 0;
                        Console.CursorTop = 0;
                        printMap.DrawMap(returnMap.map5);
                        Map.counts = 5;
                        // Menu(map.GetLength(0));
                        game.GameStart(returnMap.map5);
                    }else IsGame = false;
                    break;
                case ConsoleKey.D6:
                    if(Map.listMap.Contains(6)){
                        Console.Clear();
                        Menu(map.GetLength(0));
                        Console.CursorLeft = 0;
                        Console.CursorTop = 0;
                        printMap.DrawMap(returnMap.map6);
                        Map.counts = 6;
                        // Menu(map.GetLength(0));
                        game.GameStart(returnMap.map6);
                    }else IsGame = false;
                    break;
                case ConsoleKey.D7:
                    if(Map.listMap.Contains(7)){
                        Console.Clear();
                        Menu(map.GetLength(0));
                        Console.CursorLeft = 0;
                        Console.CursorTop = 0;
                        printMap.DrawMap(returnMap.map7);
                        Map.counts = 7;
                        // Menu(map.GetLength(0));
                        game.GameStart(returnMap.map7);
                    }else IsGame = false;
                    break;
                case ConsoleKey.D8:
                    if(Map.listMap.Contains(8)){
                        Console.Clear();
                        Menu(map.GetLength(0));
                        Console.CursorLeft = 0;
                        Console.CursorTop = 0;
                        printMap.DrawMap(returnMap.map8);
                        Map.counts = 8;
                        // Menu(map.GetLength(0));
                        game.GameStart(returnMap.map8);
                    }else IsGame = false;
                    break;
                case ConsoleKey.D9:
                    if(Map.listMap.Contains(9)){
                        Console.Clear();
                        Menu(map.GetLength(0));
                        Console.CursorLeft = 0;
                        Console.CursorTop = 0;
                        printMap.DrawMap(returnMap.map9);
                        Map.counts = 9;
                        // Menu(map.GetLength(0));
                        game.GameStart(returnMap.map9);
                    }else IsGame = false;
                    break;
                default:
                    IsGame = false;
                    break;
            }
        }
    }
}