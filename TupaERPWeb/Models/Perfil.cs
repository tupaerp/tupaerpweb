using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TupaERPWeb.Models
{
    [Table("PERFIL")]
    public class Perfil : Entity
    {
       
       
        [Column("DESCRICAO")]
        public required string Descricao { get; set; }

        
    }
}
