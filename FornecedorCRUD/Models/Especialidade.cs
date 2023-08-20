using System.ComponentModel.DataAnnotations;

namespace FornecedorCRUD.Models
{
    public enum Especialidade
    {
        [Display(Name = "Comércio")]
        Comercio = 0,

        [Display(Name = "Serviço")]
        Servico = 1,

        [Display(Name = "Indústria")]
        Industria = 2
    }
}