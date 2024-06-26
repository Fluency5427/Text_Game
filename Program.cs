﻿namespace TextGame
{
    using System;
    internal class Program
    {

        private class Character
        {
            public int Level { get; set; }
            public string? Name { get; set; }
            public int Attack { get; set; }
            public int Defense { get; set; }
            public int Health { get; set; }
            public int Gold { get; set; }
        }

        private static Character player = new Character
        {
            Level = 1,
            Name = "Chad (전사)",
            Attack = 10,
            Defense = 5,
            Health = 100,
            Gold = 1500
        };
        static void Main(string[] args)
        {
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            Console.WriteLine();
            Console.Write("원하시는 행동을 입력해주세요: ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Stats();
                    break;
                case "2":
                    Inventory();
                    break;
                case "3":
                    Shop();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }

        static void Stats()
        {
            Console.WriteLine("상태 보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.");
            Console.WriteLine("");
            Console.WriteLine(player.Name);
            Console.WriteLine("LV: " + player.Level);
            Console.WriteLine("공격력: " + player.Attack);
            Console.WriteLine("방어력: " + player.Defense);
            Console.WriteLine("체력: " + player.Health);
            Console.WriteLine("소지 골드: " + player.Gold);
        }

        static void Inventory()
        {
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유중인 아이템을 관리할 수 있습니다.");

        }

        static void Shop()
        {
            Console.WriteLine("상점");
            
        }
    }
}
