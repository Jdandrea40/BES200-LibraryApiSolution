using AutoMapper;
using LibraryApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApi.Models.Reservations;

namespace LibraryApi.AutomapperProfiles
{
    public class AutomapperReservationsProfiles : Profile
    {
        public AutomapperReservationsProfiles()
        {
            CreateMap<BookReservation, GetReservationsSummaryResponseItem>();
        }
    }
}
