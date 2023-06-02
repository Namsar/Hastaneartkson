using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HastaneYönetimSistemi;

public class UserValidator : AbstractValidator<User>
{
    public UserValidator()
{
    RuleFor(user => user.Ad)
        .NotEmpty().WithMessage("Ad alanı gereklidir.")
        .Length(2, 50).WithMessage("Ad alanı 2 ile 50 karakter arasında olmalıdır.");

    RuleFor(user => user.Soyad)
        .NotEmpty().WithMessage("Soyad alanı gereklidir.")
        .Length(2, 50).WithMessage("Soyad alanı 2 ile 50 karakter arasında olmalıdır.");

    RuleFor(user => user.Email)
        .NotEmpty().WithMessage("E-posta adresi gereklidir.")
        .EmailAddress().WithMessage("Geçersiz e-posta adresi.");

    RuleFor(user => user.TCKimlikNo)
        .NotEmpty().WithMessage("TC kimlik numarası gereklidir.")
        .Length(11).WithMessage("TC kimlik numarası 11 karakter olmalıdır.");

    RuleFor(user => user.Parola)
        .NotEmpty().WithMessage("Parola gereklidir.")
        .MinimumLength(6).WithMessage("Parola en az 6 karakter olmalıdır.");
}
}
