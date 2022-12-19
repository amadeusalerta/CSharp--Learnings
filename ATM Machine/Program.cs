using System;
using System.Net.NetworkInformation;

public class CardHolder
{
    String cardnumber;
    int pin;
    String firstName;
    String lastName;
    double Balance;

    public CardHolder(string cardnumber, int pin, string firstName, string lastName, double balance)
    {
        this.cardnumber = cardnumber;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        Balance = balance;
    }

    public String getNum()
    {
        return cardnumber;

    }

    public int getPin()
    {
        return pin;
    }

    public String getFirstName()
    {
        return firstName;
    }

    public String getLastName()
    {
        return lastName;
    }

    public double getBalance()
    {
        return Balance;
    }

    public void setNum(String NewCardNumber)
    {
        cardnumber = NewCardNumber;
    }

    public void setPin(int newPin)
    {
        pin = newPin;
    }

    public void setFirstName(String newFirstName)
    {
        firstName = newFirstName;
    }

    public void setLastName(String newLastName)
    {
        lastName = newLastName;
    }

    public void setBalance(double newBalance)
    {
        Balance = newBalance;
    }
    
    public static void Main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options.");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(CardHolder currentUser)
        {
            Console.WriteLine("How much money would you like deposit?");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance() + deposit);
            Console.WriteLine("Thank you for your Deposit. Your new balance is :"+currentUser.getBalance);
        }
        void withdraw(CardHolder currentUser)
        {
            Console.WriteLine("How much money would you like withdraw?");
            double withdrawall = Double.Parse(Console.ReadLine());

            if (currentUser.getBalance() < withdrawall)
            {
                Console.WriteLine("Insufficent Balance");
            }

            else
            {
            
                currentUser.setBalance(currentUser.getBalance() - withdrawall);
                Console.WriteLine(" Your withdrawal has been completed.");

            }

        }

        void show_balance(CardHolder currentUser)
        {
            Console.WriteLine("Current Balance:" + currentUser.getBalance());
        }

        List<CardHolder> cardHolders= new List<CardHolder>();
        cardHolders.Add(new CardHolder("5357158565741238", 1234, "Efe", "Altınbaş", 315.23));
        cardHolders.Add(new CardHolder("5357153465124460", 2336, "Furkan", "Ülker", 471.98));
        cardHolders.Add(new CardHolder("5357867165366223", 4214, "Doğa", "Deniz", 861.73));
        cardHolders.Add(new CardHolder("5357151265851276", 9966, "Ahmet", "Gör", 199.45));
        cardHolders.Add(new CardHolder("5357157865003149", 8545, "Volkan", "Aykut", 513.32));

        Console.WriteLine("Welcome to SimpleATM Machine");
        Console.WriteLine("Please enter your Debit Card Number");
        String debitCardNum = "";
        CardHolder currentUser;

        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                currentUser = cardHolders.FirstOrDefault(a =>a.cardnumber == debitCardNum);
                if (currentUser != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Card Number not recognized by system. Please try again");
                }
            }
            catch
            {
                Console.WriteLine("Card Number not recognized by system. Please try again");
            }
        }

        Console.WriteLine("Please enter your PIN");
        int userPIN = 0;
        while (true)
        {
            try
            {
                userPIN = int.Parse(Console.ReadLine());
                if(currentUser.getPin()==userPIN)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("PIN not recognized by system. Please try again");
                }
            }

            catch
            {
                Console.WriteLine("PIN not recognized by system. Please try again");
            }
        }

        Console.WriteLine("Welcome" + currentUser.getBalance);
        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch
            {

            }

            if (option == 1)
            {
                deposit(currentUser);
            }
            else if (option == 2)
            {
                withdraw(currentUser);
            }

            else if(option==3)
            {
                show_balance(currentUser);
            }

            else if (option == 4)
            {
                break;
            }

            else
            {
                option = 0;
            }
        }
        while (option != 4);
        Console.WriteLine("Thank you. Have a nice day");
    }
}