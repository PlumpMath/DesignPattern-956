using System;

namespace TerrLuo.DesignPattern.Proxy
{
    public abstract class BankAccount
    {
        public abstract string ID { get; }

        public abstract string Password { get; }

        public abstract bool Pay(decimal rmb, string targetAccountID);
    }
}
