using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonferenciaProjekt
{
    public partial class Main : Form
    {
        Dictionary<string, PictureBox> dict;
        List<string> pontozas;
        Konferencia konferencia;
        int index = 0;

        public Main()
        {
            dict = new Dictionary<string, PictureBox>();
            pontozas = new List<string>();
            konferencia = new Konferencia();
            InitializeComponent();
            Text = "KonferenciaProjekt";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            int setX = 280;
            int setY = 30;

            balra.Image = Image.FromFile(@"Resources\bal.jpg");
            jobbra.Image = Image.FromFile(@"Resources\jobb.jpg");
            mentes.Image = Image.FromFile(@"Resources\ment.jpg");

            foreach (string fileName in Directory.GetFiles("Resources"))
                if (konferencia.Eloadasok[index].Cim.ToLower().Contains(fileName.ToLower().Split('.')[0].Split('\\')[1]))
                    kep.Image = Image.FromFile(fileName);

            for (int i = 0; i < konferencia.Eloadasok[index].SorDb; i++)
            {
                setX = 280;
                for (int j = 0; j < konferencia.Eloadasok[index].HelyDb; j++)
                {
                    dict.Add($"{i}{j}", new PictureBox()
                    {
                        Location = new Point(setX, setY),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Size = new Size(50, 50),
                    });
                    foreach (string pont in Directory.GetFiles("Resources"))
                        if (pont.Contains(konferencia.Eloadasok[index].Ertekeles[i, j].ToString()))
                            dict[$"{i}{j}"].Image = Image.FromFile(pont);

                    setX += 50;
                }
                setY += 50;
            }

            foreach (PictureBox pb in dict.Values)
                Controls.Add(pb);
        }

        private void balra_Click(object sender, EventArgs e)
        {
            if (index > 0) index--;
            else index = konferencia.Eloadasok.Count - 1;

            Refresh();
        }

        private void jobbra_Click(object sender, EventArgs e)
        {
            if (index < konferencia.Eloadasok.Count - 1) index++;
            else index = 0;

            Refresh();
        }

        private void Refresh()
        {
            int setX = 280;
            int setY = 30;

            foreach (string fileName in Directory.GetFiles("Resources"))
                if (konferencia.Eloadasok[index].Cim.ToLower().Contains(fileName.ToLower().Split('.')[0].Split('\\')[1]))
                    kep.Image = Image.FromFile(fileName);

            foreach (PictureBox pb in dict.Values)
                Controls.Remove(pb);

            dict = new Dictionary<string, PictureBox>();

            for (int i = 0; i < konferencia.Eloadasok[index].SorDb; i++)
            {
                setX = 280;
                for (int j = 0; j < konferencia.Eloadasok[index].HelyDb; j++)
                {
                    dict.Add($"{i}{j}", new PictureBox()
                    {
                        Location = new Point(setX, setY),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Size = new Size(50, 50),
                    });
                    foreach (string pont in Directory.GetFiles("Resources"))
                        if (pont.Contains(konferencia.Eloadasok[index].Ertekeles[i, j].ToString()))
                            dict[$"{i}{j}"].Image = Image.FromFile(pont);

                    setX += 50;
                }
                setY += 50;
            }

            foreach (PictureBox pb in dict.Values)
                Controls.Add(pb);
        }
    }
}
