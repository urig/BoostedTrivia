using Enyim.Caching;
using Enyim.Caching.Memcached;
using System;

namespace BoostedTrivia
{
    class WinnersList
    {
        private readonly MemcachedClient memcachedClient;

        private WinnersList() {
            memcachedClient = new MemcachedClient();
        }

        private static WinnersList instance;

        public static WinnersList getInstance() {
            if (instance == null) {
                instance = new WinnersList();
            }
            return instance;
        }

        public void add(String player) {
            if (memcachedClient.Get<string>(player) == null)
            {
                memcachedClient.Store(StoreMode.Add, player, 0);
            }
            memcachedClient.Store(StoreMode.Replace, player, (int.Parse(memcachedClient.Get<string>(player)) + 1));
        }

        public int getWinnings(String player)
        {
            return int.Parse(memcachedClient.Get<string>(player));
        }

    }
}
