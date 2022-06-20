using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaServices.Backend.Data;
public class RepoNonPeriodicals<TContext> where TContext : DbContext, IMediaContextService
{
    TContext context_;

    public RepoNonPeriodicals(TContext context, bool track)
    {
        if (!track) context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

        context_ = context;
    }
}
