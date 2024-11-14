namespace TesteRPG
{
    internal class Programa
    {
        static void Main(String[] args)
        {
            int damage, penetration, slicing;
            string type;

            Danos(out damage, out type, out penetration, out slicing);

            Dano Dano = new Dano(damage, type, penetration, slicing);

            int healthmax, armor, reflection, shield, durability, health;

            Resistencias(out healthmax, out armor, out reflection, out shield, out durability, out health);

            Alvo Alvo = new Alvo(healthmax, armor, reflection, shield, durability, health);

            Lingering(Dano);

            Display(Dano, Alvo);

            Console.ReadKey();
        }

        static String Tipodedano()
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

        static void Danos(out int damage, out String type, out int penetration, out int slicing)
        {
            Console.Write("Digite Seu Dano: ");
            damage = 0;
            bool loop = true;
            string? input;

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
                    Console.WriteLine("Valor Invalido, Insira um Numero.");
                    Console.WriteLine();
                }
            }

            type = Tipodedano();

            Console.Write("Digite Sua Penetracao: ");
            penetration = 0;
            bool loop1 = true;
            string? input1;

            while (loop1)
            {
                input1 = Console.ReadLine();
                if (input1 != null && int.TryParse(input1, out penetration))
                {
                    Console.WriteLine("Penetracao Inserida: " + penetration);
                    Console.WriteLine();
                    loop1 = false;
                }
                else
                {
                    Console.WriteLine("Valor Invalido, Insira um Numero.");
                    Console.WriteLine();
                }
            }

            Console.Write("Digite Seu Fatiamento: ");
            slicing = 0;
            bool loop2 = true;
            string? input2;

            while (loop2)
            {
                input2 = Console.ReadLine();
                if (input2 != null && int.TryParse(input2, out slicing))
                {
                    Console.WriteLine("Fatiamento Inserido: " + slicing);
                    Console.WriteLine();
                    loop2 = false;
                }
                else
                {
                    Console.WriteLine("Valor Invalido, Insira um Numero.");
                    Console.WriteLine();
                }
            }
        }

        static void Resistencias(out int healthmax, out int armor, out int reflection, out int shield, out int durability, out int health)
        {
            Console.Write("Digite a Vida Maxima do Alvo: ");
            healthmax = 0;
            bool loop = true;
            string? input;

            while (loop)
            {
                input = Console.ReadLine();
                if (input != null && int.TryParse(input, out healthmax))
                {
                    Console.WriteLine("Vida Maxima Inserida: " + healthmax);
                    Console.WriteLine();
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Valor Invalido, Insira um Numero.");
                    Console.WriteLine();
                }
            }

            Console.Write("Digite a Armadura do Alvo: ");
            armor = 0;
            bool loop1 = true;
            string? input1 = "";

            while (loop1)
            {
                input1 = Console.ReadLine();
                if (input1 != null && int.TryParse(input1, out armor))
                {
                    Console.WriteLine("Armadura Inserida: " + armor);
                    Console.WriteLine();
                    loop1 = false;
                }
                else
                {
                    Console.WriteLine("Valor Invalido, Insira um Numero.");
                    Console.WriteLine();
                }
            }

            Console.Write("Digite a Reflexao do Alvo: ");
            reflection = 0;
            bool loop2 = true;
            string? input2;

            while (loop2)
            {
                input2 = Console.ReadLine();
                if (input2 != null && int.TryParse(input2, out reflection))
                {
                    Console.WriteLine("Reflexao Inserida: " + reflection);
                    Console.WriteLine();
                    loop2 = false;
                }
                else
                {
                    Console.WriteLine("Valor Invalido, Insira um Numero.");
                    Console.WriteLine();
                }
            }

            Console.Write("Digite o Escudo do Alvo: ");
            shield = 0;
            bool loop3 = true;
            string? input3;

            while (loop3)
            {
                input3 = Console.ReadLine();
                if (input3 != null && int.TryParse(input3, out shield))
                {
                    Console.WriteLine("Escudo Inserido: " + shield);
                    Console.WriteLine();
                    loop3 = false;
                }
                else
                {
                    Console.WriteLine("Valor Invalido, Insira um Numero.");
                    Console.WriteLine();
                }
            }

            Console.Write("Digite a Durabilidade do Alvo: ");
            durability = 0;
            bool loop4 = true;
            string? input4;

            while (loop4)
            {
                input4 = Console.ReadLine();
                if (input4 != null && int.TryParse(input4, out durability))
                {
                    Console.WriteLine("Durabilidade Inserida: " + durability);
                    Console.WriteLine();
                    loop4 = false;
                }
                else
                {
                    Console.WriteLine("Valor Invalido, Insira um Numero.");
                    Console.WriteLine();
                }
            }

            Console.Write("Digite a Vida Atual do Alvo: ");
            health = 0;
            bool loop5 = true;
            string? input5;

            while (loop5)
            {
                input5 = Console.ReadLine();
                if (input5 != null && int.TryParse(input5, out health))
                {
                    Console.WriteLine("Vida Atual Inserida: " + health);
                    Console.WriteLine();
                    loop5 = false;
                }
                else
                {
                    Console.WriteLine("Valor Invalido, Insira um Numero.");
                    Console.WriteLine();
                }
            }
        }

        static void Display(Dano Dano, Alvo Alvo)
        {
            Console.WriteLine($"Tipo de Dano Geral: {Dano.generaltype[Dano.generalfigure]}");
            Console.WriteLine($"Dano: {Dano.dano}");
            Console.WriteLine($"Penetracao: {Dano.penetracao}");
            Console.WriteLine($"Fatiamento: {Dano.fatiamento}");
            Console.WriteLine();

            Console.WriteLine("Efeitos do Dano:");
            Console.WriteLine($"Sangramento: {Dano.sangramento}");
            Console.WriteLine($"Atordoamento: {Dano.atordoamento}");
            Console.WriteLine($"Vulneravel: {Dano.vulneravel}");
            Console.WriteLine($"Cauterizacao: {Dano.cauterizacao}");
            Console.WriteLine($"Veneno: {Dano.veneno}");
            Console.WriteLine($"Lentidao: {Dano.lentidao}");
            Console.WriteLine($"Cadeia: {Dano.cadeia}");
            Console.WriteLine();

            Console.WriteLine("Status do Alvo: ");
            Console.WriteLine($"Vida Maxima do Alvo: {Alvo.vidamax}");
            Console.WriteLine($"Armadura do Alvo: {Alvo.armadura}");
            Console.WriteLine($"Reflexao do Alvo: {Alvo.reflexao}");
            Console.WriteLine($"Escudo do Alvo: {Alvo.escudo}");
            Console.WriteLine($"Durabilidade do Alvo: {Alvo.durabilidade}");
            Console.WriteLine($"Vida Atual do Alvo: {Alvo.vida}");
            Console.WriteLine();
        }

        static void Lingering(Dano Dano)
        {
            bool confirma = true;
            string? input;

            while (confirma)
            {

                Console.Write("O Alvo esta Envenenado? (Sim/Nao) ");
                input = Console.ReadLine();

                if (input != null)
                {
                    confirma = input.ToLower() switch
                    {
                        "sim" => false,
                        "nao" => false,
                        _ => true
                    };

                    if (input.ToLower() == "sim")
                    {
                        Dano.veneno = true;
                    }
                }
                else
                {
                    confirma = true;
                }
                if (confirma)
                {
                    Console.WriteLine("Resposta Invalida Inserida: " + input);
                    Console.WriteLine();
                }
            }
            Console.WriteLine();

            bool confirma1 = true;
            string? input1;

            while (confirma1)
            {

                Console.Write("O Alvo esta Vulneravel? (Sim/Nao) ");
                input1 = Console.ReadLine();

                if (input1 != null)
                {
                    confirma1 = input1.ToLower() switch
                    {
                        "sim" => false,
                        "nao" => false,
                        _ => true
                    };
                    if (input1.ToLower() == "sim")
                    {
                        Dano.vulneravel = true;
                    }
                }
                else
                {
                    confirma1 = true;
                }

                if (confirma1)
                {
                    Console.WriteLine("Resposta Invalida Inserida: " + input1);
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        class Dano
        {
            public string[] generaltype = { "Fisico", "Magico", "Verdadeiro" };
            public int dano { get; }
            public string tipo { get; }
            public int penetracao { get; }
            public int fatiamento { get;}
            public string categoria { get; }
            public int generalfigure { get; private set; }
            
            public bool sangramento { get; private set; }
            public bool atordoamento { get; private set; }
            public bool vulneravel { get; set; }
            public bool cauterizacao { get; private set; }
            public bool veneno { get; set; }
            public bool lentidao { get; private set; }
            public bool cadeia { get; private set; }

            public Dano(int dano, String tipo, int penetracao, int fatiamento)
            {
                this.dano = dano;
                this.tipo = tipo;
                this.penetracao = penetracao;
                this.fatiamento = fatiamento;
                this.categoria = Tipogeral(tipo);
                Efeito(tipo);
            }

            private string Tipogeral(string tipo)
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

            private void Efeito(string tipo)
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

        class Alvo
        {
            public int vidamax { get; }
            public int armadura { get; }
            public int reflexao { get; }
            public int escudo { get; }
            public int durabilidade {  get; }
            public int vida { get; }

            public Alvo(int vidamax, int armadura, int reflexao, int escudo, int durabilidade, int vida)
            {
                this.vidamax = vidamax;
                this.armadura = armadura;
                this.reflexao = reflexao;
                this.escudo = escudo;
                this.durabilidade = durabilidade;
                this.vida = vida;
            }
        }
    }
}
