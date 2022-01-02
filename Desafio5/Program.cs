using System;
using System.Collections.Generic;

namespace Desafio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> essasPessoas = new List<Pessoa>();
            List<Cachorro> essesCachorros = new List<Cachorro>();
            List<Moto> essasMotos = new List<Moto>();
            {
                int i = 0;
                while(true)
                {
                    i++;
                    Pessoa _pessoa = new Pessoa();
                    Console.Write("Informe o nome da " + i + " pessoa: ");
                    _pessoa.Nome = Convert.ToString(Console.ReadLine());
                    if(_pessoa.Nome == string.Empty)
                    
                    {
                        break;
                    }
                    Console.Write("Informe a data de nascimento da " + i + " pessoa: ");
                    _pessoa.DataDeNascimento = Convert.ToString(Console.ReadLine());
                    if (_pessoa.DataDeNascimento == string.Empty)

                    {
                        break;
                    }
                    Console.Write("Informe a altura da " + i + " pessoa:  ");
                    _pessoa.Altura = Convert.ToString(Console.ReadLine());
                    if (_pessoa.Altura == string.Empty)

                    {
                        break;
                    }
                    Console.Write("Informe o cpf da " + i + " pessoa: ");
                    _pessoa.CPF = Convert.ToString(Console.ReadLine());
                    if (_pessoa.CPF == string.Empty)

                    {
                        break;
                    }
                    Console.Write("Informe o estado civil da " + i + " pessoa: ");
                    _pessoa.EstadoCivil = Convert.ToString(Console.ReadLine());
                    if (_pessoa.EstadoCivil == string.Empty)

                    {
                        break;
                    }

                    essasPessoas.Add(_pessoa);

                    Cachorro _cachorro = new Cachorro();
                    Console.Write("Informe a cor do " + i + " cachorro: ");
                    _cachorro.Cor = Convert.ToString(Console.ReadLine());
                    if (_cachorro.Cor == string.Empty)

                    {
                        break;
                    }
                    Console.Write("Informe a data de nascimento do " + i + " cachorro: ");
                    _cachorro.DataDeNascimento = Convert.ToString(Console.ReadLine());
                    if (_cachorro.DataDeNascimento == string.Empty)

                    {
                        break;
                    }
                    Console.Write("Informe a cor dos olhos do " + i + " cachorro: ");
                    _cachorro.CorDosOlhos = Convert.ToString(Console.ReadLine());
                    if (_cachorro.CorDosOlhos == string.Empty)

                    {
                        break;
                    }
                    Console.Write("Informe o porte do " + i + " cachorro: ");
                    _cachorro.Porte = Convert.ToString(Console.ReadLine());
                    if (_cachorro.Porte == string.Empty)

                    {
                        break;
                    }

                    essesCachorros.Add(_cachorro);

                    Moto _moto = new Moto();
                    Console.Write("Informe a Cor da " + i + " moto: ");
                    _moto.Cor = Convert.ToString(Console.ReadLine());
                    if (_moto.Cor == string.Empty)

                    {
                        break;
                    }
                    Console.Write("Informe o combustivel da " + i + " moto: ");
                    _moto.Combustivel = Convert.ToString(Console.ReadLine());
                    if (_moto.Combustivel == string.Empty)

                    {
                        break;
                    }
                    Console.Write("Informe a cilindrada da " + i + " moto: ");
                    _moto.Cilindrada = Convert.ToString(Console.ReadLine());
                    if (_moto.Cilindrada == string.Empty)

                    {
                        break;
                    }
                    Console.Write("Informe o modelo da " + i + " moto: ");
                    _moto.Modelo = Convert.ToString(Console.ReadLine());
                    if (_moto.Modelo == string.Empty)

                    {
                        break;
                    }

                    essasMotos.Add(_moto);

                    Console.WriteLine(_pessoa.Nome);
                    Console.WriteLine(_pessoa.DataDeNascimento);
                    Console.WriteLine(_pessoa.Altura);
                    Console.WriteLine(_pessoa.CPF);
                    Console.WriteLine(_pessoa.EstadoCivil);

                    Console.WriteLine(_cachorro.Cor);
                    Console.WriteLine(_cachorro.DataDeNascimento);
                    Console.WriteLine(_cachorro.CorDosOlhos);
                    Console.WriteLine(_cachorro.Porte);

                    Console.WriteLine(_moto.Cor);
                    Console.WriteLine(_moto.Combustivel);
                    Console.WriteLine(_moto.Cilindrada);
                    Console.WriteLine(_moto.Modelo);

                    Console.ReadKey();
                }
            }
        }
    }
}
