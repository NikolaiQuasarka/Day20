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
    public partial class WorkPlaceForm : Form
    {
        string WorkPlacePath = ConfigurationManager.AppSettings["WorkPlaces"];
        public WorkPlaceForm()
        {
            InitializeComponent();

            if (File.Exists(WorkPlacePath))
                using (FileStream fs = new FileStream(WorkPlacePath, FileMode.Open))
                {
                    WorkPlaces = JsonSerializer.Deserialize<List<WorkPlace>>(fs);
                    if (WorkPlaces == null)
                        WorkPlaces = new List<WorkPlace>();
                }

            else
            {
                WorkPlaces = new List<WorkPlace>();
            }


            bindingSource1.DataSource = WorkPlaces;
            dataGridView1.DataSource = bindingSource1;
        }
        List<WorkPlace> WorkPlaces;
        private void buttonAddWorKPlace_Click(object sender, EventArgs e)
        {
            if (textBoxCompany.Text != "" & textBoxPost.Text != "" & sbyte.TryParse(textBoxRequiredExperience.Text, out sbyte exp))
            {
                WorkPlace workPlace = new WorkPlace(
                    textBoxCompany.Text, textBoxPost.Text,
                    exp
                    );
                bindingSource1.Add(workPlace);
            }
        }

        private void WorkPlaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (FileStream fs = new FileStream(WorkPlacePath, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(fs, WorkPlaces, new JsonSerializerOptions() { WriteIndented = true, Encoder = JavaScriptEncoder.Create(UnicodeRanges.All, UnicodeRanges.Cyrillic) });
            }
        }
    }
}
