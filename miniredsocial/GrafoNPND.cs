using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniredsocial 
{
    internal class GrafoNPND 
    {
        private int[,] red;
        private Persona[] lista;
        private int cantidad;

        public GrafoNPND(int n)
        {
            red = new int[n, n];
            lista = new Persona[n];
            cantidad = 0;

            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    red[f, c] = 0;
                }
            }
        }
        public void AgregarPersona(Persona p)
        {
            lista[cantidad] = p;
            cantidad++;
        }
        private int Buscar(string nombre)
        {
            for (int i = 0; i < cantidad; i++)
            {
                if (lista[i].Nombre == nombre)
                    return i;
            }
            return -1;
        }
        public void Conectar(string n1, string n2)
        {
            int i = Buscar(n1);
            int j = Buscar(n2);

            if (i != -1 && j != -1)
            {
                red[i, j] = 1;
                red[j, i] = 1;
            }
        }
        public void SonAmigos(string n1, string n2)
        {
            int i = Buscar(n1);
            int j = Buscar(n2);

            if (red[i, j] == 1)
            {
                Console.WriteLine(n1 + " y " + n2 + " son amigos directos.");
                return;
            }
            for (int k = 0; k < cantidad; k++)
            {
                if (red[i, k] == 1 && red[k, j] == 1)
                {
                    Console.WriteLine(n1 + " y " + n2 + " son amigos indirectos.");
                    return;
                }
            }

            Console.WriteLine(n1 + " y " + n2 + " no son amigos.");
        }
        public void Mostrar()
        {      
            for (int f = 0; f < cantidad; f++)
            {
                for (int c = 0; c < cantidad; c++)
                {
                    Console.Write(red[f, c] + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}