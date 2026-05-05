using Singleton;

var config1 = ConfiguracaoSistema.Instancia;
var config2 = ConfiguracaoSistema.Instancia;

Console.WriteLine($"São a mesma instância: {ReferenceEquals(config1, config2)}");
Console.WriteLine($"Configuração: {config1}");

config1.DiasValidadeOrcamento = 15;
config1.MoedaPadrao = "USD";

Console.WriteLine($"\nApós alteração via config1:");
Console.WriteLine($"config2 reflete a mudança: {config2}");
