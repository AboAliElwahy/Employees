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
    public partial class ShowPerson : ContentPage
    {
        int id;
        public ShowPerson(int Id)
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
            Punish.Text= xx.Punish;
            Gradation.Text= xx.Gradation;
            Level.Text= xx.Level;
            Cources.Text= xx.Cources;
            Holiday.Text= xx.Holiday;
            Degree.Text= xx.Degree;
            DegreeDate.Text= xx.DegreeDate.ToShortDateString();
            CarrerGroup.Text= xx.CarrerGroup;
            QualityGroup.Text=xx.QualityGroup;
            JobTitle.Text= xx.JobTitle;
            JobWork.Text= xx.JobWork;
            Qualification.Text= xx.Qualification;
            QualificationSpeciality.Text= xx.QualificationSpeciality;
            HiringDate.Text=xx.HiringDate.ToShortDateString();
            BirthDate.Text=xx.BirthDate.ToShortDateString();
            NationalID.Text= xx.NationalID;
            Section.Text= xx.Section;
            WorkAt.Text= xx.WorkAt;
        }
    }
}