using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borelli_TelecomandoTV
{
    public class Telecomando
    {
        private string produttore;
        private string modello;
        private int funzionamento; //1=infrarossi 2=blutut 3=wifi
        private bool stato;
        private int canale;
        private int volume;

        public Telecomando(string prod, string mod, int funz)
        {
            produttore = prod;
            modello = mod;
            funzionamento = funz;
        }

        public string getProduttore()
        {
            return produttore;
        }
        public string getModello()
        {
            return modello;
        }
        public int getFunzionamento()
        {
            return funzionamento;
        }
        public int getCanale()
        {
            return canale;
        }
        public int getVolume()
        {
            return volume;
        }
        public bool getStato()
        {
            return stato;
        }

        public void Accendi()
        {
            setStato(true);
        }
        public void Spegni()
        {
            setStato(false);
        }
        public void setCanale(int nuovoCanale)
        {
            canale = nuovoCanale;
        }
        public void CambiaVolume(int nuovoVolume)
        {
            if (volume + nuovoVolume > 0 && volume + nuovoVolume < 100)
                volume += nuovoVolume;
        }
        private void setStato(bool statoNuovo)
        {
            stato = statoNuovo;
        }
    }
}
