namespace _271020263
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animale cane1 = Factory.Crea(TipoAnimale.cane, "bob", 2);
        }
    }
    public interface Iverso
    {
        public string Verso();
    }
    public abstract class Animale
    {
        private string _name;
        private int _age;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Animale(string n, int a)
        {
            _name = n;
            if (a <= 0)
            {
                throw new ArgumentException("Errore");
            } else
            {
                _age = a;
            }
        }

        public Animale()
        {
            _name = "";
            _age = 1;
        }

        public abstract string Verso();
    }

    public class Cane : Animale
    {
        public Cane(string name, int age) : base(name, age)
        {

        }

        public override string Verso()
        {
            return "Bau";
        }
    }

    public class Gatto : Animale
    {
        public Gatto(string name, int age) : base(name, age)
        {

        }

        public override string Verso()
        {
            return "Meow";
        }
    }
    public enum TipoAnimale
    {
        cane,
        gatto
    }

    public class Factory
    {
        public static Animale Crea(TipoAnimale tipo, string name, int age)
        {
            return tipo switch
            {
                TipoAnimale.cane => new Cane(name, age),
                TipoAnimale.gatto => new Gatto(name, age),
                _ => throw new ArgumentException("Errore")
            };
        }
    }
}
