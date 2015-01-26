namespace TestOODesigns
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public abstract class Observer
    {
        public abstract void Update(string text);
    }

    public abstract class Observable
    {
        private List<Observer> observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            this.observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            this.observers.Remove(observer);
        }

        public void Notify(string text)
        {
            foreach (Observer o in observers)
            {
                o.Update(text);
            }
        }
    }

    public class Display : Observer
    {
        private string text;
        public override void Update(string text)
        {
            this.text = text;
            this.Show();
        }

        private void Show()
        {
            Console.WriteLine(this.text);
        }
    }

    public enum CoinType
    {
        Quarter = 0,
        Dime = 1,
        Nickel = 2
    }

    public abstract class Coin
    {
        public abstract CoinType Type { get; }
        public abstract decimal Value { get; }
    }

    public class Quarter : Coin
    {
        public override CoinType Type { get { return CoinType.Quarter; } }
        public override decimal Value { get { return 0.25m; } }
    }

    public class Dime : Coin
    {
        public override CoinType Type { get { return CoinType.Dime; } }
        public override decimal Value { get { return 0.10m; } }
    }

    public class Nickel : Coin
    {
        public override CoinType Type { get { return CoinType.Nickel; } }
        public override decimal Value { get { return 0.05m; } }
    }

    public abstract class Item
    {
        public decimal Price { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Drink : Item
    {
    }

    public class Snack : Item
    {
    }

    public class CoinSlot : Observable
    {
        private static CoinSlot instance;
        private static Object syncLock = new Object();
        private List<Coin> insertedCoins = new List<Coin>();
        private List<Coin> coinsToReturn = new List<Coin>();
        private Dictionary<CoinType, List<Coin>> availableCoins = new Dictionary<CoinType, List<Coin>>();

        public static CoinSlot Instance()
        {
            if (instance == null)
            {
                lock (syncLock)
                {
                    if (instance == null)
                    {
                        instance = new CoinSlot();
                    }
                }
            }

            return instance;
        }

        public void RefillCoins(List<Coin> coins)
        {
            // add into available coins
            this.Notify("Refill successful.");
        }

        public void AcceptCurrentPayment(decimal changes)
        {
            // Add from inserted coins to available coins
            this.ReturnChange(new List<Coin>());
        }

        public void CancelPayment()
        {
        }

        public decimal GetCurrentPqyment()
        {
            return 0.0m;
        }

        public void InsertCoin(Coin coin)
        {
        }

        private void ReturnChange(List<Coin> coins)
        {
            // put to coins to return list
        }
    }

    public interface IState
    {

    }

    public class OperationState : IState
    {

    }

    public class MaintananceState : IState
    {

    }

    public class VendingMachine : Observable
    {
        private IState state;
        private CoinSlot coinSlot = CoinSlot.Instance();
        private static VendingMachine instance;
        private static Object syncLock = new Object();
        private Dictionary<int, List<Item>> inventory = new Dictionary<int, List<Item>>();

        public static VendingMachine Instance()
        {
            if (instance == null)
            {
                lock (syncLock)
                {
                    if (instance == null)
                    {
                        instance = new VendingMachine();
                    }
                }
            }

            return instance;
        }

        public void UpdateInventory(List<Item> items)
        {
        }

        public Dictionary<int, List<Item>> GetInventory()
        {
            return this.inventory;
        }

        public void SetState(IState state)
        {
            this.state = state;
        }

        public void DispenseItem(int itemId)
        {
            // check payment
            this.coinSlot.GetCurrentPqyment();
            // dispense item
        }
    }

    public static class Main
    {
        public static void Run()
        {
            CoinSlot coinSlot = CoinSlot.Instance();
            List<Coin> coins = new List<Coin>();
            coinSlot.RefillCoins(coins);

            VendingMachine vendingMachine = VendingMachine.Instance();
            List<Item> items = new List<Item>();
            vendingMachine.UpdateInventory(items);

            Display display = new Display();
            coinSlot.Attach(display);
            vendingMachine.Attach(display);

            // Loop to start
        }
    }
}