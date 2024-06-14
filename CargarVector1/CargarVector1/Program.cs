using System;

namespace CargarVector1
{
    class Program
    {
        const int indice = 5;//el indice del vector siempre debe de ser una constante.

        static public int[] vector = new int[indice];//para dar tamaño a nuestro vector, siempre se utiliza la constante de arriba.
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese 5 elementos");//le pido ingresar 5 numeros al usuario.
            TomarElementos();//llamo al metodo para realiar la toma de elementos.
            Console.Clear();
            Mostrar();//llamo al metodo para mostrar los elementos que hemos cargado en el vector.
            Console.ReadKey();
        }
        static void TomarElementos()//tomamos los numeros del vector// no es necesario crear una variable para guardarlos y despues pasar al vector.
        {

            for (int i = 0; i <= indice - 1; i++)
            {
                vector[i] = Convert.ToInt16(Console.ReadLine());// con cargaros directamente es suficiente.
            }
        }
        static public void Mostrar()//Metodo para mostrar cada elemento del vector. //Tiene retorno Void porque solo muestra informacion//
        {
            Console.WriteLine("Numeros del vector: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i <= indice - 1; i++)//al querer rrecorrer un vector, es con -1 ya que sino me salgo de los limites.
            {
                Console.Write("| {0} |", vector[i]);//utilice Console.Write sin Line para que se muestren juntos y que no haga salto.
            }
        }
    }
}
