// Se creara un sistema de Agenda telefónica.
//Mediante la utilización de clases, métodos, atributos.
//agregamos un métodos para escribir texto.

Console.WriteLine("Universidad Estatal Amazónica");
Console.WriteLine("Agenda telefónica");
Console.WriteLine("===================");
//Se define una estructura pública
public struct Contacto

{
    public string Nombre;                        //Atributo nombres del contacto
    public string Telefono;                      //Atributo teléfono de contacto
    public string Direccion;                     //Atributo dirección de contacto


    //Constructor para iniciar los datos del contacto
    public Contacto(string nombre, string telefono, string direccion)
    {
        Nombre = nombre;
        Telefono = telefono;
        Direccion = direccion;

    }
    //Método para mostrar información del contacto
    public void Mostrar()
    {
        Console.WriteLine("Nombre:+" Nombre);
        Console.WriteLine("Telefono:+"Telefono);
        Console.WriteLine("Direccion:+"Direccion); 
    }
}