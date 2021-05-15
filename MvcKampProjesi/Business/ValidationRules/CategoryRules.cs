using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class CategoryRules:AbstractValidator<Category>
    {
        public CategoryRules()
        {
            RuleFor(x => x.CategoryName).MaximumLength(50).NotEmpty();
            RuleFor(x => x.CategoryDescription).MaximumLength(200).NotEmpty();
            RuleFor(x => x.CategoryName).MinimumLength(3);
        }
    }
}
