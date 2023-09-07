using System.Security.Cryptography.X509Certificates;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int snakeX=1;
            int snakeY=1;

            bool Islive= true;
            Console.Clear();
            int h = 8;
            int w = 30;

            List<int> lst= new List<int>();

            Random rdX = new Random();
            int foodx= rdX.Next(1,w-1);
            Random rdY = new Random();
            int foodY= rdY.Next(1,h-1);
            // Food vàng
            while(foodx == 2 & foodY ==2)
            {
                foodx= rdX.Next(1,w-1);
                foodY= rdY.Next(1,h-1);
            }
            while (Islive)
            {
                food(foodx,foodY,ConsoleColor.Yellow);
                 drawWall(h,w);
                // Con ran tai vi tri dau tien mau xanh
                Snake(snakeX,snakeY, ConsoleColor.Green);
                // Khi x va y vuot ra ngoai W H thi game over
                if(snakeX <1 || snakeX > w - 2 || snakeY <1 || snakeY > h-1) {
                    Console.WriteLine("Game Over");
                    break;
                }
                if (Console.KeyAvailable)
                {
                    // Truoc khi con ran tien toi vi tri tiep theo thi reset vi tri cu tai cho nay
                    Snake(snakeX,snakeY, ConsoleColor.Black);
                    var command = Console.ReadKey().Key;
                    switch (command)
                    {
                        case ConsoleKey.DownArrow:
                            snakeY++;
                            break;
                        case ConsoleKey.UpArrow:
                            if (snakeY > 0)
                            {
                                snakeY--;
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                            if (snakeX > 0)
                            {
                                snakeX--;
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            snakeX++;
                            break;
                        
                        default :
                        // La mac dinh . co nghia la khi nguoi dung nhan bat ky phim nao khong phai phim dieu huong se in ra dong canh bao
                            Console.WriteLine("Please press up down bottom right only");
                            break;
                    }
                    // Set mau xanh cho con ran tai vi tri moi
                    Snake(snakeX,snakeY, ConsoleColor.Green);
                    
                }
                if(snakeX== foodx & snakeY==foodY)
            {
                // Xoá moi cu
                Console.SetCursorPosition(foodx,foodY);
                Console.BackgroundColor=ConsoleColor.Black;
                Console.Write(' ');
                //Them moi moi
                foodx=rdX.Next(1,w-1);
                foodY= rdY.Next(1,h-1);
            }
                Console.ResetColor();
        }
    }
        public static void Snake(int x, int y, ConsoleColor consoleColor)
        {
           
            Console.BackgroundColor= consoleColor;
            Console.SetCursorPosition(x,y);
            Console.WriteLine(' ');
            Console.SetCursorPosition(0,9);
        }

        public static void food(int x, int y, ConsoleColor consoleColor)
        {
           
            Console.BackgroundColor= consoleColor;
            Console.SetCursorPosition(x,y);
            Console.WriteLine(' ');
            Console.SetCursorPosition(0,9);
        }
        private static void drawWall(int h, int w)
        {
           Console.BackgroundColor = ConsoleColor.Red;
            //Hàng trên
            for(int i = 0; i<w;i++)
            {
                Console.SetCursorPosition(i,0);
                Console.Write('#');

            }
            //Hàng trái
            for(int i=1;i<h;i++)
            {
                Console.SetCursorPosition(0,i);
                Console.Write('#');
            }
            //Hàng phải
            for(int i=1;i<h;i++)
            {
                Console.SetCursorPosition(w-1,i);
                Console.Write('#');
            }
            //Hàng dưới
            for(int i=0;i<w;i++)
            {
                Console.SetCursorPosition(i,h);
                Console.Write('#');
            }
            Console.ResetColor();
        }
    }
}