using ca_loyalty.Application.Common.Interfaces;

namespace ca_loyalty.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
