using System;

namespace CargarVector2
{
    class Program
    {
        const int indice = 100;//indice o limite del vector
        static public int cont = 0;//con esto voy a saber de cuanto va a ser el vector.
        static public int[] vector = new int[indice];//vector.
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese numeros enteros// -1 para terminar");
            TomarNumeros();
            Mostrar();
            Console.ReadKey();
        }
        static public void TomarNumeros()//metodo para tomar los numeros para el vector del cual no se el tamaño.
        {
            do//utilizo un do-while ya que no se cuantos numeros van a ser ingresados. 
            {
                    vector[cont] = Convert.ToInt16(Console.ReadLine());//cuando tomo el numero, lo hago directo en "cont"
                    cont++;//este se va a incrementar para luego guardar el otro numero que se ingrese en la segunda posicion o posicion [1]
            } while (vector[cont-1] != -1 && cont < indice);//aqui digo que se repite cuando cont "ultimo numero ingresado" sea diferente a -1  
        }//Minetras Vector[cont] sea != -1, sigue. entonces cuando ingreso -1, se guarda en la ultima posicion y al comparar, sale.
        static public void Mostrar()
        {
            Console.WriteLine("numeros del vector: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i <cont-1; i++)//aqui digo que voy a mostrar todos los numeros menos el ultimo, ya que ahi se guarda -1
            {
                Console.Write("| {0} |", vector[i]);//muestro el elemento del vector en la posicion i que se va a recorrer cont -1 veces.
            }
        }
    }
}
