using MediaServices.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaServices.Backend.Models;
public class Nonperiodical
{
    public int Id { get; set; }

    [Column(TypeName = "date")]
    public DateTime AddedDate { get; set; }

    [MaxLength(1024)]
    public string AfterWatchedNotes { get; set; }

    [MaxLength(1024)]
    public string BeforeWatchedNotes { get; set; }

    [Required, MaxLength(128)]
    public string Name { get; set; }

    [MaxLength(256)]
    public int Link { get; set; }

    [MaxLength(128)]
    public int LinkText { get; set; }

    public NonPeriodicalType NonPeriodicalType { get; set; }

    public bool Watched { get; set; }

    public bool WorthWatching { get; set; }
}
