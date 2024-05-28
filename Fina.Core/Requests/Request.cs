namespace Fina.Core.Requests;

//abstract => proibe que seja criada uma nova instância da Request
//sealed abstract => proibe que a Request seja herdade e não deixa criar uma nova instância da Request
public abstract class Request
{
    public string UserId { get; set; } = string.Empty;
}
