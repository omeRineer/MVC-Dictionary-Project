using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class ContactRules:AbstractValidator<Contact>
    {
        public ContactRules()
        {
            RuleFor(x => x.UserName).MaximumLength(50).NotEmpty();
            RuleFor(x => x.UserEmail).MaximumLength(50).NotEmpty();
            RuleFor(x => x.Subject).MaximumLength(50).NotEmpty();
            RuleFor(x => x.Message).MaximumLength(1000).NotEmpty();
        }
    }
}
