using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRUDPOC.Models;

public partial class User
{
    public string? Name { get; set; }
    [Range(18, 100)]
    [Required(ErrorMessage = "rating from 18 to 100")]
    public int? Age { get; set; }

    public string? Gender { get; set; }
    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid Email Address.")]

    public string? Email { get; set; }

    public long? PhoneNumber { get; set; }

    public string? Image { get; set; }

    public long Id { get; set; }
}
