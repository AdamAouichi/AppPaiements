using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {
        CarteCredit a = new CarteCredit(100000,"bmw",300140222);
        CarteCredit b = new CarteCredit(1000000000,"achat maison",300110100);
        CarteCredit c = new CarteCredit(2000, "achat ordinateur", 300200251);


        a.AfficherDetails();
        b.AfficherDetails();
        c.AfficherDetails();

        Paypal d = new Paypal("adam.aouichi@gmail.com", 30000000, "compte principale");
        Paypal e = new Paypal("simon.marcus@gmail.com", 20000000, "compte depargne");
       
        d.AfficherDetails();
        e.AfficherDetails();

    }

}