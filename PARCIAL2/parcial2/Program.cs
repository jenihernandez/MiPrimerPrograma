// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

class program
{
    static void Main(string[] args)
    {
        // Variables de entrada 
        int creditos, estrato;
        double costoMatricula, subsidio;
        string respuesta;
        bool retornar = true;

        do
        {
            // Pedir datos 
            Console.WriteLine("infrese la cantidad de creditos del estudiante: ");
            creditos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el estrato del estudiante: ");
            estrato = Convert.ToInt32(Console.ReadLine());  

            // Calculo del valor de la matricula
            var costoMatriculatotal = calcularcostoMatricula(costoMatricula, creditos);

            // calculo del subsidio 
            subsidio = Calcularsubsidio(estrato);

            // Mostrar resultados
            Console.WriteLine("El costo de la matricula es: " +costoMatricula);
            Console.WriteLine("El valor del subsidio es: " +subsidio);

            Console.WriteLine("¿Desea calcular otra matricula de otro estudiante? S/N");
            
            respuesta = Console.ReadLine();

            if (respuesta.ToLower() == "s")
                 retornar = true;
            else if (respuesta.ToLower() == "n");
                retornar = false;

        } while (retornar);
    }

    private static double Calcularsubsidio(int estrato)
    {
        throw new NotImplementedException();
    }

    private static double calcularcostoMatricula(double costoMatricula, int creditos)
    {
        return costoMatricula * creditos;
    }
}