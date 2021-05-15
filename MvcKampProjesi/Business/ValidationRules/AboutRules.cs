using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class AboutRules:AbstractValidator<About>
    {
        public AboutRules()
        {
            RuleFor(x => x.AboutDetails1).MaximumLength(1000).NotEmpty();
            RuleFor(x => x.AboutDetails2).MaximumLength(1000).NotEmpty();
            RuleFor(x => x.AboutImage1).MaximumLength(100).NotEmpty();
            RuleFor(x => x.AboutImage2).MaximumLength(100).NotEmpty();
        }
    }
}
