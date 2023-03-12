using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STAPP.Domain.Bases;

public class BaseEntity
{
    [Key]
    [Column("id")]
    public long Id { get; set; }
}