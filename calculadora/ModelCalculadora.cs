﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace calculadora
{
    class ModelCalculadora
    {
        //Declarando variáveis
        private double num1;
        private double num2;

        public ModelCalculadora()
        {
            GetSetNum1 = 0;
            GetSetNum2 = 0;
        }//fim do construtor

        //Métodos Gets e Sets
        public double GetSetNum1
        {
            get { return this.num1; }
            set { this.num1 = value; }
        }//fim do GetSetNum1

        public double GetSetNum2
        {
            get { return this.num2; }
            set { this.num2 = value; }
        }//fim do GetSetNum2

        //Métodos
        public double Somar()
        {
            return GetSetNum1 + GetSetNum2;
        }//fim do método somar

        public double Subtrair()
        {
            return GetSetNum1 - GetSetNum2;
        }//fim do método subtrair

        public double Dividir()
        {
            if (GetSetNum2 <= 0)
            {
                return -1;
            }
            else
            {
                return GetSetNum1 / GetSetNum2;
            }
        }//fim do método dividir

        public double Multiplicar()
        {
            return GetSetNum1 * GetSetNum2;
        }//fim do método multiplicar

        public double Potencia()
        {
            return Math.Pow(GetSetNum1, GetSetNum2);
        }//fim da potência

        public string Raiz()
        {
            string msg = "Raiz do primeiro número: " + Math.Sqrt(GetSetNum1) +
                         "\nRaiz do segundo número: " + Math.Sqrt(GetSetNum2);
            return msg;
        }//fim do método raiz

        public string TabuadaNum1()
        {
            string resultado = "";

            for (int i = 0; i <= 10; i++)
            {
                resultado += "\n" + GetSetNum1 + " * " + i + " = " + (GetSetNum1 * i);
            }//fim do for

            return resultado;
        }//fim do método
       

        //Método binario para decimal

        public static int BinarioParaDecimal(string numeroBinario)

        {

            int expoente = 0;

            int numero;

            int soma = 0;

            string numeroInvertido = ReverteString(numeroBinario);

            for (int i = 0; i < numeroInvertido.Length; i++)

            {

                numero = Convert.ToInt32(numeroInvertido.Substring(i, 1));

                soma += numero * (int)Math.Pow(2, expoente);

                expoente++;

            }

            return soma;

        }//fim do método binario para decimal

     



    }//fim da classe
}//fim do projeto
