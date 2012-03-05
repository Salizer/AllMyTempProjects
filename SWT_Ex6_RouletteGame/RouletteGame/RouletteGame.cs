using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RouletteGame
{
    public class RouletteGame
    {
        private IRoulette _roulette;
        private bool _roundIsOpen;
        private List<IBet> _bets;
        private UI uiOutput;

        public RouletteGame(IRoulette roulette)
        {
            _bets = new List<IBet>();
            _roulette = roulette;
            uiOutput = new ConsoleUI();
        }
        public RouletteGame(IRoulette roulette, UI output)
        {
            _bets = new List<IBet>();
            _roulette = roulette;
            uiOutput = output;
        }

        public void OpenBets()
        {
            Console.WriteLine("Round is open for bets");
            _roundIsOpen = true;
        }

        public void CloseBets()
        {
            Console.WriteLine("Round is closed for bets");
            _roundIsOpen = false;
        }

        public void PlaceBet(IBet bet)
        {
            if (_roundIsOpen) _bets.Add(bet);
            else throw new RouletteGameException("Bet placed while round closed");
        }

        public void SpinRoulette()
        {
            if (_roundIsOpen)
                throw new RouletteGameException("Bets not closed when spinning");
            Console.Write("Spinning...");
            _roulette.Spin();
            Console.WriteLine("Result: {0}", _roulette.GetResult());
        }

        public void PayUp()
        {
            var result = _roulette.GetResult();

            foreach (var bet in _bets)
            {
                var won = bet.WonAmount(result);
                if(won > 0)
                    uiOutput.PrintString("{0} just won {1}$ on a {2}", bet.PlayerName, won, bet);
            }
        }

    }

    public class RouletteGameException : Exception
    {
        public RouletteGameException(string s) : base(s)
        {
        }
    }
}
