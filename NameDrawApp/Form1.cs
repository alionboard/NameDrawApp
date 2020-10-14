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

namespace NameDrawApp
{
    public partial class Form1 : Form
    {
        BindingList<Person> persons = new BindingList<Person>();
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            ReadData();
            dgvPeople.DataSource = persons;
        }
        private void ReadData()
        {
            try
            {
                string json = File.ReadAllText("data.json");
                Person[] readedPersons = JsonConvert.DeserializeObject<Person[]>(json);
                foreach (var item in readedPersons)
                    persons.Add(item);
            }
            catch (Exception)
            {
                LoadExampleData();
            }
        }
        private void SaveData()
        {
            string json = JsonConvert.SerializeObject(persons);
            File.WriteAllText("data.json", json);
        }
        private void LoadExampleData()
        {
            string[] names = { "You can add, delete, update","with the left column!" };

            foreach (var item in names)
                persons.Add(new Person { Name = item });
        }
        private void MixAndList()
        {
            Person[] array = persons.OrderBy(x => x.DrawCount).ToArray();
            int limit = array.Length;

            if (rbBelowAvg.Checked)
            {
                double avg = persons.Average(x => x.DrawCount);
                limit = FindLimitIndex(avg);
            }
            else if (rbExcludeMost.Checked)
            {
                double min = persons.Min(x => x.DrawCount);
                limit = FindLimitIndex(min + 3);
            }
            else
                limit = array.Length - 1;

            int target;
            Person temp;

            for (int i = 0; i < limit; i++)
            {
                target = rnd.Next(i, limit);
                temp = array[i];
                array[i] = array[target];
                array[target] = temp;
            }

            lstResults.DataSource = array;
            lblResult.Text = array.Length == 0 ? "?" : array[0].Name;

            if (array.Length > 0)
            {
                array[0].LastDrawnTime = DateTime.Now;
                array[0].DrawCount++;

                Person[] sorted = persons.OrderBy(x => x.DrawCount).ToArray();
                persons.Clear();
                foreach (Person item in sorted)
                    persons.Add(item);

                persons.ResetBindings();
            }
        }
        int FindLimitIndex(double drawCount)
        {
            var array = persons.OrderBy(x => x.DrawCount).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].DrawCount > drawCount)
                    return i;
            }
            return array.Length;
        }
        private void btnMix_Click(object sender, EventArgs e)
        {
            MixAndList();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            lstResults.DataSource = null;
            lstResults.DisplayMember = "Name";
            lblResult.Text = "?";

            foreach (var item in persons)
            {
                item.DrawCount = 0;
                item.LastDrawnTime = DateTime.MinValue;
            }

            Person[] sortedPersons = persons.OrderBy(x => x.Name).ToArray();
            persons.Clear();
            foreach (var item in sortedPersons)
                persons.Add(item);

            persons.ResetBindings();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }
    }
}
