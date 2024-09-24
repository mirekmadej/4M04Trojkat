namespace _4M04Trojkat
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
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
