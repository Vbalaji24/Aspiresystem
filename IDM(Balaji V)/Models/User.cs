using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using IdentityManagement.Models;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;

public class User{
  [Required(ErrorMessage = "Email is required.")]
  [EmailAddress]
  public string? EmailId{get;set;}

  [Required(ErrorMessage = "Password is required.")]
  [DataType(DataType.Password)]
  public string? userPassword{get;set;}
    public bool KeepLoggedIn { get; internal set; }
}
