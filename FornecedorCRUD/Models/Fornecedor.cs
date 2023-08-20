using System.ComponentModel.DataAnnotations;

namespace FornecedorCRUD.Models
{
    public class Fornecedor
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = "Nome deve conter no máximo 100 caracteres.")]
        [Required(ErrorMessage = "Campo Nome não deve ser nulo.")]
        public string Nome { get; set; }

        [RegularExpression(@"(^\d{2}\.?\d{3}\.?\d{3}\/?\d{4}\-?\d{2}$)", ErrorMessage = "CNPJ deve conter 14 caracteres.")]
        [Required(ErrorMessage = "Campo CNPJ não deve ser nulo.")]
        public long CNPJ { get; set;}

        [Required(ErrorMessage = "Campo especialidade não deve ser nulo.")]
        public Especialidade Especialidade { get; set; }

        [RegularExpression("(^[0-9]{5})-?([0-9]{3}$)", ErrorMessage = "CEP deve conter 8 caracteres.")]
        [Required(ErrorMessage = "Campo CEP não deve ser nulo.")]
        public long CEP { get; set; }

        [MaxLength(255, ErrorMessage = "Endereço deve conter no máximo 255 caracteres.")]
        [Required(ErrorMessage = "Campo Endereço não deve ser nulo.")]
        public String Endereco { get; set; } 
    }
}
