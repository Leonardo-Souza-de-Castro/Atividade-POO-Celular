using System;

namespace Exercicio_POO_Celular
{
    class Program
    {

        static string voltar = "";

        static bool opcao_invalida = true;

        static void Main(string[] args)
        {
            string status_celular;
            string opcoes;
            string numero_para_ligar;
            string contato;
            string mensagem;
            bool recomecar = true;

            Celular celular_1 = new Celular();
            celular_1.modelo = "Samsung Galaxy S10";
            celular_1.tamanho = 6.1;
            celular_1.cor = "azul";

            do
            {

                if (celular_1.ligar() == true)
                {
                    Console.WriteLine($@"
    O Celular esta Desligado:
    Presione 1 para ligar
                ");

                    status_celular = Console.ReadLine();

                    switch (status_celular)
                    {
                        case "1":
                            Console.WriteLine("Inicializando Android");
                            do
                            {
                                Console.WriteLine($@"
=============================================================
|   Android inicializado com sucesso o que deseja fazer:    |
=============================================================
|       1 - Ligar                                           |
|       2 - Enviar mensagens                                |
|       3 - Configurações                                   |
|       4 - Desligar                                        |
=============================================================
                            ");
                                opcoes = Console.ReadLine();
                                switch (opcoes)
                                {
                                    case "1":
                                        Console.WriteLine("Digite um número para ligar");
                                        numero_para_ligar = Console.ReadLine();
                                        Console.WriteLine(celular_1.ligacao());
                                        voltar_opcoes();
                                        break;
                                    case "2":
                                        Console.WriteLine("Digite para quem vai enviar a mensagem");
                                        contato = Console.ReadLine();
                                        Console.WriteLine("Digite a mensagem");
                                        mensagem = Console.ReadLine();
                                        Console.WriteLine(celular_1.mensagem());
                                        Console.WriteLine($@"Mensagem enviada com sucesso para {contato}");
                                        voltar_opcoes();
                                        break;
                                    case "3":
                                        Console.WriteLine($@"Modelo: {celular_1.modelo}");
                                        Console.WriteLine($@"Cor: {celular_1.cor}");
                                        Console.WriteLine($@"Tamanho: {celular_1.tamanho} polegadas");
                                        recomecar = true;
                                        opcao_invalida = true;
                                        voltar_opcoes();
                                        break;
                                    case "4":
                                        if (celular_1.desligar() == false)
                                        {
                                            Console.WriteLine("Desligando");
                                            Console.Clear();
                                            recomecar = true;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Celular já desligado");
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Opção não válida favor digitar novamente");
                                        opcao_invalida = false;
                                        break;
                                }
                            } while (opcao_invalida == false);
                            break;
                        default:
                            Console.WriteLine("Não entendemos sua escolha, escolha novamente");
                            recomecar = false;
                            break;
                    }
                }
            } while (recomecar == false);
        }

        static void voltar_opcoes()
        {
            Console.WriteLine($@"
|===============================================|            
|    Gostaria de fazer algo mais no celular?    |
================================================|
|       S - Sim                                 |
|       N - Não                                 |
|===============================================|
");

            voltar = Console.ReadLine().ToLower();
            if (voltar == "s")
            {
                opcao_invalida = false;
            }
            else
            {
                opcao_invalida = true;
            }
        }
    }
}
