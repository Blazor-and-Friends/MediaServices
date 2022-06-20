using MediaServices.Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaServices.Backend.Data;
public interface IMediaContextService
{
    DbSet<Nonperiodical> Nonperiodicals { get; set; }
}
