using System;
using System.Globalization;

class MainClass {
  public static void Main (string[] args) {
    
    Triangulo X, Y;
    double areaX, areaY;

    X = new Triangulo ();
    Y = new Triangulo ();

    X.a = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
    X.b = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
    X.c = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
    Y.a = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
    Y.b = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
    Y.c = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);


    areaX = X.area();
    areaY = Y.area();

    Console.WriteLine ("Área do triangulo X: " + areaX.ToString ("F4",CultureInfo.InvariantCulture));
    Console.WriteLine ("Área do triangulo Y: " + areaY.ToString ("F4",CultureInfo.InvariantCulture));

    if (areaX > areaY) {
      Console.WriteLine ("Triangulo de maior área : X");
    }
    else if  (areaY > areaX) 
    {
      Console.WriteLine ("Triangulo de maior área : Y");
    }
    else {
      Console.WriteLine ("Triangulo de áreas iguais !");
    }
  }
}