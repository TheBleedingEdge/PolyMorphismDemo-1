namespace PolyMorphismDemo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Fido = new MaleDog("Fido");
            Fido.Bark();
            Fido.Pee();
            Fido.JumpOnCouch();

            var Fifi = new FemaleDog("Fifi");
            Fifi.Bark();
            Fifi.Pee();
            Fifi.JumpOnCouch();            
        }
    }
}
