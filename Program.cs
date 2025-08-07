using System.Media;

namespace Aprendizado;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Bem vindo(a) ao App do meu Aprendizado!");
        Console.WriteLine("O que você deseja fazer?");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("1 - App Relógio");
        Console.WriteLine("2 - App Calculadora");
        Console.WriteLine("3 - App Editor de Texto");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("----------------------------------------");

        int res = int.Parse(Console.ReadLine());

        switch (res)
        {
            case 1: MenuRelogio(); break;
            case 2: MenuCalculadora(); break;
            case 3: MenuEditor(); break;
            case 0: Sair(); break;
            default: Menu(); break;
        }
    }

    //APP RELÓGIO
    static void MenuRelogio()
    {
        Console.Clear();
        Console.WriteLine("Bem vindo(a) ao App Relógio!");
        Console.WriteLine("O que você deseja fazer?");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("1 - Cronometro");
        Console.WriteLine("2 - Timer");
        Console.WriteLine("3 - Voltar ao menu principal");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("----------------------------------------");

        int res = int.Parse(Console.ReadLine());

        switch (res)
        {
            case 1: Cronometro(); break;
            case 2: Timer(); break;
            case 3: Menu(); break;
            case 0: Sair(); break;
            default: MenuRelogio(); break;
        }

    }
    static void Cronometro()
    {
        Console.Clear();
        Console.WriteLine("Precione qualquer tecla para começar a contagem, precione novamente quando quiser parar!");
        Console.ReadKey(true);
        bool pressionado = true;
        TimeSpan tempo = TimeSpan.Zero;

        while (pressionado)
        {
            Console.Clear();
            Console.WriteLine(tempo.ToString(@"hh\:mm\:ss"));
            Thread.Sleep(1000);
            tempo = tempo.Add(TimeSpan.FromSeconds(1));


            if (Console.KeyAvailable)
            {
                Console.ReadKey(true);
                pressionado = false;
            }
        }

        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine($"Cronometro parado em {tempo.ToString(@"hh\:mm\:ss")}");
        Thread.Sleep(2000);
        MenuCronometro();
    }
    static void MenuCronometro()
    {
        Console.WriteLine("1 - Nova contagem");
        Console.WriteLine("2 - Voltar ao menu");
        Console.WriteLine("0 - Sair do App");
        int res = int.Parse(Console.ReadLine());

        switch (res)
        {
            case 1: Cronometro(); break;
            case 2: MenuRelogio(); break;
            case 0: Sair(); break;
            default: MenuCronometro(); break;
        }
    }
    static void Timer()
    {
        Console.Clear();
        Console.WriteLine("Digite o tempo no formato hh:mm:ss (ex: 00:01:00 para 1 minuto):");
        TimeSpan tempo = TimeSpan.Parse(Console.ReadLine());

        while (tempo.TotalSeconds > 0)
        {
            Console.Clear();
            Console.WriteLine(tempo.ToString(@"hh\:mm\:ss"));
            Thread.Sleep(1000);
            tempo = tempo.Subtract(TimeSpan.FromSeconds(1));
        }
        Console.Clear();
        Console.WriteLine("Tempo Encerrado!");
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        MenuTimer();
    }
    static void MenuTimer()
    {
        Console.Clear();
        Console.WriteLine("1 - Novo Timer");
        Console.WriteLine("2 - Voltar ao menu");
        Console.WriteLine("0 - Sair do App");
        int res = int.Parse(Console.ReadLine());

        switch (res)
        {
            case 1: Timer(); break;
            case 2: MenuRelogio(); break;
            case 0: Sair(); break;
            default: MenuTimer(); break;
        }
    }
    static void ChamarSom(String caminho)
    {
        try
        {
            var player = new SoundPlayer(caminho);
            player.PlaySync();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao tocar o som: " + ex.Message);
        }
    }
    //FIM DO APP RELÓGIO

    /*------------------------------------------------*/

    //APP CALCULADORA
    static void MenuCalculadora()
    {
        Console.Clear();

        Console.WriteLine("O que você deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("5 - voltar ao menu");
        Console.WriteLine("0 - Sair");

        Console.WriteLine("-----------------");

        Console.WriteLine("Selecione uma opção: ");
        short res = short.Parse(Console.ReadLine());

        switch (res)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: Menu(); break;
            case 0: Sair(); break;
            default: Menu(); break;
        }
    }
    static void Soma()
    {
        Console.Clear();

        Console.WriteLine("Primeiro Valor:");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine(" ");
        float resultado = v1 + v2;

        Console.WriteLine($"O resultado da soma é: {resultado}");
        Console.WriteLine(" ");
        Console.WriteLine("1 - Novo cálculo");
        Console.WriteLine("2 - Voltar ao menu");
        Console.WriteLine("0 - Sair");
        Console.WriteLine(" ");

        var res = short.Parse(Console.ReadLine());
        switch (res)
        {
            case 1: MenuCalculadora(); break;
            case 2: Menu(); break;
            case 0: Sair(); break;
            default: MenuCalculadora(); break;
        }
    }
    static void Subtracao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 - v2;
        Console.WriteLine($"O resultado da subtração é: {resultado}");
        Console.WriteLine(" ");
        Console.WriteLine("1 - Novo cálculo");
        Console.WriteLine("2 - Voltar ao menu");
        Console.WriteLine("0 - Sair");
        Console.WriteLine(" ");

        var res = short.Parse(Console.ReadLine());
        switch (res)
        {
            case 1: MenuCalculadora(); break;
            case 2: Menu(); break;
            case 0: Sair(); break;
            default: MenuCalculadora(); break;
        }
    }
    static void Divisao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 / v2;

        Console.WriteLine($"O resultado da divisão é: {resultado}");
        Console.WriteLine(" ");
        Console.WriteLine("1 - Novo cálculo");
        Console.WriteLine("2 - Voltar ao menu");
        Console.WriteLine("0 - Sair");
        Console.WriteLine(" ");

        var res = short.Parse(Console.ReadLine());
        switch (res)
        {
            case 1: MenuCalculadora(); break;
            case 2: Menu(); break;
            case 0: Sair(); break;
            default: MenuCalculadora(); break;
        }
    }
    static void Multiplicacao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 * v2;

        Console.WriteLine($"O resultado da multiplicação é: {resultado}");
        Console.WriteLine(" ");
        Console.WriteLine("1 - Novo cálculo");
        Console.WriteLine("2 - Voltar ao menu");
        Console.WriteLine("0 - Sair");
        Console.WriteLine(" ");

        var res = short.Parse(Console.ReadLine());
        switch (res)
        {
            case 1: MenuCalculadora(); break;
            case 2: Menu(); break;
            case 0: Sair(); break;
            default: MenuCalculadora(); break;
        }
    }
    //FIM DO APP CALCULADORA

    /*------------------------------------------------*/

    //APP EDITOR DE TEXTO
    static void MenuEditor()
    {
        Console.Clear();
        Console.WriteLine("O que você deseja fazer?");

        Console.WriteLine("1 - Abrir Arquivo");
        Console.WriteLine("2 - Criar novo arquivo");
        Console.WriteLine("3 - Voltar ao menu principal");
        Console.WriteLine("0 - Sair");
        short option = short.Parse(Console.ReadLine());

        switch (option)
        {
            case 0: Console.Clear(); Console.WriteLine("Obrigado por usar meu programa :)"); System.Environment.Exit(0); break;
            case 1: Abrir(); break;
            case 2: Editar(); break;
            case 3: Menu(); break;
            default: MenuEditor(); break;
        }
    }
    static void Abrir()
    {
        Console.Clear();

        Console.WriteLine("Qual o caminho do arquivo?");
        string patch = Console.ReadLine();

        using (var file = new StreamReader(patch))
        {
            string text = file.ReadToEnd();
            Console.WriteLine(text);
        }

        Console.WriteLine("");
        Console.ReadLine();
        MenuEditor();

    }
    static void Editar()
    {
        Console.Clear();

        Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
        Console.WriteLine("------------------------");
        string text = "";

        do
        {
            text += Console.ReadLine();
            text += Environment.NewLine;
        }
        while (Console.ReadKey().Key != ConsoleKey.Escape);

        Salvar(text);
    }
    static void Salvar(string text)
    {
        Console.Clear();
        Console.WriteLine("qQual caminho para salvar seu arquivo?");
        var patch = Console.ReadLine();

        using (var file = new StreamWriter(patch))
        {
            file.Write(text);
        }

        Console.WriteLine($"Arquivo {patch} Salvo com sucesso!");
        Console.ReadLine();
        MenuEditor();
    }
    //FIM DO APP EDITOR DE TEXTO

    /*------------------------------------------------*/
    static void Sair()
    {
        Console.Clear();
        Console.WriteLine("Obrigado por usar meu programa");
        Thread.Sleep(3000);
        System.Environment.Exit(0);
    }


}
