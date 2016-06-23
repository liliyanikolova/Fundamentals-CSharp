namespace BoatRacingSimulator.Interfaces
{
    public interface IBoatEngine : IModelable
    {
        int Output { get; }

        int Horsepower { get;  }

        int Displacement { get; }
    }
}
