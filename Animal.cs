namespace ListadeExerciciosdeHerença
{
    public abstract class Animal
    {
        public string? Nome { get; set; }

        protected Animal(string nome)
        {
            Nome = nome;
        }
        public void Apresentar()
        {
            Console.WriteLine($"Animal: {Nome}");
        }
        public abstract void EmitirSom();
        
    }
}