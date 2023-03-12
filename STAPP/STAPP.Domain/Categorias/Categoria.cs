using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using STAPP.Domain.Bases;

namespace STAPP.Domain.Categorias;

public class Categoria : BaseEntity
{
    [Column("Nome")]
    [Required]
    [StringLength(150)]
    public string Nome { get; set; }
    
    [Column("Descricao")]
    [StringLength(500)]
    public string Descricao { get; set; }
}