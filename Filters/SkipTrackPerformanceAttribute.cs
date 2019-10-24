using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace Logging.Filters
{
    public sealed class SkipTrackPerformanceAttribute : Attribute, IFilterMetadata
    {
    }
}
