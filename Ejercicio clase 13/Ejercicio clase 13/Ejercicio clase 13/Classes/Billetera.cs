using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_clase_13.Classes
{
    internal class Billetera
    {
        private int _billetesDe10;
        private int _billetesDe20;
        private int _billetesDe50;
        private int _billetesDe100;
        private int _billetesDe200;
        private int _billetesDe500;
        private int _billetesDe1000;
        public int BilletesDe10 { get { return _billetesDe10; } set { _billetesDe10 = value; } }
        public int BilletesDe20 { get { return _billetesDe20; } set { _billetesDe20 = value; } }
        public int BilletesDe50 { get { return _billetesDe50; } set { _billetesDe50 = value; } }
        public int BilletesDe100 { get { return _billetesDe100; } set { _billetesDe100 = value; } }
        public int BilletesDe200 { get { return _billetesDe200; } set { _billetesDe200 = value; } }
        public int BilletesDe500 { get { return _billetesDe500; } set { _billetesDe500 = value; } }
        public int BilletesDe1000 { get { return _billetesDe1000; } set { _billetesDe1000 = value; } }


        public decimal Total()
        {

            decimal DineroTotal = BilletesDe10 * 10 + BilletesDe20 * 20 + BilletesDe50 * 50
                + BilletesDe100 * 100 + BilletesDe200 * 200 + BilletesDe500 * 500 + BilletesDe1000 * 1000;

            return DineroTotal;
        }
        //public Billetera BilleterasCombinadas()
        //{
        //    return new Billetera
        //}


        public Billetera BilleteraCombinada;

        public Billetera Combinar(Billetera billetera1, Billetera billetera2)
        {
            Billetera billetera = new Billetera();
            billetera.BilletesDe10 = billetera1.BilletesDe10 + billetera2.BilletesDe10;
            billetera.BilletesDe20 = billetera1.BilletesDe20 + billetera2.BilletesDe20;
            billetera.BilletesDe50 = billetera1.BilletesDe50 + billetera2.BilletesDe50;
            billetera.BilletesDe100 = billetera1.BilletesDe100 + billetera2.BilletesDe100;
            billetera.BilletesDe200 = billetera1.BilletesDe200 + billetera2.BilletesDe200;
            billetera.BilletesDe500 = billetera1.BilletesDe500 + billetera2.BilletesDe500;
            billetera.BilletesDe1000 = billetera1.BilletesDe1000 + billetera2.BilletesDe1000;
            billetera1.BilletesDe10 = 0;
            billetera1.BilletesDe20 = 0;
            billetera1.BilletesDe50 = 0;
            billetera1.BilletesDe100 = 0;
            billetera1.BilletesDe200 = 0;
            billetera1.BilletesDe500 = 0;
            billetera1.BilletesDe1000 = 0;
            billetera2.BilletesDe10 = 0;
            billetera2.BilletesDe20 = 0;
            billetera2.BilletesDe50 = 0;
            billetera2.BilletesDe100 = 0;
            billetera2.BilletesDe200 = 0;
            billetera2.BilletesDe500 = 0;
            billetera2.BilletesDe1000 = 0;

            return billetera;
        }

    }
}
