using ContactList.Models.ViewModels;

namespace ContactList.Views;

public partial class HomePage : ContentPage
{
	private ContactListViewModel contactViewModel;
	public HomePage()
	{
		InitializeComponent();
		contactViewModel = new ContactListViewModel();
		BindingContext = contactViewModel;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		var contactList = new ContactList();
		contactList.BindingContext = contactViewModel;
		Navigation.PushAsync(contactList);
    }
}