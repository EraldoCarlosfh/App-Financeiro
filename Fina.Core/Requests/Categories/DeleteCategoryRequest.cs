using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Categories;

public class DeleteCategoryRequest : Request
{
    [Required(ErrorMessage = "Id do usuário é inválido")]
    public long Id { get; set; }
}
