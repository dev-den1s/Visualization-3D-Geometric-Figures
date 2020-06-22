using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Project3_Savchenko51908
{
    public partial class Form1 : Form
    {
        int dsindexfigur = 0;
        dsBrylyRosnaco dssortowanie = new dsBrylyRosnaco();
        public static bool dskierunekobrotu;
        const int dsMarginess = 50;
        const int dsMaxGruboscLinii = 10;
        const float dsKatProsty = 90.0F;
        Graphics dsRysownica;
        List<dsBrylaAbstrakcyjna> dsLBG = new List<dsBrylaAbstrakcyjna>();
        public static Form1 dsUchwytFormularza;
        Label dsLabelEtykietka;
        Button dsButtonKolor;
        Button dsButtonDotStyl;
        Button dsbuttonWys;
        ComboBox dscmb;
        public enum dsTypBryly
        {
            dsbg_Walec,
            dsbg_Stozek,
            dsbg_Kula,
            dsbg_Otroslup,
            dsbg_Graniastoslup,
            dsbg_Szescian
        }
        
        Random Gener;
        public Form1()
        {
            InitializeComponent();
            this.Width = 1327;
            this.Height = 752;
            this.StartPosition = FormStartPosition.Manual;
            this.SetAutoSizeMode(System.Windows.Forms.AutoSizeMode.GrowAndShrink);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoScroll = true;
            dsUchwytFormularza = this;
            //dsRysownica = this.CreateGraphics();////////////////////////////////////////
            // lokalizacja i zwymiarowanie kontrolki PictureBox ​       
            //// ustalenie koloru tła rysownicy i jej obramowania​
            dspbRysownica.BackColor = Color.Beige;
            dspbRysownica.BorderStyle = BorderStyle.Fixed3D;
            dspbRysownica.Image = new Bitmap(dspbRysownica.Width, dspbRysownica.Height);
            ////utworzenie egzemplarza powierzchni graficznej (egzemplarza  rysownicy) ​
            //// na BitMapie przypisanej do  picbRysownica.Image i podstawienie do zmiennej​
            //// referencyjnej Rysownica referencji utworzonego egzemplarza  powierzchni graficznej
            dsRysownica = Graphics.FromImage(dspbRysownica.Image);
            dsTimerObrotow.Enabled = true;

            
        }
        abstract class dsBrylaAbstrakcyjna : IComparable<dsBrylaAbstrakcyjna>
        {
            public enum dsTypBryly
            {
                dsbg_Walec,
                dsbg_Stozek,
                dsbg_Kula,
                dsbg_Otroslup,
                dsbg_Graniastoslup,
                dsbg_Szescian
            }
            protected int dsXsS, dsYsS;
            protected int dsXsP, dsYsP;
            public int dsWysokoscB;
            protected float dsKatPochylenia;
            protected int dsGrubosc;
            protected Color dsKolorLinii;
            protected DashStyle dsStylLinii;
            public dsTypBryly dsRodzajBryly;
            // bool dskierunekobrotu=true;
            public float dsPowierzchnaB;
            public float dsObietoscB;
            public dsBrylaAbstrakcyjna(Color kolor, DashStyle styl, int grub)
            {
                this.dsKolorLinii = kolor;
                this.dsStylLinii = styl;
                this.dsGrubosc = grub;
                this.dsKatPochylenia = 90.0F;
            }
            public abstract void dsWykresl(Graphics PowierzchniaGraficzna);
            public abstract void dsWymaz(Control Kontrolka, Graphics PowierzchniaGraficzna);
            public abstract void dsObróćIWykresl(Control Kontrolka, Graphics PowierzchniaGraficzna, float dskatObrotu);
            public abstract void dsPrzesunDoNowegoXY(Control dspbRysownica, Graphics dsRysownica, int x, int y);
            public void dsUstalAtrybutyGraficzne(Color kolor, DashStyle styl, int grub)
            {
                this.dsKolorLinii = kolor;
                this.dsStylLinii = styl;
                this.dsGrubosc = grub;
            }
            public void dsZmienKolorLinii(Color kolor)
            {
                this.dsKolorLinii = kolor;
            }
            public Color dsPobierzKolorLinii()
            {
                return this.dsKolorLinii;
            }
            public void dsZmienStyl(DashStyle d)
            {
                this.dsStylLinii = d;
            }
            public void dsZmieWysokosc(int ds)
            {
                this.dsWysokoscB = ds;
            }

            public int CompareTo(dsBrylaAbstrakcyjna bryla2)
            {
                if (dsUchwytFormularza.dsrbWysokosc.Checked)
                {
                    if (this.dsWysokoscB > bryla2.dsWysokoscB) return 1;
                    else if (this.dsWysokoscB < bryla2.dsWysokoscB) return -1;
                    else return 0;
                }
                else if (dsUchwytFormularza.dsrbobietosc.Checked)
                {
                    if (this.dsObietoscB > bryla2.dsObietoscB) return 1;
                    else if (this.dsObietoscB < bryla2.dsObietoscB) return -1;
                    else return 0;
                }
                else
                {
                    if (this.dsPowierzchnaB > bryla2.dsPowierzchnaB) return 1;
                    else if (this.dsPowierzchnaB < bryla2.dsPowierzchnaB) return -1;
                    else return 0;
                }
            }
        }
        class dsBrylyRosnaco : IComparer<dsBrylaAbstrakcyjna>
        {
            public int Compare(dsBrylaAbstrakcyjna o1, dsBrylaAbstrakcyjna o2)
            {
                if (dsUchwytFormularza.dsrbWysokosc.Checked)
                {
                    if (o1.dsWysokoscB > o2.dsWysokoscB) return 1;
                    else if (o1.dsWysokoscB < o2.dsWysokoscB) return -1;
                    else return 0;
                }
                else if (dsUchwytFormularza.dsrbobietosc.Checked)
                {
                    if (o1.dsObietoscB > o2.dsObietoscB) return 1;
                    else if (o1.dsObietoscB < o2.dsObietoscB) return -1;
                    else return 0;
                }
                else
                {
                    if (o1.dsPowierzchnaB > o2.dsPowierzchnaB) return 1;
                    else if (o1.dsPowierzchnaB < o2.dsPowierzchnaB) return -1;
                    else return 0;
                }
            }
        }
        class dsBrylyObrotowe : dsBrylaAbstrakcyjna
        {
            protected int dsPromienB;
            public dsBrylyObrotowe(int promienB, Color kolor, DashStyle styl, int grub) : base(kolor, styl, grub)
            {
                this.dsPromienB = promienB;
            }
            public override void dsWykresl(Graphics PowierzchniaGraficzna) { }
            public override void dsWymaz(Control Kontrolka, Graphics PowierzchniaGraficzna) { }
            public override void dsObróćIWykresl(Control Kontrolka, Graphics PowierzchniaGraficzna, float dskatObrotu) { }
            public override void dsPrzesunDoNowegoXY(Control dspbRysownica, Graphics dsRysownica, int x, int y) { }
        }
        class dsWielosciany : dsBrylaAbstrakcyjna
        {
            protected Point[] dsWielokatPodlogi;
            protected Point[] dsWielokatSufitu;
            protected int dsStopienWielokataPodstawy;
            protected int dsPromienBryly;
            public dsWielosciany(int promienB, int dsStopienWielokataPodstawy, Color kolor, DashStyle styl, int grub) : base(kolor, styl, grub)
            {
                this.dsPromienBryly = promienB;
                this.dsStopienWielokataPodstawy = dsStopienWielokataPodstawy;
            }
            //dla ostrosłupa
            public dsWielosciany(int promienB, Color kolor, DashStyle styl, int grub) : base(kolor, styl, grub)
            {
                this.dsPromienBryly = promienB;

            }
            public override void dsWykresl(Graphics PowierzchniaGraficzna) { }
            public override void dsWymaz(Control Kontrolka, Graphics PowierzchniaGraficzna) { }
            public override void dsObróćIWykresl(Control Kontrolka, Graphics PowierzchniaGraficzna, float dskatObrotu) { }
            public override void dsPrzesunDoNowegoXY(Control dspbRysownica, Graphics dsRysownica, int x, int y) { }
        }
        class dsStozek : dsBrylyObrotowe
        {
            int dsStopienWielokataPodstawy;
            float dsOs_duza, dsOs_mala;
            float dskatmiedzyWierzcholkami;
            float dsKatpolozenia;
            Point[] dswielokatPodlogi;
            int dsWektorPrzesunieciaWierzcholkaStozka;
            public dsStozek(int r, int wysokosc, int stopienWeilokatapodstawy, int Xsp, int Ysp,
                float katpochyleniastozka, Color kolor, DashStyle styl, int grub) : base(r, kolor, styl, grub)
            {
                this.dsRodzajBryly = dsTypBryly.dsbg_Stozek;
                this.dsWysokoscB = wysokosc;
                this.dsKatPochylenia = katpochyleniastozka;
                this.dsStopienWielokataPodstawy = stopienWeilokatapodstawy;
                this.dsOs_duza = this.dsPromienB * 2;
                this.dsOs_mala = this.dsPromienB / 2;
                dskierunekobrotu = false;
                //wyznacznie wspolrzednej X wierzcholka stozka
                if (dsKatPochylenia < dsKatProsty)
                {
                    float dskatbeta = dsKatProsty - katpochyleniastozka;
                    dsWektorPrzesunieciaWierzcholkaStozka = (int)(wysokosc * (float)(Math.Tan(dskatbeta *
                        (Math.PI / 180F))));
                    dsXsS = Xsp + dsWektorPrzesunieciaWierzcholkaStozka;
                }
                else if (dsKatPochylenia > dsKatProsty)
                {
                    float dskatbeta = katpochyleniastozka - dsKatProsty;
                    dsWektorPrzesunieciaWierzcholkaStozka = (int)(wysokosc * (float)(Math.Tan(dskatbeta *
                        (Math.PI / 180F))));
                    dsXsS = Xsp - dsWektorPrzesunieciaWierzcholkaStozka;
                }
                else dsXsS = Xsp;
                this.dsYsS = Ysp - wysokosc;
                this.dsXsP = Xsp;
                this.dsYsP = Ysp;
                this.dskatmiedzyWierzcholkami = 360 / dsStopienWielokataPodstawy;
                this.dsKatpolozenia = 0F;
                this.dswielokatPodlogi = new Point[dsStopienWielokataPodstawy + 1];
                //utworzenie egzemplarzy punktow wierzcholka wielokata podlogi i wyznaczenie wspolrzednych
                //wierzcholkow wielokata podlogi
                for (int i = 0; i <= dsStopienWielokataPodstawy; i++)
                {
                    dswielokatPodlogi[i] = new Point();
                    dswielokatPodlogi[i].X = (int)(this.dsXsP + dsOs_duza / 2 *
                        Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                    dswielokatPodlogi[i].Y = (int)(this.dsYsP + dsOs_mala / 2 *
                        Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                }
                //obietosc
                this.dsObietoscB = (float)(Math.PI * Math.Pow(this.dsPromienB, 2) * this.dsWysokoscB) / 3;
                this.dsPowierzchnaB = (float)(Math.PI * this.dsPromienB * (this.dsPromienB +
                    Math.Sqrt(this.dsWysokoscB * this.dsWysokoscB + this.dsPromienB * this.dsPromienB)));
            }


            public override void dsWykresl(Graphics PowierzchniaGraficzna)
            {
                using (Pen dsPioro = new Pen(this.dsKolorLinii, this.dsGrubosc))
                {
                    dsPioro.DashStyle = this.dsStylLinii;

                    PowierzchniaGraficzna.DrawEllipse(dsPioro, this.dsXsP - this.dsOs_duza / 2,
                        this.dsYsP - this.dsOs_mala / 2, this.dsOs_duza, this.dsOs_mala);

                    PowierzchniaGraficzna.DrawLine(dsPioro, this.dsXsP - this.dsOs_duza / 2,
                      this.dsYsP, this.dsXsS, this.dsYsS);
                    PowierzchniaGraficzna.DrawLine(dsPioro, this.dsXsP + this.dsOs_duza / 2,
                      this.dsYsP, this.dsXsS, this.dsYsS);
                    for (int i = 0; i <= dsStopienWielokataPodstawy; i++)
                    {
                        PowierzchniaGraficzna.DrawLine(dsPioro, dswielokatPodlogi[i],
                            new Point(this.dsXsS, this.dsYsS));
                    }
                }

            }
            public override void dsWymaz(Control Kontrolka, Graphics PowierzchniaGraficzna)
            {
                using (Pen dsPioro = new Pen(Kontrolka.BackColor, this.dsGrubosc))
                {
                    dsPioro.DashStyle = this.dsStylLinii;
                    PowierzchniaGraficzna.DrawEllipse(dsPioro, this.dsXsP - this.dsOs_duza / 2,
                        this.dsYsP - this.dsOs_mala / 2, this.dsOs_duza, this.dsOs_mala);
                    PowierzchniaGraficzna.DrawLine(dsPioro, this.dsXsP - this.dsOs_duza / 2,
                      this.dsYsP, this.dsXsS, this.dsYsS);
                    PowierzchniaGraficzna.DrawLine(dsPioro, this.dsXsP + this.dsOs_duza / 2,
                      this.dsYsP, this.dsXsS, this.dsYsS);
                    for (int i = 0; i <= dsStopienWielokataPodstawy; i++)
                    {
                        PowierzchniaGraficzna.DrawLine(dsPioro, dswielokatPodlogi[i],
                            new Point(this.dsXsS, this.dsYsS));
                    }
                }
            }
            //*/*/*/*/*/*/*/*/*/*/*/*/*/*stranica 54 w pdf deda*/*/*/*/*/*/*/*/*/*/*/*/*/*/

            public override void dsObróćIWykresl(Control Kontrolka, Graphics PowierzchniaGraficzna, float dskatObrotu)
            {
                dsWymaz(Kontrolka, PowierzchniaGraficzna);
                if (!dskierunekobrotu)
                    this.dsKatpolozenia += dskatObrotu;
                else this.dsKatpolozenia -= dskatObrotu;

                for (int i = 0; i <= dsStopienWielokataPodstawy; i++)
                {
                    dswielokatPodlogi[i].X = (int)(this.dsXsP + dsOs_duza / 2 *
                        Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                    dswielokatPodlogi[i].Y = (int)(this.dsYsP + dsOs_mala / 2 *
                        Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                }
                dsWykresl(PowierzchniaGraficzna);
            }
            public override void dsPrzesunDoNowegoXY(Control Kontrolka, Graphics PowierzchniaGraficzna, int x, int y)
            {
                dsWymaz(Kontrolka, PowierzchniaGraficzna);
                ////mozet byt oszybka
                int dsDx = dsXsP < x ? dsDx = x - dsXsP : dsDx = -(dsXsP - x);
                int dsDy = dsYsP < y ? dsDy = y - dsYsP : dsDy = -(dsYsP - y);
                this.dsXsP = dsXsP + dsDx;
                this.dsYsP = dsYsP + dsDy;
                this.dsXsS = dsXsS + dsDx;
                this.dsYsS = dsYsS + dsDy;
                for (int i = 0; i <= dsStopienWielokataPodstawy; i++)
                {
                    dswielokatPodlogi[i].X = (int)(this.dsXsP + dsOs_duza / 2 *
                        Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                    dswielokatPodlogi[i].Y = (int)(this.dsYsP + dsOs_mala / 2 *
                        Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                }
                dsWykresl(PowierzchniaGraficzna);
            }
        }//class Stozek
        class dsWalec : dsBrylyObrotowe
        {
            int dsStopienWielokataPodstawy;
            Point[] dswielokatPodlogi;
            Point[] dswielokatSufit;
            float dsOs_duza, dsOs_mala;
            float dskatmiedzyWierzcholkami;
            float dsKatpolozenia;
            int dsWektorPrzesunieciaWierzcholkaStozka;
            public dsWalec(int r, int wysokosc, int stopienWeilokatapodstawy, int XsS, int YsS, int Xsp, int Ysp,
               float katpochyleniastozka, Color kolor, DashStyle styl, int grub) : base(r, kolor, styl, grub)
            {
                this.dsRodzajBryly = dsTypBryly.dsbg_Walec;
                this.dsWysokoscB = wysokosc;
                this.dsKatPochylenia = katpochyleniastozka;
                this.dsStopienWielokataPodstawy = stopienWeilokatapodstawy;
                this.dsOs_duza = this.dsPromienB * 2;
                this.dsOs_mala = this.dsPromienB / 2;
                dskierunekobrotu = false;

                if (dsKatPochylenia < dsKatProsty)
                {
                    float dskatbeta = dsKatProsty - katpochyleniastozka;
                    dsWektorPrzesunieciaWierzcholkaStozka = (int)(wysokosc * (float)(Math.Tan(dskatbeta *
                        (Math.PI / 180F))));
                    dsXsS = XsS + dsWektorPrzesunieciaWierzcholkaStozka;
                }
                else if (dsKatPochylenia > dsKatProsty)
                {
                    float dskatbeta = katpochyleniastozka - dsKatProsty;
                    dsWektorPrzesunieciaWierzcholkaStozka = (int)(wysokosc * (float)(Math.Tan(dskatbeta *
                        (Math.PI / 180F))));
                    dsXsS = XsS - dsWektorPrzesunieciaWierzcholkaStozka;
                }
                else
                {
                    this.dsXsS = XsS;
                    this.dsYsS = YsS;
                }
                //dsXsS = Xsp;
                this.dsYsS = Ysp - wysokosc;
                this.dsXsP = Xsp;
                this.dsYsP = Ysp;
                this.dskatmiedzyWierzcholkami = 360 / dsStopienWielokataPodstawy;
                this.dsKatpolozenia = 0F;


                this.dswielokatSufit = new Point[dsStopienWielokataPodstawy + 1];
                this.dswielokatPodlogi = new Point[dsStopienWielokataPodstawy + 1];
                for (int i = 0; i <= dsStopienWielokataPodstawy; i++)
                {
                    dswielokatSufit[i] = new Point();
                    dswielokatSufit[i].X = (int)(this.dsXsS + dsOs_duza / 2 *
                        Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                    dswielokatSufit[i].Y = (int)(this.dsYsS + dsOs_mala / 2 *
                        Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                    dswielokatPodlogi[i] = new Point();
                    dswielokatPodlogi[i].X = (int)(this.dsXsP + dsOs_duza / 2 *
                        Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                    dswielokatPodlogi[i].Y = (int)(this.dsYsP + dsOs_mala / 2 *
                        Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                }
                //utworzenie egzemplarzy punktow wierzcholka wielokata podlogi i wyznaczenie wspolrzednych
                //wierzcholkow wielokata podlogi

                //obietosc
                this.dsObietoscB = (float)(Math.PI * Math.Pow(this.dsPromienB, 2) * this.dsWysokoscB);
                this.dsPowierzchnaB = (float)((2 * Math.PI * Math.Pow(this.dsPromienB, 2)) +
                    (2 * Math.PI * this.dsPromienB * this.dsWysokoscB));
            }

            public override void dsWykresl(Graphics PowierzchniaGraficzna)
            {
                using (Pen dsPioro = new Pen(this.dsKolorLinii, this.dsGrubosc))
                {
                    dsPioro.DashStyle = this.dsStylLinii;

                    PowierzchniaGraficzna.DrawEllipse(dsPioro, this.dsXsP - this.dsOs_duza / 2,
                        this.dsYsP - this.dsOs_mala / 2, this.dsOs_duza, this.dsOs_mala);
                    PowierzchniaGraficzna.DrawEllipse(dsPioro, this.dsXsS - this.dsOs_duza / 2,
                        this.dsYsS - this.dsOs_mala / 2, this.dsOs_duza, this.dsOs_mala);

                    PowierzchniaGraficzna.DrawLine(dsPioro, this.dsXsP - this.dsOs_duza / 2,
                      this.dsYsP, this.dsXsS - this.dsOs_duza / 2, this.dsYsS);
                    PowierzchniaGraficzna.DrawLine(dsPioro, this.dsXsP + this.dsOs_duza / 2,
                      this.dsYsP, this.dsXsS + this.dsOs_duza / 2, this.dsYsS);


                    for (int i = 0; i <= dsStopienWielokataPodstawy; i++)
                    {
                        PowierzchniaGraficzna.DrawLine(dsPioro, dswielokatPodlogi[i],
                            dswielokatSufit[i]);
                    }
                }

            }
            public override void dsWymaz(Control Kontrolka, Graphics PowierzchniaGraficzna)
            {
                using (Pen dsPioro = new Pen(Kontrolka.BackColor, this.dsGrubosc))
                {
                    dsPioro.DashStyle = this.dsStylLinii;

                    PowierzchniaGraficzna.DrawEllipse(dsPioro, this.dsXsP - this.dsOs_duza / 2,
                        this.dsYsP - this.dsOs_mala / 2, this.dsOs_duza, this.dsOs_mala);
                    PowierzchniaGraficzna.DrawEllipse(dsPioro, this.dsXsS - this.dsOs_duza / 2,
                        this.dsYsS - this.dsOs_mala / 2, this.dsOs_duza, this.dsOs_mala);

                    PowierzchniaGraficzna.DrawLine(dsPioro, this.dsXsP - this.dsOs_duza / 2,
                      this.dsYsP, this.dsXsS - this.dsOs_duza / 2, this.dsYsS);
                    PowierzchniaGraficzna.DrawLine(dsPioro, this.dsXsP + this.dsOs_duza / 2,
                      this.dsYsP, this.dsXsS + this.dsOs_duza / 2, this.dsYsS);


                    for (int i = 0; i <= dsStopienWielokataPodstawy; i++)
                    {
                        PowierzchniaGraficzna.DrawLine(dsPioro, dswielokatPodlogi[i],
                            dswielokatSufit[i]);
                    }
                }
            }
            public override void dsObróćIWykresl(Control Kontrolka, Graphics PowierzchniaGraficzna, float dskatObrotu)
            {
                dsWymaz(Kontrolka, PowierzchniaGraficzna);
                if (!dskierunekobrotu)
                    this.dsKatpolozenia += dskatObrotu;
                else this.dsKatpolozenia -= dskatObrotu;

                for (int i = 0; i <= dsStopienWielokataPodstawy; i++)
                {
                    dswielokatSufit[i].X = (int)(this.dsXsS + dsOs_duza / 2 *
                        Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                    dswielokatSufit[i].Y = (int)(this.dsYsS + dsOs_mala / 2 *
                        Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));

                    dswielokatPodlogi[i].X = (int)(this.dsXsP + dsOs_duza / 2 *
                        Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                    dswielokatPodlogi[i].Y = (int)(this.dsYsP + dsOs_mala / 2 *
                        Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                }
                dsWykresl(PowierzchniaGraficzna);
            }
            public override void dsPrzesunDoNowegoXY(Control Kontrolka, Graphics PowierzchniaGraficzna, int x, int y)
            {
                dsWymaz(Kontrolka, PowierzchniaGraficzna);
                ////mozet byt oszybka
                int dsDx = dsXsP < x ? dsDx = x - dsXsP : dsDx = -(dsXsP - x);
                int dsDy = dsYsP < y ? dsDy = y - dsYsP : dsDy = -(dsYsP - y);
                this.dsXsP = dsXsP + dsDx;
                this.dsYsP = dsYsP + dsDy;
                this.dsXsS = dsXsS + dsDx;
                this.dsYsS = dsYsS + dsDy;
                for (int i = 0; i <= dsStopienWielokataPodstawy; i++)
                {
                    dswielokatSufit[i].X = (int)(this.dsXsS + dsOs_duza / 2 *
                        Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                    dswielokatSufit[i].Y = (int)(this.dsYsS + dsOs_mala / 2 *
                        Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));

                    dswielokatPodlogi[i].X = (int)(this.dsXsP + dsOs_duza / 2 *
                        Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                    dswielokatPodlogi[i].Y = (int)(this.dsYsP + dsOs_mala / 2 *
                        Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                }
                dsWykresl(PowierzchniaGraficzna);
            }
        }// class walec
        class dsOstroslupTroj : dsWielosciany
        {
            //int dsStopienWielokataPodstawy;
            float dsOs_duza, dsOs_mala;
            float dskatmiedzyWierzcholkami;
            float dsKatpolozenia;
            int dsWektorPrzesunieciaWierzcholkaStozka;
            public dsOstroslupTroj(int r, int wysokosc, int Xsp, int Ysp,
                float katpochyleniastozka, Color kolor, DashStyle styl, int grub) : base(r, kolor, styl, grub)
            {
                this.dsRodzajBryly = dsTypBryly.dsbg_Otroslup;
                this.dsWysokoscB = wysokosc;
                this.dsKatPochylenia = katpochyleniastozka;
                this.dsStopienWielokataPodstawy = 3;
                this.dsOs_duza = r * 2;
                this.dsOs_mala = r / 2;
                dskierunekobrotu = false;
                //wyznacznie wspolrzednej X wierzcholka stozka
                if (dsKatPochylenia < dsKatProsty)
                {
                    float dskatbeta = dsKatProsty - katpochyleniastozka;
                    dsWektorPrzesunieciaWierzcholkaStozka = (int)(wysokosc * (float)(Math.Tan(dskatbeta *
                        (Math.PI / 180F))));
                    dsXsS = Xsp + dsWektorPrzesunieciaWierzcholkaStozka;
                }
                else if (dsKatPochylenia > dsKatProsty)
                {
                    float dskatbeta = katpochyleniastozka - dsKatProsty;
                    dsWektorPrzesunieciaWierzcholkaStozka = (int)(wysokosc * (float)(Math.Tan(dskatbeta *
                        (Math.PI / 180F))));
                    dsXsS = Xsp - dsWektorPrzesunieciaWierzcholkaStozka;
                }
                else dsXsS = Xsp;
                this.dsYsS = Ysp - wysokosc;
                this.dsXsP = Xsp;
                this.dsYsP = Ysp;
                this.dskatmiedzyWierzcholkami = 360 / dsStopienWielokataPodstawy;
                this.dsKatpolozenia = 0F;
                this.dsWielokatPodlogi = new Point[dsStopienWielokataPodstawy + 1];
                //utworzenie egzemplarzy punktow wierzcholka wielokata podlogi i wyznaczenie wspolrzednych
                //wierzcholkow wielokata podlogi
                for (int i = 0; i <= dsStopienWielokataPodstawy; i++)
                {
                    dsWielokatPodlogi[i] = new Point();
                    if (i == dsStopienWielokataPodstawy)
                    {
                        dsWielokatPodlogi[i].X = dsWielokatPodlogi[0].X;
                        dsWielokatPodlogi[i].Y = dsWielokatPodlogi[0].Y;
                    }
                    else
                    {
                        dsWielokatPodlogi[i].X = (int)(this.dsXsP + dsOs_duza / 2 *
                            Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                        dsWielokatPodlogi[i].Y = (int)(this.dsYsP + dsOs_mala / 2 *
                            Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                    }

                }
                //obietosc
                float Pp = (1.0F / 4.0F) * 3.0F * (float)Math.Sqrt(3) * (float)Math.Pow(r, 2);
                this.dsObietoscB =Pp*this.dsWysokoscB*(1.0F/3.0F);              
                this.dsPowierzchnaB =Pp + (3F*((1F/2F)*((float)Math.Sqrt(3)*r)*this.dsWysokoscB));
            }

            public override void dsWykresl(Graphics PowierzchniaGraficzna)
            {
                using (Pen dsPioro = new Pen(this.dsKolorLinii, this.dsGrubosc))
                {
                    dsPioro.DashStyle = this.dsStylLinii;
                    PowierzchniaGraficzna.DrawLines(dsPioro, dsWielokatPodlogi);
                    for (int i = 0; i < dsStopienWielokataPodstawy; i++)
                    {
                        PowierzchniaGraficzna.DrawLine(dsPioro, dsWielokatPodlogi[i],
                            new Point(this.dsXsS, this.dsYsS));
                    }
                }

            }
            public override void dsWymaz(Control Kontrolka, Graphics PowierzchniaGraficzna)
            {
                using (Pen dsPioro = new Pen(Kontrolka.BackColor, this.dsGrubosc))
                {
                    dsPioro.DashStyle = this.dsStylLinii;
                    PowierzchniaGraficzna.DrawLines(dsPioro, dsWielokatPodlogi);
                    for (int i = 0; i < dsStopienWielokataPodstawy; i++)
                    {
                        PowierzchniaGraficzna.DrawLine(dsPioro, dsWielokatPodlogi[i],
                            new Point(this.dsXsS, this.dsYsS));
                    }
                }
            }
            public override void dsObróćIWykresl(Control Kontrolka, Graphics PowierzchniaGraficzna, float dskatObrotu)
            {
                dsWymaz(Kontrolka, PowierzchniaGraficzna);
                if (!dskierunekobrotu)
                    this.dsKatpolozenia += dskatObrotu;
                else this.dsKatpolozenia -= dskatObrotu;

                for (int i = 0; i <= dsStopienWielokataPodstawy; i++)
                {
                    dsWielokatPodlogi[i] = new Point();
                    if (i == dsStopienWielokataPodstawy)
                    {
                        dsWielokatPodlogi[i].X = dsWielokatPodlogi[0].X;
                        dsWielokatPodlogi[i].Y = dsWielokatPodlogi[0].Y;
                    }
                    else
                    {
                        dsWielokatPodlogi[i].X = (int)(this.dsXsP + dsOs_duza / 2 *
                            Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                        dsWielokatPodlogi[i].Y = (int)(this.dsYsP + dsOs_mala / 2 *
                            Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                    }

                }
                dsWykresl(PowierzchniaGraficzna);
            }
            public override void dsPrzesunDoNowegoXY(Control Kontrolka, Graphics PowierzchniaGraficzna, int x, int y)
            {
                dsWymaz(Kontrolka, PowierzchniaGraficzna);
                ////mozet byt oszybka
                int dsDx = dsXsP < x ? dsDx = x - dsXsP : dsDx = -(dsXsP - x);
                int dsDy = dsYsP < y ? dsDy = y - dsYsP : dsDy = -(dsYsP - y);
                this.dsXsP = dsXsP + dsDx;
                this.dsYsP = dsYsP + dsDy;
                this.dsXsS = dsXsS + dsDx;
                this.dsYsS = dsYsS + dsDy;
                for (int i = 0; i <= dsStopienWielokataPodstawy; i++)
                {
                    dsWielokatPodlogi[i] = new Point();
                    if (i == dsStopienWielokataPodstawy)
                    {
                        dsWielokatPodlogi[i].X = dsWielokatPodlogi[0].X;
                        dsWielokatPodlogi[i].Y = dsWielokatPodlogi[0].Y;
                    }
                    else
                    {
                        dsWielokatPodlogi[i].X = (int)(this.dsXsP + dsOs_duza / 2 *
                            Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                        dsWielokatPodlogi[i].Y = (int)(this.dsYsP + dsOs_mala / 2 *
                            Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                    }

                }
                dsWykresl(PowierzchniaGraficzna);
            }
        }//class Ostroslup
        class dsGraniastoslup : dsWielosciany
        {
            float dsOs_duza, dsOs_mala;
            float dskatmiedzyWierzcholkami;
            float dsKatpolozenia;
            int dsWektorPrzesunieciaWierzcholkaStozka;
            public dsGraniastoslup(int r, int wysokosc, int StopienWielokataPodstawy, int XsS, int YsS, int Xsp, int Ysp,
                float katpochyleniastozka, Color kolor, DashStyle styl, int grub) : base(r, StopienWielokataPodstawy, kolor, styl, grub)
            {
                this.dsRodzajBryly = dsTypBryly.dsbg_Graniastoslup;
                this.dsWysokoscB = wysokosc;
                this.dsKatPochylenia = katpochyleniastozka;
                this.dsStopienWielokataPodstawy = StopienWielokataPodstawy;
                this.dsOs_duza = r * 2;
                this.dsOs_mala = r / 2;
                dskierunekobrotu = false;
                if (dsKatPochylenia < dsKatProsty)
                {
                    float dskatbeta = dsKatProsty - katpochyleniastozka;
                    dsWektorPrzesunieciaWierzcholkaStozka = (int)(wysokosc * (float)(Math.Tan(dskatbeta *
                        (Math.PI / 180F))));
                    dsXsS = XsS + dsWektorPrzesunieciaWierzcholkaStozka;
                }
                else if (dsKatPochylenia > dsKatProsty)
                {
                    float dskatbeta = katpochyleniastozka - dsKatProsty;
                    dsWektorPrzesunieciaWierzcholkaStozka = (int)(wysokosc * (float)(Math.Tan(dskatbeta *
                        (Math.PI / 180F))));
                    dsXsS = XsS - dsWektorPrzesunieciaWierzcholkaStozka;
                }
                else
                {
                    this.dsXsS = XsS;
                    this.dsYsS = YsS;
                }
                //dsXsS = Xsp;
                this.dsYsS = Ysp - wysokosc;               
                this.dsXsP = Xsp;
                this.dsYsP = Ysp;
                this.dskatmiedzyWierzcholkami = 360 / dsStopienWielokataPodstawy;
                this.dsKatpolozenia = 0F;
                this.dsWielokatPodlogi = new Point[dsStopienWielokataPodstawy + 1];
                this.dsWielokatSufitu = new Point[dsStopienWielokataPodstawy + 1];
                for (int i = 0; i <= dsStopienWielokataPodstawy; i++)
                {
                    dsWielokatSufitu[i] = new Point();
                    dsWielokatPodlogi[i] = new Point();
                    if (i == dsStopienWielokataPodstawy)
                    {
                        dsWielokatSufitu[i].X = dsWielokatSufitu[0].X;
                        dsWielokatSufitu[i].Y = dsWielokatSufitu[0].Y;
                        dsWielokatPodlogi[i].X = dsWielokatPodlogi[0].X;
                        dsWielokatPodlogi[i].Y = dsWielokatPodlogi[0].Y;
                    }
                    else
                    {
                        dsWielokatSufitu[i].X = (int)(this.dsXsS + dsOs_duza / 2 *
                        Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                        dsWielokatSufitu[i].Y = (int)(this.dsYsS + dsOs_mala / 2 *
                            Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));

                        dsWielokatPodlogi[i].X = (int)(this.dsXsP + dsOs_duza / 2 *
                            Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                        dsWielokatPodlogi[i].Y = (int)(this.dsYsP + dsOs_mala / 2 *
                            Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                    }                      
                    
                }
                //obietosc w 
                double pole_odstawy = ((this.dsStopienWielokataPodstawy * Math.Pow(r+r, 2)) / 4)*
                   (1/ Math.Tan(180.0F/this.dsStopienWielokataPodstawy));
                this.dsObietoscB = (float)pole_odstawy * this.dsWysokoscB;
                this.dsPowierzchnaB = (2 * (float)pole_odstawy) + (this.dsStopienWielokataPodstawy * this.dsWysokoscB * (r + r));
            }
            public override void dsWykresl(Graphics PowierzchniaGraficzna)
            {
                using (Pen dsPioro = new Pen(this.dsKolorLinii, this.dsGrubosc))
                {
                    dsPioro.DashStyle = this.dsStylLinii;

                    PowierzchniaGraficzna.DrawLines(dsPioro, dsWielokatSufitu);
                    PowierzchniaGraficzna.DrawLines(dsPioro, dsWielokatPodlogi);
                    for (int i = 0; i <= dsStopienWielokataPodstawy; i++)
                    {
                        PowierzchniaGraficzna.DrawLine(dsPioro, dsWielokatPodlogi[i],
                            dsWielokatSufitu[i]);
                    }
                }
            }
            public override void dsWymaz(Control Kontrolka, Graphics PowierzchniaGraficzna)
            {
                using (Pen dsPioro = new Pen(Kontrolka.BackColor, this.dsGrubosc))
                {
                    dsPioro.DashStyle = this.dsStylLinii;

                    PowierzchniaGraficzna.DrawLines(dsPioro, dsWielokatSufitu);
                    PowierzchniaGraficzna.DrawLines(dsPioro, dsWielokatPodlogi);
                    for (int i = 0; i <= dsStopienWielokataPodstawy; i++)
                    {
                        PowierzchniaGraficzna.DrawLine(dsPioro, dsWielokatPodlogi[i],
                            dsWielokatSufitu[i]);
                    }
                }
            }
            public override void dsObróćIWykresl(Control Kontrolka, Graphics PowierzchniaGraficzna, float dskatObrotu)
            {
                dsWymaz(Kontrolka, PowierzchniaGraficzna);
                if (!dskierunekobrotu)
                    this.dsKatpolozenia += dskatObrotu;
                else this.dsKatpolozenia -= dskatObrotu;

                for (int i = 0; i <= dsStopienWielokataPodstawy; i++)
                {
                    dsWielokatSufitu[i] = new Point();
                    dsWielokatPodlogi[i] = new Point();
                    if (i == dsStopienWielokataPodstawy)
                    {
                        dsWielokatSufitu[i].X = dsWielokatSufitu[0].X;
                        dsWielokatSufitu[i].Y = dsWielokatSufitu[0].Y;
                        dsWielokatPodlogi[i].X = dsWielokatPodlogi[0].X;
                        dsWielokatPodlogi[i].Y = dsWielokatPodlogi[0].Y;
                    }
                    else
                    {
                        dsWielokatSufitu[i].X = (int)(this.dsXsS + dsOs_duza / 2 *
                        Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                        dsWielokatSufitu[i].Y = (int)(this.dsYsS + dsOs_mala / 2 *
                            Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));

                        dsWielokatPodlogi[i].X = (int)(this.dsXsP + dsOs_duza / 2 *
                            Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                        dsWielokatPodlogi[i].Y = (int)(this.dsYsP + dsOs_mala / 2 *
                            Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                    }

                }
                dsWykresl(PowierzchniaGraficzna);
            }
            public override void dsPrzesunDoNowegoXY(Control Kontrolka, Graphics PowierzchniaGraficzna, int x, int y)
            {
                dsWymaz(Kontrolka, PowierzchniaGraficzna);
                ////mozet byt oszybka
                int dsDx = dsXsP < x ? dsDx = x - dsXsP : dsDx = -(dsXsP - x);
                int dsDy = dsYsP < y ? dsDy = y - dsYsP : dsDy = -(dsYsP - y);
                this.dsXsP = dsXsP + dsDx;
                this.dsYsP = dsYsP + dsDy;
                this.dsXsS = dsXsS + dsDx;
                this.dsYsS = dsYsS + dsDy;
                for (int i = 0; i <= dsStopienWielokataPodstawy; i++)
                {
                    dsWielokatSufitu[i] = new Point();
                    dsWielokatPodlogi[i] = new Point();
                    if (i == dsStopienWielokataPodstawy)
                    {
                        dsWielokatSufitu[i].X = dsWielokatSufitu[0].X;
                        dsWielokatSufitu[i].Y = dsWielokatSufitu[0].Y;
                        dsWielokatPodlogi[i].X = dsWielokatPodlogi[0].X;
                        dsWielokatPodlogi[i].Y = dsWielokatPodlogi[0].Y;
                    }
                    else
                    {
                        dsWielokatSufitu[i].X = (int)(this.dsXsS + dsOs_duza / 2 *
                        Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                        dsWielokatSufitu[i].Y = (int)(this.dsYsS + dsOs_mala / 2 *
                            Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));

                        dsWielokatPodlogi[i].X = (int)(this.dsXsP + dsOs_duza / 2 *
                            Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                        dsWielokatPodlogi[i].Y = (int)(this.dsYsP + dsOs_mala / 2 *
                            Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                    }

                }
                dsWykresl(PowierzchniaGraficzna);
            }
         
        }//graniastoslup
        class dsOstroslupCzworo : dsWielosciany///////    Panie Professorze, żeby ostroślup był pochyły to trzeba ustalić kąt pochylenia w odpowiedniej kontrolce
        {
            //int dsStopienWielokataPodstawy;
            float dsOs_duza, dsOs_mala;
            float dskatmiedzyWierzcholkami;
            float dsKatpolozenia;
            int dsWektorPrzesunieciaWierzcholkaStozka;
            int dsXx, dsYy;
            public dsOstroslupCzworo(int r, int wysokosc, int Xsp, int Ysp,
                float katpochyleniastozka, Color kolor, DashStyle styl, int grub) : base(r, kolor, styl, grub)
            {
                
                this.dsRodzajBryly = dsTypBryly.dsbg_Otroslup;
                this.dsWysokoscB = wysokosc;
                this.dsKatPochylenia = katpochyleniastozka;
                this.dsStopienWielokataPodstawy = 4;
                this.dsOs_duza = r * 2;
                this.dsOs_mala = r / 2;
                dskierunekobrotu = false;
                //wyznacznie wspolrzednej X wierzcholka stozka
                if (dsKatPochylenia < dsKatProsty)
                {
                    float dskatbeta = dsKatProsty - katpochyleniastozka;
                    dsWektorPrzesunieciaWierzcholkaStozka = (int)(wysokosc * (float)(Math.Tan(dskatbeta *
                        (Math.PI / 180F))));
                    dsXsS = Xsp + dsWektorPrzesunieciaWierzcholkaStozka;
                }
                else if (dsKatPochylenia > dsKatProsty)
                {
                    float dskatbeta = katpochyleniastozka - dsKatProsty;
                    dsWektorPrzesunieciaWierzcholkaStozka = (int)(wysokosc * (float)(Math.Tan(dskatbeta *
                        (Math.PI / 180F))));
                    dsXsS = Xsp - dsWektorPrzesunieciaWierzcholkaStozka;
                }
                else dsXsS = Xsp;
                if (dsKatPochylenia < dsKatProsty)
                {
                    float dskatbeta = dsKatProsty - katpochyleniastozka;
                    dsWektorPrzesunieciaWierzcholkaStozka = (int)(wysokosc * (float)(Math.Tan(dskatbeta *
                        (Math.PI / 180F))));
                    this.dsXx = Xsp - dsWektorPrzesunieciaWierzcholkaStozka;
                }
                else if (dsKatPochylenia > dsKatProsty)
                {
                    float dskatbeta = katpochyleniastozka - dsKatProsty;
                    dsWektorPrzesunieciaWierzcholkaStozka = (int)(wysokosc * (float)(Math.Tan(dskatbeta *
                        (Math.PI / 180F))));
                    this.dsXx = Xsp + dsWektorPrzesunieciaWierzcholkaStozka;
                }
                else  this.dsXx = Xsp;

                this.dsYsS = Ysp - wysokosc;
                this.dsXsP = Xsp;
                this.dsYsP = Ysp;
                this.dsYy = Ysp + wysokosc;
                this.dskatmiedzyWierzcholkami = 360 / dsStopienWielokataPodstawy;
                this.dsKatpolozenia = 0F;
                this.dsWielokatPodlogi = new Point[dsStopienWielokataPodstawy + 1];
                //utworzenie egzemplarzy punktow wierzcholka wielokata podlogi i wyznaczenie wspolrzednych
                //wierzcholkow wielokata podlogi
                //float dskatb = dsKatProsty - 20;
                //dsWektorPrzesunieciaWierzcholkaStozka = (int)(wysokosc * (float)(Math.Tan(dskatb *
                //    (Math.PI / 180F))));
                //this.dsXd = Xsp - dsWektorPrzesunieciaWierzcholkaStozka;
                for (int i = 0; i <= dsStopienWielokataPodstawy; i++)
                {
                    dsWielokatPodlogi[i] = new Point();
                    if (i == dsStopienWielokataPodstawy)
                    {
                        dsWielokatPodlogi[i].X = dsWielokatPodlogi[0].X;
                        dsWielokatPodlogi[i].Y = dsWielokatPodlogi[0].Y;
                    }
                    else if (i > 1)
                    {
                        if (dsKatPochylenia < dsKatProsty)
                        {
                            float dskatbeta = dsKatProsty - this.dsKatPochylenia;
                            dsWektorPrzesunieciaWierzcholkaStozka = (int)(this.dsWysokoscB * (float)(Math.Tan(dskatbeta *
                                (Math.PI / 180F))));
                            dsWielokatPodlogi[i].X = (int)(this.dsXsP + dsOs_duza / 2 *
                           Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                            dsWielokatPodlogi[i].Y = (int)(this.dsYsP + dsOs_mala / 3 *
                                Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F)) - dsWektorPrzesunieciaWierzcholkaStozka;
                        }
                        else if (dsKatPochylenia > dsKatProsty)
                        {

                            float dskatbeta = dsKatProsty - this.dsKatPochylenia;
                            dsWektorPrzesunieciaWierzcholkaStozka = (int)(this.dsWysokoscB * (float)(Math.Tan(dskatbeta *
                                (Math.PI / 180F))));
                            dsWielokatPodlogi[i].X = (int)(this.dsXsP + dsOs_duza / 2 *
                           Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                            dsWielokatPodlogi[i].Y = (int)(this.dsYsP + dsOs_mala / 3 *
                                Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F)) + dsWektorPrzesunieciaWierzcholkaStozka;
                        }
                        else
                        {
                            dsWielokatPodlogi[i].X = (int)(this.dsXsP + dsOs_duza / 2 *
                            Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                            dsWielokatPodlogi[i].Y = (int)(this.dsYsP + dsOs_mala / 3 *
                                Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                        }

                    }
                    else
                    {
                        dsWielokatPodlogi[i].X = (int)(this.dsXsP + dsOs_duza / 2 *
                            Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                        dsWielokatPodlogi[i].Y = (int)(this.dsYsP + dsOs_mala / 3 *
                            Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                    }

                }
                //obietosc
                float Pp = 8*this.dsPromienBryly;
                this.dsObietoscB = Pp * (this.dsWysokoscB * (1.0F / 3.0F)*2);
                this.dsPowierzchnaB = Pp + ((3F * ((1F / 2F) * ((float)Math.Sqrt(3) * r) * this.dsWysokoscB))*2);
            }

            public override void dsWykresl(Graphics PowierzchniaGraficzna)
            {
                using (Pen dsPioro = new Pen(this.dsKolorLinii, this.dsGrubosc))
                {
                    dsPioro.DashStyle = this.dsStylLinii;
                    PowierzchniaGraficzna.DrawLines(dsPioro, dsWielokatPodlogi);
                    for (int i = 0; i < dsStopienWielokataPodstawy; i++)
                    {
                        PowierzchniaGraficzna.DrawLine(dsPioro, dsWielokatPodlogi[i],
                            new Point(this.dsXsS, this.dsYsS));
                        PowierzchniaGraficzna.DrawLine(dsPioro, dsWielokatPodlogi[i],
                            new Point(this.dsXx, this.dsYy));
                    }
                }
            }
            public override void dsWymaz(Control Kontrolka, Graphics PowierzchniaGraficzna)
            {
                using (Pen dsPioro = new Pen(Kontrolka.BackColor, this.dsGrubosc))
                {
                    dsPioro.DashStyle = this.dsStylLinii;
                    PowierzchniaGraficzna.DrawLines(dsPioro, dsWielokatPodlogi);
                    for (int i = 0; i < dsStopienWielokataPodstawy; i++)
                    {
                        PowierzchniaGraficzna.DrawLine(dsPioro, dsWielokatPodlogi[i],
                            new Point(this.dsXsS, this.dsYsS));
                        PowierzchniaGraficzna.DrawLine(dsPioro, dsWielokatPodlogi[i],
                            new Point(this.dsXx, this.dsYy));
                    }
                }
            }
            public override void dsObróćIWykresl(Control Kontrolka, Graphics PowierzchniaGraficzna, float dskatObrotu)
            {
                dsWymaz(Kontrolka, PowierzchniaGraficzna);
                if (!dskierunekobrotu)
                    this.dsKatpolozenia += dskatObrotu;
                else this.dsKatpolozenia -= dskatObrotu;

                for (int i = 0; i <= dsStopienWielokataPodstawy; i++)
                {
                    dsWielokatPodlogi[i] = new Point();
                    if (i == dsStopienWielokataPodstawy)
                    {
                        dsWielokatPodlogi[i].X = dsWielokatPodlogi[0].X;
                        dsWielokatPodlogi[i].Y = dsWielokatPodlogi[0].Y;
                    }
                    else if (i > 1)
                    {
                        if (dsKatPochylenia < dsKatProsty)
                        {
                            float dskatbeta = dsKatProsty - this.dsKatPochylenia;
                            dsWektorPrzesunieciaWierzcholkaStozka = (int)(this.dsWysokoscB * (float)(Math.Tan(dskatbeta *
                                (Math.PI / 180F))));
                            dsWielokatPodlogi[i].X = (int)(this.dsXsP + dsOs_duza / 2 *
                           Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                            dsWielokatPodlogi[i].Y = (int)(this.dsYsP + dsOs_mala / 3 *
                                Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F)) - dsWektorPrzesunieciaWierzcholkaStozka;
                        }
                        else if (dsKatPochylenia > dsKatProsty)
                        {
                            
                            float dskatbeta = dsKatProsty - this.dsKatPochylenia;
                            dsWektorPrzesunieciaWierzcholkaStozka = (int)(this.dsWysokoscB * (float)(Math.Tan(dskatbeta *
                                (Math.PI / 180F))));
                            dsWielokatPodlogi[i].X = (int)(this.dsXsP + dsOs_duza / 2 *
                           Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                            dsWielokatPodlogi[i].Y = (int)(this.dsYsP + dsOs_mala / 3 *
                                Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F)) + dsWektorPrzesunieciaWierzcholkaStozka;
                        }
                        else
                        {
                            dsWielokatPodlogi[i].X = (int)(this.dsXsP + dsOs_duza / 2 *
                            Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                            dsWielokatPodlogi[i].Y = (int)(this.dsYsP + dsOs_mala / 3 *
                                Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                        }
                       
                    }
                    else
                    {
                        dsWielokatPodlogi[i].X = (int)(this.dsXsP + dsOs_duza / 2 *
                            Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                        dsWielokatPodlogi[i].Y = (int)(this.dsYsP + dsOs_mala / 3 *
                            Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                    }

                }
                dsWykresl(PowierzchniaGraficzna);
            }
            public override void dsPrzesunDoNowegoXY(Control Kontrolka, Graphics PowierzchniaGraficzna, int x, int y)
            {
                dsWymaz(Kontrolka, PowierzchniaGraficzna);
                ////mozet byt oszybka
                int dsDx = dsXsP < x ? dsDx = x - dsXsP : dsDx = -(dsXsP - x);
                int dsDy = dsYsP < y ? dsDy = y - dsYsP : dsDy = -(dsYsP - y);
                this.dsXsP = dsXsP + dsDx;
                this.dsYsP = dsYsP + dsDy;
                this.dsXsS = dsXsS + dsDx;
                this.dsYsS = dsYsS + dsDy;
                this.dsXx = dsXx + dsDx;
                this.dsYy = dsYy + dsDy;
                for (int i = 0; i <= dsStopienWielokataPodstawy; i++)
                {
                    dsWielokatPodlogi[i] = new Point();
                    if (i == dsStopienWielokataPodstawy)
                    {
                        dsWielokatPodlogi[i].X = dsWielokatPodlogi[0].X;
                        dsWielokatPodlogi[i].Y = dsWielokatPodlogi[0].Y;
                    }
                    else if (i > 1)
                    {
                        if (dsKatPochylenia < dsKatProsty)
                        {
                            float dskatbeta = dsKatProsty - this.dsKatPochylenia;
                            dsWektorPrzesunieciaWierzcholkaStozka = (int)(this.dsWysokoscB * (float)(Math.Tan(dskatbeta *
                                (Math.PI / 180F))));
                            dsWielokatPodlogi[i].X = (int)(this.dsXsP + dsOs_duza / 2 *
                           Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                            dsWielokatPodlogi[i].Y = (int)(this.dsYsP + dsOs_mala / 3 *
                                Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F)) - dsWektorPrzesunieciaWierzcholkaStozka;
                        }
                        else if (dsKatPochylenia > dsKatProsty)
                        {

                            float dskatbeta = dsKatProsty - this.dsKatPochylenia;
                            dsWektorPrzesunieciaWierzcholkaStozka = (int)(this.dsWysokoscB * (float)(Math.Tan(dskatbeta *
                                (Math.PI / 180F))));
                            dsWielokatPodlogi[i].X = (int)(this.dsXsP + dsOs_duza / 2 *
                           Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                            dsWielokatPodlogi[i].Y = (int)(this.dsYsP + dsOs_mala / 3 *
                                Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F)) + dsWektorPrzesunieciaWierzcholkaStozka;
                        }
                        else
                        {
                            dsWielokatPodlogi[i].X = (int)(this.dsXsP + dsOs_duza / 2 *
                            Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                            dsWielokatPodlogi[i].Y = (int)(this.dsYsP + dsOs_mala / 3 *
                                Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                        }

                    }
                    else
                    {
                        dsWielokatPodlogi[i].X = (int)(this.dsXsP + dsOs_duza / 2 *
                            Math.Cos(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                        dsWielokatPodlogi[i].Y = (int)(this.dsYsP + dsOs_mala / 3 *
                            Math.Sin(Math.PI * (dsKatpolozenia + i * dskatmiedzyWierzcholkami) / 180F));
                    }

                }
                dsWykresl(PowierzchniaGraficzna);
            }
        }//class OstroslupcZworo

        private void dsTimerObrotow_Tick(object sender, EventArgs e)
            {
                for (int i = 0; i < dsLBG.Count; i++)
                {
                    dsLBG[i].dsObróćIWykresl(dspbRysownica, dsRysownica, 5F);
                    //dsLBG[i].dsWykresl(dsRysownica);
                }
                dspbRysownica.Refresh();
            }

            private void dsbtnDodaj_Click(object sender, EventArgs e)
            {
                string dsRodzajBryly;
                int dsPromienBryly, dsWysokoscBryly, dsStopienWielokataBryly, dsXmax, dsYmax, dsGruboscLinii;
                float dsKatPochyleniaBryly;
                int dsWspolrzednaXPodlogiBryly, dsWspolrzednaYPodlogiBryly;
                Color dsKolorLinii;
                DashStyle dsStylLinii;

                if (dscmbWybierz.SelectedIndex < 0)
                {
                    errorProvider1.SetError(dscmbWybierz, "ERROR: musisz wybrać bryłę geometryczna");
                    return;
                }
                else errorProvider1.Dispose();
                if (dscmbPodstawaBryly.SelectedIndex < 0 && dscmbWybierz.Text != "Ostroślup trójkątny" && dscmbWybierz.Text != "Ostroślup czworokątny")
                {
                    errorProvider1.SetError(dscmbPodstawaBryly, "ERROR: musisz wybrać podstwę bryły");
                    return;
                }
                else errorProvider1.Dispose();

                dsXmax = dspbRysownica.Width;
                dsYmax = dspbRysownica.Height;
                Gener = new Random();
                dsKolorLinii = Color.FromArgb(Gener.Next(0, 255), Gener.Next(0, 255), Gener.Next(0, 255));

                switch (Gener.Next(1, 6))
                {
                    case 1:
                        dsStylLinii = DashStyle.Dash;
                        break;
                    case 2:
                        dsStylLinii = DashStyle.Dot;
                        break;
                    case 3:
                        dsStylLinii = DashStyle.Solid;
                        break;
                    case 4:
                        dsStylLinii = DashStyle.DashDot;
                        break;
                    case 5:
                        dsStylLinii = DashStyle.DashDotDot;
                        break;
                    default:
                        dsStylLinii = DashStyle.Solid;
                        break;
                }
                dsGruboscLinii = Gener.Next(1, 6);
                dsRodzajBryly = dscmbWybierz.Text;
                dsPromienBryly = dstbPromien.Value;
                dsWysokoscBryly = dstbWysokosc.Value;
                dsStopienWielokataBryly = int.Parse(dscmbPodstawaBryly.Text);
                dsKatPochyleniaBryly = (float)dstbkat.Value;
                dsWspolrzednaXPodlogiBryly = Gener.Next(dsPromienBryly, dsXmax);
                dsWspolrzednaYPodlogiBryly = Gener.Next(dsPromienBryly, dsYmax);
                switch (dsRodzajBryly)
                {
                    case "Stożek":
                        dsStozek stozek = new dsStozek(dsPromienBryly, dsWysokoscBryly, dsStopienWielokataBryly,
                           dsWspolrzednaXPodlogiBryly, dsWspolrzednaYPodlogiBryly, dsKatPochyleniaBryly, dsKolorLinii, dsStylLinii, dsGruboscLinii);
                        dsLBG.Add(stozek);
                        break;
                    case "Walec":
                        dsWalec walec = new dsWalec(dsPromienBryly, dsWysokoscBryly, dsStopienWielokataBryly,
                           dsWspolrzednaXPodlogiBryly, dsWspolrzednaYPodlogiBryly - dsWysokoscBryly, dsWspolrzednaXPodlogiBryly, dsWspolrzednaYPodlogiBryly, dsKatPochyleniaBryly, dsKolorLinii, dsStylLinii, dsGruboscLinii);
                        dsLBG.Add(walec);
                        break;
                    case "Ostroślup trójkątny":
                        dsOstroslupTroj ostroslup = new dsOstroslupTroj(dsPromienBryly, dsWysokoscBryly,
                           dsWspolrzednaXPodlogiBryly, dsWspolrzednaYPodlogiBryly, dsKatPochyleniaBryly, dsKolorLinii, dsStylLinii, dsGruboscLinii);
                        dsLBG.Add(ostroslup);
                        break;
                case "Graniastoślup":
                    dsGraniastoslup graniastoslup = new dsGraniastoslup(dsPromienBryly, dsWysokoscBryly, dsStopienWielokataBryly,
                        dsWspolrzednaXPodlogiBryly, dsWspolrzednaYPodlogiBryly - dsWysokoscBryly, dsWspolrzednaXPodlogiBryly, dsWspolrzednaYPodlogiBryly, dsKatPochyleniaBryly, dsKolorLinii, dsStylLinii, dsGruboscLinii);
                    dsLBG.Add(graniastoslup);
                    break;                  
                case "Ostroślup czworokątny":
                    dsOstroslupCzworo ostroslupcz = new dsOstroslupCzworo(dsPromienBryly, dsWysokoscBryly,
                           dsWspolrzednaXPodlogiBryly, dsWspolrzednaYPodlogiBryly, dsKatPochyleniaBryly, dsKolorLinii, dsStylLinii, dsGruboscLinii);
                    dsLBG.Add(ostroslupcz);
                    break;
                default:
                        MessageBox.Show("ERROR: pracuję nad zrealizowanie bryły geometrycznej");
                        break;
                }
                dspbRysownica.Refresh();
                dsbtnReset.Enabled = true;
                dsbtnKierunekObrotuLewo.Enabled = false;
                dsbtnKierunekObrotuPrawo.Enabled = true;
                dsbtnUsunOstatnia.Enabled = true;
                dsbtnUsunPierwsa.Enabled = true;
                dsbtnUsunWybrana.Enabled = true;
                dsbtnslajderOn.Enabled = true;
                dsbtnWylosujNowepolozenie.Enabled = true;
                dsbtnAtrybutyLosowo.Enabled = true;
                dsgbPokaz.Enabled = true;
                dsgbpokazslajder.Enabled = true;
            }

            private void dsbtnAtrybutyLosowo_Click(object sender, EventArgs e)
            {
                int dsGruboscLinii;
                Color dsKolorLinii;
                DashStyle dsStylLinii;
                dsRysownica.Clear(dspbRysownica.BackColor);
                Gener = new Random();

                for (int i = 0; i < dsLBG.Count; i++)
                {
                    dsKolorLinii = Color.FromArgb(Gener.Next(0, 255), Gener.Next(0, 255), Gener.Next(0, 255));
                    switch (Gener.Next(1, 6))
                    {
                        case 1:
                            dsStylLinii = DashStyle.Dash;
                            break;
                        case 2:
                            dsStylLinii = DashStyle.Dot;
                            break;
                        case 3:
                            dsStylLinii = DashStyle.Solid;
                            break;
                        case 4:
                            dsStylLinii = DashStyle.DashDot;
                            break;
                        case 5:
                            dsStylLinii = DashStyle.DashDotDot;
                            break;
                        default:
                            dsStylLinii = DashStyle.Solid;
                            break;
                    }
                    dsGruboscLinii = Gener.Next(1, 6);
                    dsLBG[i].dsUstalAtrybutyGraficzne(dsKolorLinii, dsStylLinii, dsGruboscLinii);
                }
                for (int i = 0; i < dsLBG.Count; i++)
                {
                    dsLBG[i].dsWykresl(dsRysownica);
                }
                dspbRysownica.Refresh();
            }

            private void dsbtnWylosujNowepolozenie_Click(object sender, EventArgs e)
            {
                int dsXmax = dspbRysownica.Width;
                int dsYmax = dspbRysownica.Height;
                Gener = new Random();
                dsRysownica.Clear(dspbRysownica.BackColor);

                for (int i = 0; i < dsLBG.Count; i++)
                {
                    int dsWspolrzednaXPodlogiBryly = Gener.Next(0, dsXmax);
                    int dsWspolrzednaYPodlogiBryly = Gener.Next(0, dsYmax);

                    dsLBG[i].dsPrzesunDoNowegoXY(dspbRysownica, dsRysownica, dsWspolrzednaXPodlogiBryly, dsWspolrzednaYPodlogiBryly);
                }
                dspbRysownica.Refresh();
            }

            private void dsbtnUsunPierwsa_Click(object sender, EventArgs e)
            {
                try
                {
                    dsLBG[0].dsWymaz(dspbRysownica, dsRysownica);
                    dsLBG.RemoveAt(0);
                }
                catch (Exception)
                {

                    errorProvider1.SetError(dsbtnUsunPierwsa, "ERROR: Nie zostało więcej elementów w liscie");
                }

                dspbRysownica.Refresh();
            }

            private void dsbtnUsunOstatnia_Click(object sender, EventArgs e)
            {
                try
                {
                    dsLBG[dsLBG.Count - 1].dsWymaz(dspbRysownica, dsRysownica);
                    dsLBG.RemoveAt(dsLBG.Count - 1);
                }
                catch (Exception)
                {
                    errorProvider1.SetError(dsbtnUsunOstatnia, "ERROR: Nie zostało więcej elementów w liscie");
                }

                dspbRysownica.Refresh();
            }

            private void dsbtnUsunWybrana_Click(object sender, EventArgs e)
            {
                int dsUsuwana;
                if (!int.TryParse(dsdNumerUsuwanej.Text, out dsUsuwana) || dsUsuwana >= dsLBG.Count ||
                    string.IsNullOrEmpty(dsdNumerUsuwanej.Text))
                {
                    if (dsUsuwana >= dsLBG.Count)
                    {
                        errorProvider1.SetError(dsdNumerUsuwanej, "ERROR: nie ma elementu z takim indeksem");
                        return;
                    }
                    else if (!int.TryParse(dsdNumerUsuwanej.Text, out dsUsuwana) ||
                    string.IsNullOrEmpty(dsdNumerUsuwanej.Text))
                    {
                        errorProvider1.SetError(dsdNumerUsuwanej, "ERROR: nieprawidwoło wpisana wartość");
                        return;
                    }

                }
                else errorProvider1.Dispose();
                try
                {
                    dsLBG[dsUsuwana].dsWymaz(dspbRysownica, dsRysownica);
                    dsLBG.RemoveAt(dsUsuwana);
                }
                catch (Exception)
                {
                    errorProvider1.SetError(dsbtnUsunWybrana, "ERROR: Nie zostało więcej elementów w liscie");
                }

                dspbRysownica.Refresh();
            }

            private void dsbtnKierunekObrotuLewo_Click(object sender, EventArgs e)
            {
                dskierunekobrotu = false;
                dsbtnKierunekObrotuPrawo.Enabled = true;
                dsbtnKierunekObrotuLewo.Enabled = false;
            }

            private void dsbtnKierunekObrotuPrawo_Click(object sender, EventArgs e)
            {
                dskierunekobrotu = true;
                dsbtnKierunekObrotuPrawo.Enabled = false;
                dsbtnKierunekObrotuLewo.Enabled = true;
            }

            private void dsbtnslajderOn_Click(object sender, EventArgs e)
            {
                try
                {
                    if (dsLBG.Count > 0)
                        dsLBG.Sort(dssortowanie);
                    else
                        throw new Exception();
                }
                catch (Exception)
                {
                    errorProvider1.SetError(dsbtnslajderOn, "ERROR: Nie ma żadnych figur dla włączenia slajdera!");
                    return;
                }
                errorProvider1.Dispose();
                dsRysownica.Clear(dspbRysownica.BackColor);
                dsTimerObrotow.Enabled = false;
                if (dsrbAutomatyczny.Checked)
                {
                    timer1.Enabled = true;
                    timer1.Tag = 0;
                    dstbnumerSlajder.Text = "0";
                    timer1.Interval = 1000;
                    timer1.Enabled = true;
                }
                else
                {
                    if (string.IsNullOrEmpty(dstbnumerSlajder.Text.Trim()))
                        dstbnumerSlajder.Text = "0";
                    else
                    {
                        if (!int.TryParse(dstbnumerSlajder.Text, out dsindexfigur))
                        {
                            errorProvider1.SetError(dstbnumerSlajder, "ERROR: błędny zapis!");
                            return;
                        }
                        if ((dsindexfigur < 0) || (dsindexfigur >= (dsLBG.Count)))
                        {
                            errorProvider1.SetError(dstbnumerSlajder, "ERROR: numer figury wykracza poza tablicę");
                            return;
                        }
                        errorProvider1.Dispose();
                    }
                    /////////////////
                    dstbnumerSlajder.ReadOnly = true;
                    int dsXmax = dspbRysownica.Width;
                    int dsYmax = dspbRysownica.Height;
                    dsLBG[dsindexfigur].dsPrzesunDoNowegoXY(dspbRysownica, dsRysownica, dsXmax / 2, dsYmax / 2);
                    ///
                    dsbtnnastepny.Enabled = true;
                    dsbtnpoprzedni.Enabled = true;
                }
                dspbRysownica.Refresh();
                dsbtnslajderOn.Enabled = false;
                dsgbPokaz.Enabled = false;
                dsgbpokazslajder.Enabled = false;
                dsbtnSlajderOff.Enabled = true;
            //dstbnumerSlajder.Enabled = false;
            //dsbtngbPokazfigur.Enabled = true;
            if(dsrbManualny.Checked)
            dsDodajKOntrolki();
            }

            private void timer1_Tick(object sender, EventArgs e)
            {
                dsRysownica.Clear(dspbRysownica.BackColor);
                int dsXmax = dspbRysownica.Width;
                int dsYmax = dspbRysownica.Height;
                dstbnumerSlajder.Text = timer1.Tag.ToString();
                dsLBG[(int)timer1.Tag].dsPrzesunDoNowegoXY(dspbRysownica, dsRysownica, dsXmax / 2, dsYmax / 2);
                dspbRysownica.Refresh();
                timer1.Tag = (int.Parse(timer1.Tag.ToString()) + 1) % dsLBG.Count;
            }

            private void dsbtnnastepny_Click(object sender, EventArgs e)
            {
                dsRysownica.Clear(dspbRysownica.BackColor);
                int dsindexfigury = int.Parse(dstbnumerSlajder.Text);
                dsLBG[dsindexfigur].dsWymaz(dspbRysownica, dsRysownica);
                if (dsindexfigur < (dsLBG.Count - 1))
                    dsindexfigur++;
                else
                    dsindexfigur = 0;
                int dsXmax = dspbRysownica.Width;
                int dsYmax = dspbRysownica.Height;
                dsLBG[dsindexfigur].dsPrzesunDoNowegoXY(dspbRysownica, dsRysownica, dsXmax / 2, dsYmax / 2);
                ///
                dstbnumerSlajder.Text = dsindexfigur.ToString();
                dspbRysownica.Refresh();
            }

            private void dsbtnpoprzedni_Click(object sender, EventArgs e)
            {
                dsRysownica.Clear(dspbRysownica.BackColor);
                int dsindexfigury = int.Parse(dstbnumerSlajder.Text);
                dsLBG[dsindexfigur].dsWymaz(dspbRysownica, dsRysownica);
                if (dsindexfigur > 0)
                    dsindexfigur--;
                else
                    dsindexfigur = dsLBG.Count - 1;
                int dsXmax = dspbRysownica.Width;
                int dsYmax = dspbRysownica.Height;
                dsLBG[dsindexfigur].dsPrzesunDoNowegoXY(dspbRysownica, dsRysownica, dsXmax / 2, dsYmax / 2);
                ///
                dstbnumerSlajder.Text = dsindexfigur.ToString();
                dspbRysownica.Refresh();
            }
            private void dsbtnSlajderOff_Click(object sender, EventArgs e)
            {
                dsRysownica.Clear(dspbRysownica.BackColor);
                timer1.Enabled = false;
                int dsXmax = dspbRysownica.Width;
                int dsYmax = dspbRysownica.Height;
                int dsxp, dsyp;
                Random dslos = new Random();
                for (int i = 0; i < dsLBG.Count; i++)
                {
                    dsxp = dslos.Next(dsMarginess, dsXmax - dsMarginess);
                    dsyp = dslos.Next(dsMarginess, dsYmax - dsMarginess);
                    dsLBG[i].dsPrzesunDoNowegoXY(dspbRysownica, dsRysownica, dsxp, dsyp);
                }
                dspbRysownica.Refresh();
                dsbtnslajderOn.Enabled = true;
                dsbtnSlajderOff.Enabled = false;
                dsbtnnastepny.Enabled = false;
                dsbtnpoprzedni.Enabled = false;
                dstbnumerSlajder.ReadOnly = false;
                dstbnumerSlajder.Text = "";
                dsgbPokaz.Enabled = true;
                dsgbpokazslajder.Enabled = true;
                //dsbtngbPokazfigur.Enabled = true;
                dsTimerObrotow.Enabled = true;
            dsPanelKontrolek.Visible = false;
            }
            private void dsbtnReset_Click(object sender, EventArgs e)
            {
            dsRysownica.Clear(dspbRysownica.BackColor);

            for (int i = dsLBG.Count - 1; i >= 0; i--)
                {
                    dsLBG[i].dsWymaz(dspbRysownica, dsRysownica);
                    dsLBG.RemoveAt(i);

                }


                dstbnumerSlajder.Text = "";
                timer1.Enabled = false;
                dsdNumerUsuwanej.Text = "";
                dsbtnReset.Enabled = false;
                dstbkat.Value = 90;
                dstbPromien.Value = 50;
                dstbWysokosc.Value = 50;
                dscmbWybierz.Text = "Wybierz bryłe geometryczną";
                dscmbPodstawaBryly.Text = "0";
                dsbtnKierunekObrotuLewo.Enabled = false;
                dsbtnKierunekObrotuPrawo.Enabled = false;
                dsbtnUsunOstatnia.Enabled = false;
                dsbtnUsunPierwsa.Enabled = false;
                dsbtnUsunWybrana.Enabled = false;
                dsbtnslajderOn.Enabled = false;
                dsbtnWylosujNowepolozenie.Enabled = false;
                dsbtnAtrybutyLosowo.Enabled = false;
                dsgbPokaz.Enabled = false;
                dsgbpokazslajder.Enabled = false;
            dsPanelKontrolek.Visible = false;
                errorProvider1.Dispose();
                dspbRysownica.Refresh();
            }

        void dsDodajKOntrolki()
        {
            dsPanelKontrolek.Visible = true;
            dsPanelKontrolek.Controls.Add(dsNowyLabel("Zmień kolor linii", new Point(10, 10)));
            dsPanelKontrolek.Controls.Add(dsNowyButtonKolor(25,60, new Point(110, 3)));

            dsPanelKontrolek.Controls.Add(dsNowyLabel("Zmień styl linii", new Point(10, 60)));
            dsPanelKontrolek.Controls.Add(dsNowyButton(25, 65, new Point(110, 53)));

            dsPanelKontrolek.Controls.Add(dsNowyLabel("Zmień wysokość linii", new Point(10, 110)));
            dsPanelKontrolek.Controls.Add(dsNowyBut(25, 65, new Point(110, 103)));
        }
       
        private void dsButtonKolor_Click(object sender, EventArgs e)
        {
            ColorDialog dspaleta = new ColorDialog();
            dspaleta.Color = dsLBG[dsindexfigur].dsPobierzKolorLinii();
            if (dspaleta.ShowDialog() == DialogResult.OK)
                dsLBG[dsindexfigur].dsZmienKolorLinii(dspaleta.Color);
            dsLBG[dsindexfigur].dsWymaz(dspbRysownica, dsRysownica);
            dsLBG[dsindexfigur].dsWykresl(dsRysownica);
            dspbRysownica.Refresh();
        }
       private void dsbuttonWys_Click(object sender, EventArgs e)
        {
            dsLBG[dsindexfigur].dsWymaz(dspbRysownica, dsRysownica);
            dsLBG[dsindexfigur].dsZmieWysokosc(50);
            dsLBG[dsindexfigur].dsWykresl(dsRysownica);
            dspbRysownica.Refresh();
        }
        private void dsNowyButton_Click(object sender, EventArgs e)
        {
            dsLBG[dsindexfigur].dsWymaz(dspbRysownica, dsRysownica);

            DashStyle D =DashStyle.Dot;
                dsLBG[dsindexfigur].dsZmienStyl(D);
            dsLBG[dsindexfigur].dsWykresl(dsRysownica);
            dspbRysownica.Refresh();
        }
        
        //private void dscmb_Click(object sender, EventArgs e)
        //{

        //    if (dscmb.SelectedIndex < 0)
        //    {
        //        errorProvider1.SetError(dscmb, "ERROR: musisz wybrać bryłę geometryczna");
        //        return;
        //    }

        //    dsLBG[dsindexfigur].dsZmienGruboscLinii(dscmb.Text);
        //    dsLBG[dsindexfigur].dsWymaz(dspbRysownica, dsRysownica);
        //    dsLBG[dsindexfigur].dsWykresl(dsRysownica);
        //    dspbRysownica.Refresh();
        //}
        

        #region Kontrolki
        Control dsNowyLabel(string t, Point lokal)
        {
            dsLabelEtykietka = new Label();
            dsLabelEtykietka.Text = t;
            dsLabelEtykietka.Location = lokal;

            Font dscz = new Font("Courier New", 10, FontStyle.Italic);
            dsLabelEtykietka.Width = 100;
            return dsLabelEtykietka;
        }
        Control dsNowyButtonKolor(int w, int s,Point lokal)
        {
            dsButtonKolor = new Button();
            dsButtonKolor.Height = w;
            dsButtonKolor.Width = s;
            dsButtonKolor.Location = lokal;
            dsButtonKolor.Text = "Kolor Linii";
            //dsButtonKolor.TextAlign= 
            dsButtonKolor.BackColor = Color.Aqua;
            dsButtonKolor.Click += new System.EventHandler(dsButtonKolor_Click);
            return dsButtonKolor;
        }
        Control dsNowyBut(int w, int s, Point lokal)
        {
            dsbuttonWys = new Button();
            dsbuttonWys.Height = w;
            dsbuttonWys.Width = s;
            dsbuttonWys.Location = lokal;
            dsbuttonWys.Text = "50";
            //dsButtonKolor.TextAlign= 
            dsbuttonWys.BackColor = Color.Aqua;
            dsbuttonWys.Click += new System.EventHandler(dsbuttonWys_Click);
            return dsbuttonWys;
        }
        
        Control dsNowyButton(int w, int s, Point lokal)
        {
            dsButtonDotStyl = new Button();
            dsButtonDotStyl.Height = w;
            dsButtonDotStyl.Width = s;
            dsButtonDotStyl.Location = lokal;
            dsButtonDotStyl.Text = "Dot";
            //dsButtonKolor.TextAlign= 
            dsButtonDotStyl.BackColor = Color.Aqua;
            dsButtonDotStyl.Click += new System.EventHandler(dsNowyButton_Click);
            return dsButtonDotStyl;
        }
        //Control dsNowyCMB(int w, int s, Point lokal)
        //{
        //    dscmb = new ComboBox();
        //    dscmb.Items.AddRange(new object[] {
        //    "2",
        //    "3",
        //    "4",
        //    "5",
        //    "6"});
        //    dscmb.Height = w;
        //    dscmb.Width = s;
        //    dscmb.Location = lokal;
        //    dscmb.Text = "Grubość";
        //    //dsButtonKolor.TextAlign= 
        //    dscmb.BackColor = Color.Aqua;
        //    dscmb.Click += new System.EventHandler(dscmb_Click);
        //    return dscmb;          
        //}


        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Pytanie = MessageBox.Show("Czy rzeczywiście chcesz zamknąć ten project ?",
           this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            switch (Pytanie)
            {
                case DialogResult.Yes:

                    break;
                case DialogResult.No:

                    e.Cancel = true;
                    break;
                case DialogResult.Cancel:

                    e.Cancel = true;
                    break;
            }
        }
    }

}





