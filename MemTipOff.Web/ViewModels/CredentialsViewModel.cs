
using MemTipOff.Web.ViewModels.Validations;
using FluentValidation.Attributes;

namespace MemTipOff.Web.ViewModels
{
    [Validator(typeof(CredentialsViewModelValidator))]
    public class CredentialsViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
