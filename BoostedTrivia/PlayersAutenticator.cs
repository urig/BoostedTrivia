using System;

namespace BoostedTrivia
{
    public class PlayersAutenticator
    {
        public PlayersAutenticator() {
            throw new ApplicationException("I am trying to connect a remote server - you have to bypass me...");
        }

        public bool authenticate(String playerName) {
            return false;
        }
    }
}
