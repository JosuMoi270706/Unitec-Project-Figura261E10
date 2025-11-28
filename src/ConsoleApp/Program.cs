double lado = 5;
double altura = 10;
double perimetro = Application.Figura261E10.Perimetro(lado);
double area = Application.Figura261E10.Area(lado);
double volumen = Application.Figura261E10.Volumen(area, altura);

Console.WriteLine($"El perímetro de la base de un Rectángulo de {lado}cm por lado es {perimetro}cm");
Console.WriteLine($"El área de la base de un Rectángulo de {lado}cm por lado es {area}cm");
Console.WriteLine($"El volumen de un Rectángulo con un área de la base de {area}cm2 y {altura}cm de altura es {volumen}cm3");
