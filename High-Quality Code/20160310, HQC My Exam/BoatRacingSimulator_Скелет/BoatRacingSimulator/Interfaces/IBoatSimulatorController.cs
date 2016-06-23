namespace BoatRacingSimulator.Interfaces
{
    using BoatRacingSimulator.Enumerations;

    public interface IBoatSimulatorController
    {
        IRace CurrentRace { get; }

        IBoatSimulatorDatabase Database { get; }

        /// <summary>
        /// Creates Boat Engine
        /// </summary>
        /// <param name="model">Engine model</param>
        /// <param name="horsepower">Engine horsepower</param>
        /// <param name="displacement">Engine displacement</param>
        /// <param name="engineType">Engine type</param>
        /// <returns>Returns sucessful message. If engine type is not Jet or Sterndrive, throw NotImplementedException.</returns>
        string CreateBoatEngine(string model, int horsepower, int displacement, EngineType engineType);

        string CreateRowBoat(string model, int weight, int oars);

        string CreateSailBoat(string model, int weight, int sailEfficiency);

        string CreatePowerBoat(string model, int weight, string firstEngineModel, string secondEngineModel);

        string CreateYacht(string model, int weight, string engineModel, int cargoWeight);

        string OpenRace(int distance, int windSpeed, int oceanCurrentSpeed, bool allowsMotorboats);

        /// <summary>
        /// Sign up boat to current race.
        /// </summary>
        /// <param name="model">Boat model</param>
        /// <returns>Returns sucessful message. If current race does not allow boats with engine and the sign up boat is with engine, throw ArgumentException.</returns>
        string SignUpBoat(string model);

        string StartRace();

        string GetStatistic();
    }
}
