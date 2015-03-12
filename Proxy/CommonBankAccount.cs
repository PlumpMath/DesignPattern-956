using System;

namespace TerrLuo.DesignPattern.Proxy
{
    public class CommonBankAccount : BankAccount
    {
        private readonly string _id;
        private readonly string _password;

        public CommonBankAccount(string id, string password)
        {
            this._id = id;
            this._password = password;
        }

        public override string ID { get { return this._id; } }

        public override string Password { get { return this._password; } }

        /// <summary>
        /// Pay specified money to target account
        /// </summary>
        /// <param name="money"></param>
        /// <param name="targetAccountID"></param>
        /// <returns></returns>
        public override bool Pay(decimal money, string targetAccountID)
        {
            bool successful = false;

            if (ValidateAccount(this.ID, this.Password))
            {
                if (CheckBalance(money))
                {
                    successful = Transfer(money, targetAccountID);
                }
            }

            return successful;            
        }

        private bool ValidateAccount(string id, string password)
        {
            bool isAccountValid = false;
            // Code to call bank service to check if current id and password are valid
            return isAccountValid;

        }

        private bool CheckBalance(decimal money)
        {
            bool isBalanceEnough = false;
            // Code to call bank service to check balance
            return isBalanceEnough;
        }

        private bool Transfer(decimal money, string targetAccountID)
        {
            bool successfull = false;
            // Code to call bank service to transfer specified money to target account
            return successfull;
        }
    }
}
