using System;

using Xamarin.Forms;

namespace iGarson
{
	public class mainPage : ContentPage
	{
		Button loginButton = new Button
		{
			Text = "login",
			TextColor = Color.White,
			BackgroundColor = Color.FromHex("77D065")
		};
		Button registerButton = new Button
		{
			Text = "REGISTER",
			TextColor = Color.White,
			BackgroundColor = Color.FromHex("77D065")
		};
		public mainPage ()
		{
			loginButton.Clicked += OnButtonClicked;

			registerButton.Clicked += OnButtonClicked;
			Title = "Login";
			BackgroundColor = Color.FromHex ("2C8675");
			Content = new StackLayout {
				Spacing = 20,
				Padding = 50,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Entry { Placeholder = "User Name" },
					new Entry { Placeholder = "Password", IsPassword = true },
					loginButton,
					registerButton
				}

			};
		}
		void OnButtonClicked(object sender, EventArgs args) { 
			Button button = (Button)sender; 
			if (button == loginButton) {
				Navigation.PushAsync(new searchRestaurantPage());
			} else if (button == registerButton) {
				Navigation.PushAsync(new registerPage());

			}

		}
	}
}


