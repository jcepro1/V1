using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace examenvect12023
{
    class Vector
    {
        const int MAX = 100;
        private int[] v;
        private int n;
        public Vector()
        {
            n = 0;
            v = new int[MAX];
        }


        public void cargardato(int nele)
        {
            n = nele;//JCE
            int num = n;
            for (int i = 1; i <= num; i++)
            {//JCE
                v[i] = Conversions.ToInteger(Interaction.InputBox(" ", " "));
            }
        }



        public void Cargar_rnd(int n1, int a, int b)
        {
            Random r;
            r = new Random();
            int i;
            n = n1;
            for (i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b);
            }

        }


        public string descargar()
        {
            string s;
            int i;
            s = "";
            for (i = 1; i <= n; i++)
            {
                s = s + v[i] + " | ";
            }
            return s;
        }

        //examen
        public void examen7p1(Vector e, Vector f, int a, int b)
        {
            Nent numero = new Nent();
            //OrdenarSegVec(a, b);
            for (int i = a; i <= b; i++)
            {
                numero.cargar(v[i]);

                if (numero.veriffibo())
                {
                    int ele = v[i];
                    int frec = frec_elem_segmento(v[i], a, b);
                    if (e.frecuencia(ele) == 0)
                    {
                        e.insertar(ele);
                        f.insertar(frec);
                    }

                }

            }
            e.ordenarAsc();
            f.ordenarDesc();

        }
        public int frec_elem_segmento(int elem, int a, int b)
        {
            int c = 0;
            int num = a;
            int num2 = b;
            checked
            {
                for (int i = num; i <= num2; i++)
                {

                    if (elem == v[i])
                    {
                        c++;
                    }
                }
                return c;
            }
        }

        public int frecuencia(int ele)
        {
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                if (v[i] == ele)
                {
                    c++;
                }
            }
            return c;
        }
        private void insertar(int ele)
        {
            n++;
            v[n] = ele;
        }

        public void ordenarAsc()
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    if (v[i] > v[j])
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
            }
        }
        public void ordenarDesc()
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    if (v[i] < v[j])
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
            }
        }


    }
}
