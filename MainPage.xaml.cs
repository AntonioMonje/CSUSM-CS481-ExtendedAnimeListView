using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Extended_list_view.Model;
using Xamarin.Forms.PlatformConfiguration;

namespace Extended_list_view
{
	public partial class MainPage : ContentPage
	{
        
        public MainPage()
		{
			InitializeComponent();
            Populate();
		}
        private void Populate()
        {
            var AniCollection = new ObservableCollection<ANIME>();


            var Anime0 = new ANIME()
            {
                Details = "Noragami",
                MDetails = "This is is an Anime about Heros who fight villians. A weak kid with no powerr gets the powers of the strongest hero and tries to become a hero",
                IconSource = "MyHero.jpg",
                MoreD = "A pro [hero] always puts his life on the line!",
                URL = "https://en.wikipedia.org/wiki/My_Hero_Academia",
                pos = 0
            };
            var Anime1 = new ANIME()
            {
                Details = "Noragami",
                MDetails = "This is is an Anime about GODS who can do no wrong. Yato is the main character a Good trying to get back into heaven",
                IconSource = "nora.jpg",
                MoreD = "There's no such thing as a free wish",
                URL = "https://en.wikipedia.org/wiki/Noragami",
                pos = 1
            };
            var Anime2 = new ANIME()
            {
                Details= "Naruto",
                MDetails = "This is is an Anime about ninjas fighting to become better ninjas. The main character nruto is aiming to become the hokage the leader of the village",
                IconSource = "naruto.jpg",
                MoreD = "Fear. That is what we live with. And we live it everyday. Only in death are we free of it.",
                URL = "http://naruto.wikia.com/wiki/Narutopedia",
                pos = 2
            };
            var Anime3 = new ANIME()
            {
                Details = "Detective conan",
                MDetails = "This is is an Anime about a boy who solves crimes. He was  highschool student that got turned into a kid",
                IconSource = "Conan.jpg",
                MoreD = "When you have eliminated the impossible, whatever remains, however improbable, must be the truth.",
                URL = "http://www.detectiveconanworld.com/wiki/",
                pos = 3
            };
            var Anime4 = new ANIME()
            {
                Details = "HunterxHunter",
                MDetails = "This is is an Anime about fighting using nen. Gon the main character is on a mission trying to find his dad and the reason his dad left",
                IconSource = "Hunter.jpg",
                MoreD = "If you want to get to know someone, find out what makes them angry.",
                URL = "https://en.wikipedia.org/wiki/Hunter_%C3%97_Hunter",
                pos = 4
            };
            var Anime5 = new ANIME()
            {
                Details = "Fate/Zero",
                MDetails = "This is is an Anime about heros coming back to life to fight for the holy grail. Whoever whens the Holy grail get to make a wish",
                IconSource = "Fate.jpg",
                MoreD = "When you look back after a long life, you'll realize there's nothing that's really worth risking your life for.",
                URL = "https://en.wikipedia.org/wiki/Fate/Zero",
                pos = 5
            };
            var Anime6 = new ANIME()
            {
                Details = "erased",
                MDetails = "This is is an Anime about getting to do things over until he solves the murder case. He goes back in time to when he was a kid to stop the death of his classmate",
                IconSource = "erased.jpg",
                MoreD = "Every day, the words cross my mind. If I had done this back then... but they don't take the sincere form of regret. The words are just an excuse that come to my mind then disappear.",
                URL = "https://en.wikipedia.org/wiki/Erased_(manga)",
                pos = 6
            };
            var Anime7 = new ANIME()
            {
                Details = "Dragon ball Super",
                MDetails = "This is is an Anime about Goku defeating all his enemies. Right now the are fighting to keep the universe alive",
                IconSource = "DBS.jpg",
                MoreD = "In this world, we have gods that create and give life. On the other side of the balance, there exist gods who destroy planets and end lives.",
                URL = "https://en.wikipedia.org/wiki/Dragon_Ball_Super",
                pos = 7
            };
       
            AniCollection.Add(Anime0);
            AniCollection.Add(Anime1);
            AniCollection.Add(Anime2);
            AniCollection.Add(Anime3);
            AniCollection.Add(Anime4);
            AniCollection.Add(Anime5);
            AniCollection.Add(Anime6);
            AniCollection.Add(Anime7);

            VCell.ItemsSource = AniCollection;


           
        }

        void Handle_M_Clicked(object sender, System.EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var anime = (ANIME)menuItem.CommandParameter;
            Navigation.PushAsync(new NavigationPage(new MoreInfo(anime)));            
        }
        void Handle_Delete_Clicked(object sender, System.EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var list = (ObservableCollection<ANIME>)VCell.ItemsSource;
            int pos = (int)menuItem.CommandParameter;
            int spot = FindPos(pos,list);
            list.RemoveAt(spot);
        }         
        protected int FindPos(int pos, ObservableCollection<ANIME> list)
        {
            int i = 0;
            foreach(ANIME item in list)
            {
                if (pos == item.pos)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
       
        void Handle_Refreshing(object sender, System.EventArgs e)
        {
            VCell.IsRefreshing = false;
            Populate();
        }

    }
}
