using System;

class Program
{
    static void Main(string[] args)
    {
        Animal MeuAnimal;

        MeuAnimal = new Cachorro();
        MeuAnimal.EmitirSom();

        MeuAnimal = new Gato();
        MeuAnimal.EmitirSom();

        Animal[] animais = new Animal[2];
        animais[0] = new Cachorro();
        animais[1] = new Gato();

        foreach (Animal animal in animais)
        {
            animal.EmitirSom();
        }
    }
}
