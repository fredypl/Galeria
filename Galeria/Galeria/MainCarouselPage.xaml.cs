using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Galeria
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainCarouselPage : CarouselPage
    {
        int a1, a2;
        int b1, b2;
        int c1, c2;
        int d1, d2;
        int e1, e2;
        int f1, f2;
        int g1, g2;
        int h1, h2;
        int i1, i2;
        int j1, j2;

        public MainCarouselPage()

        {
            InitializeComponent();

        }
       
        private void like_Clicked(object sender, EventArgs e)
        {
            a1 = 1;
            if(a1==1)
            {
                a2 = 1;

              DisplayAlert("!!!", "Me Gusta", "ok");

            }
           
        }

        private void dislike_Clicked(object sender, EventArgs e)
        {
            if (dislike.IsEnabled)
            {
                a2 = 0;

                if (a2 == 0)
                {

                    a1 = 0;
                 DisplayAlert("!!!", "No me Gusta", "ok");
                }
            }
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            b1 = 1;
            if (b1 == 1)
            {
                b2 = 1;
                DisplayAlert("!!!", "Me Gusta", "ok");

            }
            
           

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (dislike.IsEnabled)
            {
                b2 = 0;

                if (b2 == 0)
                {

                    b1 = 0;
                    DisplayAlert("!!!", "No me Gusta", "ok");
                }
            }
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            c1 = 1;
            if (c1 == 1)
            {
                c2 = 1;
                DisplayAlert("!!!", "Me Gusta", "ok");

            }

        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            if (dislike.IsEnabled)
            {
                c2 = 0;

                if (c2 == 0)
                {

                    c1 = 0;
                    DisplayAlert("!!!", "No me Gusta", "ok");
                }
            }
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            d1 = 1;
            if (d1 == 1)
            {
                d2 = 1;
                DisplayAlert("!!!", "Me Gusta", "ok");

            }

        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            if (dislike.IsEnabled)
            {
                d2 = 0;

                if (d2 == 0)
                {

                    d1 = 0;
                    DisplayAlert("!!!", "No me Gusta", "ok");
                }
            }
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            e1 = 1;
            if (e1 == 1)
            {
                e2 = 1;
                DisplayAlert("!!!", "Me Gusta", "ok");

            }

        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            if (dislike.IsEnabled)
            {
                e2 = 0;

                if (e2 == 0)
                {

                    e1 = 0;
                    DisplayAlert("!!!", "No me Gusta", "ok");
                }
            }
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            f1 = 1;
            if (f1 == 1)
            {
                f2 = 1;
                DisplayAlert("!!!", "Me Gusta", "ok");

            }

        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            if (dislike.IsEnabled)
            {
                f2 = 0;

                if (f2 == 0)
                {

                    f1 = 0;
                    DisplayAlert("!!!", "No me Gusta", "ok");
                }
            }
        }

        private void Button_Clicked_10(object sender, EventArgs e)
        {
            g1 = 1;
            if (g1 == 1)
            {
                g2 = 1;
                DisplayAlert("!!!", "Me Gusta", "ok");

            }

        }

        private void Button_Clicked_11(object sender, EventArgs e)
        {
            if (dislike.IsEnabled)
            {
                g2 = 0;

                if (g2 == 0)
                { 
                    g1 = 0;
                    DisplayAlert("!!!", "No me Gusta", "ok");
                }
            }
        }

        private void Button_Clicked_12(object sender, EventArgs e)
        {
            h1 = 1;
            if (h1 == 1)
            {
                h2 = 1;
                DisplayAlert("!!!", "Me Gusta", "ok");

            }

        }

        private void Button_Clicked_13(object sender, EventArgs e)
        {
            if (dislike.IsEnabled)
            {
                h2 = 0;

                if (h2 == 0)
                {

                    h1 = 0;
                    DisplayAlert("!!!", "No me Gusta", "ok");
                }
            }
        }

        private void Button_Clicked_14(object sender, EventArgs e)
        {
            i1 = 1;
            if (i1 == 1)
            {
                i2 = 1;
                DisplayAlert("!!!", "Me Gusta", "ok");

            }

        }

        private void Button_Clicked_15(object sender, EventArgs e)
        {
            if (dislike.IsEnabled)
            {
                i2 = 0;

                if (i2 == 0)
                {

                    i1 = 0;

                    DisplayAlert("!!!", "No me Gusta", "ok");
                }
            }
        }

        private void Button_Clicked_16(object sender, EventArgs e)
        {
            j1 = 1;
            if (j1 == 1)
            {
                j2 = 1;

                DisplayAlert("!!!", "Me Gusta", "ok");

            }

        }

        private void Button_Clicked_17(object sender, EventArgs e)
        {
            if (dislike.IsEnabled)
            {
                j2 = 0;

                if (j2 == 0)
                {

                    j1 = 0;
                    DisplayAlert("!!!", "No me Gusta", "ok");
                }
            }
        }

        private void Button_Clicked_18(object sender, EventArgs e)
        {
            if (a1 == 1)
            {

                DisplayAlert("Gufy", "Me gusta", "ok");
            }
            if (b1 == 1)
            {

                DisplayAlert("Android", "Me gusta", "ok");
            }
            if (c1 == 1)
            {

                DisplayAlert("App Android", "Me gusta", "ok");
            }
            if (d1 == 1)
            {

                DisplayAlert("Apple", "Me gusta", "ok");
            }
            if (e1 == 1)
            {

                DisplayAlert("Small Apple", "Me gusta", "ok");
            }
            if (f1 == 1)
            {

                DisplayAlert("Android vs Apple", "Me gusta", "ok");
            }
            if (g1 == 1)
            {

                DisplayAlert("Membrana Redes", "Me gusta", "ok");
            }
            if (h1 == 1)
            {

                DisplayAlert("Redes Sociales", "Me gusta", "ok");
            }
            if (i1 == 1)
            {

                DisplayAlert("Globo Redes Sociales", "Me gusta", "ok");
            }
            if (j1 == 1)
            {

                DisplayAlert("Windows Phone", "Me gusta", "ok");
            }
            

            

        }

        private void Button_Clicked_19(object sender, EventArgs e)
        {
            if (a2 == 0)
            {

                DisplayAlert("Gufy", "No me Gusta", "ok");
            }
            if (b2 == 0)
            {

                DisplayAlert("Android", "No me Gusta", "ok");
            }
            if (c2 == 0)
            {

                DisplayAlert("App Android", "No me Gusta", "ok");
            }
            if (d2 == 0)
            {

                DisplayAlert("Apple", "No me Gusta", "ok");
            }
            if (e2 == 0)
            {

                DisplayAlert("Smal Apple", "No me Gusta", "ok");
            }
            if (f2 == 0)
            {

                DisplayAlert("Android vs Apple", "No me Gusta", "ok");
            }
            if (g2 == 0)
            {

                DisplayAlert("Membrana Redes", "No me Gusta", "ok");
            }
            if (h2 == 0)
            {

                DisplayAlert("Redes Sociales", "No me Gusta", "ok");
            }
            if (i2 == 0)
            {

                DisplayAlert("Globo Redes sociales", "No me Gusta", "ok");
            }
            if (j2 == 0)
            {

                DisplayAlert("Windows Phone", "No me Gusta", "ok");
            }

        }

         
    }
}