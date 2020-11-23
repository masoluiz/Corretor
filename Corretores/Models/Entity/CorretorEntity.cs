using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Corretores.Models.Entity
{
    [Table("Corretor")]
    public class CorretorEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CorretorId { get; set; }
        public string Codigo { get; set; }
        public byte Tipo { get; set; }
        [Required(ErrorMessage = "*Campo obrigatório!")]
        public string Nome { get; set; }
        public string Status { get; set; }
        public string Endereco { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Fone { get; set; }

        [Required(ErrorMessage = "*Campo obrigatório!")]
        public string Celular { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime Cadastro { get; set; }
        public DateTime? Nascimento { get; set; }
        [Required(ErrorMessage = "*Campo obrigatório!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "*Campo obrigatório!")]
        public string Senha { get; set; }
        public string Token { get; set; }
    }
}
