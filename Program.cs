Console.Clear();

Console.Write($"Início: ");
int inicio = Convert.ToInt32(Console.ReadLine()!);

Console.Write($"Fim: ");
int fim = Convert.ToInt32(Console.ReadLine()!);

string mensagem = "";

try
{
    if (fim < inicio)
        throw new Exception("O segundo número não pode ser menor que o primeiro");

    while (fim >= inicio)
    {
        mensagem += $"{inicio++} ";
    }
    exibirMensagemSucesso(mensagem);
}
catch (Exception e)
{
    exibirMensagemErro(e.Message);
}
finally
{
    Console.ResetColor();
    Console.WriteLine("Obrigado por utilizar o programa!");
}

void exibirMensagemErro(string mensagem)
{
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(mensagem);
}

void exibirMensagemSucesso(string mensagem)
{
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(mensagem);
}