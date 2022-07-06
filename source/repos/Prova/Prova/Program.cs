using System;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escolha exercicio");
            int exercicio = Int32.Parse(Console.ReadLine());

            switch (exercicio)
            {
                case 1:
                    Console.WriteLine("Exercício 1");
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.WriteLine("-------------------------------------------------------------------------");
                    Console.WriteLine("Calcular media final \r\n");
                    Console.WriteLine("Insira nome do aluno");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Primeira nota");
                    float n1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Segunda nota");
                    float n2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Nota do trabalho");
                    float t1 = float.Parse(Console.ReadLine());

                    float media = (n1 + n2 + t1) / 3;
                    if (media >= 8.5)
                    {
                        Console.WriteLine("Nome:" + nome + " " + "Media final:" + media + " " + "Conceito: A");
                    } else if (media >= 7 && media >= 8.4)
                    {
                        Console.WriteLine("Nome:" + nome + " " + "Media final:" + media + " " + "Conceito: B");

                    } else if (media >= 6 && media <= 6.9)
                    {
                        Console.WriteLine("Nome:" + nome + " " + "Media final:" + media + " " + "Conceito: C");

                    }
                    else if (media >= 0.1 && media <= 5.9)
                    {
                        Console.WriteLine("Nome:" + nome + " " + "Media final:" + media + " " + "Conceito: D");

                    }
                    else if (media == 0)
                    {
                        Console.WriteLine("Nome:" + nome + " " + "Media final:" + media + " " + "Conceito: E");

                    }
                    Console.WriteLine("Pressione R para reiniciar a aplicação . . .");

                    string restar = Console.ReadLine();
                    if (restar.ToUpper() == "R")
                    {
                        System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);

                        Environment.Exit(0);
                    }
                    break;

                case 2:
                    Console.WriteLine("Exercício 2");
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.WriteLine("-------------------------------------------------------------------------");

                    string[] mes = new string[] { " ", "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
                    string[] cidade = new string[]{ " ", "Atibaia", "Bragança Paulista", "Mairiporã", "Nazaré", "Terra Preta", "Extrema", "Vargem" };

                    Console.WriteLine("Escolha uma cidade:");
                    for (int contador = 0; contador < cidade.Length; contador++) {  
                    Console.WriteLine(contador + " - " + cidade[contador]);
                    }
                    int escolha = Int32.Parse(Console.ReadLine());

                    Console.Write("Digite o dia: ");
                    int dd = Int32.Parse(Console.ReadLine());

                    Console.Write("Digite o mês: ");
                    for (int i = 0; i < mes.Length; i++);
                    int mm = Int32.Parse(Console.ReadLine());

                    Console.Write("Digite o ano: ");
                    int yyyy = Int32.Parse(Console.ReadLine());

                    Console.Write(cidade[escolha] + "," + " " + dd + " " + "de" + " " + mes[mm] + " " + yyyy);


                    string restar2 = Console.ReadLine();
                    if (restar2.ToUpper() == "R")
                    {
                        System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);

                        Environment.Exit(0);
                    }
                    break;

                case 3:
                    Console.WriteLine("Exercício 3");
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.WriteLine("-------------------------------------------------------------------------");

                    string[] formula = new string[] { "Circulo", "Trapezio", "Losangulo" };

                    for(int contador = 0; contador < 3; contador++)
                    {
                        Console.Write(contador + " - " + formula[contador] + " ");
                    }
                    Console.WriteLine();
                    int calculo = Int32.Parse(Console.ReadLine());

                    switch (calculo)
                    {
                        case 0:
                            Console.WriteLine("Raio");
                            double r = double.Parse(Console.ReadLine());
                            double pi = 3.14;

                            double area = pi * (r * r);

                            Console.WriteLine(area);
                            Console.WriteLine("Calculo Finalizado");

                            break;

                        case 1:
                            Console.WriteLine("Base maior");
                            double B = double.Parse(Console.ReadLine());
                            Console.WriteLine("Base menor");
                            double b = double.Parse(Console.ReadLine());
                            Console.WriteLine("Altura");
                            double h = double.Parse(Console.ReadLine());

                            double area2 = (B*b)*h/2;

                            Console.WriteLine(area2);
                            Console.WriteLine("Calculo Finalizado");
                            break;

                        case 2:
                            Console.WriteLine("Diagonal Maior");
                            double D = double.Parse(Console.ReadLine());
                            Console.WriteLine("Diagonal Menor");
                            double d = double.Parse(Console.ReadLine());

                            double area3 = (D * d)/ 2;

                            Console.WriteLine(area3);
                            Console.WriteLine("Calculo Finalizado");

                            break;
                    }

                    string restar3 = Console.ReadLine();
                    if (restar3.ToUpper() == "R")
                    {
                        System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);

                        Environment.Exit(0);
                    }
                    break;

                case 4:
                    Console.WriteLine("Exercício 4");
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.WriteLine("-------------------------------------------------------------------------");

                    for(int i = 1; i <= 50; i++) {
                        Console.WriteLine(i);
                    }

                    string restar4 = Console.ReadLine();
                    if (restar4.ToUpper() == "R")
                    {
                        System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);

                        Environment.Exit(0);
                    }
                    break;

                case 5:
                    Console.WriteLine("Exercício 5");
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.WriteLine("-------------------------------------------------------------------------");

                    for(int i = 0; i < 100; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }

                    string restar5 = Console.ReadLine();
                    if (restar5.ToUpper() == "R")
                    {
                        System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);

                        Environment.Exit(0);
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
