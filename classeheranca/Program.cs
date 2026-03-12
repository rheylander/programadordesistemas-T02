using classeheranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeheranca
{

    // Classe base (superclasse)
    internal class Animal
    {
        //Propriedade da classe animal
        public string Nome { get; set; }

        // Método que seá sobrescrito pelas classes derivadas
        public virtual void EmitirSom()
        {
            Console.WriteLine("O animal emite um som.");
        }
    }

        //classe derivada (subclasse)
        internal class Cachorro : Animal
        {
            // Sobrescrevendo o método EmitirSom
            public override void EmitirSom()
            {
                // Sobrescrevendo o método EmitirSom
                Console.WriteLine($"{Nome} late: Au Au!");
            }
        }

        //Outra classe derivada
        internal class Gato : Animal
        {
            // Sobrescrevendo o método EmitirSom
            public override void EmitirSom()
            {
                // Sobrescrevendo o método EmitirSom
                Console.WriteLine($"{Nome} mia: Miau!");
            }
        }

}

internal class Program
{
    static void Main(string[] args)
    {
        // Criando instâncias das classes derivadas
        Animal meuCachorro = new Cachorro { Nome = "Rex" };
        Animal meuGato = new Gato { Nome = "Felix" };

        // Chamando o método EmitirSom para cada animal
        meuCachorro.EmitirSom(); // Saída: Rex late: Au Au!
        meuGato.EmitirSom();    // Saída: Felix mia: Miau!
        Console.ReadLine();

        //Utilizando polimorfismo: Array de animais
        Animal[] animais = { meuCachorro, meuGato };

        foreach (Animal animal in animais)
        {
           animal.EmitirSom(); // Cada objeto chama o método adequado de sua classe
        }
    }
}