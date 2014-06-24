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
            er.AddParty(new Party(24168, 6));
            er.AddParty(new Party(23889, 7));
            er.AddParty(new Party(13443, 8));
            er.CalculateSeats();
            Assert.IsTrue(er.SeatsCalculated(1) == 59, "Hasn't worked for National");
            Assert.IsTrue(er.SeatsCalculated(2) == 34, "Hasn't worked for Labour");
            Assert.IsTrue(er.SeatsCalculated(3) == 14);
            Assert.IsTrue(er.SeatsCalculated(4) == 8);
            Assert.IsTrue(er.SeatsCalculated(5) == 3, "Hasn't worked for the Maori Party");
            Assert.IsTrue(er.SeatsCalculated(6) == 1);
            Assert.IsTrue(er.SeatsCalculated(7) == 1);
            Assert.IsTrue(er.SeatsCalculated(8) == 1);
        }
    }
}
