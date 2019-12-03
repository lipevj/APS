using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_API.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
        [MaxLength(150)]
        public string Email { get; set; }
        public string Consumo { get; set; }
    }
}
