using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Models.ViewModels
{
    partial class ContactDetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        private Contact contact;
    }
}
