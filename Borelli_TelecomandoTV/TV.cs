using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borelli_TelecomandoTV
{
    public class TV
    {
        private string produttore;
        private string modello;
        private string[] connettori;
        private bool stato;
        private int canale;
        private int volume;

        public TV(string ilproduttore, string ilmodello)//costruttore
        {
            produttore = ilproduttore;
            modello = ilmodello;
        }
        public TV()
        {

        }

        public bool getStato()
        {
            return stato;
        }
        public string[] getConnettori()
        {
            return connettori;
        }
        public int getVolume()
        {
            return volume;
        }
        public int getCanale()
        {
            return canale;
        }
        public string getProdutore()
        {
            return produttore;
        }
        public string getModello()
        {
            return modello;
        }

        public void accendi()
        {
            setStato(true);
        }
        public void spegni()
        {
            setStato(false);
        }
        public void setCanale(int nuovoCanale)
        {
            canale = nuovoCanale;
        }
        public void setVolume(int nuovoVolume)
        {
            volume += nuovoVolume;
        }
        public void AumentaVolume()
        {
            volume++;
        }
        public void DiminuisciVolume()
        {
            volume--;
        }
        public void SetConnettori(string[] nuoviConn)
        {
            connettori = new string[nuoviConn.Length];
            for (int i = 0; i < connettori.Length; i++)
                connettori[i] = nuoviConn[i];
        }
        private void setStato(bool nuovoStato)
        {
            stato = nuovoStato;
        }
    }
}
