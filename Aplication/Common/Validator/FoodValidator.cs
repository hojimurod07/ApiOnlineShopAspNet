using Domain.Entities;
using FluentValidation;

namespace Aplication.Common.Validator
{
    public class FoodValidator:AbstractValidator<Food>
    {
        public FoodValidator()
        {
            RuleFor(x => x.Name).NotEmpty()
                .WithMessage("Name bosh bolmasligi kerak")
                .Length(3, 50)
                .WithMessage("Ism 3 va 50 orasida bolishi kerak");
            RuleFor(x => x.Description).NotEmpty()
                .WithMessage("Description bosh bolmasligi kerak")
                .Length(3, 200)
                .WithMessage("Description 3 va 200 orasida bolishi kerak");
            RuleFor(x => x.Price).NotEmpty()
                .WithMessage("Narx bolishi kerak");
            RuleFor(x => x.Category).NotEmpty()
                .WithMessage("Category bolishi kerak");
            RuleFor(x => x.CategoryId).NotEmpty()
                .GreaterThan(0)
                .WithMessage("0 dan katta  bolishi kerak"); 
           

        }
    }
}
