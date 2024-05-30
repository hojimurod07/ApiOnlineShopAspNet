using Domain.Entities;
using FluentValidation;

namespace Aplication.Common.Validator
{
    public class OrderItemValidator:AbstractValidator<OrderItem>
    {
        public OrderItemValidator()
        {
            RuleFor(x=>x.BusketId).NotEmpty()
                .WithMessage("Nusket id bolishi kerak");
            RuleFor(x => x.Amount).NotEmpty()
                .WithMessage("Nusket id bolishi kerak")
                .GreaterThan(0)
                .WithMessage("Amount 0 dan katta bolishi kerak");
              

        }
    }
}
