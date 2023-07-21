﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class ControlCalculadora
    {
        //Criando um objeto calculadora na memória
        ModelCalculadora calculadora;

        public ControlCalculadora()
        {
           this.calculadora = new ModelCalculadora();
        }//fim do construtor

        public void Coletar()
        {
            Console.WriteLine("Informe um número: ");
            this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe outro número: ");
            this.calculadora.GetSetNum2 = Convert.ToDouble(Console.ReadLine());
        }//fim do coletar

        public int Menu()
        {
            Console.WriteLine("------ Menu -------"                 +
                              "\n0. Sair"                           +
                              "\n1. Somar"                          +
                              "\n2. Subtrair"                       +
                              "\n3. Dividir"                        +
                              "\n4. Multiplicar"                    +
                              "\n5. Potência"                       +
                              "\n6. Raiz"                           +
                              "\n7. Tabuada"                        +
                              "\n8.binario em decimal"              +
                              "\n\nEscolha uma das opções acima: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }//fim do método Menu

        public void Operacao()
        {
            int opcao = 0;
            do
            { 
                opcao = Menu();
                Console.Clear();//Limpa a tela
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Coletar();
                        Console.WriteLine("Soma: " + this.calculadora.Somar());
                        break;
                    case 2:
                        Coletar();
                        Console.WriteLine("Subtração: " + this.calculadora.Subtrair());
                        break;
                    case 3:
                        Coletar();
                        if (this.calculadora.Dividir() == -1)
                        {
                            Console.WriteLine("Impossível dividir!");
                        }
                        else
                        {
                            Console.WriteLine("Divisão: " + this.calculadora.Dividir());
                        }
                        break;
                    case 4:
                        Coletar();
                        Console.WriteLine("Multiplicar: " + this.calculadora.Multiplicar());
                        break;
                    case 5:
                        Coletar();
                        Console.WriteLine("Potência: " + this.calculadora.Potencia());
                        break;
                    case 6:
                        Coletar();
                        Console.WriteLine(this.calculadora.Raiz());
                        break;
                    case 7:
                        Console.WriteLine("Informe um número: ");
                        this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.TabuadaNum1());
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é valida");
                        break;
                    case 8:
                        Console.Write("Digite um número decimal: ");
                        int decimalNumber = int.Parse(Console.ReadLine());

                        string hexadecimalValue = DecimalToHexadecimal(decimalNumber);
                        Console.WriteLine($"O número decimal {decimalNumber} é igual a {hexadecimalValue} em hexadecimal.");
                }//fim do switch
                
            } while(opcao != 0);//fim do Do...while
        }//fim do operacao
    }//fim da classe
}//fim do projeto
