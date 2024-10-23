using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AtvTDD
{
    public class Calculadora
    {
        private List<string> Listahistorico;
        private string data;

        public Calculadora(string data)
        {
            Listahistorico = new List<string>();
            this.data = data;
        }
        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            Listahistorico.Insert(0, "Resultado: " + resultado + "Data: "+ data);
            return resultado;
        }
        public int Subtrair(int num1, int num2) 
        { 
            int resultado =  num1 - num2;
            Listahistorico.Insert(0, "Resultado: " + resultado + "Data: " + data);
            return resultado;
        }
        public int Multiplicar(int num1, int num2)
        {
            int resultado =  Convert.ToInt16(num1 * num2);
            Listahistorico.Insert(0, "Resultado: " + resultado + "Data: " + data);
            return resultado;
        }
        public int Dividir(int num1, int num2)
        {
            int resultado = Convert.ToInt16(num1 / num2);
            Listahistorico.Insert(0, "Resultado: " + resultado + "Data: " + data);
            return resultado;
        }

        public List<string> historico()
        {
            Listahistorico.RemoveRange(3, Listahistorico.Count - 3);
            return Listahistorico;
        }
    }
}
