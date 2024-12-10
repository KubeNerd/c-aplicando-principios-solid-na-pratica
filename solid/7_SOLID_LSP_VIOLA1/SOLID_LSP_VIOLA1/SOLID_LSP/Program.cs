using SOLID_LSP;

Funcionario funci1 = new Gerente("Paulo", "Cargo");
Console.WriteLine(funci1.GetType());

Funcionario funci2 = new Vendedor("Paulo", "Cargo");
Console.WriteLine(funci2.GetType());

Console.WriteLine("Salário do Gerente");
var salario1 = funci1.CalculaSalario(5000);
Console.WriteLine(salario1);

Console.WriteLine("Salário do Vendedor");
var salario2 = funci2.CalculaSalario(3000);
Console.WriteLine(salario2);


Console.ReadKey();
