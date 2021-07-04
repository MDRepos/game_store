
using System;

namespace dotnet_backend.Common
{
    public interface IDateTimeProvider
    {
        DateTime Now();
    }
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime Now() => DateTime.Now;
    }
}