using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Employees
{
    public partial class MainPage : ContentPage
    {
        int ID;
        public MainPage()
        {
            InitializeComponent();
            Start();
        }
        private void Start()
        {
            try
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    MyList.ItemsSource = null;
                    MyList.ItemsSource = await App.Database.GetPersonsAsync();
                });
            }
            catch (Exception)
            {
                throw;
            }
        }
        private async void New_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewPerson());
        }
        private async void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Person> person = await App.Database.GetPersonsAsync();
            var listData = person.Where(x => x.Name.Contains(Search.Text)||x.ComputerNO.Contains(Search.Text)).ToList();
            MyList.ItemsSource = listData;
        }
        Person LastSelection;
        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LastSelection = e.CurrentSelection[0] as Person;
        }
        private async void update_Clicked(object sender, EventArgs e)
        {
            if (LastSelection != null)
            {
                ID = LastSelection.ID;
                await Navigation.PushAsync(new EditPerson(ID));
            }
            else
            {
                _ = DisplayAlert("تنبيه","يجب اختيار موظف اولا", "OK");
            }
        }
        private async void Delete_Clicked(object sender, EventArgs e)
        {
            if (LastSelection != null)
            {
                var name = LastSelection.Name;
                var ask= await DisplayAlert("تحذير", "هل انت متاكد من حذف" + name +"","نعم","لا").ConfigureAwait(false);
                if (ask)
                {
                    await App.Database.DeletePersonAsync(LastSelection);
                }
                Start();
            }
            else
            {
                _ = DisplayAlert("تنبيه", "يجب اختيار موظف اولا", "OK");
            }
        }
        private async void Show_Clicked(object sender, EventArgs e)
        {
            if (LastSelection != null)
            {
                ID = LastSelection.ID;
                await Navigation.PushAsync(new ShowPerson(ID));
            }
            else
            {
                _ = DisplayAlert("تنبيه", "يجب اختيار موظف اولا", "OK");
            }
        }
    }
}
