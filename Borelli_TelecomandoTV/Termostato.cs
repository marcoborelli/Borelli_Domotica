using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borelli_TelecomandoTV
{
    public class Termostato
    {
        private string produttore;
        private string modello;
        private string numSerie;
        private Caldaia cald;
        public Termostato(string prod, string mod,string numSer)
        {
            setProduttore(prod);
            setModello(mod);
            setNumSerie(numSer);
        }
        public Termostato(string prod, string mod, string numSer, Caldaia caldaiuccia)
        {
            setProduttore(prod);
            setModello(mod);
            setNumSerie(numSer);
            setCaldaia(caldaiuccia);
        }

        public string getFunzionamentoCaldaia()
        {
            if (cald != null)
                return cald.getStatoFunzionamento();
            else
                throw new Exception("ASSOCIARE UNA CALDAIA");

        }
        public int getTempRiscaldamento()
        {
            if (cald != null)
                return cald.getTempRiscaldamento();
            else
                throw new Exception("ASSOCIARE UNA CALDAIA");
        }
        public int getTempAcqua()
        {
            if (cald != null)
                return cald.getTempAcqua();
            else
                throw new Exception("ASSOCIARE UNA CALDAIA");

        }
        public void setTempRiscaldamento(int tmpRsc)
        {
            if (cald != null)
                cald.setTempRiscaldamento(tmpRsc);
        }
        public void setTempAcqua(int tmpAcq)
        {
            if (cald != null && cald.getStato())
                cald.setTempAcqua(tmpAcq);
        }
        public void setFunzionamento(int funz)
        {
            if (cald != null && cald.getStato())
                cald.setFunzionamento(funz);
        }
        public void Accendi()
        {
            if (cald != null)
                cald.accendi();
        }
        public void Spegni()
        {
            if (cald != null)
                cald.spegni();
        }
        public void setCaldaia(Caldaia caldarietta)
        {
            cald = caldarietta;
        }

        private void setProduttore(string prod)
        {
            produttore = prod;
        }
        private void setModello(string mod)
        {
            modello = mod;
        }
        private void setNumSerie(string numSer)
        {
            numSerie = numSer;
        }
    }
}
