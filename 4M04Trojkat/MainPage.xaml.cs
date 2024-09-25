namespace _4M04Trojkat
{
    public partial class MainPage : ContentPage
    {
        int typFigury = 0;
            // 0 - trójkąt
            // 1 - prostokąt
            // 2 - kwadrtat
            // 3 - koło

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnWybTrojkat(object sender, EventArgs e)
        {
            lblNazwa.Text = "Trójkąt";
            entBokA.IsVisible = true;
            entBokB.IsVisible = true;
            entBokC.IsVisible = true;
            entBokA.Placeholder = "bok A";
            entBokB.Placeholder = "bok B";
            entBokC.Placeholder = "bok C";
            typFigury = 0;
        }
        private void btnWybProstokat(object sender, EventArgs e)
        {
            lblNazwa.Text = "Prostokąt";
            entBokA.IsVisible = true;
            entBokB.IsVisible = true;
            entBokC.IsVisible = false;
            entBokA.Placeholder = "bok A";
            entBokB.Placeholder = "bok B";
            typFigury = 1;

        }
        private void btnCalcClicked(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0;
            bool czyLiczba = true;


            czyLiczba = czyLiczba && double.TryParse(entBokA.Text, out a);
            czyLiczba = czyLiczba && double.TryParse(entBokB.Text, out b);
            czyLiczba = czyLiczba && double.TryParse(entBokC.Text, out c);

            if (!czyLiczba)
            {
                lblPole.Text = "długości boków musza być wartościami liczbowymi";
                return;
            }
            if (a <= 0 || b <= 0 || c <= 0)
            {
                lblPole.Text = "długości boków musza być dodatnie";
                return;
            }
            if (!(a + b > c && a + c > b && b + c > a))
            {
                lblPole.Text = "boki nei spełniają warunku istnienia trójkąta";
                return;
            }
            double obwod = a + b + c;
            double p = obwod / 2;
            double pole = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            lblPole.Text = $"pole: {pole}, obwód: {obwod}";

            if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                lblProst.Text = "czy prostokątny: TAK";
            else
                lblProst.Text = "czy prostokątny: NIE";

            if (a == b || b == c || c == a)
                lblRownoram.Text = "czy równoramienny: TAK";
            else
                lblRownoram.Text = "czy równoramienny: NIE";

            if (a == b && b == c)
                lblRownBok.Text = "czy równoboczny: TAK";
            else
                lblRownBok.Text = "czy równoboczny: NIE";
        }
    }

}
