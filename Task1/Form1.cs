using System.Configuration;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Task1
{
    public partial class Form1 : Form
    {

        string UniversityPath = ConfigurationManager.AppSettings["Universitys"];
        string AddressesPath = ConfigurationManager.AppSettings["Addresses"];
        string WorkPlacePath = ConfigurationManager.AppSettings["WorkPlaces"];



        public Form1()
        {
            InitializeComponent();

            if (File.Exists(AddressesPath))
                using (FileStream fs = new FileStream(AddressesPath, FileMode.Open))
                {
                    AddressList = JsonSerializer.Deserialize<List<Address>>(fs);
                    if (AddressList == null)
                        AddressList = new List<Address>();
                }

            else
            {
                AddressList = new List<Address> { };
            }




            if (File.Exists(UniversityPath))

                using (FileStream fs = new FileStream(UniversityPath, FileMode.Open))
                {
                    University = JsonSerializer.Deserialize<University>(fs);
                    if (University == null)
                        University = new University();
                }
            else
            {
                University = new University();
            }

            if (File.Exists(WorkPlacePath))

                using (FileStream fs = new FileStream(WorkPlacePath, FileMode.Open))
                {
                    WorkPlaceList = JsonSerializer.Deserialize<List<WorkPlace>>(fs);
                    if (WorkPlaceList == null)
                        WorkPlaceList = new List<WorkPlace>();
                }
            else
            {
                WorkPlaceList = new List<WorkPlace>();
            }




            bindingSource1.DataSource = University.Students;
            dataGridView1.DataSource = bindingSource1;

            ComboBoxAddressItemsUpdate(AddressList);
            ComboBoxWorkPlaceItemsUpdate(WorkPlaceList);


        }
        University University;
        List<Address> AddressList;
        List<WorkPlace> WorkPlaceList;
        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            if (textBoxFullName.Text != "" & double.TryParse(textBoxAverageMark.Text, out double averageMark) & sbyte.TryParse(textBoxCourse.Text, out sbyte course) &
                textBoxGroup.Text != "" & textBoxSpeculity.Text != "" & comboBoxAddress.Text != "" & (radioButtonFemale.Checked | radioButtonMale.Checked)&comboBoxWorkPlace.Text!="")
            {
                Student student = new Student(
                    textBoxFullName.Text, dateTimePickerBirhtDay.Value,
                    textBoxSpeculity.Text, course,
                    textBoxGroup.Text, averageMark,
                    radioButtonMale.Checked ? ("Мужской") : ("Женский"),
                    AddressList[comboBoxAddress.SelectedIndex],
                    WorkPlaceList[comboBoxWorkPlace.SelectedIndex]
                    );
                bindingSource1.Add(student);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (FileStream fs = new FileStream(UniversityPath, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(fs, University, new JsonSerializerOptions() { WriteIndented = true, Encoder = JavaScriptEncoder.Create(UnicodeRanges.All, UnicodeRanges.Cyrillic) });
            }
        }

        private void Addresses_Click(object sender, EventArgs e)
        {
            AddressesForm addressesForm = new AddressesForm();
            addressesForm.FormClosed += delegate (object? sender, FormClosedEventArgs e)
            {
                using (FileStream fs = new FileStream(AddressesPath, FileMode.Open))
                {
                    AddressList = JsonSerializer.Deserialize<List<Address>>(fs);
                }
                ComboBoxAddressItemsUpdate(AddressList);
            };
            addressesForm.ShowDialog();
        }

        private void ComboBoxAddressItemsUpdate(List<Address> addresses)
        {
            comboBoxAddress.Items.Clear();
            foreach (Address address in addresses)
            {
                comboBoxAddress.Items.Add(address.ToString());
            }
        }
        private void ComboBoxWorkPlaceItemsUpdate(List<WorkPlace> workPlaces)
        {
            comboBoxWorkPlace.Items.Clear();
            foreach (WorkPlace workPlace in workPlaces)
            {
                comboBoxWorkPlace.Items.Add(workPlace.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkPlaceForm workPlaceForm = new WorkPlaceForm();
            workPlaceForm.FormClosed += delegate (object? sender, FormClosedEventArgs e)
            {
                using (FileStream fs = new FileStream(WorkPlacePath, FileMode.Open))
                {
                    WorkPlaceList = JsonSerializer.Deserialize<List<WorkPlace>>(fs);
                }
               ComboBoxWorkPlaceItemsUpdate(WorkPlaceList);
            };
            workPlaceForm.ShowDialog();
        }
    }
}
