using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using STAPP.Domain.Bases;
using STAPP.Domain.Categorias;

namespace STAPP.Domain.Produtos;

[Table("Produto")]
public class Produto : BaseEntity
{
    [Column("Nome")]
    [Required]
    [StringLength(150)]
    public string Nome { get; set; } 
    
    [Column("Preco")]
    [Required]
    [Range(1, 10000)]
    public decimal Preco { get; set; }
    
    [Column("Descricao")]
    [StringLength(500)]
    public string Descricao { get; set; }
    
    [Column("UrlImagem")]
    [StringLength(300)]
    public string UrlImagem { get; set; }
    
    [ForeignKey("IdCategoria")]
    [Required]
    public Categoria Categoria { get; set; }
}