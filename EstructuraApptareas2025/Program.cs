//Calcularemos el área y perímetro de dos figuras gemétricas (círculo y cuadrado)
//Clase círculo para representar la figura geométrica círculo calcula el área y perímetro.
public class Circulo
{
    private double radio; //Atributo privado que encapsula el valor del radio del círculo.

    //Constructor de la clase Círculo
    public Circulo(double radio)
    {
        this.radio=radio;
    }
    //Función para calcular el Área de Círculo devuelve un valor doble.
    public double areaCirculo()
    {
        return Math.PI * radio * radio; //Fórmula para calcular el área del círculo.
    }
    //Función para calcular el perímetro del Círculo
    public double perimetroCirculo()
    {
        return 2 * Math.PI * radio; //Fórmula para calcular el perimetro de un círculo.
    }


}
// Clase Cuadrado que representa a la figura geométrica cuadrado, calcula el área y perímetro.
public class Cuadrado
{
    private double lado; // Atributo privado

    //Constructor de la clase Círculo.
    public Cuadrado( double lado)
    {
        this.lado=lado;
    }
    //Función areaCuadrado calculara el área del Cuadrado
    public double areaCuadrado()
    {
        return lado*lado;
    }
    //Función perimetroCuadrado permitira calcular el perímetro del Cuadrado.
    public double perimetroCuadrado()
    {
        return lado + lado + lado +lado;
    }

}

//Clase Inicio para que el programa se ejecute 

public class Inicio
{
    public static void main()
    {
        Circulo circulo = new Circulo(6);
        Console.WriteLine("El perímetro del círculo de radio 6 es: " + circulo.perimetroCirculo());
        Console.WriteLine("El área del círculo de radio 6 es: " + circulo.areaCirculo());
        
        Cuadrado cuadrado = new Cuadrado(8);
        Console.WriteLine("El perímetro del cuadrado de lado 8 es: " + cuadrado.perimetroCuadrado());
        Console.WriteLine("El área del cuadrado de lado 8 es: " + cuadrado.areaCuadrado());


    }
  
}
   





