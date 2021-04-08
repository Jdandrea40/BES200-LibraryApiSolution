using LibraryApi.Domain;
using System.Threading.Tasks;

namespace LibraryApi
{
    public interface IProcessReservations
    {
        Task AddWorkAsync(BookReservation reservation);
    }
}