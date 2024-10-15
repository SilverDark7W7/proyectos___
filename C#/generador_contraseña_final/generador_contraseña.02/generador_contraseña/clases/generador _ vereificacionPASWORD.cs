using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Pasword
{
    public class generador_pasword
    {
        public string cadena_letras = "";
        public int contador_numeros = 0;
        public int enviar_datos;
        public string generador(string longitud_letras)
        {
            // ponemos todo caracteres un solo contenedor para que sean escogidas aleatoreamente desde
            //la propiedad ramdom 
            string letras_minusculas = "ajwgryabcdefghijklmnñ";
            string letras_mayusculas = "ABCDEFGHIJKLMNÑOPQ";
            string numeros_caract = "123456789099";
            string signos = "@%&#!¡";
            string caracteres_contraseña = letras_minusculas + signos + numeros_caract + letras_mayusculas;
            string password = "";
            int b = Convert.ToInt32(longitud_letras);
            // declaramos un objeto con la propiedad ramdon() asi se escoje todo aleatoreo
            Random Generar_todo = new Random();
            for (int i = 0; i < b; i++)
            {
                char letraAleatoria = caracteres_contraseña[Generar_todo.Next(caracteres_contraseña.Length)];
                password += letraAleatoria.ToString();
            }
            cadena_letras = password;
            return password;
        }
    }

    class verdad
    {
        public string True_false(string contraseña)
        {
            string fuerte = "Fuerte";
            string media = "Media";
            string debil = "Debil";


            int puntos = 0;

            int simbolos = 0;

            int minuscula = 0;

            int mayusculas = 0;

            int numero = 0;


            /* ciclo cadena de caracteres */
            
            foreach (char cantidad in contraseña)//ciclos para caracteres
            {
                if (char.IsLower(cantidad) ) {
                    for (int i = 0; i < contraseña.Length; i++)
                    {
                        if (char.IsLower(contraseña[i]))
                        {
                            minuscula += 1; 
                        }
                    }
                }

                if (char.IsUpper(cantidad))
                {
                    for (int i = 0; i < contraseña.Length; i++)
                    {
                        if (char.IsUpper(contraseña[i]))
                        {
                            mayusculas += 1;
                        }
                    }
                }
                if(char.IsDigit(cantidad) )
                   {

                    for (int i = 0; i < contraseña.Length; i++)
                    {
                        if (char.IsDigit(contraseña[i]))
                        {
                            numero += 1;
                        }
                    }
                }
               if (char.IsSymbol(cantidad))
                {
                    for (int i = 0; i < contraseña.Length; i++)
                    {
                        if (char.IsSymbol(contraseña[i]))
                        {
                            simbolos += 1;
                        }
                    }
                }
            }

            //puntos para comprobar que tan fuerte es la contraseña generada

            if (mayusculas >= 3 & numero >= 3 & simbolos >=2 || minuscula<=1 )
            {

                return fuerte;
            }
            else if ( /*mayusculas<3 & (minuscula<2 || numero<3  )& simbolos <=1*/ numero < 3 & simbolos <= 2)
            {
                return media;
            }


            else
            {
               
               return debil;
             }

            
           

        }
    }
}
/*try {

}
catch (Exception) { 

}*/

/* if anidados

if (minuscula_pts >= 1)
{
    puntos = +2;

    if (mayusculas_pts >= 2)
    {
        puntos = +3;

        if (numero_pts >= 3)
        {
            puntos = +5;

            if (simbolos_pts >= 2)
            {

                puntos = +3;
            }
        }
    }

} /*





// block the code de prueba
// este metodo solo imprime mayusculas en caso no 
// se puede verificar si es fuerte o debil, pero 
// es funcional
/* 
string letras;

string password = "";

int b = Convert.ToInt32(longitud_letras);
// declaracion de un objeto tipo ramdon 
Random letrasMinusculas = new Random();
for (int i = 0; i < b; i++)
{
    char letraAleatoria = (char)letrasMinusculas.Next('a', 'z' + 1);
    password += letraAleatoria.ToString();
}
compacion = password;*/
