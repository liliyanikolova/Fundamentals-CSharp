namespace BoatRacingSimulator.Models.BoatModels.MotorBoats
{
    using BoatRacingSimulator.Interfaces;

    public class PowerBoat : MotorBoats
    {
        private IBoatEngine secondBoatEngine;

        public PowerBoat(string model, int weight, IBoatEngine firstBoatEngine, IBoatEngine secondBoatEngine)
            : base(model, weight, firstBoatEngine)
        {
            this.SecondBoatEngine = secondBoatEngine;
        }

        public IBoatEngine SecondBoatEngine
        {
            get
            {
                return this.secondBoatEngine;
            }

            private set
            {
                this.secondBoatEngine = value;
            }
        }

        public override double CalculateRaceSpeed(IRace race)
        {
            var speed = this.BoatEngine.Output + this.SecondBoatEngine.Output - this.Weight + (race.OceanCurrentSpeed / 5d);
            return speed;
        }
    }
}
