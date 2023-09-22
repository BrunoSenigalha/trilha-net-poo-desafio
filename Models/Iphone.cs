namespace DesafioPOO.Models
{
    // FEITO!!!
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // FEITO!!!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.Write("Instalando o aplicativo " + nomeApp + " no Iphone");
        }
    }
}