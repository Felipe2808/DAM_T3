using Arreglos.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ejemplo de gestion de arreglos");
        
        MiArreglo arr = new MiArreglo(7);
        //rellenar con for
        arr.agregar(6);
        arr.agregar(7);
        arr.agregar(9);
        arr.agregar(8);
        //arr.agregar(5);
        //con agregar
        arr.incertar(3,1);
        Console.WriteLine(arr);
        Console.ReadKey();
        Console.WriteLine("elimina");
        //con eliminar
        arr.eliminar(1);
        Console.WriteLine(arr);
        //for (int i = 0; i < arr.N; i++)
        //{
        //    arr.agregar(i + 1);
        //}
        //Console.WriteLine(arr);

        //arr.Llenar(1, 100);
        //Console.WriteLine("REGLO ordenado");
        //Console.WriteLine(arr);

        //Console.WriteLine("arreglo ordenado\n\n");
        //arr.burbuja();
        //Console.WriteLine(arr);

        //arr.burbuja(true);

        //Console.WriteLine("areglo ordenado asendente con parametro");
        //arr.burbuja(false);
        //Console.WriteLine(arr);





        Console.ReadKey();
    }
}