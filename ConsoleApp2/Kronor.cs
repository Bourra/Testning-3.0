using System;

namespace Lektion2
{
    public class Kronor
    {
        /*
         * Totala värdet i öre. 
         * När vi väl har skapat ett Kronor-objekt ska det aldrig kunna ändras
         */
        private readonly int öre;


        // Skapar tom Kronor
        public Kronor()
        {

        }

        // Skapar kopia av en annan Kronor
        // Korrigerat fel: borde inte multiplicera med 100
        public Kronor(Kronor kronor)
        {
            öre = kronor.öre;
        }
        /*
         * Skapar Kronor med initialt värde
         */
        // Korrigerat fel: skrev om uträkningen
        public Kronor(int kronor, int öre)
        {
            this.öre = kronor * 100 + öre;
        }

        /*
         * Returnerar kronordelen av kronorna
         */
        // Fel: Räknar inte kronor rätt
        // Korrigerat fel: 100 istället för 10

        public int KronorPart()
        {
            return öre / 100;
        }


        /*
         * Returnerar öresdelen av kronorna
         */

        // Fel: Räknar inte ören rätt
        // Korrigerat fel: 100 istället för 10
        public int ÖrenPart()
        {
            return öre % 100;
        }
        /*
         * Adderar den här Kronor med other och returnerar resultatet
         */
        // Fel: Räknar inte rätt
        // Korrigerat fel: Ändrade på paranteserna
        public Kronor Add(Kronor other)
        {

            var temp = (this.KronorPart() + other.KronorPart()) * 100 + this.ÖrenPart() + other.ÖrenPart();
            var tempKronor = temp / 100;
            var tempÖren = temp % 100;

            return new Kronor(tempKronor, tempÖren);
        }
        // Fel: Räknar inte rätt
        // Korrigerat fel: Ändrade på paranteserna och tog bort * 10
        public Kronor Subtract(Kronor other)
        {
            var temp = (this.KronorPart() - other.KronorPart()) * 100 + (this.ÖrenPart() - other.ÖrenPart());
            var tempKronor = temp / 100;
            var tempÖren = temp % 100;

            return new Kronor(tempKronor, tempÖren);
        }
        /*
         * Returnerar sant om kronorna har ett positivt värde
         */
        public bool IsPositive()
        {
            return öre > 0;
        }

        /*
         * Returnerar sant om kronorna har ett negativt värde
         */
        public bool isNegative()
        {
            return öre < 0;
        }

        /*
         * Returnerar sant om kronorna har ett värde på 0
         */
        public bool isZero()
        {
            return öre == 0;
        }
    }
}
