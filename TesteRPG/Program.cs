namespace TesteRPG
{
    internal class Programa
    {
        static void Main(String[] args)
        {
            Console.Write("Digite seu dano: ");
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

            Console.WriteLine($"Tipo de dano geral: {Dano.generaltype[Dano.generalfigure]}");
            Console.WriteLine();

            Console.WriteLine("Efeitos do Dano:");
            Console.WriteLine($"Sangramento: {Dano.sangramento}");
            Console.WriteLine($"Atordoamento: {Dano.atordoamento}");
            Console.WriteLine($"Vulneravel: {Dano.vulneravel}");
            Console.WriteLine($"Cauterizacao: {Dano.cauterizacao}");
            Console.WriteLine($"Veneno: {Dano.veneno}");
            Console.WriteLine($"Lentidao: {Dano.lentidao}");
            Console.WriteLine($"Cadeia: {Dano.cadeia}");

            Console.ReadKey();
        }

        static String tipodedano()
        {
            bool confirma = true;
            string? type = "";

            while (confirma) {

                Console.Write("Insira Seu Tipo de Dano: ");
                type = Console.ReadLine();

                if (type != null)
                { 
                    confirma = type.ToLower() switch
                    {
                        "corte" => false,
                        "impacto" => false,
                        "perfuracao" => false,
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
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Tipo Inserido: " + type);
            Console.WriteLine();

            return type ?? "unknown";
        }

        class Dano
        {
            public string[] generaltype = { "Fisico", "Magico", "Verdadeiro" };
            public int dano { get; }
            public string tipo { get; }
            public string categoria { get; }
            public int generalfigure { get; private set; }

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
                        generalfigure = 0;
                        return generaltype[0];

                    case "fogo":
                    case "gelo":
                    case "toxina":
                    case "eletricidade":
                        generalfigure = 1;
                        return generaltype[1];

                    case "umbral":
                        generalfigure = 2;
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
