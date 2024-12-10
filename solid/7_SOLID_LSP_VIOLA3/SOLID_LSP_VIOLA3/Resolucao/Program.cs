using SOLID_LSP3;

PassarosVoadores passaro1 = new Pato("Donaldo");
passaro1.Comer();
passaro1.BotarOvos();
passaro1.Voar();

Passaro passaro2 = new Pinguim("Willy");
passaro2.BotarOvos();
passaro2.Comer();

Console.ReadKey();
