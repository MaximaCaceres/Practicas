using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenVecortesParalelos
{
    //Se crearon dos vectores para guardar nombres y notas de alumnos, estos tenian que ordenarse de menor a mayor.
    //No se conocia la cantidad de alumnos a ingresar.
    class Program
    {
        const int indice = 300;//indice costante para el vector.
        static int cont = 0;//contador de cuantos elementos se ingresan, con esto se la capacidad del vector.
        static int[] vector = new int[indice];//vector el cual guarda las notas.
        static string[] nombres = new string[indice];//vector que guarda los nombres.
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese nombre y nota de alumno// -1 para salir");//le damos indicaciones al usuario.
            TomarDatos();//llamamos a TomarDatos(), aqui tomamos los nombres y notas.
            Console.Clear();//limpiamos para que no se amontone todo.
            Mostrar();//mostramos informacion ingresada por el usuario.
            Console.ReadKey();//para que cuando pulse Enter, siga el programa.
            Console.Clear();//volvemos a limpiar.
            Burbuja();//llamamos al Burbuja() para ordenar nuestros vectores.
            Console.WriteLine("Notas de alunos de menor a mayor (:p)\n");//mensaje antes de mostrar informacion ordenada.
            Mostrar();//llamamos a mostrar, para que se vean los datos, esta vez ordenados de menor a mayor.
            Console.ReadKey();
        }

        static public void TomarDatos()
        {
            do
            {
                nombres[cont] = Console.ReadLine();//tomo los nombres y las notas de los alumnos.
                vector[cont] = Convert.ToInt32(Console.ReadLine());
                cont++;//luego de tomar sus notas, incremento "cont" para que la proxima nota se guarde en la posicion que sigue.
            } while (vector[cont - 1] != -1 && nombres[cont -1]!= "-1" && cont < indice);//esto es para cortar la entrada de datos ene l caso de que sea -1.


        }


        static public void Mostrar()
        {
            for (int i = 0; i < cont - 1; i++)//aqui recorro con un for hasta la cantidad de elementos ingresados.
            {
                Console.WriteLine("{0}:{1}",nombres[i],vector[i]);//muestro los nombres y notas, las cuales se mostraran como debe ser, ya que sopn vecotres paralelos.
            }
        }

        static public void Burbuja()//al querer ordenar los datos de menor a mayor, tenemos que ordenarlos// los vectoes a ordenar son paralelos.
        {//es decir que estos tienen que ir de la mano. A continuacion el ordenamiento:

            int aux = 0, i = 0, j = 0;//creo variables como aux y aux2 para almacenar valores del vector que esten fuera de lugar.
            string aux2 = "";
            for(i = 0; i < cont ; i++)//recorre el vector de notas.
            {
                for(j = i+1; j < cont -1; j++)//recorre el vector de nombres
                {
                    if (vector[i] > vector[j])
                    {
                        aux = vector[i];//en el caso de que vector[i] sea mayor que ""[j] guardo el valor mayor en aux.
                        vector[i] = vector[j];//luego digo que al lugar de ""[i] lo va a ocupar ""[j].
                        vector[j] = aux;//finalmente digo que al ""[j] lo va a ocupar el aux que es ""[i].

                        aux2 = nombres[i];//ahora tengo que hacer lo mismo para el vector de nombres ya que estos deben ir a la par. De lo contrario, perderemos informacion.
                        nombres[i] = nombres[j];
                        nombres[j] = aux2;
                    }
                }
            }    
        }
    }
}
