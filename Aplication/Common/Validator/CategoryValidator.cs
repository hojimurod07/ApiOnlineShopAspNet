

using Domain.Entities;
using FluentValidation;

namespace Aplication.Common.Validator
{
    public  class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty()
                .WithMessage("Name mast be null")
                .Length(3, 50)
                .WithMessage("Name mast be between 3 and 50 ");

        }
    }
}
