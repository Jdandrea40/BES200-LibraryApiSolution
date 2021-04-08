using LibraryApi.Models.Reservations;
using System.Threading.Tasks;

namespace LibraryApi
{
    public interface IReservationCommands
    {
        Task<GetReservationsSummaryResponseItem> AddReservationAsync(PostReservationRequest request);
    }
}