using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBankApp.Share.DTOs.CreationDto
{
    public class AccountCreationDto
    {
        [Required(ErrorMessage = "Please provide a first name.")]
        [StringLength(50, ErrorMessage = "First name must not exceed 50 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please provide a last name.")]
        [StringLength(50, ErrorMessage = "Last name must not exceed 50 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please provide a user email.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string UserEmail { get; set; }

        [Phone(ErrorMessage = "Invalid phone number.")]
        public string PhoneNumber { get; set; }
        /* public AccountType AccountType { get; set; }*/
    }
}
