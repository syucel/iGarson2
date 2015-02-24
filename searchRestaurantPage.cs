using System;

using Xamarin.Forms;

namespace iGarson
{
	public class searchRestaurantPage : ContentPage
	{
		Picker cityPicker = new Picker
		{
			Title = "City",
		};
		public searchRestaurantPage ()
		{
			Title = "Search Restaurant";
			BackgroundColor = Color.FromHex ("2C8675");
			cityPicker.Items.Add ("Ankara");
			cityPicker.SelectedIndexChanged += cityPickerSelected;

			SearchBar searchBar = new SearchBar
			{
				Placeholder = "Search Restaurant",
			};
			searchBar.SearchButtonPressed += OnSearchBarButtonPressed;

			Content = new StackLayout { 
				Spacing = 20,
				Padding = 50,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					searchBar,
					new Label { Text = "OR", HorizontalOptions = LayoutOptions.Center},
					cityPicker
				}
			};


		}

		void OnSearchBarButtonPressed(object sender, EventArgs args)
		{
			// Get the search text.
			SearchBar searchBar = (SearchBar)sender;
			string searchText = searchBar.Text;
			Navigation.PushAsync(new searchRestaurantPage());
		}
		void cityPickerSelected(object sender, EventArgs args)
		{
			Picker picker = (Picker)sender;
			// Get the search text.
			if (picker.SelectedIndex == 1) {
				Navigation.PushAsync(new searchRestaurantPage());
			}

		}
	}
}


