namespace Animal
{
    internal class program
    {
        static void Main(string[] args)
        {
            Animal gato = new Animal();

            gato.Nome = "Tobis";

            Console.WriteLine(gato.Nome);
            gato.EmitirSom();
            gato.Comer();

            Cachorro dog = new Cachorro("Bob", 10, "Puddle", "M");
            dog.EmitirSom();
            dog.Comer();

            Tubarao shark = new Tubarao();
            shark.EmitirSom();
            shark.Comer();

        }
    }
}

