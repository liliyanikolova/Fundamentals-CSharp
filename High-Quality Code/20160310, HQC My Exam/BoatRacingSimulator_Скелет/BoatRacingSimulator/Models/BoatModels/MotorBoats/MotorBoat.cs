namespace BoatRacingSimulator.Models.BoatModels.MotorBoats
{
    using BoatRacingSimulator.Interfaces;

    public abstract class MotorBoats : Boat
    {
        private IBoatEngine boatEngine;

        protected MotorBoats(string model, int weight, IBoatEngine boatEngine)
            : base(model, weight)
        {
            this.BoatEngine = boatEngine;
        }

        public IBoatEngine BoatEngine
        {
            get
            {
                return this.boatEngine;
            }

            private set
            {
                this.boatEngine = value;
            }
        }
    }
}
