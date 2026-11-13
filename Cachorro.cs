namespace ListadeExerciciosdeHerença
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome) : base(nome) { }
        public override void EmitirSom() => Console.WriteLine("Au au!");
    }
}