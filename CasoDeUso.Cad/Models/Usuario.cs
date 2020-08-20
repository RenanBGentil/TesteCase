using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CasoDeUso.Cad.Models
{
    public class Usuario
    {
        [Required]
        [MaxLength(150)]
        public string Nome { get; set; }

        [Required]
        public string Cpf { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public DateTime DataCadastro { get; set; }

        public decimal Renda { get; set; }

        public int id { get; set; }
    }
}
