using ContactList.Models;
using ContactList.Models.ViewModels;

namespace ContactList.Views;

public partial class ContactList : ContentPage
{
	public ContactList()
	{
		InitializeComponent();
	}

    private void Lv_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		var contact = e.Item as Contact;
		var contactViewModel = new ContactDetailsViewModel { Contact = contact };
		var contactDetails = new ContactDetails();
		contactDetails.BindingContext = contactViewModel;
		Navigation.PushAsync(contactDetails);
    }
}