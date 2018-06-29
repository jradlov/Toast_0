using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Toast_0
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void btnToast_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IToast>().Show("this is a Toast popup");
        }
    }
}
