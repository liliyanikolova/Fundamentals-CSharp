namespace BoatRacingSimulator.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public interface IRace
    {
        /// <summary>
        /// The distance of the race.
        /// </summary>
        int Distance { get; }

        /// <summary>
        /// The wind speed ot the race.
        /// </summary>
        int WindSpeed { get; }

        /// <summary>
        /// The ocean current speed of the race.
        /// </summary>
        int OceanCurrentSpeed { get; }

        /// <summary>
        /// Contains the information of all registered boats.
        /// </summary>
        Dictionary<string, IBoat> RegisteredBoats { get; }

        /// <summary>
        /// Signifies if motor boats (boats which have an engine) are allowed.
        /// </summary>
        bool AllowsMotorboats { get; }

        /// <summary>
        /// Adds participant to current race and check if a participant with the same Model has already been registered for the race.
        /// </summary>
        /// <param name="boat">Candidate boat.</param>
        void AddParticipant(IBoat boat);

        /// <summary>
        /// Returns the collection of participants sign up to current race.
        /// </summary>
        /// <returns>Collection of participants sign up to current race.</returns>
        IList<IBoat> GetParticipants();
    }
}
