using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {

        Iphone meuIphone = new Iphone("123456789", "iPhone 12", "111222333444555", 64)
        meuIphone.Ligar();
        meuIphone.ReceberLigacao();
        meuIphone.InstalarAplicativo("WhatsApp");

        Nokia meuNokia = new Nokia("123456789", "iPhone 12", "111222333444555", 64);
        meuNokia.Ligar();
        meuNokia.ReceberLigacao();
        meuIphone.InstalarAplicativo("WhatsApp");
    }
}
