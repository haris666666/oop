using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace oopInvest
{
    [DataContract]
    class Investment
    {
       
        [DataMember]
        private List<Securities> _securities = new List<Securities>();
        [DataMember]
        private List<Client> _clients = new List<Client>();
        [DataMember]
        private List<string> _dateOfPurchase = new List<string>();
        [DataMember]
        private List<string> _dateOfSale = new List<string>();
        [DataMember]
        private int _quotations;
        [DataMember]
        private int _bankDeposit;

        public void AddClient(string Name, string Title, string Property, string Address, long Phone)
        {
            _clients.Add(new Client(Name, Title, Property, Address, Phone));
           // _jsonSave.SaveJSON();
        }
        public Securities GetSecurities(int Index)
        {
            return _securities[Index];
        }
        public Client GetClients(int Index)
        {
            return _clients[Index];
        }
        public int GetBankDeposit()
        {
            return _bankDeposit;
        }
        public void BuySecurities(int CodeSecurities)
        {
            _securities.Add(new Securities(CodeSecurities));
            AddDateOfPurchase();
        }
        public void SaleSecurities(int Index)
        {
            _securities.RemoveAt(Index);
            AddDateOfSale();
        }

        public void AddDateOfPurchase()
        {
            _dateOfPurchase.Add(Convert.ToString(DateTime.Now.ToShortDateString()));
        }
        public void GetDateOfPurchase()
        {
            foreach (var auto in _dateOfPurchase)
            {
                Console.WriteLine(auto.ToString());
            }
        }

        public void AddDateOfSale()
        {
            _dateOfSale.Add(DateTime.Now.ToShortDateString());
        }
        public void GetDateOfSale()
        {
            foreach (var auto in _dateOfSale)
            {
                Console.WriteLine(auto.ToString());
            }
        }

        public void Start() /*Для этого нужно было сделать отдельный класс, но чтобы соответствовать условиям - я сделал это тут*/
        {
            Console.WriteLine("1. Клиенты, " +
                "2. Ценные бумаги, " +
                "3. Инвестиции, " +
                "4. Выход, " + 
                "Выберите вариант(1-4):");
            int Choise = Convert.ToInt32(Console.ReadLine());
            if (Choise == 1)
            {
                Console.WriteLine("1. Добавить клиента, " +
                "2. Получить данные клиента, " +
                "Выберите вариант(1-2):");
                Choise = Convert.ToInt32(Console.ReadLine());
                if (Choise == 1)
                {

                    string Name = Console.ReadLine();
                    string Title = Console.ReadLine();
                    string Property = Console.ReadLine();
                    string Address = Console.ReadLine();
                    long Phone = Convert.ToInt64(Console.ReadLine());

                    AddClient(Name, Title, Property, Address, Phone);

                    Console.WriteLine("Добавлено.");

                    Start();
                }
                if (Choise == 2)
                {
                    Console.WriteLine("Введите номер клиента(Index): ");

                    int Index = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(GetClients(Index).GetName());
                    Console.WriteLine(GetClients(Index).GetTitle());
                    Console.WriteLine(GetClients(Index).GetProperty());
                    Console.WriteLine(GetClients(Index).GetAddress());
                    Console.WriteLine(GetClients(Index).GetPhone());

                    Start();
                }
               // else Start();
                //Start();
            }
            if (Choise == 2)
            {
                Console.WriteLine("1. Получить данные ценной бумаги."
                    + " Введите индекс:");
                int Index = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine(GetSecurities(Index).GetCodeSecurities());
                Console.WriteLine(GetSecurities(Index).GetSumMin());
                Console.WriteLine(GetSecurities(Index).GetScore());
                Console.WriteLine(GetSecurities(Index).GetRevenueYear());

                Start();
            }
            if (Choise == 3)
            {
                Console.WriteLine("1. Купить ценные бумаги, "
                    + "2. Продать ценные бумаги, " + "3. Вложить деньги в банковские депозиты" + 
                    "4. Получить историю покупок и продаж ценных бумаг: " +  " Введите номер(1-4):");
                Choise = Convert.ToInt32(Console.ReadLine());

                if(Choise == 1)
                {
                    Console.WriteLine("Введите код ценной бумаги: ");
                    int Securities = Convert.ToInt32(Console.ReadLine());

                    BuySecurities(Securities);
                }
                if (Choise == 2)
                {
                    Console.WriteLine("Введите индекс продаваемой ценной бумаги: ");
                    int Index = Convert.ToInt32(Console.ReadLine());

                    SaleSecurities(Index);

                }
                if (Choise == 3)
                {
                    Console.WriteLine("Введите сумму: ");
                    int Sum = Convert.ToInt32(Console.ReadLine());
                    _bankDeposit += Sum;
                }
                if (Choise == 4)
                {
                    Console.WriteLine("Даты покупок: ");
                    GetDateOfPurchase();

                    Console.WriteLine("Даты продаж: ");
                    GetDateOfSale();
                }
               Start();
            }
            if (Choise >= 4)
            {
               return;
            }
        }
    }
}
