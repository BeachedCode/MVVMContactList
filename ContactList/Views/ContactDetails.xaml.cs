namespace ContactList.Views;

public partial class ContactDetails : ContentPage
{
	public ContactDetails()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}