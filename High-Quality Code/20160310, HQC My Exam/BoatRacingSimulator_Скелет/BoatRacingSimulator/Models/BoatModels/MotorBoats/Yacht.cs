namespace BoatRacingSimulator.Models.BoatModels.MotorBoats
{
    using BoatRacingSimulator.Interfaces;
    using BoatRacingSimulator.Utility;

    public class Yacht : MotorBoats
    {
        private int cargoWeight;
        
        public Yacht(string model, int weight, int cargoWeight, IBoatEngine boatEngine)
            : base(model, weight, boatEngine)
        {
            this.CargoWeight = cargoWeight;
        }

        public int CargoWeight
        {
            get
            {
                return this.cargoWeight;
            }

            private set
            {
                Validator.ValidatePropertyValue(value, "Cargo Weight");
                this.cargoWeight = value;
            }
        }

        public override double CalculateRaceSpeed(IRace race)
        {
            var speed = this.BoatEngine.Output - (this.Weight + this.CargoWeight) + (race.OceanCurrentSpeed / 2d);
            return speed;
        }
    }
}
