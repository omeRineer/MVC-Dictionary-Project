using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class HeadingRules:AbstractValidator<Heading>
    {
        public HeadingRules()
        {
            RuleFor(x => x.HeadingName).MaximumLength(100).NotEmpty();
        }
    }
}
