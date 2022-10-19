using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borelli_TelecomandoTV
{
    public class Caldaia
    {
        private string produttore;
        private string modello;
        private string numSerie;
        private DateTime dataInstallazione;
        private bool stato;
        private int funzionamento;//0=risc+h20 1=h20
        private int tempAcqua;
        private int tempRiscaldamento;

        public Caldaia(string prod, string mod, string numSer, DateTime dataInst)
        {
            setProduttore(prod);
            setModello(mod);
            setNumSerie(numSer);
            setDataInstallazione(dataInst);
            setFunzionamento(0);

            inizializzaVariabili();//inzializzo le altre variabili
        }

        public string getProduttore() { return produttore; }
        public string getModello() { return modello; }
        public string getNumSerie() { return numSerie; }
        public DateTime getDataInstallazione() { return dataInstallazione; }
        public bool getStato() { return stato; }
        public int getFunzionamento() { return funzionamento; }
        public int getTempAcqua() { return tempAcqua; }
        public int getTempRiscaldamento() { return tempRiscaldamento; }
        public string getStatoFunzionamento()
        {
            if (!(tempAcqua > 10 && tempAcqua < 40) && getStato())
                return "La temperatura dell'acqua è fuori dai range. Assicurarsi di averla impostata correttamente";
            else if (!(tempRiscaldamento > 10 && tempRiscaldamento < 40) && getFunzionamento() == 0 && getStato())
                return "La temperatura del riscaldamento è fuori dai range. Assicurarsi di averla impostata correttamente";
            else
                return null;
        }

        public void setTempAcqua(int tmpAcq)
        {
            if ((tmpAcq > 10 && tmpAcq < 40) && getStato())
                tempAcqua = tmpAcq;
            else
                throw new Exception("Impostare valori accettabili");
        }
        public void setTempRiscaldamento(int tmpRsc)
        {
            if ((tmpRsc > 10 && tmpRsc < 40) && getFunzionamento() == 0 && getStato())
                tempRiscaldamento = tmpRsc;
            else
                throw new Exception("Impostare valori accettabili");
        }
        public void accendi()
        {
            setStato(true);
        }
        public void spegni()
        {
            setStato(false);
        }
        public void setFunzionamento(int funz)
        {
            if ((funz == 0 || funz == 1) && getStato())
                funzionamento = funz;
        }

        private void inizializzaVariabili()
        {
            funzionamento = 0;
            tempAcqua = -1;
            tempRiscaldamento = -1;
        }
        private void setStato(bool nuovoStato)
        {
            stato = nuovoStato;
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
        private void setDataInstallazione(DateTime dataInst)
        {
            dataInstallazione = dataInst;
        }
    }
}
