using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    class Program
    {

        //As enum são declaradas no inicio das classes .
        //Aqui criei uma enumeraçao chamada notas e dentro delas enumerei alguns itens 
        enum Notas
        {
            Minimo = 2,
            Media = 4,
            Maxima= 9,

        }

       
        struct Pessoa
        {
            
            public string nome;
            public int idade;
            public double altura;                     
              
        }

        static void Main(string[] args)
        {
            #region Numericas Integrais

            //Integral assinado
            //sbyte num1 = 10;// 8 bits, de -128 a 127
            //sbyte num2 = 20; //16 bits,-32.768 a 32.767
            //int num3 = 30;//32 bits,-2.147487.648 a 2.147.483..647
            //long num4 = 40L;//64bits,-9.223.372.036.854.775.808 a 9.223..372..036.854.775.807

            //Integrau sem sinal
            //byte num5 = 10;//8bits intervalos de 0 a 255
            //ushort num6 = 20;//16 bits ,de 0 a 65.535
            //uint nnum7 = 30;//32bits, de 0 a 4.294.967.295
            //ulong num8 = 40L;//64bits,de 0 a 18.246.744.073.709.551,615


            //Aqui estou declarando do tipo sbyte com nome de numero
            //long numero;
            //Aqui estou armazzenando o numero para dentro da variavel
            //numero = 100;
            //Aqui estou armazenando um numero dentro da variavel que e  120


            //numero = 120;
            //numero = num4;

            #endregion

            #region Real

            ////declarei uma variavel com o nome real1 do tipo float que vai receber numeros reais e inteiros.
            //float real1 = 100.75f;
            ////declarei uma variavel com o nome real2 do tipo double que vai receber numeros reais e inteiros.
            //double real2 = 12500.45;
            ////declarei uma variavel com o nome real3 do tipo decimal  que vai receber numeros reais inteiros.
            //decimal real3 = 75283.457m;
            ////aqui eu declarei a variavel do nome valor com o tipo float , ele recebe o valor real ou inteiro.
            //float valor;
            ////aqui eu fiz uma atribuiçao para dentro da variavel valor.
            //valor = real1;
            ////aqui eu exibo o valor da variavel.
            //Console.WriteLine(valor);
            //Console.ReadKey();

            #endregion

            #region Caracter
            //Aqui eu declarei uma variavel no tipo char que armazena um byte
            //com o nome de letra e atribuir uma posição ocupada na memoria para esse caracter
            //char letra ='\u0070';
            //aqui eu declarei uma variavel tipo char que  armazena um byte com o nome de escape 
            //e atribuir o caracter \n no qual ele quebra a linha
            //char escape = '\n';
            // Aqui eu declarei uma variavel tippo char que armazena um byte com o nome literal e atribuir um caracter c
            //char literal = 'c';

            //Console.WriteLine(letra);
            //Console.ReadKey();
            #endregion

            #region Boolean

            //Aqui eu declarei uma variavel com o nome de verificar
            // bool(uma variavel ela recebe 2 valores falso ou verdadeiro)
            //eu fiz uma atribuição passando como false.
            //*/
            //bool verificar = false;

            ///*
            // Aqui eu declarei uma variavel com  o 
            // nome verificar e eu fiz uma atribuição passando com true            
            //*/

            //verificar = true;

            ///*
            // Na linha 94 foi passado para dentro da variavel um valor falso e
            // na  101 foi passado um valor verdadeiro, ou seja ela substituiu o valor para true sendo que o operador de atribuição 
            //somente coloca um valor na variavel.        
             
             

            //Aqui estou mandando exibir a variavel verificar
            //Console.WriteLine(verificar);
            //Console.ReadKey();
            #endregion

            #region string (Cdeia de Caracteres)

            //// Aqui eu declarei uma string na variavel texto fiz uma atribuição para texto.
            //string texto = "leidiane motta  1985 @@??$$";
            ////Aqui eu declarei uma string  na variavel mensagen e eu fiz uma atribuição null.
            //string mensagem = null;
            ////Aqui eu atribuir 
            //mensagem = texto;


            //Console.WriteLine(mensagem);
            //Console.ReadKey();

            #endregion

            #region Tipo Implicito Var
               //Aqui declarei uma variavel implicita " converção implicita é quando a propia variavel converte para tipagem
              //ou seja se eu atribuir um float ou um boleano ela vai assumir esses valores default"
             //var valor = 09.9f;
             // valor = 20;
            //var valor = "Samuel";
            //Aqui estou exibindo a variavel
            //Console.WriteLine(valor);
            //Console.ReadKey();

            #endregion

            #region Tipo Obejct

            // Aqui eu declarei um object que pode receber qualquer coisa seja string inteiro
            //boll float etc
            //object obj = false;
            //obj = 200;
            //obj = "Leidiane";
            //Aqui estou a variavel obj
            //Console.WriteLine(obj);
            //Console.ReadKey();
            #endregion

            #region Tipo  Constant
        //    // Aqui eu declarei uma variavel com o nome pi com a tipagem double e constante que nunca muda o valor
        //    const double pi = 3.1415;
        //    //Aqui eu declarei uma variavel chamada nome com a tipagem string e constante ou seja nunca muda o valor
        //    const string nome = "Leidiane";
        //// nome = "samuel";
        //    //
        //    Console.WriteLine(nome);
        //    Console.ReadKey();
            #endregion

            #region Enumeração
            //Aqui eu chamei a minha enum criada no inicio da classe atribuir para a variavel notasAlunos 
            //o item da enum
            //Notas notasAlunos = Notas.Media;
            ////Aqui estou exibindo o valor da variavel notas alunos que é enum.
            //Console.WriteLine(notasAlunos);
            //Console.ReadKey();
            #endregion

            #region Tipo Struct Pessoa
            
            //Pessoa p1 = new Pessoa();
            
            //p1.altura = 1.65;
            //p1.idade = 35;
            //p1.nome = "Leidiane";

            //Pessoa P2 = new Pessoa()
            //{
            //    nome ="Edarda",
            //    idade = 9,
            //    altura =1.35,
            //};

            ////p1.nome="Longan";
            ////Aqui estou exibindo os valores das propriedades
            //Console.WriteLine(p1.nome);
            //Console.WriteLine(p1.altura);
            //Console .WriteLine (p1.idade);

            ////Console.WriteLine();

            ////Console.WriteLine(p2.nome);
            ////Console.WriteLine(p2.autura);
            ////Console.WriteLine(p2.idade);

            Console. ReadKey();
               
            #endregion





        }
    }
}

