using BuberBreakfast.Models;
using ErrorOr;

namespace BuberBreakfast.Services.Breakfasts
{
    public interface IBreakfastService
    {
        ErrorOr<Created> CreateBreakfastAsync(Breakfast breakfasts);
        ErrorOr<Deleted> DeleteBreakfast(Guid id);
        ErrorOr<Breakfast> GetBreakfast(Guid id);
        Breakfast[] GetBreakfasts();
        ErrorOr<UpsertBreakfast> UpsertBreakfastAsync(Breakfast breakfast);
    }
}