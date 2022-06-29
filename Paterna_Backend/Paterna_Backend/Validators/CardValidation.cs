using FluentValidation;
using Paterna_Backend.Models;

namespace Paterna_Backend.Validators
{
    public class CardValidation:AbstractValidator<ServicesCard>
    {
        public CardValidation()
        {
            RuleFor(c => c.IconPath).NotEmpty().NotNull();
            RuleFor(c => c.Name).NotEmpty().NotNull();
            RuleFor(c => c.Description).NotNull().NotEmpty().MinimumLength(5);
        }
    }
}
