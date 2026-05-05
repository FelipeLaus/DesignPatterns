namespace Bridge.Formatos
{
    public class FormatoCsv : IFormatoRelatorio
    {
        public string Formatar(string titulo, string conteudo)
        {
            return $"titulo,conteudo\n\"{titulo}\",\"{conteudo}\"";
        }
    }
}
