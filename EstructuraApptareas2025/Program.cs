//Clases para dos figuras geométricas(círculo, cuadrado) en código C#.
using System;


namespace FigurasGeometricas

//Clase círculo para representar el círculo y calcular área y perímetro
public class Circulo
{
    private doble radio; //Atributo privado que encapsula el valor del radio del círculo

    //Constructor de la clase Círculo
    public Circulo(double radio)
    ¨{
        this.radio=radio
    }
    //Función para calcular el Área de Círculo
    public double areaCirculo()
    {
        return Math.PI * radio * radio; //Fórmula para calcular el área del circulo.
    }
    //función para calcular el perímetro del Círculo
    public double perimetroCirculo()
    {
        return 2 * Math.PI * radio; //Fórmula para calcular el perimetro de un circulo.
    }



// Clase Cuadrado para calcular el área y perimetro del cuadrado
public class Cuadrado
{
    private int lado; // Atributo privado

    //Constructor de la clase Círculo

}
   





