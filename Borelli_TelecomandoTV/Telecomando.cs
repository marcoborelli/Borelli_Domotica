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
        private TV telev;

        public Telecomando(string prod, string mod, int funz, TV ilTelev)
        {
            setProduttore(prod);
            setModello(mod);
            setFunzionamento(funz);
            setTV(ilTelev);
            if (telev != null)
            {
                telev.setVolume(0);
                telev.setCanale(1);
            }
        }
        public Telecomando(string prod, string mod, int funz)
        {
            setProduttore(prod);
            setModello(mod);
            setFunzionamento(funz);
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
        public string getTV()
        {
            return $"{telev}";
        }

        public void Accendi()
        {
            if (telev != null)
                telev.accendi();
        }
        public void Spegni()
        {
            if (telev != null)
                telev.spegni();
        }
        public void setCanale(int nuovoCanale)
        {
            if (telev != null && (nuovoCanale > 0 && nuovoCanale < 1000)&&telev.getStato())
                telev.setCanale(nuovoCanale);
        }
        public void setVolume(int nuovoVolume)
        {
            if (telev != null && (telev.getVolume() + nuovoVolume > 0 && telev.getVolume() + nuovoVolume < 100) && telev.getStato())
                telev.setVolume(nuovoVolume);
        }
        public void AumentaVolume()
        {
            if (telev != null && (telev.getVolume() + 1 < 100) && telev.getStato())
                telev.AumentaVolume();
        }
        public void DiminuisciVolume()
        {
            if (telev != null && (telev.getVolume() - 1 >= 0) && telev.getStato())
                telev.DiminuisciVolume();
        }
        public void setTV(TV laTV)
        {
            telev = laTV;
        }

        private void setProduttore(string IlProd)
        {
            produttore = IlProd;
        }
        private void setModello(string IlMod)
        {
            modello = IlMod;
        }
        private void setFunzionamento(int IlFunz)
        {
            funzionamento = IlFunz;
        }
    }
}
