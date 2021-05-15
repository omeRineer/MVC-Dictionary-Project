using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class WriterRules:AbstractValidator<Writer>
    {
        public WriterRules()
        {
            RuleFor(x => x.WriterName).MaximumLength(50).NotEmpty();
            RuleFor(x => x.WriterSurname).MaximumLength(50).NotEmpty();
            RuleFor(x => x.WriterImage).MaximumLength(100).NotEmpty();
            RuleFor(x => x.WriterEmail).MaximumLength(50).NotEmpty();
            RuleFor(x => x.WriterPassword).MaximumLength(20).NotEmpty();
        }
    }
}
