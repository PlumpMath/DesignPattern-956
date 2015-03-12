using System;

namespace TerrLuo.DesignPattern.Proxy
{
    public class CommonBankAccountProxy : BankAccount
    {
        private const decimal UpperLimit = 500m;

        private readonly CommonBankAccount _commonBankAccount;

        public CommonBankAccountProxy(CommonBankAccount commonBankAccount)
        {
            this._commonBankAccount = commonBankAccount;
        }

        public override string ID { get { return this._commonBankAccount.ID; } }

        public override string Password { get { return this._commonBankAccount.Password; } }

        /// <summary>
        /// Pay specified money to target account
        /// </summary>
        /// <param name="money"></param>
        /// <param name="targetAccountID"></param>
        /// <returns></returns>
        public override bool Pay(decimal money, string targetAccountID)
        {
            bool successful = false;

            /* Why Proxy instead of deriving a new class from CommonBankAccount?
                The blacklist logic doesn't belong to CommonBankAccount, so it's not proper to create a new inheritence class from CommonBankAccount. 
                That's why we choose to use Proxy. 
            */
            if (CheckBlackAccount(targetAccountID))
            {
                successful = this._commonBankAccount.Pay(money, targetAccountID);
            }

            return successful;            
        }

        /// <summary>
        /// Check if target account is in the black list
        /// </summary>
        /// <param name="targetAccountID"></param>
        /// <returns></returns>
        private bool CheckBlackAccount(string targetAccountID)
        {
            var blacklist = new AccountBlacklister().GetBlacklist();
            bool isBlackAccount = blacklist.Contains(targetAccountID);
            return isBlackAccount;
        }
    }
}
