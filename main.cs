using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("¿Cuántas notas va a ingresar? ");
	int cantidadNotas = int.Parse(Console.ReadLine()); //Tener en cuenta convertir de string a int.

	double[] notas = new double[cantidadNotas];//crear arreglo de doble para almacenar las notas.
	/*
	*/
	double sumaNotas = 0.0;
	int aprobados = 0;

	double maxNota = double.MinValue; //0
	double minNota = double.MaxValue; //5

	for (int i = 1; i <= cantidadNotas; i++) //inicialización, condición, actualización
	{
		Console.WriteLine("El contador i es: " + i);
		Console.Write($"Nota #{i}: "); //"Nota #" + i + ": "
		double nota = double.Parse(Console.ReadLine());//convertimos string a double

		// Validación de rango (0.0 a 5.0) podría extraerse a otra función más adelante
		if (nota < 0.0 || nota > 5.0)
		{
			Console.WriteLine("Valor inválido, la nota debe estar entre 0.0 y 5.0.");
			i--; // Repetir esta iteración
			Console.WriteLine("El contador i es: " + i);
			continue; //saltamos esta iteracción para evitar errores.
		}
		
		notas[i] = nota;//almacenamos la nota

		sumaNotas += nota; //igual a sumaNotas = sumaNotas + nota;

		if (nota >= 3.0) //contamos cuantos han aprobado
		{
			aprobados++;
		}
/*
if (nota > maxNota)
{
maxNo	ta = nota
}
*/		Console.WriteLine("NOTA: " + nota + "Es mayor? "+  "MAXNOTA" + maxNota);
		if (nota > maxNota) maxNota = nota;
		Console.WriteLine("NOTA: " + nota + "Es menor? "+ "minNOTA" + minNota);
		if (nota < minNota) minNota = nota;
	}

	double promedio = sumaNotas / cantidadNotas;

	Console.WriteLine($"\nPromedio: {promedio:F2}"); //:F2 formatea la salida 2 decimales
	Console.WriteLine($"Nota más alta: {maxNota:F2}");
	Console.WriteLine($"Nota más baja: {minNota:F2}");
	Console.WriteLine($"Aprobados: {aprobados}");
		
		
	}
}
