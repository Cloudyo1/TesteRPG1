namespace TesteRPG
{
    internal class Programa
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Digite seu dano");
            int damage = 0;
            bool loop = true;
            string? input = "";

            while (loop)
            {
                input = Console.ReadLine();
                if (input != null && int.TryParse(input, out damage))
                {
                    Console.WriteLine("Dano Inserido: " + damage);
                    Console.WriteLine();
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Valor Invalido, insira um numero.");
                    Console.WriteLine();
                }
            }

            string type = tipodedano();

            Dano Dano = new Dano(damage, type);
        }

        static String tipodedano()
        {
            bool confirma = true;
            string? type = "";

            while (confirma) {

                Console.WriteLine("Insira Seu Tipo de Dano");
                Console.WriteLine();
                type = Console.ReadLine();

                if (type != null)
                {


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
                }
                else
                {
                    confirma = true;
                }

                if (confirma)
                {
                    Console.WriteLine("Tipo Invalido Inserido: " + type);
                }
            }
            Console.WriteLine("Tipo Inserido: " + type);
            return type ?? "unknown";
        }

        class Dano
        {
            public string[] generaltype = { "Fisico", "Magico", "Verdadeiro" };
            public int dano { get; }
            public string tipo { get; }
            public string categoria { get; }

            public bool sangramento { get; private set; }
            public bool atordoamento { get; private set; }
            public bool vulneravel { get; private set; }
            public bool cauterizacao { get; private set; }
            public bool veneno { get; private set; }
            public bool lentidao { get; private set; }
            public bool cadeia { get; private set; }

            public Dano(int dano, String tipo)
            {
                this.dano = dano;
                this.tipo = tipo;
                this.categoria = tipogeral(tipo);
                efeito(tipo);
            }

            private string tipogeral(string tipo)
            {
                switch (tipo.ToLower())
                {
                    case "corte":
                    case "impacto":
                    case "perfuracao":
                        return generaltype[0];
                    case "fogo":
                    case "gelo":
                    case "toxina":
                    case "eletricidade":
                        return generaltype[1];
                    case "umbral":
                        return generaltype[2];
                    default:
                        return "unknown";
                }
            }

            private void efeito(string tipo)
            {
                Random random = new Random();

                switch (tipo.ToLower())
                {
                    case "corte":
                        sangramento = random.NextDouble() <= 0.125;
                        break;

                    case "impacto":
                        atordoamento = random.NextDouble() <= 0.125;
                        break;

                    case "perfuracao":
                        vulneravel = random.NextDouble() <= 0.125;
                        break;

                    case "fogo":
                        cauterizacao = random.NextDouble() <= 0.125;
                        break;

                    case "gelo":
                        lentidao = true;
                        break;

                    case "toxina":
                        veneno = true;
                        break;

                    case "eletricidade":
                        cadeia = true;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
