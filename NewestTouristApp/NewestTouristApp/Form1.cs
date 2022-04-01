using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NewestTouristApp
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void table1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.touristAttractionsDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'touristAttractionsDataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.touristAttractionsDataSet.Table1);
            filterSelections();
        }

        public Boolean[] buttonSelections = new Boolean[8];

        public void filterSelections()
        {
            if (buttonSelections[0] && buttonSelections[1] && buttonSelections[2] && buttonSelections[3])
            {
                try
                {
                    // Query database  
                    var contactDetails =
                       from c in touristAttractionsDataSet.Table1
                       where c.Urban == "Yes" && c.Rural == "Yes" && c._Man_made == "Yes" && c.Natural == "Yes" orderby c.ID
                       select c;
                    table1DataGridView.DataSource = contactDetails.AsDataView();
                    table1BindingSource.DataSource = contactDetails.AsDataView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (buttonSelections[1] && buttonSelections[2] && buttonSelections[3] && buttonSelections[4])
            {
                try
                {
                    // Query database  
                    var contactDetails =
                       from c in touristAttractionsDataSet.Table1
                       where c.Rural == "Yes" && c._Man_made == "Yes" && c.Natural == "Yes" && c.Exercise == "Yes" orderby c.ID
                       select c;
                    table1DataGridView.DataSource = contactDetails.AsDataView();
                    table1BindingSource.DataSource = contactDetails.AsDataView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (buttonSelections[3] && buttonSelections[4] && buttonSelections[5] && buttonSelections[6])
            {
                try
                {
                    // Query database  
                    var contactDetails =
                       from c in touristAttractionsDataSet.Table1
                       where c.Natural == "Yes" && c.Exercise == "Yes" && c.Amusement == "Yes" && c.Fast_food == "Yes" orderby c.ID
                       select c;
                    table1DataGridView.DataSource = contactDetails.AsDataView();
                    table1BindingSource.DataSource = contactDetails.AsDataView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (buttonSelections[4] && buttonSelections[5] && buttonSelections[6] && buttonSelections[7])
            {
                try
                {
                    // Query database  
                    var contactDetails =
                       from c in touristAttractionsDataSet.Table1
                       where c.Exercise == "Yes" && c.Amusement == "Yes" && c.Fast_food == "Yes" && c.Sit_down == "Yes" orderby c.ID
                       select c;
                    table1DataGridView.DataSource = contactDetails.AsDataView();
                    table1BindingSource.DataSource = contactDetails.AsDataView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (buttonSelections[0] && buttonSelections[2] && buttonSelections[4] && buttonSelections[6])
            {
                try
                {
                    // Query database  
                    var contactDetails =
                       from c in touristAttractionsDataSet.Table1
                       where c.Urban == "Yes" && c._Man_made == "Yes" && c.Exercise == "Yes" && c.Fast_food == "Yes" orderby c.ID
                       select c;
                    table1DataGridView.DataSource = contactDetails.AsDataView();
                    table1BindingSource.DataSource = contactDetails.AsDataView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (buttonSelections[1] && buttonSelections[3] && buttonSelections[5] && buttonSelections[7])
            {
                try
                {
                    // Query database  
                    var contactDetails =
                       from c in touristAttractionsDataSet.Table1
                       where c.Rural == "Yes" && c.Natural == "Yes" && c.Amusement == "Yes" && c.Sit_down == "Yes" orderby c.ID
                       select c;
                    table1DataGridView.DataSource = contactDetails.AsDataView();
                    table1BindingSource.DataSource = contactDetails.AsDataView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        

        public mainForm(Boolean[] filter)
        {
            InitializeComponent();
            this.buttonSelections = filter;
            filterSelections();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            bindingNavigatorMovePreviousItem.PerformClick();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            bindingNavigatorMoveNextItem.PerformClick();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backPageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            interestsForm interests = new interestsForm();
            interests.Show();
        }

        private void imageTextBox_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(imageTextBox.Text))
            {
                attractionPictureBox.Load(imageTextBox.Text);
            }
            else
            {
                attractionPictureBox.Image = null;
            }
        }
    }
}
