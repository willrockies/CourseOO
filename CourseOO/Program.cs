using System;
using System.Globalization;

namespace CourseOO
{
    class Program
    {

       
        static void Main(string[] args)
        {

            /*    *//*Exercicio 3 - Calculo retângulo *//*
                Aluno aluno = new Aluno();
                Console.Write("Nome do Aluno: ");
                aluno.Nome = Console.ReadLine();

                Console.WriteLine("Digite as Três notas do aluno: ");
                aluno.Nota1 = double.Parse(Console.ReadLine());
                aluno.Nota2 = double.Parse(Console.ReadLine());
                aluno.Nota3 = double.Parse(Console.ReadLine());

                Console.WriteLine("Nota Final = "
                    + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

                if (aluno.Aprovado())
                {
                    Console.WriteLine("Aluno Aprovado");
                }
                else
                {
                    Console.WriteLine("Faltaram " 
                        + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture));
                }

            */


            /*Exercicio 2 - Funcionario aumento porcentagem */
            /*FuncionarioSalario func = new FuncionarioSalario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionario: " + func);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double aumento = double.Parse(Console.ReadLine());
            func.AumentarSalario(aumento);

            Console.WriteLine("Dados atualizados: " + func);*/


            /*
             Exercicio 1 - Calculo retângulo

             */
            /*Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine());
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Altura = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));*/


            /*Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario");

            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionario");

            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.Salario = double.Parse(Console.ReadLine());

            double media = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine("Salário medio = " + media.ToString("F2", CultureInfo.InvariantCulture));
            */

            //Pessoa p1 = new Pessoa();
            //Pessoa p2 = new Pessoa();

            //Console.WriteLine("Dados da primeira pessoa");
            //Console.Write("Nome: ");
            //p1.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //p1.Idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dados da segunda pessoa");
            //Console.Write("Nome: ");
            //p2.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //p2.Idade = int.Parse(Console.ReadLine());


            //if (p1.Idade > p2.Idade)
            //{
            //    Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            //}
            //else if (p2.Idade > p1.Idade)
            //{
            //    Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            //}
            //else
            //{
            //    Console.WriteLine("Pessoa tem a mesma idade");
            //}

            /*Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            Console.WriteLine("entre com as medidas do triângulo x;");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("entre com as medidas do triângulo y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areaX = x.Area();


            double areaY = y.Area();

            Console.WriteLine("Área de X:" + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y:" + areaY.ToString("F4", CultureInfo.InvariantCulture));
            if (areaX > areaY)
            {
                Console.WriteLine("Maior area: X");
            }
            else
            {
                Console.WriteLine("Maior area: Y");
            }*/

            // Exercicio resolvido - produto
            /*Produto p = new Produto();
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: {0}", p); ;

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine("Dados Atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados Atualizados: " + p);
        
            */
            
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circuferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI:" + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));


        }
        
        
    }
}
