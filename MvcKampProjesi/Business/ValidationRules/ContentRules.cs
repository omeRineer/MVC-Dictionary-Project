using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class ContentRules:AbstractValidator<Content>
    {
        public ContentRules()
        {
            RuleFor(x => x.ContentValue).MaximumLength(1000).NotEmpty();
        }
    }
}
