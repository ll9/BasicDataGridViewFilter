using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveJson
{
    public partial class Form1 : Form
    {
        public string JsonFilePath => $"{AppDomain.CurrentDomain.BaseDirectory}\\save.json";
        BindingList<Person> People { get; set; } = new BindingList<Person>();
        List<Func<Person, bool>> Filters = new List<Func<Person, bool>>();

        public Form1()
        {
            InitializeComponent();

            // Read Json if File Exists and Fill Textbox
            if (File.Exists(JsonFilePath))
            {
                var json = File.ReadAllText(JsonFilePath);
                var people = JsonConvert.DeserializeObject<BindingList<Person>>(json);

                foreach (var person in people)
                {
                    People.Add(person);
                }
            }
            personDataGridView.DataSource = People;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var json = JsonConvert.SerializeObject(People);
            File.WriteAllText(JsonFilePath, json);

        }

        private void FilterBeneButton_Click(object sender, EventArgs e)
        {
            Filters.Add(person => person.Name == "Bene");

            FilterGrid();
        }


        private void GenderFilterButton_Click(object sender, EventArgs e)
        {
            Filters.Add(person => person.Gender == Gender.Male);

            FilterGrid();
        }

        private void Unfilter_Click(object sender, EventArgs e)
        {
            Filters.Clear();
            FilterGrid();
        }

        private void FilterGrid()
        {
            var filteredBindingList = new BindingList<Person>(People);

            foreach (var filter in Filters)
            {
                filteredBindingList = new BindingList<Person>(filteredBindingList.Where(filter).ToList());
            }
            personDataGridView.DataSource = filteredBindingList;
        }
    }
}
