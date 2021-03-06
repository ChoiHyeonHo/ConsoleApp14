﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class AccountManager
    {
        BankAccount account;

        public void PrintMenu()  //계좌관리프로그램 메뉴
        {
            Console.WriteLine("\n---Menu--------");
            Console.WriteLine("1. 계좌 개설");
            Console.WriteLine("2. 입금");
            Console.WriteLine("3. 출금");
            Console.WriteLine("4. 잔액 조회");
            Console.WriteLine("5. 프로그램 종료");
        }

        public void MakeAccount() //1. 계좌 개설
        {
            Console.Write("계좌번호:");
            string accNum = Console.ReadLine();
            Console.Write("예금주명:");
            string accName = Console.ReadLine();
            
            account = new BankAccount(accNum, accName);            
        }

        public void Deposit() //2. 입금
        {
            Console.Write("입금하실 금액은?:");
            int money = int.Parse(Console.ReadLine());
            account.InputMoney(money);
        }

    }

    class AccountProgram
    {
        static void Main()
        {
            AccountManager manager = new AccountManager();

            int choice;
            while (true)
            {
                manager.PrintMenu();
                Console.Write("선택:");
                choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        manager.MakeAccount(); break;
                    case 2:
                        manager.Deposit(); break;
                    case 3:break;
                    case 4:break;
                    case 5:return;
                    default:
                        Console.WriteLine("다시 선택하세요");break;
                }
            }

        }

    }
}
