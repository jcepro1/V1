using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenvect12023
{
    class Nent
    {
        private int n;
        public Nent()
        {
            n = 0;
        }

        public void cargar(int dato)
        {
            n = dato;
        }

        public int descargar()
        {
            return n;
        }


        public bool VerifPar()
        {
            int r;
            Boolean b;

            r = n % 2;
            if (r == 0)
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return b;

        }


        public bool Verif_num_mult(int num)
        {
            int r;
            bool b;

            r = n % num;
            if (r == 0)
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return b;
        }



        public bool Verif_num_submult(int num)
        {
            int r;
            bool b;

            r = num % n;
            if (r == 0)
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return b;
        }



        public bool verifprimo()
        {
            int c, i, r;
            c = 0;
            for (i = 1; i <= n; i = i + 1)
            {
                r = n % i;
                if (r == 0)
                    c++;
            }

            return (c == 2);

        }



        public void Invertir_num()
        {
            int nn, d;
            nn = 0;
            while (n > 0)
            {
                d = n % 10;
                n = n / 10;
                nn = nn * 10 + d;
            }
            n = nn;
        }

        public bool Verif_num_capicua()
        {
            int na;
            bool b;
            na = 0;
            na = n;
            Invertir_num();
            b = n == na;

            return b;

        }


        public bool verif_fibo()
        {
            int a = -1;
            int b = 1;
            int c;
            do
            {
                c = a + b;
                a = b;
                b = c;
            }
            while (!((c == n) || (c > n)));
            return c == n;
        }

        public double factorial()
        {
            double Fac = 1.0;
            if (n != 0)
            {
                int num = Math.Abs(n);
                for (int c = num; c >= 1; c = (c + -1))
                {
                    Fac *= (double)c;

                }
                if (n < 0)
                {
                    Fac = 0.0 - Fac;
                }
            }
            return Fac;
        }


        public bool Verif_orden_asc()
        {
            Nent dr = new Nent();
            bool b = true;
            int na = n;
            dr.n = na % 10;
            na /= 10;
            while (na > 0 && b)
            {
                int d = na % 10;
                na /= 10;
                if (d <= dr.n)
                {
                    dr.n = d;
                }
                else
                {
                    b = false;
                }
            }
            return b;
        }

        public bool verifcapi()
        {
            bool b = false;
            int nu = 0;
            int aux = n;
            while (n > 0)
            {
                int dig = n % 10;
                n /= 10;
                nu = (nu * 10 + dig);
            }
            if (nu == aux)
            {
                b = true;
            }
            n = aux;
            return b;
        }

        public bool veriffibo()
        {
            int a, b, c;
            a = -1;
            b = 1;
            c = 0;
            while (c < n)
            {
                c = a + b;
                a = b;
                b = c;
            }
            if (c == n)
            {
                return true;
            }
            return false;
        }

    
}
}
