
using ErrorOr;

namespace BuberBreakfast.Models.ServiceErrors;

public static class Errors
{
   public static class Breakfast
   {
        public static Error InvalidName => Error.Validation(
            code: "Breakfast.InvalidName",
            description: $"Breakfast name must be at least {Models.Breakfast.MinNameLength} character long and at most {Models.Breakfast.MaxNameLength} character long."
        );

        public static Error InvalidDescription => Error.Validation(
            code: "Breakfast.InvalidDescription",
            description: $"Breakfast name must be at least {Models.Breakfast.MinDescriptionLength} character long and at most {Models.Breakfast.MaxDescriptionLength} character long."
        );

        public static Error NotFound => Error.NotFound(
            code: "Breakfast.NotFound",
            description: "Breakfast not found."
        );
   }
}
