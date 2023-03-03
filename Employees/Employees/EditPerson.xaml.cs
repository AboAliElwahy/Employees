using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Collections.Specialized.BitVector32;
using static Xamarin.Essentials.Permissions;

namespace Employees
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditPerson : ContentPage
    {
        int id;
        public EditPerson(int Id)
        {
            InitializeComponent();
            this.id = Id;
            Get(id);
        }
        private async void Get(int ID)
        {
            List<Person> person = await App.Database.GetPersonsAsync();
            var xx = person.Where(x => x.ID == ID).ToList().FirstOrDefault();
            Name.Text = xx.Name;
            Gender.Text = xx.Gender;
            Marital.Text = xx.Marital;
            Milatiry.Text = xx.Milatiry;
            Address.Text = xx.Address;
            ComputerNO.Text = xx.ComputerNO;
            FileNO.Text = xx.FileNO;
            MotherName.Text = xx.MotherName;
            Phone.Text = xx.Phone;
            InsuranceNO.Text = xx.InsuranceNO;
            PrevReport.Text = xx.PrevReport;
            Punish.Text = xx.Punish;
            Gradation.Text = xx.Gradation;
            Level.Text = xx.Level;
            Cources.Text = xx.Cources;
            Holiday.Text = xx.Holiday;
            Degree.Text = xx.Degree;
            DegreeDate.Date = xx.DegreeDate;
            CarrerGroup.Text = xx.CarrerGroup;
            QualityGroup.Text = xx.QualityGroup;
            JobTitle.Text = xx.JobTitle;
            JobWork.Text = xx.JobWork;
            Qualification.Text = xx.Qualification;
            QualificationSpeciality.Text = xx.QualificationSpeciality;
            HiringDate.Date = xx.HiringDate;
            BirthDate.Date = xx.BirthDate;
            NationalID.Text = xx.NationalID;
            Section.Text = xx.Section;
            WorkAt.Text = xx.WorkAt;
        }

        private async void Update_Clicked(object sender, EventArgs e)
        {
            List<Person> persons = await App.Database.GetPersonsAsync();
            Person personToUpdate = persons.FirstOrDefault(p => p.ID == id);

            personToUpdate.Name = Name.Text;
            personToUpdate.Gender = Gender.Text;
            personToUpdate.Marital = Marital.Text;
            personToUpdate.Milatiry = Milatiry.Text;
            personToUpdate.Address = Address.Text;
            personToUpdate.ComputerNO = ComputerNO.Text;
            personToUpdate.FileNO = FileNO.Text;
            personToUpdate.MotherName = MotherName.Text;
            personToUpdate.Phone = Phone.Text;
            personToUpdate.InsuranceNO = InsuranceNO.Text;
            personToUpdate.PrevReport = PrevReport.Text;
            personToUpdate.Punish = Punish.Text;
            personToUpdate.Gradation = Gradation.Text;
            personToUpdate.Level = Level.Text;
            personToUpdate.Cources = Cources.Text;
            personToUpdate.Holiday = Holiday.Text;
            personToUpdate.Degree = Degree.Text;
            personToUpdate.DegreeDate = DegreeDate.Date;
            personToUpdate.CarrerGroup = CarrerGroup.Text;
            personToUpdate.QualityGroup = QualityGroup.Text;
            personToUpdate.JobTitle = JobTitle.Text;
            personToUpdate.JobWork = JobWork.Text;
            personToUpdate.Qualification = Qualification.Text;
            personToUpdate.QualificationSpeciality = QualificationSpeciality.Text;
            personToUpdate.HiringDate = HiringDate.Date;
            personToUpdate.BirthDate = BirthDate.Date;
            personToUpdate.NationalID = NationalID.Text;
            personToUpdate.Section = Section.Text;
            personToUpdate.WorkAt = WorkAt.Text;

            // Update the record in the database
            var success = await App.Database.UpdatePersonAsync(personToUpdate);

            // Display a message to the user
            if (success > 0)
            {
                await DisplayAlert("تم", "تم التعديل بنجاح", "OK");
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("خطا", "فشل التعديل", "OK");
            }
        }
    }
}