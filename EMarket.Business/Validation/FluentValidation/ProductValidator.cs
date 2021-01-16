using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMarket.Business.Messages;
using EMarket.Entity.Concrete;
using FluentValidation;

namespace EMarket.Business.Validation.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).Length(3, 20).NotEmpty().WithMessage(ErrorMessages.LengthMessage(3,20));
            RuleFor(p => p.UnitPrice).GreaterThan(0).WithMessage(ErrorMessages.GreaterThanZeroMessage);
            RuleFor(p => p.StockAmount).GreaterThanOrEqualTo((short) 0).WithMessage(ErrorMessages.GreaterThanOrEqualToZeroMessage);
            RuleFor(p => p.CategoryId).InclusiveBetween(1, 4).WithMessage(ErrorMessages.ExclusiveBetween(1,4));
            //RuleFor(p => p.ProductName).Must(StartWithA).When(p=>p.CategoryId==1).WithMessage("Must start with a");
        }

        //private bool StartWithA(string arg)
        //{
        //    return arg.ToLower().StartsWith("a");
        //}
    }
}
