namespace TesteRPG
{
    internal class Programa
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Digite seu dano");
            string input = Console.ReadLine();
            int damage;
            string type = tipodedano();

            if (int.TryParse(input, out damage))
            {
                Console.WriteLine("Dano Inserido: " + damage);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Valor Invalido, insira um numero.");
                Console.WriteLine();
                return;
            }

            Dano Dano = new Dano(damage, type);
        }

        static String tipodedano()
        {
            bool confirma = true;
            string type = "";

            while (confirma) {

                Console.WriteLine("Insira Seu Tipo de Dano");
                Console.WriteLine();
                type = Console.ReadLine();

                confirma = type.ToLower() switch

                {

                    "corte" => false,
                    "impacto" => false,
                    "perfuração" => false,
                    "fogo" => false,
                    "gelo" => false,
                    "toxina" => false,
                    "eletricidade" => false,
                    "umbral" => false,
                    _ => true
                };

                if (confirma)
                {
                    Console.WriteLine("Tipo Invalido Inserido: " + type);
                }
            }
            return type;
        }

        class Dano
        {
            public string[] generaltype = { "fisico", "magico", "verdadeiro" };
            public int dano { get; }
            public string tipo {  get; }
            public bool sangramento { get; }
            public bool atordoamento { get; }
            public bool vulneravel { get; }
            public bool cauterizacao { get; }
            public bool veneno { get; }
            public bool lentidao { get; }
            public bool cadeia { get; }
            public bool verdadeiro { get; }

            public Dano(int dano, String tipo)
            {
                this.dano = dano;
                this.tipo = tipo;
            }

        }
    }
}