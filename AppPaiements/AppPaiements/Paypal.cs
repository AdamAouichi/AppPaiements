using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Paypal: Paiement
    {
        public string Courriel {  get; set; }

        public Paypal(string courriel, double montant, string description) : base(montant, description)
        { 
        Courriel= courriel;
        }
        public override void AfficherDetails()
        {
            Console.WriteLine($"le montant du paement est:{Montant},la description:{Description},le courriel est {Courriel}");
        }

    }
}
