using System;

namespace tack1var4
{
    class BankAccount
    {
        // Поля для хранения имени, возраста и адреса
        private string accnumber;
        private string owner;
        private float balance;

        // Конструктор класса для инициализации полей: имя, возраст и адрес
        public BankAccount(string accnumber, string owner, int balance)
        {
            this.accnumber = accnumber;
            this.owner = owner;
            this.balance = balance;
        }

        // Методы для установки и получения значений полей
        //уст. имя
        public void SetAccnumber(string accnumber)
        {
            this.accnumber = accnumber;
        }
        //получить имя
        public string GetAccnumber()
        {
            return accnumber;
        }
        //уст. владельца
        public void SetOwner(string owner)
        {
            this.owner = owner;
        }
        //получить имя владельца
        public string GetOwner()
        {
            return owner;
        }
        //уст. баланс
        public void SetBalance(float balance)
        {
            this.balance = balance;
        }
        //получить баланс
        public float GetBalance()
        {
            return balance;
        }

        // Метод для пополнения счета
        public void Deposit(float money)
        {
            //если денег больше 0
            if (money > 0)
            {
                //прибавить внос в баланс
                balance += money;
                Console.WriteLine($"Пополнено {money} рублей. Новый баланс: {balance} рублей.");
            }
            //если меньше
            else
            {
                Console.WriteLine("Сумма для пополнения должна быть больше нуля.");
            }
        }

        // Метод для снятия средств со счета
        public void Withdraw(float money)
        {
            //елси больше 0 и баланс больше вывода
            if (money > 0 && money <= balance)
            {
                //убавлять вывод с баланса
                balance -= money;
                Console.WriteLine($"Снято {money} рублей. Новый баланс: {balance} рублей.");
            }
            //если вывод меньше 0
            else if (money <= 0)
            {
                Console.WriteLine("Сумма для снятия должна быть больше нуля.");
            }
            //если средст на счету меньше вывода
            else
            {
                Console.WriteLine("Недостаточно средств на счете.");
            }
        }
    }
    class tack1vr4
    {
        static void Main()
        {
            // Создание объекта банковского счета (номер, владелец, счёт)
            BankAccount account = new BankAccount("1234567890", "Иванов Иван", 1000);

            // Вывод информации о счете
            Console.WriteLine("Информация о банковском счете:");
            Console.WriteLine($"Номер счета: {account.GetAccnumber()}");
            Console.WriteLine($"Владелец: {account.GetOwner()}");
            Console.WriteLine($"Баланс: {account.GetBalance()} рублей");

            // Пополнение счета
            account.Deposit(500);

            // Снятие средств со счета
            account.Withdraw(200);

            // Снятие суммы больше баланса
            account.Withdraw(1500);

            // Попытка пополнить счет на отрицательную сумму
            account.Deposit(-100);

            Console.ReadLine();
        }
    }
}