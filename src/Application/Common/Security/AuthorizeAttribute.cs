using System;

namespace Randevu.Application.Common.Security;

// Specifies the class this attribute is applied to requires authorization.
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
public class AuthorizeAttribute : Attribute
{
    // Initializes a new instance of the AuthorizeAttribute class.
    public AuthorizeAttribute()
    {
    }

    // Gets or sets a comma delimited list of roles that are allowed to access the resource.
    public string Roles { get; set; } = string.Empty;

    // Gets or sets the policy name that determines access to the resource.
    public string Policy { get; set; } = string.Empty;
}