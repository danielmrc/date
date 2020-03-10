using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_ex3._1
{
    public class date5
    {
        private int dia, mes, ano;
        private static int[] numDias = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public date5()
        {
            dia = 1; mes = 1; ano = 1900;
        }

        public date5(int d, int m, int a)
        {
            if ((d > 0) && (d <= numDias[m - 1]))
            {
                this.dia = d;
            }
            else { this.dia = 1; }

            if ((m > 0) && (m < 13))
            {
                this.mes = m;
            }
            else { this.mes = 1; }

            if ((a > 1900) && (a <= 2050))
            {
                this.ano = a;
            }
            else { this.ano = 1900; }

        }

        public void setDia(int d)
        {
            this.dia = d;
        }

        public void setMes(int m)
        {
            this.mes = m;
        }

        public void setAno(int a)
        {
            this.ano = a;
        }

        public int getDia()
        {
            return this.dia;
        }

        public int getMes()
        {
            return this.mes;
        }

        public int getAno()
        {
            return this.ano;
        }

        public string retornaStringP(int d, int m, int a)
        {
            string extenso2;
            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };


            extenso2 = d + " de " + meses[m - 1] + " de " + a;

            return (extenso2);
        }
        public string retornaString()
        {
            string extenso;
            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

            extenso = this.dia + " de " + meses[this.mes - 1] + " de " + this.ano;

            return (extenso);
        }

        public void proxDia()
        {
            if ((this.dia < numDias[this.mes - 1]) && (this.mes <= 12) && (this.ano <= 2050))
            {
                this.dia++;
            }
            else if ((this.dia == numDias[this.mes - 1]) && (this.mes < 12) && (this.ano <= 2050))
            {
                this.dia = 1;
                this.mes++;
            }
            else if ((this.dia == numDias[this.mes - 1]) && (this.mes == 12) && (this.ano == 2050))
            {
                this.dia = 1;
                this.mes = 1;
                this.ano = 1900;
            }
            else
            {
                Console.WriteLine("Não há suporte para está data!");
            }
        }

        public int calcDif(int dia1, int mes1, int ano1, int dia2, int mes2, int ano2)
        {
            int d = 0, dif = 0, s = 0, dias = 0, d2 = 0;

            if (mes2 < mes1 && ano2 < ano1)
            {
                return (-1);
            }
            else if ((dia1 == dia2) && (mes1 == mes2) && (ano1 == ano2))
            {
                return (0);
            }
            else if ((mes2 < mes1) && (ano2 - ano1) < 2)
            {
                dif = 12 - (mes1 - mes2);
                for (int i = 0; i < dif; i++)
                {
                    d = d + numDias[mes1 - 1];

                    if (mes1 == 12)
                    {
                        mes1 = 1;
                    }
                    mes1++;
                }
                s = (dia2 - dia1) + d;

                return (s);

            }
            else
            {
                dif = ano2 - ano1;

                dias = dif * 365;
                for (int i = 0; i < mes1; i++)
                {
                    d = d + numDias[i];
                }
                for(int i = 0; i < mes2; i++)
                {
                    d2 = d2 + numDias[i];
                }
                s = ((dias + d2) - d + (dia2 - dia1));

                return (s);
            }

        }

        public int diaA() 
        {
            int result = 0;

            for(int i = 0; i < this.mes; i++)
            {
                result = result + numDias[i];
            }

            result = result - (numDias[this.mes -1] - this.dia);

            return (result);
        }

        public int diaP(int d, int m, int a)
        {
            int result = 0, dias = 0;

            for (int i = 0; i < m; i++)
            {
                result = result + numDias[i];
                
            }
            result = result - (numDias[m -1] - d);

            return (result);
        }




    }
}
