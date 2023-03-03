using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Employees
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewPerson : ContentPage
    {
        public NewPerson()
        {
            InitializeComponent();
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
          var success=  await App.Database.SavePersonAsync(new Person
            {
                Name = Name.Text,
                Gender = Gender.Text,
                Marital = Marital.Text,
                Milatiry = Milatiry.Text,
                Address = Address.Text,
                ComputerNO = ComputerNO.Text,
                FileNO = FileNO.Text,
                MotherName = MotherName.Text,
                Phone = Phone.Text,
                InsuranceNO = InsuranceNO.Text,
                PrevReport = PrevReport.Text,
                Punish = Punish.Text,
                Gradation = Gradation.Text,
                Level = Level.Text,
                Cources = Cources.Text,
                Holiday = Holiday.Text,
                Degree = Degree.Text,
                DegreeDate = DegreeDate.Date,
                CarrerGroup = CarrerGroup.Text,
                QualityGroup = QualityGroup.Text,
                JobTitle = JobTitle.Text,
                JobWork = JobWork.Text,
                Qualification = Qualification.Text,
                QualificationSpeciality = QualificationSpeciality.Text,
                HiringDate = HiringDate.Date,
                BirthDate = BirthDate.Date,
                NationalID = NationalID.Text,
                Section = Section.Text,
                WorkAt = WorkAt.Text
            });
            if (success > 0)
            {
                await DisplayAlert("تم", "تم الحفظ بنجاح", "OK");
            }
            else
            {
                await DisplayAlert("خطا", "فشل الحفظ", "OK");
            }
            await Navigation.PushAsync(new MainPage());
        }
    }
}