using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Controlador
{
    public class Controlador
    {
        public string[] Nombres = new string[1000];
        public int Contador = 0;
        public int[] DNIs = new int[1000];
        public double[] Notas = new double[1000];

        public void AgregarAlumno(string nombre, int dni, double nota)
        {
            Nombres[Contador] = nombre;
            DNIs[Contador] = dni;
            Notas[Contador] = nota;
            Contador++;
        }
        public double CalcularPromedio()
        {
            double acumulador = 0;

            for (int i = 0; i < Contador; i++)
            {
                acumulador += Notas[i];

            }
            return acumulador / Contador;

        }
        public string[] NombresProm = new string[1000];
        public int[] DNIsProm = new int[1000];
        public double[] NotasProm = new double[1000];
        public int ContadorProm = 0;

        public void AlumnosQueSuperanAlPromedio() 
        {
            
        }

    }
}
