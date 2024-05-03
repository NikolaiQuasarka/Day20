using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class AddressesForm : Form
    {
        string AddressesPath = ConfigurationManager.AppSettings["Addresses"];
        public AddressesForm()
        {
            InitializeComponent();

            if (File.Exists(AddressesPath))
                 using (FileStream fs = new FileStream(AddressesPath, FileMode.Open))
                    {
                        Addresses = JsonSerializer.Deserialize<List<Address>>(fs);
                    if (Addresses == null)
                        Addresses= new List<Address>();
                    }
            else
            {
                Addresses = new List<Address>();
            }
                
            

       
            bindingSource1.DataSource = Addresses;
            dataGridView1.DataSource = bindingSource1;
        }
        public List<Address> Addresses;

        private void buttonAddAddress_Click(object sender, EventArgs e)
        {
            if (textBoxTown.Text != "" & textBoxStreet.Text != "" & sbyte.TryParse(textBoxApartment.Text, out sbyte apartment) & uint.TryParse(textBoxHouse.Text, out uint house))
            {
                Address address = new Address(
                    textBoxTown.Text, textBoxStreet.Text,
                    house, apartment
                    );
                bindingSource1.Add(address);
            }
        }

        private void AddressesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            using(FileStream fs = new FileStream(AddressesPath, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(fs, Addresses, new JsonSerializerOptions() { WriteIndented=true, Encoder = JavaScriptEncoder.Create(UnicodeRanges.All, UnicodeRanges.Cyrillic) });
            }
        }
    }
}
