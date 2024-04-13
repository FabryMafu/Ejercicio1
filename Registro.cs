public class Registro 
{
    public Personas[] persona;
    public Registro(int cant)
    {
        persona = new Personas[cant];
    }
    public void Registrar()
    {
        for (int i = 0; i < persona.Length; i++) {
            Console.WriteLine("Nombre: ");
            persona[i] = new Personas();
            persona[i].nombre = Console.ReadLine() ?? "";
            Console.WriteLine("Apellido: ");
            persona[i].apellido = Console.ReadLine() ?? "";
            Console.WriteLine("Edad: ");
            persona[i].edad = Console.ReadLine() ?? "";
            Console.WriteLine("Telefono: ");
            persona[i].telefono = Console.ReadLine() ?? "";
        }
    }
    public void mostrarPersonas(){
        foreach (Personas persona in persona){
            Console.WriteLine("El nombre es: " + persona.nombre);
            Console.WriteLine("El apellido es: " + persona.apellido);
            Console.WriteLine("La edad es: " + persona.edad);
            Console.WriteLine("El telefono es: " + persona.telefono);
        }
    }
}