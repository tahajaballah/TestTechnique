using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationTEST.Models
{
    [Table("Personne")]
    public class Personne
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonneId { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public DateTime DateDeNaissance { get; set; }
    }
}
