class JogoDivertido
{
    static void Main(string[] args)
    {

        Console.WriteLine("Qual seu nome?");

        string nomeDoUsuario = Console.ReadLine();

        Console.WriteLine($"Olá {nomeDoUsuario}");
        Console.WriteLine($"""
    Você é um guerreiro, que está de frente ao pé da montanha
    se preparando para subi-la, então avista um senhor, ele diz:
    Boa tarde garoto, {nomeDoUsuario} é?... Os deuses me dizem que
    o seu nome ecoará por muito tempo, você sera o que trará muita
    alegria, mas também muita desgraça.
    Você carrega alguma arma consigo?
    """);

        Console.WriteLine(
            "1-Sim\n" +
            "2-Não");
        string RespostaArma = Console.ReadLine();
        while (RespostaArma != "1" && RespostaArma != "2")
        {
            Console.WriteLine("Não entendi, viajante...");
            RespostaArma = Console.ReadLine();
        }
        if (RespostaArma == "1")
        {
            Console.WriteLine("Muito bem, então siga em frente, já tem tudo o que precisa.");
        }
        if (RespostaArma == "2")
        {
            Console.WriteLine("Então não se acanhe, que tipo de arma gosta?");
            Thread.Sleep(1000);
            

            do
            {
                Console.WriteLine("1-Espada\n" +
                "2-Arco\n" +
                "3-Machado\n" +
                "4-Cajado\n" +
                "5-Adaga");
                string respostaTipoArma = Console.ReadLine();
                if (respostaTipoArma == "1" || respostaTipoArma == "2" || respostaTipoArma == "3" || respostaTipoArma == "4" || respostaTipoArma == "5")
                {
                    string resultado = respostaTipoArma switch
                    {
                        "1" => "Aqui está sua Espada, abençoada com o sangue dos dragões!",
                        "2" => "Aqui está seu arco, com a benção de Zéfiro!",
                        "3" => "Aqui está seu machado, imbuida com a raiz dos ents!",
                        "4" => "Aqui está seu cajado, pertenceu ao mago negro, usado na guerra arcana.",
                        "5" => "Aqui está sua adaga, do antigo rei dos ladinos."
                    };
                    Console.WriteLine(resultado);
                    break;
                }
                else
                {
                    Console.WriteLine("Não entendi...");
                }
            } while (true);
        }Console.WriteLine("O codigo até aqui está dando certo");
        
    }
}
public class Atributos
{
    public double Vida {  get; set; }
    public double Forca { get; set; }
    public double Defesa { get; set; }
    public double Agilidade { get; set; }

    public Atributos(double vida, double forca, double defesa, double agilidade)
    {
        vida = Vida;
        forca = Forca;
        defesa = Defesa;
        agilidade = Agilidade;
    }
    
}
class Player : Atributos
{
    public string Nome { get; set; }
    public Player(string nome, double vida, double forca, double defesa, double agilidade)
        : base(vida, forca, defesa, agilidade)
    {
        Nome = nome;
    }
        
}
class Enemy : Atributos
{
    public string Nome { get; set; }
    public Enemy(string nome, double vida, double forca, double defesa, double agilidade)
        : base(vida, forca, defesa, agilidade)
    {
        Nome = nome;
    }
}
class Weapon {
}