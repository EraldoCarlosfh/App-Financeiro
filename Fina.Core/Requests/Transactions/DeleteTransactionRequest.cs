using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Transactions;

public class DeleteTransactionRequest : Request
{
    [Required(ErrorMessage = "Id do usuário é inválido")]
    public long Id { get; set; }
}
