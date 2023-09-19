internal class Program
{
    private static void Main(string[] args)
    {
        Persona personaNormal = new Persona("Manolo", 23);
        Trabajador trabajador = new Trabajador("Ventas", "Ana", 23);

        List<Persona> lista = new List<Persona>() { personaNormal, trabajador};

        Trabajador trabajador2 = (Trabajador) lista[1];
        Console.WriteLine(trabajador2.departamento);
    }
}

class Persona
{
    private string nombre;
    private int edad;

    public Persona(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }
}

class Trabajador : Persona
{
    public string departamento;
   

    public Trabajador(string departamento, string nombre, int edad) : base(nombre, edad)
    {
        this.departamento = departamento;
    }
}