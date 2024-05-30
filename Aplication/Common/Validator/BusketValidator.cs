using Domain.Entities;
using FluentValidation;

namespace Aplication.Common.Validator
{
    public class BusketValidator:AbstractValidator<Busket>
    {
        public BusketValidator()
        {
            RuleFor(x=>x.UserId).NotEmpty()
                .WithMessage("User id bosh bolmasligi kerak");
            RuleFor(x => x.User).NotEmpty()
                .WithMessage("User tanlangan bolishi kerak");
        }
    }
}
