using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveJson
{
    public partial class Form1 : Form
    {
        public string JsonFilePath => $"{System.AppDomain.CurrentDomain.BaseDirectory}\\save.json";

        public Form1()
        {
            InitializeComponent();

            // Read Json if File Exists and Fill Textbox
            if (File.Exists(JsonFilePath))
            {
                var json = File.ReadAllText(JsonFilePath);
                var Person = JsonConvert.DeserializeObject<Person>(json);

                birthdayTextBox.Text = Person.Birthday.ToString();
                genderTextBox.Text = Person.Gender.ToString();
                idTextBox.Text = Person.Id.ToString();
                nameTextBox.Text = Person.Name.ToString();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DateTime Birthday = DateTime.Parse(birthdayTextBox.Text);
            var Gender = (Gender) Enum.Parse(typeof(Gender), genderTextBox.Text, true);
            var Id = int.Parse(idTextBox.Text);
            var Name = nameTextBox.Text;

            var Person = new Person(Id, Name, Birthday, Gender);

            var json = JsonConvert.SerializeObject(Person);
            File.WriteAllText(JsonFilePath, json);
        }
    }
}
