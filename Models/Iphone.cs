namespace DesafioPOO.Models
{
      // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public  Iphone(string numero, string imie, string modelo, int memoria) : base(numero, imie, modelo, memoria)
        {

        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void  InstalarAplicativo(string nomeApp)
        { 
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no IPhone");
        } 
        
    }
}