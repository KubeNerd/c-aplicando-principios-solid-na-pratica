using SOLID_LSP3;

PassarosVoadores passaro1 = new Pato("Donald");
passaro1.BotaOvos();
passaro1.Comer();
passaro1.Voar();

Passaro passaro2 = new Pinguim("Willy");
passaro2.BotaOvos();
passaro2.Comer();

Console.ReadKey();

//List<PassarosVoadores> passaros = new List<PassarosVoadores>();
//passaros.Add(new Pato("Donald"));

//TesteVoar(passaros);

//Console.ReadKey();

//void TesteVoar(List<PassarosVoadores> passaros)
//{
//    foreach (var passaro in passaros)
//    {
//        passaro.Voar();
//    }
//}
