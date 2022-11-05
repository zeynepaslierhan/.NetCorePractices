using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator: AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Başlığı Boş Geçilemez");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Blog Başlığı 5 karakterden az olamaz.");

            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog İçeirği Boş Geçilemez");
            RuleFor(x => x.BlogContent).MaximumLength(200).WithMessage("Blog İçeriği 200 karakterden fazla olamaz.");
            RuleFor(x => x.BlogContent).MinimumLength(30).WithMessage("Blog İçeriği 30 karakterden az olamaz.");
        }
    }
}
