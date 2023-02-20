using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace naymaxia1
{
    public class Tablo
    {
        public List<Button> tablo;
        public List<int> kateilhmenaKoytakia = new List<int>();
        public List<Button> ypobryxio = new List<Button>();
        public List<Button> polemiko = new List<Button>();
        public List<Button> antitorpiliko = new List<Button>();
        public List<Button> aeroplanoforo = new List<Button>();
        public Ploio ypobryxioP;
        public Ploio polemikoP;
        public Ploio antitorpilikoP;
        public Ploio aeroplanoforoP;

        Random r = new Random();

        public Tablo(List<Button> tablo)
        {
            this.tablo = tablo;
        }
        public void clearTablo()
        {
            foreach (Button b in tablo) { b.BackgroundImage = null; b.BackColor = SystemColors.ButtonFace; }
        }

        public void topothethshPloiwnPaixth()
        {
            int rnd;
            int rnd2;
            // ypobryxio
            rnd = r.Next(101);
            foreach (Button koytaki in tablo)
            {
                if (koytaki.Name.EndsWith("n" + rnd.ToString()))
                {
                    koytaki.BackColor = Color.DeepSkyBlue;
                    ypobryxio.Add(koytaki);

                }
            }
            kateilhmenaKoytakia.Add(rnd);

            while (true)
            {

                rnd2 = r.Next(3);
                if (rnd2 == 0)
                {
                    if ((rnd + 1) <= 100 && (rnd % 10 != 0) || rnd == 0)
                    {
                        foreach (Button koytaki in tablo)
                        {
                            if (koytaki.Name.EndsWith("n" + (rnd + 1).ToString()))
                            {
                                koytaki.BackColor = Color.DeepSkyBlue;
                                ypobryxio.Add(koytaki);
                            }
                        }
                        kateilhmenaKoytakia.Add(rnd + 1);
                        break;
                    }
                }
                else if (rnd2 == 1)
                {
                    if ((rnd - 1) >= 0 && (rnd % 10 != 1))
                    {
                        foreach (Button koytaki in tablo)
                        {
                            if (koytaki.Name.EndsWith("n" + (rnd - 1).ToString()))
                            {
                                koytaki.BackColor = Color.DeepSkyBlue;
                                ypobryxio.Add(koytaki);
                            }
                        }
                        kateilhmenaKoytakia.Add(rnd - 1);
                        break;

                    }
                }
                else if (rnd2 == 2)
                {
                    if ((rnd + 10) <= 100)
                    {
                        foreach (Button koytaki in tablo)
                        {
                            if (koytaki.Name.EndsWith("n" + (rnd + 10).ToString()))
                            {
                                koytaki.BackColor = Color.DeepSkyBlue;
                                ypobryxio.Add(koytaki);
                            }
                        }
                        kateilhmenaKoytakia.Add(rnd + 10);
                        break;

                    }
                }
                else if (rnd2 == 3)
                {
                    if ((rnd - 10) >= 0)
                    {
                        foreach (Button koytaki in tablo)
                        {
                            if (koytaki.Name.EndsWith("n" + (rnd - 10).ToString()))
                            {
                                koytaki.BackColor = Color.DeepSkyBlue;
                                ypobryxio.Add(koytaki);
                            }
                        }
                        kateilhmenaKoytakia.Add(rnd - 10);
                        break;

                    }
                }
            }
            ypobryxioP = new Ploio(ypobryxio, "ypobryxio");

            // polemiko
            while (true)
            {
                rnd = r.Next(0, 101);
                if (!kateilhmenaKoytakia.Contains(rnd))
                {
                    while (true)
                    {
                        rnd2 = r.Next(0, 3);
                        if (rnd2 == 0)
                        {
                            if ((rnd + 2 <= 100) && (rnd % 10 != 9) && (rnd % 10 != 0 || rnd == 0) && (!kateilhmenaKoytakia.Contains(rnd + 1)) && (!kateilhmenaKoytakia.Contains(rnd + 2)))
                            {
                                foreach (Button koytaki in tablo)
                                {
                                    if (koytaki.Name.EndsWith("n" + (rnd + 1).ToString()) || koytaki.Name.EndsWith("n" + (rnd + 2).ToString()) || koytaki.Name.EndsWith("n" + (rnd).ToString()))
                                    {
                                        koytaki.BackColor = Color.DeepSkyBlue;
                                        polemiko.Add(koytaki);
                                    }
                                }
                                kateilhmenaKoytakia.Add(rnd);
                                kateilhmenaKoytakia.Add(rnd + 1);
                                kateilhmenaKoytakia.Add(rnd + 2);
                                break;
                            }
                        }
                        else if (rnd2 == 1)
                        {
                            if ((rnd - 2 > 0) && (rnd % 10 != 2) && (rnd % 10 != 1) && (!kateilhmenaKoytakia.Contains(rnd - 1)) && (!kateilhmenaKoytakia.Contains(rnd - 2)))
                            {
                                foreach (Button koytaki in tablo)
                                {
                                    if (koytaki.Name.EndsWith("n" + (rnd - 1).ToString()) || koytaki.Name.EndsWith("n" + (rnd - 2).ToString()) || koytaki.Name.EndsWith("n" + (rnd).ToString()))
                                    {
                                        koytaki.BackColor = Color.DeepSkyBlue;
                                        polemiko.Add(koytaki);
                                    }
                                }
                                kateilhmenaKoytakia.Add(rnd);
                                kateilhmenaKoytakia.Add(rnd - 1);
                                kateilhmenaKoytakia.Add(rnd - 2);
                                break;
                            }
                        }
                        if (rnd2 == 2)
                        {
                            if ((rnd + 20 <= 100) && (!kateilhmenaKoytakia.Contains(rnd + 10)) && (!kateilhmenaKoytakia.Contains(rnd + 20)))
                            {
                                foreach (Button koytaki in tablo)
                                {
                                    if (koytaki.Name.EndsWith("n" + (rnd + 10).ToString()) || koytaki.Name.EndsWith("n" + (rnd + 20).ToString()) || koytaki.Name.EndsWith("n" + (rnd).ToString()))
                                    {
                                        koytaki.BackColor = Color.DeepSkyBlue;
                                        polemiko.Add(koytaki);
                                    }
                                }
                                kateilhmenaKoytakia.Add(rnd);
                                kateilhmenaKoytakia.Add(rnd + 10);
                                kateilhmenaKoytakia.Add(rnd + 20);
                                break;
                            }
                        }
                        if (rnd2 == 3)
                        {
                            if ((rnd - 20 > 0) && (!kateilhmenaKoytakia.Contains(rnd - 10)) && (!kateilhmenaKoytakia.Contains(rnd - 20)))
                            {
                                foreach (Button koytaki in tablo)
                                {
                                    if (koytaki.Name.EndsWith("n" + (rnd - 10).ToString()) || koytaki.Name.EndsWith("n" + (rnd - 20).ToString()) || koytaki.Name.EndsWith("n" + (rnd).ToString()))
                                    {
                                        koytaki.BackColor = Color.DeepSkyBlue;
                                        polemiko.Add(koytaki);
                                    }
                                }
                                kateilhmenaKoytakia.Add(rnd);
                                kateilhmenaKoytakia.Add(rnd - 10);
                                kateilhmenaKoytakia.Add(rnd - 20);
                                break;
                            }
                        }
                    }
                    break;
                }
            }
            polemikoP = new Ploio(polemiko, "polemiko");


            // antitorpiliko
            while (true)
            {
                rnd = r.Next(0, 101);
                if (!kateilhmenaKoytakia.Contains(rnd))
                {
                    while (true)
                    {
                        rnd2 = r.Next(0, 3);
                        if (rnd2 == 0)
                        {
                            if ((rnd + 3 <= 100) && (rnd % 10 != 8) && (rnd % 10 != 9) && (rnd % 10 != 0 || rnd == 0) && (!kateilhmenaKoytakia.Contains(rnd + 1)) && (!kateilhmenaKoytakia.Contains(rnd + 2)) && (!kateilhmenaKoytakia.Contains(rnd + 3)))
                            {
                                foreach (Button koytaki in tablo)
                                {
                                    if (koytaki.Name.EndsWith("n" + (rnd + 1).ToString()) || koytaki.Name.EndsWith("n" + (rnd + 2).ToString()) || koytaki.Name.EndsWith("n" + (rnd).ToString()) || koytaki.Name.EndsWith("n" + (rnd + 3).ToString()))
                                    {
                                        koytaki.BackColor = Color.DeepSkyBlue;
                                        antitorpiliko.Add(koytaki);
                                    }
                                }
                                kateilhmenaKoytakia.Add(rnd);
                                kateilhmenaKoytakia.Add(rnd + 1);
                                kateilhmenaKoytakia.Add(rnd + 2);
                                kateilhmenaKoytakia.Add(rnd + 3);

                                break;
                            }
                        }
                        else if (rnd2 == 1)
                        {
                            if ((rnd - 3 > 0) && (rnd % 10 != 2) && (rnd % 10 != 3) && (rnd % 10 != 1) && (!kateilhmenaKoytakia.Contains(rnd - 1)) && (!kateilhmenaKoytakia.Contains(rnd - 2)) && (!kateilhmenaKoytakia.Contains(rnd - 3)))
                            {
                                foreach (Button koytaki in tablo)
                                {
                                    if (koytaki.Name.EndsWith("n" + (rnd - 1).ToString()) || koytaki.Name.EndsWith("n" + (rnd - 2).ToString()) || koytaki.Name.EndsWith("n" + (rnd).ToString()) || koytaki.Name.EndsWith("n" + (rnd - 3).ToString()))
                                    {
                                        koytaki.BackColor = Color.DeepSkyBlue;
                                        antitorpiliko.Add(koytaki);
                                    }
                                }
                                kateilhmenaKoytakia.Add(rnd);
                                kateilhmenaKoytakia.Add(rnd - 1);
                              kateilhmenaKoytakia.Add(rnd - 2);
                                kateilhmenaKoytakia.Add(rnd - 3);

                                break;
                            }
                        }
                        if (rnd2 == 2)
                        {
                            if ((rnd + 30 <= 100) && (!kateilhmenaKoytakia.Contains(rnd + 10)) && (!kateilhmenaKoytakia.Contains(rnd + 20)) && (!kateilhmenaKoytakia.Contains(rnd + 30)))
                            {
                                foreach (Button koytaki in tablo)
                                {
                                    if (koytaki.Name.EndsWith("n" + (rnd + 10).ToString()) || koytaki.Name.EndsWith("n" + (rnd + 20).ToString()) || koytaki.Name.EndsWith("n" + (rnd).ToString()) || koytaki.Name.EndsWith("n" + (rnd + 30).ToString()))
                                    {
                                        koytaki.BackColor = Color.DeepSkyBlue;
                                        antitorpiliko.Add(koytaki);
                                    }
                                }
                                kateilhmenaKoytakia.Add(rnd);
                                kateilhmenaKoytakia.Add(rnd + 10);
                                kateilhmenaKoytakia.Add(rnd + 20);
                                kateilhmenaKoytakia.Add(rnd + 30);

                                break;
                            }
                        }
                        if (rnd2 == 0)
                        {
                            if ((rnd - 30 > 0) && (!kateilhmenaKoytakia.Contains(rnd - 10)) && (!kateilhmenaKoytakia.Contains(rnd - 20)) && (!kateilhmenaKoytakia.Contains(rnd - 30)))
                            {
                                foreach (Button koytaki in tablo)
                                {
                                    if (koytaki.Name.EndsWith("n" + (rnd - 10).ToString()) || koytaki.Name.EndsWith("n" + (rnd - 20).ToString()) || koytaki.Name.EndsWith("n" + (rnd).ToString()) || koytaki.Name.EndsWith("n" + (rnd - 30).ToString()))
                                    {
                                        koytaki.BackColor = Color.DeepSkyBlue;
                                        antitorpiliko.Add(koytaki);
                                    }
                                }
                                kateilhmenaKoytakia.Add(rnd);
                                kateilhmenaKoytakia.Add(rnd - 10);
                                kateilhmenaKoytakia.Add(rnd - 20);
                                kateilhmenaKoytakia.Add(rnd - 30);

                                break;
                            }
                        }
                    }
                    break;
                }
            }
            antitorpilikoP = new Ploio(antitorpiliko, "antitorpiliko");

            // aeroplanoforo
            while (true)
            {
                rnd = r.Next(0, 101);
                if (!kateilhmenaKoytakia.Contains(rnd))
                {
                    while (true)
                    {
                        rnd2 = r.Next(0, 3);
                        if (rnd2 == 0)
                        {
                            if ((rnd + 4 <= 100) && (rnd % 10 != 7) && (rnd % 10 != 8) && (rnd % 10 != 9) && (rnd % 10 != 0 || rnd == 0) && (!kateilhmenaKoytakia.Contains(rnd + 1)) && (!kateilhmenaKoytakia.Contains(rnd + 2)) && (!kateilhmenaKoytakia.Contains(rnd + 3)) && (!kateilhmenaKoytakia.Contains(rnd + 4)))
                            {
                                foreach (Button koytaki in tablo)
                                {
                                    if (koytaki.Name.EndsWith("n" + (rnd + 1).ToString()) || koytaki.Name.EndsWith("n" + (rnd + 2).ToString()) || koytaki.Name.EndsWith("n" + (rnd).ToString()) || koytaki.Name.EndsWith("n" + (rnd + 3).ToString()) || koytaki.Name.EndsWith("n" + (rnd + 4).ToString()))
                                    {
                                        koytaki.BackColor = Color.DeepSkyBlue;
                                        aeroplanoforo.Add(koytaki);
                                    }
                                }
                                kateilhmenaKoytakia.Add(rnd);
                                kateilhmenaKoytakia.Add(rnd + 1);
                                kateilhmenaKoytakia.Add(rnd + 2);
                                kateilhmenaKoytakia.Add(rnd + 3);
                                kateilhmenaKoytakia.Add(rnd + 4);


                                break;
                            }
                        }
                        else if (rnd2 == 1)
                        {
                            if ((rnd - 4 > 0) && (rnd % 10 != 2) && (rnd % 10 != 3) && (rnd % 10 != 3) && (rnd % 10 != 1) && (!kateilhmenaKoytakia.Contains(rnd - 1)) && (!kateilhmenaKoytakia.Contains(rnd - 2)) && (!kateilhmenaKoytakia.Contains(rnd - 3)) && (!kateilhmenaKoytakia.Contains(rnd - 4)))
                            {
                                foreach (Button koytaki in tablo)
                                {
                                    if (koytaki.Name.EndsWith("n" + (rnd - 1).ToString()) || koytaki.Name.EndsWith("n" + (rnd - 2).ToString()) || koytaki.Name.EndsWith("n" + (rnd).ToString()) || koytaki.Name.EndsWith("n" + (rnd - 3).ToString()) || koytaki.Name.EndsWith("n" + (rnd - 4).ToString()))
                                    {
                                        koytaki.BackColor = Color.DeepSkyBlue;
                                        aeroplanoforo.Add(koytaki);
                                    }
                                }
                                kateilhmenaKoytakia.Add(rnd);
                                kateilhmenaKoytakia.Add(rnd - 1);
                                kateilhmenaKoytakia.Add(rnd - 2);
                                kateilhmenaKoytakia.Add(rnd - 3);
                                kateilhmenaKoytakia.Add(rnd - 4);
                                break;
                            }
                        }
                        if (rnd2 == 2)
                        {
                            if ((rnd + 40 <= 100) && (!kateilhmenaKoytakia.Contains(rnd + 10)) && (!kateilhmenaKoytakia.Contains(rnd + 20)) && (!kateilhmenaKoytakia.Contains(rnd + 30)) && (!kateilhmenaKoytakia.Contains(rnd + 40)))
                            {
                                foreach (Button koytaki in tablo)
                                {
                                    if (koytaki.Name.EndsWith("n" + (rnd + 10).ToString()) || koytaki.Name.EndsWith("n" + (rnd + 20).ToString()) || koytaki.Name.EndsWith("n" + (rnd).ToString()) || koytaki.Name.EndsWith("n" + (rnd + 30).ToString()) || koytaki.Name.EndsWith("n" + (rnd + 40).ToString()))
                                    {
                                        koytaki.BackColor = Color.DeepSkyBlue;
                                        aeroplanoforo.Add(koytaki);
                                    }
                                }
                                kateilhmenaKoytakia.Add(rnd);
                                kateilhmenaKoytakia.Add(rnd + 10);
                                kateilhmenaKoytakia.Add(rnd + 20);
                                kateilhmenaKoytakia.Add(rnd + 30);
                                kateilhmenaKoytakia.Add(rnd + 40);
                                break;
                            }
                        }
                        if (rnd2 == 0)
                        {
                            if ((rnd - 40 > 0) && (!kateilhmenaKoytakia.Contains(rnd - 10)) && (!kateilhmenaKoytakia.Contains(rnd - 20)) && (!kateilhmenaKoytakia.Contains(rnd - 30)) && (!kateilhmenaKoytakia.Contains(rnd - 40)))
                            {
                                foreach (Button koytaki in tablo)
                                {
                                    if (koytaki.Name.EndsWith("n" + (rnd - 10).ToString()) || koytaki.Name.EndsWith("n" + (rnd - 20).ToString()) || koytaki.Name.EndsWith("n" + (rnd).ToString()) || koytaki.Name.EndsWith("n" + (rnd - 30).ToString()) || koytaki.Name.EndsWith("n" + (rnd - 40).ToString()))
                                    {
                                        koytaki.BackColor = Color.DeepSkyBlue;
                                        aeroplanoforo.Add(koytaki);
                                    }
                                }
                                kateilhmenaKoytakia.Add(rnd);
                                kateilhmenaKoytakia.Add(rnd - 10);
                                kateilhmenaKoytakia.Add(rnd - 20);
                                kateilhmenaKoytakia.Add(rnd - 30);
                                kateilhmenaKoytakia.Add(rnd - 40);
                                break;
                            }
                        }
                    }
                    break;
                }
            }
            aeroplanoforoP = new Ploio(aeroplanoforo, "aeroplanoforo");


        }

        public void topothethshPloiwnYpologisth()
        {
            int rnd;
            int rnd2;
            // ypobryxio
            rnd = r.Next(101, 201);
            foreach (Button koytaki in tablo)
            {
                if (koytaki.Name.EndsWith("n" + rnd.ToString()))
                {
                    ypobryxio.Add(koytaki);

                }
            }
            kateilhmenaKoytakia.Add(rnd);

            while (true)
            {

                rnd2 = r.Next(3);
                if (rnd2 == 0)
                {
                    if ((rnd + 1) <= 200 && (rnd % 10 != 0) || rnd == 0)
                    {
                        foreach (Button koytaki in tablo)
                        {
                            if (koytaki.Name.EndsWith("n" + (rnd + 1).ToString()))
                            {
                                ypobryxio.Add(koytaki);
                            }
                        }
                        kateilhmenaKoytakia.Add(rnd + 1);
                        break;
                    }
                }
                else if (rnd2 == 1)
                {
                    if ((rnd - 1) > 100 && (rnd % 10 != 1))
                    {
                        foreach (Button koytaki in tablo)
                        {
                            if (koytaki.Name.EndsWith("n" + (rnd - 1).ToString()))
                            {
                                ypobryxio.Add(koytaki);
                            }
                        }
                        kateilhmenaKoytakia.Add(rnd - 1);
                        break;

                    }
                }
                else if (rnd2 == 2)
                {
                    if ((rnd + 10) <= 200)
                    {
                        foreach (Button koytaki in tablo)
                        {
                            if (koytaki.Name.EndsWith("n" + (rnd + 10).ToString()))
                            {
                                ypobryxio.Add(koytaki);
                            }
                        }
                        kateilhmenaKoytakia.Add(rnd + 10);
                        break;

                    }
                }
                else if (rnd2 == 3)
                {
                    if ((rnd - 10) > 100)
                    {
                        foreach (Button koytaki in tablo)
                        {
                            if (koytaki.Name.EndsWith("n" + (rnd - 10).ToString()))
                            {
                                ypobryxio.Add(koytaki);
                            }
                        }
                        kateilhmenaKoytakia.Add(rnd - 10);
                        break;

                    }
                }
            }
            ypobryxioP = new Ploio(ypobryxio, "ypobryxio");


            // polemiko
            while (true)
            {
                rnd = r.Next(101, 201);
                if (!kateilhmenaKoytakia.Contains(rnd))
                {
                    while (true)
                    {
                        rnd2 = r.Next(0, 3);
                        if (rnd2 == 0)
                        {
                            if ((rnd + 2 <= 200) && (rnd % 10 != 9) && (rnd % 10 != 0 || rnd == 0) && (!kateilhmenaKoytakia.Contains(rnd + 1)) && (!kateilhmenaKoytakia.Contains(rnd + 2)))
                            {
                                foreach (Button koytaki in tablo)
                                {
                                    if (koytaki.Name.EndsWith("n" + (rnd + 1).ToString()) || koytaki.Name.EndsWith("n" + (rnd + 2).ToString()) || koytaki.Name.EndsWith("n" + (rnd).ToString()))
                                    {
                                        polemiko.Add(koytaki);
                                    }
                                }
                                kateilhmenaKoytakia.Add(rnd);
                                kateilhmenaKoytakia.Add(rnd + 1);
                                kateilhmenaKoytakia.Add(rnd + 2);
                                break;
                            }
                        }
                        else if (rnd2 == 1)
                        {
                            if ((rnd - 2 > 100) && (rnd % 10 != 2) && (rnd % 10 != 1) && (!kateilhmenaKoytakia.Contains(rnd - 1)) && (!kateilhmenaKoytakia.Contains(rnd - 2)))
                            {
                                foreach (Button koytaki in tablo)
                                {
                                    if (koytaki.Name.EndsWith("n" + (rnd - 1).ToString()) || koytaki.Name.EndsWith("n" + (rnd - 2).ToString()) || koytaki.Name.EndsWith("n" + (rnd).ToString()))
                                    {
                                        polemiko.Add(koytaki);
                                    }
                                }
                                kateilhmenaKoytakia.Add(rnd);
                                kateilhmenaKoytakia.Add(rnd - 1);
                                kateilhmenaKoytakia.Add(rnd - 2);
                                break;
                            }
                        }
                        if (rnd2 == 2)
                        {
                            if ((rnd + 20 <= 200) && (!kateilhmenaKoytakia.Contains(rnd + 10)) && (!kateilhmenaKoytakia.Contains(rnd + 20)))
                            {
                                foreach (Button koytaki in tablo)
                                {
                                    if (koytaki.Name.EndsWith("n" + (rnd + 10).ToString()) || koytaki.Name.EndsWith("n" + (rnd + 20).ToString()) || koytaki.Name.EndsWith("n" + (rnd).ToString()))
                                    {
                                        polemiko.Add(koytaki);
                                    }
                                }
                                kateilhmenaKoytakia.Add(rnd);
                                kateilhmenaKoytakia.Add(rnd + 10);
                                kateilhmenaKoytakia.Add(rnd + 20);
                                break;
                            }
                        }
                        if (rnd2 == 0)
                        {
                            if ((rnd - 20 > 100) && (!kateilhmenaKoytakia.Contains(rnd - 10)) && (!kateilhmenaKoytakia.Contains(rnd - 20)))
                            {
                                foreach (Button koytaki in tablo)
                                {
                                    if (koytaki.Name.EndsWith("n" + (rnd - 10).ToString()) || koytaki.Name.EndsWith("n" + (rnd - 20).ToString()) || koytaki.Name.EndsWith("n" + (rnd).ToString()))
                                    {
                                        polemiko.Add(koytaki);
                                    }
                                }
                                kateilhmenaKoytakia.Add(rnd);
                                kateilhmenaKoytakia.Add(rnd - 10);
                                kateilhmenaKoytakia.Add(rnd - 20);
                                break;
                            }
                        }
                    }
                    break;
                }
            }
            polemikoP = new Ploio(polemiko, "polemiko");

            // antitorpiliko
            while (true)
            {
                rnd = r.Next(101, 201);
                if (!kateilhmenaKoytakia.Contains(rnd))
                {
                    while (true)
                    {
                        rnd2 = r.Next(0, 3);
                        if (rnd2 == 0)
                        {
                            if ((rnd + 3 <= 200) && (rnd % 10 != 8) && (rnd % 10 != 9) && (rnd % 10 != 0 || rnd == 0) && (!kateilhmenaKoytakia.Contains(rnd + 1)) && (!kateilhmenaKoytakia.Contains(rnd + 2)) && (!kateilhmenaKoytakia.Contains(rnd + 3)))
                            {
                                foreach (Button koytaki in tablo)
                                {
                                    if (koytaki.Name.EndsWith("n" + (rnd + 1).ToString()) || koytaki.Name.EndsWith("n" + (rnd + 2).ToString()) || koytaki.Name.EndsWith("n" + (rnd).ToString()) || koytaki.Name.EndsWith("n" + (rnd + 3).ToString()))
                                    {
                                        antitorpiliko.Add(koytaki);
                                    }
                                }
                                kateilhmenaKoytakia.Add(rnd);
                                kateilhmenaKoytakia.Add(rnd + 1);
                                kateilhmenaKoytakia.Add(rnd + 2);
                                kateilhmenaKoytakia.Add(rnd + 3);

                                break;
                            }
                        }
                        else if (rnd2 == 1)
                        {
                            if ((rnd - 3 > 100) && (rnd % 10 != 2) && (rnd % 10 != 3) && (rnd % 10 != 1) && (!kateilhmenaKoytakia.Contains(rnd - 1)) && (!kateilhmenaKoytakia.Contains(rnd - 2)) && (!kateilhmenaKoytakia.Contains(rnd - 3)))
                            {
                                foreach (Button koytaki in tablo)
                                {
                                    if (koytaki.Name.EndsWith("n" + (rnd - 1).ToString()) || koytaki.Name.EndsWith("n" + (rnd - 2).ToString()) || koytaki.Name.EndsWith("n" + (rnd).ToString()) || koytaki.Name.EndsWith("n" + (rnd - 3).ToString()))
                                    {
                                        antitorpiliko.Add(koytaki);
                                    }
                                }
                                kateilhmenaKoytakia.Add(rnd);
                                kateilhmenaKoytakia.Add(rnd - 1);
                                kateilhmenaKoytakia.Add(rnd - 2);
                                kateilhmenaKoytakia.Add(rnd - 3);

                                break;
                            }
                        }
                        if (rnd2 == 2)
                        {
                            if ((rnd + 30 <= 200) && (!kateilhmenaKoytakia.Contains(rnd + 10)) && (!kateilhmenaKoytakia.Contains(rnd + 20)) && (!kateilhmenaKoytakia.Contains(rnd + 30)))
                            {
                                foreach (Button koytaki in tablo)
                                {
                                    if (koytaki.Name.EndsWith("n" + (rnd + 10).ToString()) || koytaki.Name.EndsWith("n" + (rnd + 20).ToString()) || koytaki.Name.EndsWith("n" + (rnd).ToString()) || koytaki.Name.EndsWith("n" + (rnd + 30).ToString()))
                                    {
                                        antitorpiliko.Add(koytaki);
                                    }
                                }
                                kateilhmenaKoytakia.Add(rnd);
                                kateilhmenaKoytakia.Add(rnd + 10);
                                kateilhmenaKoytakia.Add(rnd + 20);
                                kateilhmenaKoytakia.Add(rnd + 30);

                                break;
                            }
                        }
                        if (rnd2 == 0)
                        {
                            if ((rnd - 30 > 100) && (!kateilhmenaKoytakia.Contains(rnd - 10)) && (!kateilhmenaKoytakia.Contains(rnd - 20)) && (!kateilhmenaKoytakia.Contains(rnd - 30)))
                            {
                                foreach (Button koytaki in tablo)
                                {
                                    if (koytaki.Name.EndsWith("n" + (rnd - 10).ToString()) || koytaki.Name.EndsWith("n" + (rnd - 20).ToString()) || koytaki.Name.EndsWith("n" + (rnd).ToString()) || koytaki.Name.EndsWith("n" + (rnd - 30).ToString()))
                                    {
                                        antitorpiliko.Add(koytaki);
                                    }
                                }
                                kateilhmenaKoytakia.Add(rnd);
                                kateilhmenaKoytakia.Add(rnd - 10);
                                kateilhmenaKoytakia.Add(rnd - 20);
                                kateilhmenaKoytakia.Add(rnd - 30);

                                break;
                            }
                        }
                    }
                    break;
                }
            }
            antitorpilikoP = new Ploio(antitorpiliko, "antitorpiliko");

            // aeroplanoforo
            while (true)
            {
                rnd = r.Next(101, 201);
                if (!kateilhmenaKoytakia.Contains(rnd))
                {
                    while (true)
                    {
                        rnd2 = r.Next(0, 3);
                        if (rnd2 == 0)
                        {
                            if ((rnd + 4 <= 200) && (rnd % 10 != 7) && (rnd % 10 != 8) && (rnd % 10 != 9) && (rnd % 10 != 0 || rnd == 0) && (!kateilhmenaKoytakia.Contains(rnd + 1)) && (!kateilhmenaKoytakia.Contains(rnd + 2)) && (!kateilhmenaKoytakia.Contains(rnd + 3)) && (!kateilhmenaKoytakia.Contains(rnd + 4)))
                            {
                                foreach (Button koytaki in tablo)
                                {
                                    if (koytaki.Name.EndsWith("n" + (rnd + 1).ToString()) || koytaki.Name.EndsWith("n" + (rnd + 2).ToString()) || koytaki.Name.EndsWith("n" + (rnd).ToString()) || koytaki.Name.EndsWith("n" + (rnd + 3).ToString()) || koytaki.Name.EndsWith("n" + (rnd + 4).ToString()))
                                    {
                                        aeroplanoforo.Add(koytaki);
                                    }
                                }
                                kateilhmenaKoytakia.Add(rnd);
                                kateilhmenaKoytakia.Add(rnd + 1);
                                kateilhmenaKoytakia.Add(rnd + 2);
                                kateilhmenaKoytakia.Add(rnd + 3);
                                kateilhmenaKoytakia.Add(rnd + 4);


                                break;
                            }
                        }
                        else if (rnd2 == 1)
                        {
                            if ((rnd - 4 > 100) && (rnd % 10 != 2) && (rnd % 10 != 3) && (rnd % 10 != 3) && (rnd % 10 != 1) && (!kateilhmenaKoytakia.Contains(rnd - 1)) && (!kateilhmenaKoytakia.Contains(rnd - 2)) && (!kateilhmenaKoytakia.Contains(rnd - 3)) && (!kateilhmenaKoytakia.Contains(rnd - 4)))
                            {
                                foreach (Button koytaki in tablo)
                                {
                                    if (koytaki.Name.EndsWith("n" + (rnd - 1).ToString()) || koytaki.Name.EndsWith("n" + (rnd - 2).ToString()) || koytaki.Name.EndsWith("n" + (rnd).ToString()) || koytaki.Name.EndsWith("n" + (rnd - 3).ToString()) || koytaki.Name.EndsWith("n" + (rnd - 4).ToString()))
                                    {
                                        aeroplanoforo.Add(koytaki);
                                    }
                                }
                                kateilhmenaKoytakia.Add(rnd);
                                kateilhmenaKoytakia.Add(rnd - 1);
                                kateilhmenaKoytakia.Add(rnd - 2);
                                kateilhmenaKoytakia.Add(rnd - 3);
                                kateilhmenaKoytakia.Add(rnd - 4);
                                break;
                            }
                        }
                        if (rnd2 == 2)
                        {
                            if ((rnd + 40 <= 200) && (!kateilhmenaKoytakia.Contains(rnd + 10)) && (!kateilhmenaKoytakia.Contains(rnd + 20)) && (!kateilhmenaKoytakia.Contains(rnd + 30)) && (!kateilhmenaKoytakia.Contains(rnd + 40)))
                            {
                                foreach (Button koytaki in tablo)
                                {
                                    if (koytaki.Name.EndsWith("n" + (rnd + 10).ToString()) || koytaki.Name.EndsWith("n" + (rnd + 20).ToString()) || koytaki.Name.EndsWith("n" + (rnd).ToString()) || koytaki.Name.EndsWith("n" + (rnd + 30).ToString()) || koytaki.Name.EndsWith("n" + (rnd + 40).ToString()))
                                    {
                                        aeroplanoforo.Add(koytaki);
                                    }
                                }
                                kateilhmenaKoytakia.Add(rnd);
                                kateilhmenaKoytakia.Add(rnd + 10);
                                kateilhmenaKoytakia.Add(rnd + 20);
                                kateilhmenaKoytakia.Add(rnd + 30);
                                kateilhmenaKoytakia.Add(rnd + 40);
                                break;
                            }
                        }
                        if (rnd2 == 0)
                        {
                            if ((rnd - 40 > 100) && (!kateilhmenaKoytakia.Contains(rnd - 10)) && (!kateilhmenaKoytakia.Contains(rnd - 20)) && (!kateilhmenaKoytakia.Contains(rnd - 30)) && (!kateilhmenaKoytakia.Contains(rnd - 40)))
                            {
                                foreach (Button koytaki in tablo)
                                {
                                    if (koytaki.Name.EndsWith("n" + (rnd - 10).ToString()) || koytaki.Name.EndsWith("n" + (rnd - 20).ToString()) || koytaki.Name.EndsWith("n" + (rnd).ToString()) || koytaki.Name.EndsWith("n" + (rnd - 30).ToString()) || koytaki.Name.EndsWith("n" + (rnd - 40).ToString()))
                                    {
                                        aeroplanoforo.Add(koytaki);
                                    }
                                }
                                kateilhmenaKoytakia.Add(rnd);
                                kateilhmenaKoytakia.Add(rnd - 10);
                                kateilhmenaKoytakia.Add(rnd - 20);
                                kateilhmenaKoytakia.Add(rnd - 30);
                                kateilhmenaKoytakia.Add(rnd - 40);
                                break;
                            }
                        }
                    }
                    break;
                }
            }
            aeroplanoforoP = new Ploio(aeroplanoforo, "aeroplanoforo");


        }
    }
}
