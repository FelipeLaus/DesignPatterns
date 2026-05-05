namespace Bridge.Formatos
{
    public class FormatoTexto : IFormatoRelatorio
    {
        public string Formatar(string titulo, string conteudo)
        {
            return $"=== {titulo} ===\n{conteudo}";
        }
    }
}
