using System.Diagnostics;
using System.Windows;


namespace GameTime
{
    public partial class MainPage : Window
    {

        public MainPage()
        {

            InitializeComponent();
            
        }

        private void Button_Rozdil1_Click(object sender, RoutedEventArgs e)
        {
            Rozdil1Content.Visibility = Visibility.Visible;
            Rozdil2Content.Visibility = Visibility.Collapsed;
            Rozdil3Content.Visibility = Visibility.Collapsed;
            Rozdil4Content.Visibility = Visibility.Collapsed;
            ShowBackgroundImage(false);

        }

        private void Button_Rozdil2_Click(object sender, RoutedEventArgs e)
        {
            Rozdil1Content.Visibility = Visibility.Collapsed;
            Rozdil2Content.Visibility = Visibility.Visible;
            Rozdil3Content.Visibility = Visibility.Collapsed;
            Rozdil4Content.Visibility = Visibility.Collapsed;
            ShowBackgroundImage(false);

        }

        private void Button_Rozdil3_Click(object sender, RoutedEventArgs e)
        {
            Rozdil1Content.Visibility = Visibility.Collapsed;
            Rozdil2Content.Visibility = Visibility.Collapsed;
            Rozdil3Content.Visibility = Visibility.Visible;
            Rozdil4Content.Visibility = Visibility.Collapsed;
            ShowBackgroundImage(false);


        }

        private void Button_Rozdil4_Click(object sender, RoutedEventArgs e)
        {
            Rozdil1Content.Visibility = Visibility.Collapsed;
            Rozdil2Content.Visibility = Visibility.Collapsed;
            Rozdil3Content.Visibility = Visibility.Collapsed;
            Rozdil4Content.Visibility = Visibility.Visible;
            ShowBackgroundImage(false);


        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://dont-nod.com/en/games/remember-me/");
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://store.steampowered.com/app/1174180/Red_Dead_Redemption_2/");
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://www.ubisoft.com/en-gb/game/assassins-creed");
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://store.steampowered.com/app/1817070/Marvels_SpiderMan_Remastered/");
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://store.steampowered.com/app/1286680/Tiny_Tinas_Wonderlands/");
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://store.steampowered.com/agecheck/app/2208920/");
        }
        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://www.playlostark.com/en-us");
        }
        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://store.steampowered.com/app/730/CounterStrike_Global_Offensive/");
        }
        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://store.steampowered.com/app/1203220/NARAKA_BLADEPOINT/");
        }
        private void Button_Click10(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://playvalorant.com/pl-pl/?gad=1&gclid=CjwKCAjwwb6lBhBJEiwAbuVUSgIhQqxyFlVBdRbkbPJ100d4gLYQZwNRrmyd6z6vK2lbhZDR77N4GBoCrqwQAvD_BwE&gclsrc=aw.ds");
        }
        private void Button_Click11(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://worldofwarships.eu/ru/");
        }
        private void Button_Click12(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://worldoftanks.eu/ru/");
        }
        private void Button_Click13(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://store.steampowered.com/app/578080/PUBG_BATTLEGROUNDS/");
        }
        private void Button_Click14(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://www.bungie.net/7/en/Destiny/Lightfall?gclsrc=aw.ds&gclsrc=aw.ds&utm_source=adwords&utm_campaign=19716580219&utm_term=144919333183&utm_content=648997156502&gsc=1&utm_medium=g_5651567&gclid=CjwKCAjwwb6lBhBJEiwAbuVUSk2iyro-jx63WPAxAip70Ig154gmhxcf1LSXgzAsEG3KCZEPx2PXfBoCEV0QAvD_BwE&wbraid=CjgKCAjwnrmlBhAoEigAsD3PyoSH2odtyklPm5P-RBGqsmjTbBoq4vrbaD2s4CuDaR7SGHwHGgIRnQ&gsid=1ee218f73bdd62109f07bebfd9342cac");
        }
        private void Button_Click15(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://store.steampowered.com/app/281990/Stellaris/");
        }
        private void Button_Click16(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://store.steampowered.com/app/294100/RimWorld/");
        }
        private void Button_Click17(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://store.epicgames.com/pl/p/cities-skylines");
        }
        private void Button_Click18(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://store.steampowered.com/app/1956040/Kingdom_Eighties/");
        }
        private void Button_Click19(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://www.bluestacks.com/bluestacks-5.html");
        }
        private void Button_Click20(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://store.steampowered.com/app/394360/Hearts_of_Iron_IV/");
        }
        private void Button_Click21(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://www.baseattackforce.com/");
        }
        private void Button_Click22(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://store.steampowered.com/app/1641960/Forever_Skies/");
        }
        private void Button_Click23(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://store.steampowered.com/app/264710/Subnautica/");
        }
        private void Button_Click24(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://store.steampowered.com/app/739630/Phasmophobia/");
        }
        private void Button_Click25(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://store.steampowered.com/app/1332010/Stray/?l=polish");
        }
        private void Button_Click26(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://store.epicgames.com/pl/p/amnesia-the-bunker-9d5799");
        }
        private void Button_Click27(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://store.steampowered.com/app/1172380/_/");
        }
        private void Button_Click28(object sender, RoutedEventArgs e)
        {
            OpenWebsite("https://store.epicgames.com/en-US/p/genshin-impact");
        }
        private void OpenWebsite(string url)
        {
            {
                Process.Start(new ProcessStartInfo(url));
            }
        }

        private void ShowBackgroundImage(bool show)
        {
            backgroundImage.Visibility = show ? Visibility.Visible : Visibility.Collapsed;
        }

    }
}