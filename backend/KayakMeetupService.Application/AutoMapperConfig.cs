using AutoMapper;

namespace KayakMeetupService
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig() 
        {
            //Enums
            CreateMap<Application.Models.State, Application.Models.State> ();

            //User info
            CreateMap<Application.Models.User, Data.Models.User>();
            CreateMap<Data.Models.User, Application.Models.User>();
            CreateMap<Application.Models.Boat, Data.Models.Boat>();

            //Boat info
            CreateMap<Application.Models.Event, Data.Models.Event>();
            CreateMap<Application.Models.EventType, Data.Models.EventType>();
        }
    }
}
