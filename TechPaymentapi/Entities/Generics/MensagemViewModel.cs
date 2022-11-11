namespace Entities.Generics
{
    public class MensagemViewModel
    {
        public bool executouServico { get; set; }
        public DateTime dtHoraRetorno { get; set; }
        public string mensagemFalha { get; set; }
        public string mensagemSucesso { get; set; }
        public int codigo { get; set; }
    }
}
