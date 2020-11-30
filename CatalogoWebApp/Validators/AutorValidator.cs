
using CatalogoWebApp.Models;
using FluentValidation;

namespace CatalogoWebApp.Validators
{
    public class AutorValidator : AbstractValidator<Autor>
    {
        public AutorValidator()
        {
            RuleFor(x => x.Codigo)
                .NotEmpty()
                .NotNull()
                .MaximumLength(16);

            RuleFor(x => x.Nombres)
                .NotEmpty()
                .NotNull()
                .MaximumLength(120);

            RuleFor(x => x.Apellidos)
                .NotEmpty()
                .NotNull()
                .MaximumLength(120);
        }
    }
}
