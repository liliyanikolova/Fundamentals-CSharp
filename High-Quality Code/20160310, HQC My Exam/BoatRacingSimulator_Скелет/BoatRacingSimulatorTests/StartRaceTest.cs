namespace BoatRacingSimulatorTests
{
    using BoatRacingSimulator.Controllers;
    using BoatRacingSimulator.Exceptions;
    using BoatRacingSimulator.Interfaces;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class StartRaceTest
    {
        private IBoatSimulatorController Contoller { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            this.Contoller = new BoatSimulatorController();
        }

        [ExpectedException(typeof(InsufficientContestantsException))]
        [TestMethod]
        public void StartRace_WithCorrectInput_ShouldThrowInsufficientContestantsException()
        {
            
        }
    }
}
