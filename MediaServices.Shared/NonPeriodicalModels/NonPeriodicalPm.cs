using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaServices.Shared.NonPeriodicalModels;
public class NonPeriodicalPm
{
    public int Id { get; set; }

    public DateTime AddedDate { get; set; }

    public string AfterWatchedNotes { get; set; }

    public string BeforeWatchedNotes { get; set; }

    [Required, MaxLength(128)]
    public string Name { get; set; }

    public int Link { get; set; }

    public int LinkText { get; set; }

    public NonPeriodicalType NonPeriodicalType { get; set; }

    public bool Watched { get; set; }

    public bool WorthWatching { get; set; }
}
