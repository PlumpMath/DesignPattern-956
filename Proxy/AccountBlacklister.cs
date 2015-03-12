using System;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Proxy
{
    public class AccountBlacklister
    {
        public List<string> GetBlacklist()
        {
            List<string> blacklist = new List<string>();
            // Code to load blacklist from database
            return blacklist;
        }
    }
}
