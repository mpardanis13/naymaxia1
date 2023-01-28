using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace naymaxia1
{
    public partial class Form1 : Form
    {
        SQLiteConnection connection;
        String connectionString = "Data source=identifier.sqlite;Version=3";
        public int prospatheies, seconds, nikes=0, httes=0;
        public Tablo tabloPaixth;
        public List<Button> ploia;
        public Tablo tabloYpologisth;
        public List<int> kateilhmenaKoytakia = new List<int>();

        public Form1()
        {
            InitializeComponent();
            List<Button> tabloPaixthL = new List<Button>();
            List<Button> tabloYpologisthL = new List<Button>();


            for (int i = 1; i <= 200;)
            {
                foreach (var button in this.Controls.OfType<Button>())
                {
                    if (i <= 100)
                    {

                        if (button.Name.EndsWith("n" + i.ToString()))
                        {
                            tabloPaixthL.Add(button);
                            i++;
                        }
                    }
                    else
                    {
                        if (button.Name.EndsWith("n" + i.ToString()))
                        {
                            tabloYpologisthL.Add(button);
                            i++;

                        }
                    }
                }
            }

            tabloPaixth = new Tablo(tabloPaixthL);
            tabloYpologisth = new Tablo(tabloYpologisthL);

        }

        private void Start_Click(object sender, EventArgs e)
        {
            seconds = 0;
            prospatheies = 0;
            StartBtn.Visible = false;
            StartBtn.Enabled = false;
            textBox1.Visible = false;
            textBox1.Enabled= false;
            label42.Visible = false;
            label42.Enabled = false;
            button203.Visible = false;
            button203.Enabled = false;
            tabloPaixth.clearTablo();
            tabloYpologisth.clearTablo();
            foreach (Button b in tabloYpologisth.tablo) b.Enabled = true; 
            tabloPaixth.topothethshPloiwnPaixth();
            tabloYpologisth.topothethshPloiwnYpologisth();
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(connectionString);
        }

        private void button201_Click(object sender, EventArgs e)
        {
            prospatheies++;
            Button btn = ((Button)sender);
            btn.Enabled = false;
            Bitmap c = new Bitmap("cross.png");
            Bitmap h = new Bitmap("hyphen.png");

            if (tabloYpologisth.ypobryxio.Contains(btn))
            {

                btn.BackgroundImage = c;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                tabloYpologisth.ypobryxio.RemoveAt(tabloYpologisth.ypobryxio.IndexOf(btn));
                if (!tabloYpologisth.ypobryxio.Any())
                {
                    label41.Text = "To ypobryxio toy antipaloy katastrafhke!";
                }
            }
            else if (tabloYpologisth.aeroplanoforo.Contains(btn))
            {
                btn.BackgroundImage = c;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                tabloYpologisth.aeroplanoforo.RemoveAt(tabloYpologisth.aeroplanoforo.IndexOf(btn));
                if (!tabloYpologisth.aeroplanoforo.Any())
                {
                    label41.Text = "To aeroplanoforo toy antipaloy katastrafhke!";
                }

            }
            else if (tabloYpologisth.polemiko.Contains(btn))
            {
                btn.BackgroundImage = c;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                tabloYpologisth.polemiko.RemoveAt(tabloYpologisth.polemiko.IndexOf(btn));
                if (!tabloYpologisth.polemiko.Any())
                {
                    label41.Text = "To polemiko toy antipaloy katastrafhke!";
                }

            }
            else if (tabloYpologisth.antitorpiliko.Contains(btn))
            {
                btn.BackgroundImage = c;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                tabloYpologisth.antitorpiliko.RemoveAt(tabloYpologisth.antitorpiliko.IndexOf(btn));
                if (!tabloYpologisth.antitorpiliko.Any())
                {
                    label41.Text = "To antitorpiliko toy antipaloy katastrafhke!";
                }

            }
            else
            {
                btn.BackgroundImage = h;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if(!tabloYpologisth.ypobryxio.Any()&& !tabloYpologisth.polemiko.Any()&& !tabloYpologisth.antitorpiliko.Any()&& !tabloYpologisth.aeroplanoforo.Any())
            {
                foreach (Button koytaki in tabloYpologisth.tablo)
                {
                    koytaki.Enabled = false;
                }
                nikes++;
                MessageBox.Show("Nikhths einai o xrhsths!\nProspatheies poy eginan: "+ prospatheies.ToString()+".\nPerasan "+seconds+" deyterolepta.\nNikes: "+nikes.ToString()+" Httes: "+httes.ToString());
                timer1.Enabled = false;
                StartBtn.Enabled = true;
                StartBtn.Visible = true;

                connection.Open();
                String createSQL = "Create table if not exists GameStats(Onoma Text," +
                    "Nikhths Text,Diarkeia integer, id integer auto increment primary key )";
                SQLiteCommand command = new SQLiteCommand(createSQL, connection);
                command.ExecuteNonQuery();
                String insertSQL = "Insert into GameStats(Onoma,Nikhths,diarkeia) values('" + textBox1.Text + "','Paixths'," + seconds.ToString() + ")";
                command = new SQLiteCommand(insertSQL, connection);
                command.ExecuteNonQuery();
                connection.Close();

                button203.Enabled = true;
                button203.Visible = true;
                label42.Visible = true;
                label42.Enabled = true;
                textBox1.Visible = true;
                textBox1.Enabled = true;

            }
            kinhshYpologisth();

        }

        private void button203_Click(object sender, EventArgs e)
        {
            String stats = "";
            connection.Open();
            String selectSQL = "Select * from GameStats";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                stats += "Onoma: ";
                stats+=reader.GetString(0);
                stats+=", Nikhths: ";
                stats += reader.GetString(1);
                stats += ", Diarkeia: ";
                stats+=(reader.GetInt16(2).ToString());
                stats += "\n";
            }
            MessageBox.Show(stats);
            connection.Close();
        }

        public void kinhshYpologisth()
        {
            Random r = new Random();
            int rnd;
            Button btn = new Button();
            while (true)
            {
                rnd = r.Next(1, 101);
                if (!kateilhmenaKoytakia.Contains(rnd))
                {
                    kateilhmenaKoytakia.Add(rnd);
                    break;
                }
            }
            foreach (Button button in tabloPaixth.tablo)
            {
                if(button.Name.EndsWith("n"+rnd.ToString())) {
                    btn = button;
                        }
            }
            Bitmap c = new Bitmap("cross.png");
            Bitmap h = new Bitmap("hyphen.png");

            if (tabloPaixth.ypobryxio.Contains(btn))
            {

                btn.BackgroundImage = c;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                tabloPaixth.ypobryxio.RemoveAt(tabloPaixth.ypobryxio.IndexOf(btn));
                if (!tabloPaixth.ypobryxio.Any())
                {
                    label41.Text = "Bythisthke to ypobryxio moy!";

                }
            }
            else if (tabloPaixth.aeroplanoforo.Contains(btn))
            {
                btn.BackgroundImage = c;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                tabloPaixth.aeroplanoforo.RemoveAt(tabloPaixth.aeroplanoforo.IndexOf(btn));
                if (!tabloPaixth.aeroplanoforo.Any())
                {
                    label41.Text = "Bythisthke to aeroplanoforo moy!";
                }

            }
            else if (tabloPaixth.polemiko.Contains(btn))
            {
                btn.BackgroundImage = c;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                tabloPaixth.polemiko.RemoveAt(tabloPaixth.polemiko.IndexOf(btn));
                if (!tabloPaixth.polemiko.Any())
                {
                    label41.Text = "Bythisthke to polemiko moy!";
                }

            }
            else if (tabloPaixth.antitorpiliko.Contains(btn))
            {
                btn.BackgroundImage = c;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                tabloPaixth.antitorpiliko.RemoveAt(tabloPaixth.antitorpiliko.IndexOf(btn));
                if (!tabloPaixth.antitorpiliko.Any())
                {
                    label41.Text = "Bythisthke to antitorpiliko moy!";
                }

            }
            else
            {
                btn.BackgroundImage = h;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (!tabloPaixth.ypobryxio.Any() && !tabloPaixth.polemiko.Any() && !tabloPaixth.antitorpiliko.Any() && !tabloPaixth.aeroplanoforo.Any())
            {
                foreach (Button koytaki in tabloPaixth.tablo)
                {
                    koytaki.Enabled = false;
                }
                MessageBox.Show("Nikhths einai o ypologisths!\nProspatheies poy eginan: " + prospatheies.ToString() + ".\nPerasan " + seconds + " deyterolepta.\nNikes: " + nikes.ToString() + " Httes: " + httes.ToString());
                httes++;
                timer1.Enabled = false;
                StartBtn.Enabled = true;
                StartBtn.Visible = true;

                connection.Open();
                String createSQL = "Create table if not exists GameStats(Onoma Text," +
                    "Nikhths Text,Diarkeia integer, id integer auto increment primary key )";
                SQLiteCommand command = new SQLiteCommand(createSQL, connection);
                command.ExecuteNonQuery();
                String insertSQL = "Insert into GameStats(Onoma,Nikhths,diarkeia) values('" + textBox1.Text + "','Ypologisths'," + seconds.ToString() + ")";
                command = new SQLiteCommand(insertSQL, connection);
                command.ExecuteNonQuery();
                connection.Close();

                button203.Enabled = true;
                button203.Visible = true;
                label42.Visible = true;
                label42.Enabled = true;
                textBox1.Visible = true;
                textBox1.Enabled = true;

            }

        }

        private void button202_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
        }
    }
}
