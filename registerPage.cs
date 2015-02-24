using System;

using Xamarin.Forms;

namespace iGarson
{
	public class registerPage : ContentPage
	{

		Button confirmButton = new Button
		{
			Text = "CONFIRM",
			TextColor = Color.White,
			BackgroundColor = Color.FromHex("77D065")
		};

		DatePicker dateOfBirth = new DatePicker
		{
			Format = "D"
		};

		Picker genderPicker = new Picker
		{
			Title = "Gender",
		};
		Picker cityPicker = new Picker
		{
			Title = "City",
		};
		Editor addressEditor = new Editor { Text = "Address" };

		public registerPage ()
		{
			Title = "Register";
			BackgroundColor = Color.FromHex ("2C8675");
			addressEditor.Completed += editorCompleted;
			confirmButton.Clicked += OnButtonClicked;
			genderPicker.Items.Add ("Female");
			genderPicker.Items.Add ("Male");
			genderPicker.SelectedIndexChanged += pickerSelected;
			cityPicker.Items.Add ("Ankara");
			cityPicker.SelectedIndexChanged += pickerSelected;

			Content = new ScrollView {
				Content = new StackLayout { 
					Spacing = 20,
					Padding = 50,
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Entry { Placeholder = "User Name" },
						new Entry { Placeholder = "E-mail" },
						new Entry { Placeholder = "Password", IsPassword = true },
						dateOfBirth,
						new Entry { Placeholder = "Full Name" },
						genderPicker,
						addressEditor,
						cityPicker,
						new Entry { Placeholder = "Phone Number"},
						confirmButton
					}
				}
			};
		}

		void pickerSelected(object sender, EventArgs args)
		{
			Picker picker = (Picker)sender;
			// Get the search text.
			if (picker == genderPicker) {

			} else if (picker == cityPicker) {

			}

		}
		void OnButtonClicked(object sender, EventArgs args) { 
			Button button = (Button)sender; 

		}
		void editorCompleted(object sender, EventArgs args) { 
			Button button = (Button)sender; 

		}
	}
}


