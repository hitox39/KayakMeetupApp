using KayakMeetupService.Abstractions.Models;

namespace KayakMeetupService.Application.UseCases.EventUseCases
{
    public class AddFishingTournamentEvent
    {
        public Guid Id { get; set; }
        public string CityName { get; set; } = string.Empty;
        public State State { get; set; }
        public int Zip { get; set; }
        public string Address { get; set; } = string.Empty;
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Country { get; set; } = string.Empty;
        public int PrizePool { get; set; }
    }
}
