using Extended_list_view.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Extended_list_view
{
	
	public partial class MoreInfo : ContentPage
	{
        public MoreInfo()
        {
            InitializeComponent();
        }
        public MoreInfo(ANIME anime)
        {
            InitializeComponent();
            BindingContext = anime;
        }
        void Handle_B_Clicked(object sender, System.EventArgs e)
        {
            var LUrl = (Button)sender;
            var url = (string)LUrl.CommandParameter;
            Device.OpenUri(new Uri(url));
        }
    }
}