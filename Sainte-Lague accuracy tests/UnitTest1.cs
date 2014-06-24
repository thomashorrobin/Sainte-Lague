using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using saintelague;

namespace Sainte_Lague_accuracy_tests
{
    [TestClass]
    public class PastElectionResults
    {
        [TestMethod]
        public void Election2011()
        {
            ElectionResult er = new ElectionResult();
            er.AddParty(new Party(1058636, 1));
            er.AddParty(new Party(614937, 2));
            er.AddParty(new Party(247372, 3));
            er.AddParty(new Party(147544, 4));
            er.AddParty(new Party(31982, 5, 3));
            er.AddParty(new Party(24168, 6, 1));
            er.AddParty(new Party(23889, 7, 1));
            er.AddParty(new Party(13443, 8, 1));
            er.AddParty(new Party(59237, 9, 0));
            er.CalculateSeats();
            Assert.IsTrue(er.GetSeatsCalculated(1) == 59, "Hasn't worked for National");
            Assert.IsTrue(er.GetSeatsCalculated(2) == 34, "Hasn't worked for Labour");
            Assert.IsTrue(er.GetSeatsCalculated(3) == 14);
            Assert.IsTrue(er.GetSeatsCalculated(4) == 8);
            Assert.IsTrue(er.GetSeatsCalculated(5) == 3, "Hasn't worked for the Maori Party");
            Assert.IsTrue(er.GetSeatsCalculated(6) == 1);
            Assert.IsTrue(er.GetSeatsCalculated(7) == 1);
            Assert.IsTrue(er.GetSeatsCalculated(8) == 1);
            Assert.IsTrue(er.GetSeatsCalculated(9) == 0, "Conservative party shouldn't get any seats");
        }

        [TestMethod]
        public void Election2008()
        {
            ElectionResult er = new ElectionResult();
            er.AddParty(new Party(1053398, 1));
            er.AddParty(new Party(796880, 2));
            er.AddParty(new Party(157613, 3));
            er.AddParty(new Party(55980, 4, 5));
            er.AddParty(new Party(21241, 5, 1));
            er.AddParty(new Party(85496, 6, 1));
            er.AddParty(new Party(20497, 7, 1));
            er.CalculateSeats();
            Assert.IsTrue(er.GetSeatsCalculated(1) == 58, "Hasn't worked for National");
            Assert.IsTrue(er.GetSeatsCalculated(2) == 43, "Hasn't worked for Labour");
            Assert.IsTrue(er.GetSeatsCalculated(3) == 9);
            Assert.IsTrue(er.GetSeatsCalculated(4) == 5, "Hasn't worked for the Maori Party");
            Assert.IsTrue(er.GetSeatsCalculated(5) == 1);
            Assert.IsTrue(er.GetSeatsCalculated(6) == 5);
            Assert.IsTrue(er.GetSeatsCalculated(7) == 1);
        }
    }
}
