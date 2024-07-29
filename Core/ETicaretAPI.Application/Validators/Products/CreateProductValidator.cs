using ETicaretAPI.Application.ViewModels.Products;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen ürün adını boş geçmeyiniz.")
                .MaximumLength(150)
                .MinimumLength(5)
                .WithMessage("lütfen ürün adını 5 ile 150 karakter arası giriniz.");

            RuleFor(p => p.stock)
                .NotEmpty()
                .NotNull().
                    WithMessage("lütfen stok bilgisini boş geçmeyiniz")
                    .Must(s => s >= 0)
                        .WithMessage("stok bilgisi negatif olamaz");

            RuleFor(p => p.price)
             .NotEmpty()
             .NotNull().
                 WithMessage("lütfen stok bilgisini boş geçmeyiniz")
                 .Must(s => s >= 0)
                     .WithMessage("fiyat bilgisi negatif olamaz");

        }
    }
}
