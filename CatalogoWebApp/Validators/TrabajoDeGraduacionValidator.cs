using CatalogoWebApp.Inputs;
using CatalogoWebApp.Models;
using FluentValidation;

namespace CatalogoWebApp.Validators
{
    public class TrabajoDeGraduacionValidator : AbstractValidator<TrabajoDeGraduacionInput>
    {
        public TrabajoDeGraduacionValidator()
        {
            RuleFor(x => x.Titulo)
                .NotEmpty()
                .NotNull()
                .MaximumLength(60);

            RuleFor(x => x.Descripcion)
                .NotEmpty()
                .NotNull()
                .MaximumLength(280);
        }
    }
}
