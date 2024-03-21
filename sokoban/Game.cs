using System;
namespace DayThung{
    class Game : Program {
        public PrintMap printmap = new PrintMap();
        public bool End = false;
        public void Controller(int[,] map){
            while(!End){
                ConsoleKeyInfo key = Console.ReadKey(true);
                if(key.Key == ConsoleKey.UpArrow){
                    if(Limit.PlayerLimit(playerX, playerY-1, map)){
                        if(MovePlayer.PlayerMoveUp(playerX,playerY, map)){
                            if(MoveBox.PlayerMoveToBoxUp(playerX,playerY,map)){
                                if(MoveDone.PlayerMoveToDoneUp(playerX,playerY,map)){
                                    printmap.HidePlayer(map);
                                    playerY--;
                                    printmap.DrawPlayer();
                                }
                            }
                        }
                    }
                }else if(key.Key == ConsoleKey.DownArrow){
                    if(Limit.PlayerLimit(playerX, playerY+1,map)){
                        if(MovePlayer.PlayerMoveDown(playerX,playerY,map)){
                            if(MoveBox.PlayerMoveToBoxDown(playerX,playerY,map)){
                                if(MoveDone.PlayerMoveToDoneDown(playerX,playerY,map)){
                                    printmap.HidePlayer(map);
                                    playerY++;
                                    printmap.DrawPlayer();
                                }
                            }
                        }
                    }
                }else if(key.Key == ConsoleKey.LeftArrow){
                    if(Limit.PlayerLimit(playerX-1, playerY,map)){
                        if(MovePlayer.PlayerMoveLeft(playerX,playerY,map)){
                            if(MoveBox.PlayerMoveToBoxLeft(playerX,playerY,map)){
                                if(MoveDone.PlayerMoveToDoneLeft(playerX,playerY,map)){
                                    printmap.HidePlayer(map);
                                    playerX--;
                                    printmap.DrawPlayer();
                                }
                            }
                        }
                    }
                }else if(key.Key == ConsoleKey.RightArrow){
                    if(Limit.PlayerLimit(playerX+1, playerY,map)){
                        if(MovePlayer.PlayerMoveRight(playerX,playerY,map)){
                            if(MoveBox.PlayerMoveToBoxRight(playerX,playerY,map)){
                                if(MoveDone.PlayerMoveToDoneRight(playerX,playerY,map)){
                                    printmap.HidePlayer(map);
                                    playerX++;
                                    printmap.DrawPlayer();
                                }
                            }
                        }
                    }
                }else if(key.Key == ConsoleKey.Escape){
                    IsGame = false;
                    break;
                }else if(key.Key == ConsoleKey.Q){
                    InitGame initGame = new InitGame();
                    initGame.repeat(map);
                    End = true;
                }
                if(!GameEnd(map)){
                    End = true;
                }
            }
        }
        public void GameStart(int[,] map){
                // // printmap.DrawMap(map);
                // Console.Clear();
                // Menu(map.GetLength(0));
                // Console.CursorLeft = 0;
                // Console.CursorTop = 0;
                // printmap.DrawMap(map);
            ConsoleKeyInfo keys = Console.ReadKey(true);
            Console.CursorVisible = false;

            if(keys.Key == ConsoleKey.Enter){
                Console.Clear();
                printmap.DrawMap(map);
                Console.CursorLeft = map.GetLength(0) + 3;
                Console.CursorTop = 0;
                Console.Write($"level {Map.counts}");
                Console.CursorLeft = map.GetLength(0) + 3;
                Console.CursorTop = 1;
                Console.WriteLine("Press ESC to Quit Game");
                Console.CursorLeft = map.GetLength(0) + 3;
                Console.CursorTop = 2;
                Console.WriteLine("Press q to Select Level Game");

                End = false;
            }else if(keys.Key == ConsoleKey.Q){
                    InitGame initGame = new InitGame();
                    initGame.repeat(map);
                    End = true;
            }else{
                IsGame = false;
                End = true;
            }
            Controller(map);
        }
        public bool GameEnd(int[,] map){
            int check = 0;
            for(int i=0;i<map.GetLength(1);i++){
                for(int j=0;j<map.GetLength(0);j++){
                    if(map[j,i] == 2){
                        check = map[j,i];
                    }
                }
            }
            if(check == 0){
                Console.Clear();
                Console.WriteLine($"    you win!");
                Console.WriteLine("Enter Next Level");
                Console.WriteLine("q to Select Level Game");
                Console.WriteLine($"Press any key to Quit Game");
                return false;
            }
            return true;
        }
    }
}