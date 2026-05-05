using FactoryMethod.Criadores;

var online = new CriadorOrcamentoOnline();
Console.WriteLine(online.ProcessarOrcamento("Maria Souza", 1200m));

var presencial = new CriadorOrcamentoPresencial();
Console.WriteLine(presencial.ProcessarOrcamento("Carlos Lima", 3500m));
