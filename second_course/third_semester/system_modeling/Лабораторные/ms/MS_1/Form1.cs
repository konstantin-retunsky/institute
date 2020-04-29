using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void BtnStart_Click(object sender, EventArgs e)
        {
            int countWorker = int.Parse(tbCountWorkers.Text);
            double h = double.Parse(tbValH.Text);
            double t = double.Parse(tbValT.Text) / 60;

            double m = 1/t;

            double a = h / m;

            double probQ = 0;

            if (countWorker > a)
            {
                dgvProbs.Rows.Clear();
                for (int i = 0; i <= countWorker; i++)
                {
                    double temp = GetProb(a, i, countWorker);
                    probQ += temp;
                    dgvProbs.Rows.Add("p"+i, temp);
                }
                labelProbQ.Text = (1-probQ).ToString();

                double Nq;
                double Wq;
                double Ns;

                Nq = GetNq(a, countWorker);
                labelAvgQ.Text = Nq.ToString();

                Wq = Nq / h * 60;
                labelAvgTimeInQ.Text = Wq.ToString();

                Ns = a;
                labelAvgNs.Text = Ns.ToString();
            }
        }

        static double GetNq(double a, int n)
        {
            double top = Math.Pow(a, n + 1) / ((double) n * Fact(n) * Math.Pow((1 - a / n), 2));
            double bottom1 = 0;
            for (int i = 0; i <= n; i++)
            {
                bottom1 += Math.Pow(a, i) / Fact(i);
            }
            double bottom2 = Math.Pow(a, n + 1) / (Fact(n) * (n - a));

            return top / (bottom1 + bottom2);
        }

        static double GetProb(double a, int k, int n)
        {
            double top = Math.Pow(a, k) / Fact(k);

            double bottom1 = 0;
            for (int i = 0; i <= n; i++)
            {
                bottom1 += Math.Pow(a, i) / Fact(i);
            }

            double bottom2 = Math.Pow(a, n + 1) / (Fact(n) * (n - a));

            return top / (bottom1 + bottom2);
        }

        static int Fact(int n)
        {
            int res = 1;
            for(int i = 1; i <= n; i++)
            {
                res *= i;
            }

            return res;
        }

        private void BtnStart2nd_Click(object sender, EventArgs e)
        {
            int countWorker = int.Parse(tbCountWorkers.Text);
            double h = double.Parse(tbValH.Text);
            double t = double.Parse(tbValT.Text) / 60;
            double tMax = double.Parse(tbPrefTime.Text);

            double m = 1 / t;

            double a = h / m;

            int preferN = (int) Math.Ceiling(a);
            while(GetNq(a, preferN)/h  > tMax/60)
            {
                preferN++;
            }

            prefNumWorker.Text = preferN.ToString();


            double probQ = 0;
            dgvProbs.Rows.Clear();
            for (int i = 0; i <= preferN; i++)
            {
                double temp = GetProb(a, i, preferN);
                if(i < preferN-1) probQ += temp;
                dgvProbs.Rows.Add("p" + i, temp);
            }
            moreThan1.Text = (probQ).ToString();
        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }
    }
}
