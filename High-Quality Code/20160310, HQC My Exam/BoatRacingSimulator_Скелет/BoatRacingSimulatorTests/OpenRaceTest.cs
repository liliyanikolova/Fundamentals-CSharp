namespace BoatRacingSimulatorTests
{
    using BoatRacingSimulator.Controllers;
    using BoatRacingSimulator.Exceptions;
    using BoatRacingSimulator.Interfaces;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class OpenRaceTest
    {
        private IBoatSimulatorController Contoller { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            this.Contoller = new BoatSimulatorController();
        }

        [TestMethod]
        public void OpenRace_WithCorrectInput_ShouldReturnSuccessMessage()
        {
            var result = this.Contoller.OpenRace(1500, 150, 10, false);
            string expectedResult = "A new race with distance 1500 meters, wind speed 150 m/s and ocean current speed 10 m/s has been set.";

            Assert.AreEqual(expectedResult, result, "Expected message did not match!");
        }

        [ExpectedException(typeof(RaceAlreadyExistsException))]
        [TestMethod]
        public void OpenRace_WithAlreadyExistingRace_ShouldThrowRaceAlreadyExistsException()
        {
            string firstRace = this.Contoller.OpenRace(1500, 150, 10, false);
            string secondRace = this.Contoller.OpenRace(1600, 150, 10, true);
        }
    }
}
