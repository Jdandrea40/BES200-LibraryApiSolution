using LibraryApi.Models.Reservations;
using System.Threading.Tasks;

namespace LibraryApi
{
    public interface ILookupReservations
    {
        Task<GetReservationSummaryResponse> GetAllReservationsAsync();
        Task<GetReservationsSummaryResponseItem> GetByIdAsync(int id);
    }
}