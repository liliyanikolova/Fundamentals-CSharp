namespace BoatRacingSimulator.Core
{
    using System;
    using System.Linq;
    using BoatRacingSimulator.Interfaces;

    public class Engine : IEngine
    {
        private ICommandHandler commandHandler;

        public Engine(ICommandHandler commandHandler)
        {
            this.CommandHandler = commandHandler;
        }

        public ICommandHandler CommandHandler
        {
            get
            {
                return this.commandHandler;
            }

            private set
            {
                this.commandHandler = value;
            }
        }

        public void Run()
        {
            while (true)
            {
                string line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                {
                    break;
                }

                var tokens = line.Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var parameters = tokens.Skip(1).ToArray();

                try
                {
                    string commandResult = this.CommandHandler.ExecuteCommand(name, parameters);
                    Console.WriteLine(commandResult);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
