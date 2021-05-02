using EmployeeManagement.Models.CustomValidators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Xunit;

namespace EmployeeManagement.Models
{
    public class EditEmployeeModel
    {
        public int EmployeeId { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string FirstName { get; set; }
        [MinLength(2)]
        [Required(ErrorMessage = "FirstName is mandatory")]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [EmailDomainValidator(AllowedDomain = "pragimtech.com")]
        public string ConfirmEmail { get; set; }
        [CompareProperty("Email", ErrorMessage = "Email and Confirm Email must match")]
        public DateTime DateOfBrith { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public string PhotoPath { get; set; }
        [ValidateComplexType]
        public Department Department { get; set; } = new Department();

    }
}