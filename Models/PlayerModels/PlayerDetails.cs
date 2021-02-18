using System;
using System.Collections.Generic;

namespace FPLForecaster.Models
{
    public class PlayerDetails
    {
        public ICollection<PlayerFutureFixture> futureFixtures {get;set;}
        public ICollection<PlayerPastFixture> pastFixtures {get;set;}
        public ICollection<PlayerHistoricalFixture> historicalFixtures {get;set;}
        public ICollection<PlayerFixture> fixtures {get;set;}
    }
}