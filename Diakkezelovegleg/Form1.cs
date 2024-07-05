using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Diakkezelovegleg
{

    public partial class Form1 : Form
    {
        public List<Diak> diak = new List<Diak>();
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            GombBeallitas(true);
        }
        private void GombBeallitas(bool b)
        {
            btnAdatbevitel.Enabled = b;
            btnKivalaszt.Enabled = !b;
        }

        private void adatbevitel_Click(object sender, EventArgs e)
        {
            Adatbevitel();
            GombBeallitas(false);
        }

        private void kivalaszt_Click(object sender, EventArgs e)
        {
            lstLegidosebbek.Items.Clear();
            lstKivalaszottak.Items.Clear();
            List<Diak> list = new List<Diak>();
            foreach (UserControl1 item in pnlDiakok.Controls)
            {
                if (item.Checked)
                {
                    list.Add(item.Diak);
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                lstKivalaszottak.Items.Add(list[i]);
            }
            try
            {

                int max = list[0].Idos;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Idos < max)
                    {
                        max = list[i].Idos;
                    }
                }
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Idos == max)
                    {
                        lstLegidosebbek.Items.Add(list[i]);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nem választott ki semmit");
            }
            
        }

        private void Adatbevitel()
        {
            DialogResult eredmeny = openFileDialog1.ShowDialog();
            if (eredmeny == DialogResult.OK)
            {
                string fajlNev = openFileDialog1.FileName;
                try
                {
                    AdatBeolvasas(fajlNev);
                    FelrakDiakok();
                    GombBeallitas(true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba a fájl beolvasásakor", "Hiba");
                }
            }
        }
        private void AdatBeolvasas(string fajlNev)
        {

            StreamReader sr = new StreamReader(fajlNev);
            while (!sr.EndOfStream)
            {
                string sor;
                string[] s;
                sor = sr.ReadLine();
                s = sor.Split(';');
                diak.Add(new Diak(s[0], s[1], int.Parse(s[2])));
            }
            sr.Close();
        }
        private void FelrakDiakok()
        {
            for (int i = 0; i < diak.Count; i++)
            {
                int felso = i * 52 - pnlDiakok.AutoScrollPosition.Y;
                UserControl1 control1 = new UserControl1(diak[i]);
                control1.Top = felso;
                pnlDiakok.Controls.Add(control1);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                kivalsztott.Text = $"{diak[lstKivalaszottak.SelectedIndex].Neve}  {diak[lstKivalaszottak.SelectedIndex].Kodos}  {diak[lstKivalaszottak.SelectedIndex].Idos}";

            }
            catch (Exception)
            {
                MessageBox.Show("A nevekre kattintson.");
            }
        }
    }
    public class Diak
    {
        public string Neve;
        public string Kodos;
        public int Idos;

        public Diak(string nev, string kod, int ido)
        {
            Neve = nev;
            this.Kodos = kod;
            this.Idos = ido;
        }
        public override string ToString()
        {
            return Neve + ' ' + Kodos;
        }

    }
}
