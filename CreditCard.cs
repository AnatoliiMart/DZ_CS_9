using System.Runtime.CompilerServices;

namespace DZ_CS_9
{
    
    internal class CreditCard
    {
        private string? cardNumber;
        private string? cardHoldersName;
        private DateOnly cardValidity;
        int pinCode;
        int creditLimit;
        int money;
        int sumAchive;
        public event Action<string>? MoneyOperations;
        public event Action<string>? Confirmation;



        public CreditCard() {
        }

        public CreditCard(string cardNumber, string cardHoldersName, DateOnly cardValidity, 
                          int pinCode, int creditLimit, int money, int sumAchive)
        {
            this.cardNumber      = cardNumber;
            this.cardHoldersName = cardHoldersName;
            this.cardValidity    = cardValidity;
            this.pinCode         = pinCode;
            this.creditLimit     = creditLimit;
            this.money           = money + creditLimit;
            this.sumAchive       = sumAchive;
        }

        public void InputData()
        {
            Console.Write("Enter card number:\t");
            cardNumber = Console.ReadLine();

            Console.Write("Enter card holders name:\t");
            cardHoldersName = Console.ReadLine();

            Console.WriteLine("Enter card validity date:\t");

            Console.Write("day:\t");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.Write("month:\t");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("year:\t");
            int year = Convert.ToInt32(Console.ReadLine());

            cardValidity = new DateOnly(year, month, day);

            Console.Write("Enter card PIN:\t");
            pinCode = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter credit limit:\t");
            creditLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter amount of money on card:\t");
            money = Convert.ToInt32(Console.ReadLine()) + creditLimit;

            Console.Write("Enter the amount of money you want to achieve:\t");
            sumAchive = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return "Card number:\t\t" + cardNumber + "\nCard holder name:\t" + cardHoldersName + "\nCard valid to:\t\t" +
                    cardValidity.ToShortDateString() + "\nPIN\t\t\t" + pinCode + "\nCredit limit:\t\t" + creditLimit +
                   "\nTotal money\t\t" + money + " including credit money!\n" + "Sum to achieve:\t\t" + sumAchive;
        }

        public void AddMoney()
        {
            Console.Write("Enter how much money you want to add:\t");
            int tmp = Convert.ToInt32(Console.ReadLine());
            if (tmp <= 0)
                Confirmation?.Invoke("Wronng input amount of money!!!");
            else
            {
                money += tmp;
                MoneyOperations?.Invoke("Balance replenishment completed successfully");
                SumCornfim();
            }
        }

        public void RemoveMoney()
        {
            Console.Write("Enter how much money you want to take:\t");
            int tmp = Convert.ToInt32(Console.ReadLine());
            if (tmp <= 0)
                Confirmation.Invoke("Wronng input amount of money!!!");
            else
            {
                money -= tmp; 
                MoneyOperations?.Invoke("Balance replenishment completed successfully");
                StartUseCreditMoney();
            }
        }

        public void StartUseCreditMoney()
        {
            if (money <= creditLimit)
                MoneyOperations?.Invoke("You satrt using credit money!");
        }

        public void SumCornfim()
        {
            if (money >= sumAchive)
            {
                Confirmation?.Invoke("You have reached the amount you wanted!!!");
            }
        }

        public void ChangePIN()
        {
            Console.Write("Enter new PIN code:\t");
            int newPin = Convert.ToInt32(Console.ReadLine());
            pinCode = newPin;
            Console.Write("Cornfim new PIN code:\t");
            int newPINCornfirm = Convert.ToInt32(Console.ReadLine());

            if (pinCode == newPin && pinCode == newPINCornfirm)
                Confirmation?.Invoke("PIN changed successfully!");
            else
                Confirmation?.Invoke("Wrong input new PIN!!!");
        }



    }
}
