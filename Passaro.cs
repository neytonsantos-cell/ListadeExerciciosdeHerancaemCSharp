
namespace ListadeExerciciosdeHerença
{
    public class Passaro : Animal
    {
        public Passaro(string nome) : base(nome) { }
        public override void EmitirSom() => Console.WriteLine("Piu piu!");
    }
}