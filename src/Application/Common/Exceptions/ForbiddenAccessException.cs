using System;

namespace Randevu.Application.Common.Exceptions;

public class ForbiddenAccessException : Exception
{
    public ForbiddenAccessException() : base()
    {
    }
}