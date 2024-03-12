
// Ejemplo clase 

static void suma()
{

    int val1, res, val2 = 0;
    Console.WriteLine("INGRESE VALOR 1");
    val1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("INGRESE VALOR 2");
    val2 = Convert.ToInt32(Console.ReadLine());
    res = val1 + val2;
    Console.WriteLine("suma :  " + res);

    Console.WriteLine("");





}


static void datos()
{



    Console.WriteLine("¿Cual es su nombre?");
    string nombre = Console.ReadLine();

    Console.WriteLine("!MUCHO GUSTO! " + nombre);


}



static void Edad()
{

    Console.WriteLine("INGRESE SU AÑO DE NACIMIENTO");

    int anio = Convert.ToInt32(Console.ReadLine());
    int edad = 2024 - anio;
    Console.WriteLine("su edad es = " + edad);
}


int opi = 0;

do
{

    Console.WriteLine("*************");
    Console.WriteLine("Elija una opción:");
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Datos");
    Console.WriteLine("3. Edad");
    Console.WriteLine("4. Salir");
    Console.WriteLine("**************");

    opi = int.Parse(Console.ReadLine());

    switch (opi)
    {

        case 1:
            suma();
            break;


        case 2:
            datos();
            break;
        case 3:
            Edad();
            break;

        case 4:
            Console.WriteLine("SALIENDO DEL PROGRAMA");
            break;



        default:
            Console.WriteLine("OPCION INCORRECTA");
            break;



    }




} while (opi != 4);
Console.WriteLine(":)");
static int suma2(int var1, int var2)
{

    int resi = var1 + var2;
    return resi;

}
int sumanum = suma2(10, 20);
Console.WriteLine(sumanum);

static string nombre1()
{

    string nombre1 = "";
    Console.WriteLine("Ingrese el nombre");
    nombre1 = Console.ReadLine();
    return nombre1;





}

//Ejercicio 1 

int numero, mayor, menor;

Console.WriteLine("Ingrese un número positivo (0 para salir):");
numero = Convert.ToInt32(Console.ReadLine());

mayor = numero;
menor = numero;

do
{
    Console.WriteLine("Ingrese un número positivo (0 para salir):");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero > 0)
    {
        if (numero > mayor)
        {
            mayor = numero;
        }

        if (numero < menor)
        {
            menor = numero;
        }
    }

} while (numero != 0);

if (mayor != int.MinValue && menor != int.MaxValue)
{
    Console.WriteLine("El número mayor ingresado es: {0}", mayor);
    Console.WriteLine("El número menor ingresado es: {0}", menor);
}
else
{
    Console.WriteLine("No se ingresaron números positivos.");
}

// Adivinar e numero que esta pensando 

Console.WriteLine("1. Piensa o anota un numero positivo");
Console.WriteLine("2. Multiplica ese numero por 2");
Console.WriteLine("3. Ahora sumale 8 al resultado que obtuviste");
Console.WriteLine("4. Multiplica ese resultado por 5");
Console.WriteLine("Ahora escribe el resultado final y te dire el numero que pensaste");
string resultadoStr = Console.ReadLine();

int numero = int.Parse(resultadoStr.Substring(0, resultadoStr.Length - 1));
numero -= 4;

Console.WriteLine("¡¡Tu numero es {0}!!", numero);



// Contador de palabras

Console.WriteLine("Ingrese una frase: ");
string frase = Console.ReadLine();

int numeroPalabras = 0;
int i = 0;
while (i < frase.Length)
{
    // Saltar espacios en blanco
    while (i < frase.Length && Char.IsWhiteSpace(frase[i]))
    {
        i++;
    }


    if (i < frase.Length)
    {
        numeroPalabras++;
        while (i < frase.Length && !Char.IsWhiteSpace(frase[i]))
        {
            i++;
        }
    }
}

// Contar vocales
int numeroVocales = 0;
foreach (char caracter in frase)
{
    if ("aeiouáéíóú".Contains(char.ToLower(caracter)))
    {
        numeroVocales++;
    }
}

Console.WriteLine("Número de palabras: {0}", numeroPalabras);
Console.WriteLine("Número de vocales: {0}", numeroVocales);


//Programa para comprobar si una palabra es un palíndromo

// Ingreso de la palabra
Console.WriteLine("Ingrese una palabra: ");
string palabra = Console.ReadLine();

// Convertir la palabra a minúsculas
palabra = palabra.ToLower();

// Invertir la palabra
string palabraInvertida = "";
for (int i = palabra.Length - 1; i >= 0; i--)
{
    palabraInvertida += palabra[i];
}

// Comparar la palabra original con la invertida
bool esPalindromo = palabra == palabraInvertida;

// Mostrar el resultado
if (esPalindromo)
{
    Console.WriteLine("¡La palabra '{0}' es un palíndromo!", palabra);
}
else
{
    Console.WriteLine("La palabra '{0}' no es un palíndromo.", palabra);
}

















