

using Domain.Entities;
using FluentValidation;

namespace Aplication.Common.Validator
{
    public  class Uservalidator:AbstractValidator<User>
    {
        public Uservalidator()
        {
            RuleFor(x => x.FullName).NotEmpty()
                .WithMessage("Ism bolishi kerak").
                Length(3, 50)
                .WithMessage("3 va 50 orasida bolishi kerak");
            RuleFor(x => x.Email).NotEmpty()
                .EmailAddress()
               .WithMessage("Email bolishi kerak").
               Length(3, 50)
               .WithMessage("3 va 100 orasida bolishi kerak");
            RuleFor(x => x.Adress).NotEmpty()
               .WithMessage("Adress bolishi kerak").
               Length(3, 50)
               .WithMessage("3 va 100 orasida bolishi kerak");
            RuleFor(x => x.Password).NotEmpty()
               .WithMessage("password bolishi kerak").
               Length(3, 50)
               .WithMessage("3 va 100 orasida bolishi kerak");
            RuleFor(x => x.Role).NotEmpty()
               .WithMessage("Role bolishi kerak");
            RuleFor(x => x.Gender).NotEmpty()
               .WithMessage("Gender bolishi kerak");
               

        }
    }
}
