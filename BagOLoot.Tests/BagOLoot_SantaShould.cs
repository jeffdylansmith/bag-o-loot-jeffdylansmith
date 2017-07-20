using System;
using System.Collections.Generic;
using Xunit;

namespace BagOLoot.Tests
{
    public class SantaClausShould
    {
        SantaClaus _santa = new SantaClaus();
        public SantaClausShould()
        {
            _santa = new SantaClaus();
        }
        [Fact]
        public void SantaChecksHisListTwice()
        {
            int childId = 322;
            List<int> listId = _santa.CheckSantasList(childId);
            Assert.IsType<List<int>>(listId);
        }

        [Fact]
        public void SantaChecksAKidOffHisList()
        {
            int childId = 32;
            Assert.True (_santa.CheckOffList(childId));
        }

        [Fact]
        public void YuletideReportShould()
        {
            int childId = 32;
            int toyId = 56;
            List<int> report = _santa.YuletideReport(childId, toyId);
            Assert.IsType<List<int>>(report);
        }
    }
}