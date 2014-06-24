﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saintelague
{
    public class ElectionResult
    {
        private List<Party> parties = new List<Party>();
        private int seatsRemaining = 120;

        public ElectionResult() { }
        public ElectionResult(int TotalSeats) { this.seatsRemaining = TotalSeats; }

        public void AddParty(Party party) { parties.Add(party); }

        public void CalculateSeats()
        {
            while (this.seatsRemaining > 0)
            {
                parties.OrderByDescending(pp => pp.quot()).First().AddSeat();
                this.seatsRemaining--;
            }
        }

        public int SeatsCalculated(int PartyNumber)
        {
            Party p = parties.Find(xx => xx.GetPartyNumber() == PartyNumber);
            return p.GetSeats();
        }
    }

    public class Party
    {
        private int votes;
        private int partyNumber;
        private int seats = 0;
        private int electriteSeats;

        public Party(int Votes, int PartyNumber, int ElectriteSeats)
        {
            this.votes = Votes;
            this.partyNumber = PartyNumber;
            this.electriteSeats = ElectriteSeats;
        }

        public Party(int Votes, int PartyNumber)
        {
            this.votes = Votes;
            this.partyNumber = PartyNumber;
            this.electriteSeats = 0;
        }

        public double quot()
        {
            return (double)(this.votes / (2 * this.seats + 1));
        }

        public void AddSeat()
        {
            this.seats++;
        }

        public int GetSeats()
        {
            if (this.seats > this.electriteSeats)
            {
                return this.seats;
            }
            else
            {
                return this.electriteSeats;
            }
        }

        public int GetPartyNumber() { return this.partyNumber; }
    }
}
