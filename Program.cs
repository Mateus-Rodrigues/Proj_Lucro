using System;

namespace Proj_Lucro
{
    class Program
    {
        static void Main(string[] args)
        {
            double vPctFolha, vPctSaquinho, vPctFita, vVenda, tCusto, lucro;
            int qFolha, qSaquinho, qFitas;


            Console.WriteLine("************************************Calculadora de Custo e Lucro************************************");

            Console.WriteLine(" ");

            //Calculo Da Folha

            #region Folha

            Console.Write("Qual o valor do Pacote de Folha: R$ ");
            vPctFolha = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ");

            Console.Write("Qual a Quantidade de Folha Por Pacote ? ");
            qFolha = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");

            #endregion 

            //Calculo do Saquinho

            #region Saquinho

            Console.Write("Qual o valor do pacote de Saquinho: R$ ");
            vPctSaquinho = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ");

            Console.Write("Qual a Quantidade de Saquinho por pacote ? ");
            qSaquinho = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");

            #endregion

            //Calculo da Fita

            #region Fita

            Console.Write("Qual o valor do pacote de fita: R$ ");
            vPctFita = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ");

            Console.Write("Qual a Quantidade de fita por pacote ? ");
            qFitas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");

            #endregion

            //Valor de Venda

            #region Venda

            Console.Write("Qual o valor de venda: R$ ");
            vVenda = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ");

            #endregion

            //Calculo De Custo

            #region Custo
            
            tCusto = vPctFolha/qFolha + vPctSaquinho/qSaquinho + vPctFita/qFitas;

            Console.WriteLine(" ");

            Console.WriteLine("O seu custo é: R$ " + tCusto);

            Console.WriteLine(" ");
            
            #endregion
            
            //Calculo do Lucro

            #region Lucro

            lucro = vVenda - tCusto;

            Console.WriteLine("O seu Lucro é de:  R$" + lucro);

            #endregion
            
            Console.ReadKey();
        }

    }

}                  