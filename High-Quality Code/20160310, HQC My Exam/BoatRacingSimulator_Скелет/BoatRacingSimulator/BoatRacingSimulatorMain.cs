namespace BoatRacingSimulator
{
    using BoatRacingSimulator.Controllers;
    using BoatRacingSimulator.Core;
    using BoatRacingSimulator.Database;
    using BoatRacingSimulator.Interfaces;

    public class BoatRacingSimulatorMain
    {
        public static void Main()
        {
            IBoatSimulatorDatabase database = new BoatSimulatorDatabase();
            IBoatSimulatorController controller = new BoatSimulatorController(database);
            ICommandHandler commandHandler = new CommandHandler(controller);
            var engine = new Engine(commandHandler);
            engine.Run();
        }
    }
}
