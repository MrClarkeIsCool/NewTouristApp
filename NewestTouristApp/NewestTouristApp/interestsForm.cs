using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewestTouristApp
{
    public partial class interestsForm : Form
    {
        int total_selections = 0;
        int s1 = 0;
        int s2 = 0;
        int s3 = 0;
        int s4 = 0;
        int s5 = 0;
        int s6 = 0;
        int s7 = 0;
        int s8 = 0;

        Boolean[] buttonSelections = new Boolean[8];

        public interestsForm()
        {
            InitializeComponent();
        }

        public void check_selections()
        {
            if (total_selections == 4)
            {
                doneButton.Enabled = true;
                doneButton.BackColor = Color.LimeGreen;
                if (s1 == 0)
                {
                    urbanButton.Enabled = false;
                }
                if (s1 == 1)
                {
                    urbanButton.Enabled = true;
                }

                if (s2 == 0)
                {
                    ruralButton.Enabled = false;
                }
                if (s2 == 1)
                {
                    ruralButton.Enabled = true;
                }

                if (s3 == 0)
                {
                    manMadeButton.Enabled = false;
                }
                if (s3 == 1)
                {
                    manMadeButton.Enabled = true;
                }

                if (s4 == 0)
                {
                    naturalButton.Enabled = false;
                }
                if (s4 == 1)
                {
                    naturalButton.Enabled = true;
                }

                if (s5 == 0)
                {
                    hikingButton.Enabled = false;
                }
                if (s5 == 1)
                {
                    hikingButton.Enabled = true;
                }

                if (s6 == 0)
                {
                    amusementParksButton.Enabled = false;
                }
                if (s6 == 1)
                {
                    amusementParksButton.Enabled = true;
                }

                if (s7 == 0)
                {
                    fastFoodButton.Enabled = false;
                }
                if (s7 == 1)
                {
                    fastFoodButton.Enabled = true;
                }

                if (s8 == 0)
                {
                    sitdownFoodButton.Enabled = false;
                }
                if (s8 == 1)
                {
                    sitdownFoodButton.Enabled = true;
                }
                doneButton.Text = "√";
            }
            if (total_selections <= 3)
            {
                sitdownFoodButton.Enabled = true;
                fastFoodButton.Enabled = true;
                amusementParksButton.Enabled = true;
                hikingButton.Enabled = true;
                naturalButton.Enabled = true;
                manMadeButton.Enabled = true;
                ruralButton.Enabled = true;
                urbanButton.Enabled = true;
                doneButton.Enabled = false;
                doneButton.BackColor = Color.Red;
                doneButton.Text = $"You have selected {total_selections} interest(s). Please select {4 - total_selections} more.";
            }
        }

            private void interestsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'touristAttractionsDataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.touristAttractionsDataSet.Table1);
            buttonStyle();
        }

        private void table1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.touristAttractionsDataSet);

        }

        private void urbanButton_Click(object sender, EventArgs e)
        {
            if (s1 == 0)
            {
                urbanButton.BackColor = Color.LimeGreen;
                total_selections += 1;
                s1 = 1;
                buttonSelections[0] = true;
            }
            else if (s1 == 1)
            {
                urbanButton.BackColor = Color.FromArgb(16, 20, 28);
                total_selections -= 1;
                s1 = 0;
                buttonSelections[0] = false;
            }
            check_selections();
        }

        private void ruralButton_Click(object sender, EventArgs e)
        {
            if (s2 == 0)
            {
                ruralButton.BackColor = Color.LimeGreen;
                total_selections += 1;
                s2 = 1;
                buttonSelections[1] = true;
            }
            else if (s2 == 1)
            {
                ruralButton.BackColor = Color.FromArgb(16, 20, 28);
                total_selections -= 1;
                s2 = 0;
                buttonSelections[1] = false;
            }
            check_selections();
        }

        private void manMadeButton_Click(object sender, EventArgs e)
        {
            if (s3 == 0)
            {
                manMadeButton.BackColor = Color.LimeGreen;
                total_selections += 1;
                s3 = 1;
                buttonSelections[2] = true;
            }
            else if (s3 == 1)
            {
                manMadeButton.BackColor = Color.FromArgb(16, 20, 28);
                total_selections -= 1;
                s3 = 0;
                buttonSelections[2] = false;
            }
            check_selections();
        }

        private void naturalButton_Click(object sender, EventArgs e)
        {
            if (s4 == 0)
            {
                naturalButton.BackColor = Color.LimeGreen;
                total_selections += 1;
                s4 = 1;
                buttonSelections[3] = true;
            }
            else if (s4 == 1)
            {
                naturalButton.BackColor = Color.FromArgb(16, 20, 28);
                total_selections -= 1;
                s4 = 0;
                buttonSelections[3] = false;
            }
            check_selections();
        }

        private void hikingButton_Click(object sender, EventArgs e)
        {
            if (s5 == 0)
            {
                hikingButton.BackColor = Color.LimeGreen;
                total_selections += 1;
                s5 = 1;
                buttonSelections[4] = true;
            }
            else if (s5 == 1)
            {
                hikingButton.BackColor = Color.FromArgb(16, 20, 28);
                total_selections -= 1;
                s5 = 0;
                buttonSelections[4] = false;
            }
            check_selections();
        }

        private void amusementParksButton_Click(object sender, EventArgs e)
        {
            if (s6 == 0)
            {
                amusementParksButton.BackColor = Color.LimeGreen;
                total_selections += 1;
                s6 = 1;
                buttonSelections[5] = true;
            }
            else if (s6 == 1)
            {
                amusementParksButton.BackColor = Color.FromArgb(16, 20, 28);
                total_selections -= 1;
                s6 = 0;
                buttonSelections[5] = false;
            }
            check_selections();
        }

        private void fastFoodButton_Click(object sender, EventArgs e)
        {
            if (s7 == 0)
            {
                fastFoodButton.BackColor = Color.LimeGreen;
                total_selections += 1;
                s7 = 1;
                buttonSelections[6] = true;
            }
            else if (s7 == 1)
            {
                fastFoodButton.BackColor = Color.FromArgb(16, 20, 28);
                total_selections -= 1;
                s7 = 0;
                buttonSelections[6] = false;
            }
            check_selections();
        }

        private void sitdownFoodButton_Click(object sender, EventArgs e)
        {
            if (s8 == 0)
            {
                sitdownFoodButton.BackColor = Color.LimeGreen;
                total_selections += 1;
                s8 = 1;
                buttonSelections[7] = true;
            }
            else if (s8 == 1)
            {
                sitdownFoodButton.BackColor = Color.FromArgb(16, 20, 28);
                total_selections -= 1;
                s8 = 0;
                buttonSelections[7] = false;
            }
            check_selections();
        }

        private void buttonStyle()
        {
            urbanButton.FlatStyle = FlatStyle.Flat;
            urbanButton.FlatAppearance.BorderSize = 0;

            ruralButton.FlatStyle = FlatStyle.Flat;
            ruralButton.FlatAppearance.BorderSize = 0;

            manMadeButton.FlatStyle = FlatStyle.Flat;
            manMadeButton.FlatAppearance.BorderSize = 0;

            naturalButton.FlatStyle = FlatStyle.Flat;
            naturalButton.FlatAppearance.BorderSize = 0;

            hikingButton.FlatStyle = FlatStyle.Flat;
            hikingButton.FlatAppearance.BorderSize = 0;

            amusementParksButton.FlatStyle = FlatStyle.Flat;
            amusementParksButton.FlatAppearance.BorderSize = 0;

            fastFoodButton.FlatStyle = FlatStyle.Flat;
            fastFoodButton.FlatAppearance.BorderSize = 0;

            sitdownFoodButton.FlatStyle = FlatStyle.Flat;
            sitdownFoodButton.FlatAppearance.BorderSize = 0;

            doneButton.Enabled = false;
            doneButton.FlatStyle = FlatStyle.Flat;
            doneButton.FlatAppearance.BorderSize = 0;
            doneButton.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            mainForm main = new mainForm(buttonSelections);
            this.Hide();
            main.Show();
        }

        private void interestsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
