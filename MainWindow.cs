using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace TeCSSchoolManagmentSystem
{
    //All according to antipattern Magic button )"
    public partial class MainWindow : Form
    {
        private const string PATH_TO_COURSES_CODES = "course_codes.txt";
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool checkIfRankingIsCalculated()
        {
            return txtAverage.Text != "" && txtTotalScore.Text != "" &&
                txtRanking.Text != "" && txtProgressionDecision.Text != "";
        }

        private void loadCourseCodesFromFile()
        {
            this.cmbCourseCode.Items.Clear();
            System.IO.StreamReader file = new System.IO.StreamReader(PATH_TO_COURSES_CODES);
            string nextLine;
            while ((nextLine = file.ReadLine()) != null)
            {
                this.cmbCourseCode.Items.Add(nextLine);
            }
        }

        private void createRandomCourseCodes()
        {
            this.cmbCourseCode.Items.Clear();
            Random rnd = new Random();
            for (int i = 0; i < 20; ++i)
            {
                this.cmbCourseCode.Items.Add(rnd.Next(10000, 100000));
            } 
        }

        private void calculate_ranking()
        {
            ArrayList list = new ArrayList();
            list.Add(Convert.ToDouble(txtMath.Text));
            list.Add(Convert.ToDouble(txtPhysics.Text));
            list.Add(Convert.ToDouble(txtComputing.Text));
            list.Add(Convert.ToDouble(txtEconomics.Text));
            list.Add(Convert.ToDouble(txtEnglish.Text));
            list.Add(Convert.ToDouble(txtBiology.Text));
            list.Add(Convert.ToDouble(txtBusiness.Text));
            list.Add(Convert.ToDouble(txtChemistry.Text));

            double total = 0;

            foreach (double mark in list)
            {
                total += mark;
            }
            double average = total / list.Count;
            double max = list.Count * 100;
            double rel = total / max;
            //A = Excellent; B = Good; C = Adequate; D = Marginal; F = Inadequate
            if (rel <= 0.5)
            {
                txtProgressionDecision.Text = "Fail";
                txtRanking.Text = "F-Inadequate";
            }
            else if (rel <= 0.6)
            {
                txtProgressionDecision.Text = "Course completed";
                txtRanking.Text = "D-Marginal";
            }
            else if (rel <= 0.75)
            {
                txtProgressionDecision.Text = "Course completed";
                txtRanking.Text = "C-Adequate";
            }
            else if (rel <= 0.9)
            {
                txtProgressionDecision.Text = "Course completed";
                txtRanking.Text = "B-Good";
            }
            else
            {
                txtProgressionDecision.Text = "Course completed";
                txtRanking.Text = "A - Excellent";
            }

            txtTotalScore.Text = Convert.ToString(total);
            txtAverage.Text = Convert.ToString(average);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Confirm if you want to exit", "Student ranking",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rtTranscript.Clear();
            //cmbCourseCode.Items.Clear();
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }
            };

            func(Controls);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.table.Rows.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (table.SelectedRows.Count > 0)
            {
                table.Rows.RemoveAt(table.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Select a row to be deleted", this.Text);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.table.Rows.Add(txtStudentID.Text, txtFirstName.Text, txtSurname.Text,
                    txtMath.Text, txtPhysics.Text, txtComputing.Text, txtEconomics.Text,
                    txtEnglish.Text, txtBusiness.Text, txtBiology.Text, txtChemistry.Text,
                    txtAverage.Text, txtRanking.Text, txtTotalScore.Text,
                    txtProgressionDecision.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnTranscript_Click(object sender, EventArgs e)
        {
            rtTranscript.AppendText("StudentID - " + txtStudentID.Text);
            rtTranscript.AppendText("\nFirstName- " + txtFirstName.Text);
            rtTranscript.AppendText("\nSurname - " + txtSurname.Text);

            rtTranscript.AppendText("\nMath - " + txtMath.Text);
            rtTranscript.AppendText("\nStudentID - " + txtPhysics.Text);
            rtTranscript.AppendText("\nComputing- " + txtComputing.Text);
            rtTranscript.AppendText("\nEconomics - " + txtEconomics.Text);
            rtTranscript.AppendText("\nEnglish - " + txtEnglish.Text);
            rtTranscript.AppendText("\nBusiness - " + txtBusiness.Text);
            rtTranscript.AppendText("\nBiology - " + txtBiology.Text);
            rtTranscript.AppendText("\nChemistry - " + txtChemistry.Text);

            rtTranscript.AppendText("\nAverage - " + txtAverage.Text);
            rtTranscript.AppendText("\nTotalScore - " + txtTotalScore.Text);
            rtTranscript.AppendText("\nRanking- " + txtRanking.Text);
            rtTranscript.AppendText("\nProgressionDecision - " + txtProgressionDecision.Text);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            try
            {
                loadCourseCodesFromFile();
            }
            catch (Exception ex)
            {
                createRandomCourseCodes();
                MessageBox.Show(null,ex.Message,"Error",MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void validator(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !Char.IsDigit(ch))
            {
                e.Handled = true;
            }
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            calculate_ranking();
        }

        private void cell_click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtStudentID.Text = table.CurrentRow.Cells["Student_ID"].Value.ToString();
                txtFirstName.Text = table.CurrentRow.Cells["First_Name"].Value.ToString();
                txtSurname.Text = table.CurrentRow.Cells["Surname"].Value.ToString();
                //Subjects
                txtMath.Text = table.CurrentRow.Cells["Math"].Value.ToString();
                txtPhysics.Text = table.CurrentRow.Cells["Physics"].Value.ToString();
                txtComputing.Text = table.CurrentRow.Cells["Computing"].Value.ToString();
                txtEconomics.Text = table.CurrentRow.Cells["Economics"].Value.ToString();
                txtEnglish.Text = table.CurrentRow.Cells["English"].Value.ToString();
                txtBusiness.Text = table.CurrentRow.Cells["Business"].Value.ToString();
                txtBiology.Text = table.CurrentRow.Cells["Biology"].Value.ToString();
                txtChemistry.Text = table.CurrentRow.Cells["Chemistry"].Value.ToString();

                txtAverage.Text = table.CurrentRow.Cells["Average"].Value.ToString();
                txtTotalScore.Text = table.CurrentRow.Cells["Total_Score"].Value.ToString();
                txtRanking.Text = table.CurrentRow.Cells["Ranking"].Value.ToString();
                txtProgressionDecision.Text = table.CurrentRow.Cells["Progressing_decision"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(null,ex.Message,"Error",MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {            
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Text files|*.txt";
                DialogResult result = dialog.ShowDialog();
                if (result != DialogResult.OK) return;
                System.IO.StreamReader file = new System.IO.StreamReader(dialog.FileName);
                file.ReadLine();
                string nextLine;
                while ((nextLine = file.ReadLine()) != null)
                {                    
                    string[] values = nextLine.Split('\t');
                    this.table.Rows.Add(values);                    
                }
                file.Close();
                MessageBox.Show("Data was read from file: \n" + dialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            if (!checkIfRankingIsCalculated())
            {
                MessageBox.Show(null, "Ranking must be calculated before saving",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Text files|*.txt";
                DialogResult result = dialog.ShowDialog();
                if (result != DialogResult.OK) return;
                int rowCount = table.Rows.Count;
                int colCount = table.Columns.Count;
                StringBuilder sb = new StringBuilder();
                List<string> headers = new List<string>();
                for (int c = 0; c < colCount - 1; ++c)
                {
                    headers.Add(table.Columns[c].HeaderText);
                }
                sb.AppendLine(string.Join("\t", headers));
                List<string> line = new List<string>();
                for (int r = 0; r < rowCount - 1; ++r)
                {
                    line.Clear();
                    for (int c = 0; c < colCount - 1; ++c)
                    {
                        line.Add(table.Rows[r].Cells[c].Value.ToString());
                    }
                    sb.AppendLine(string.Join("\t", line));
                }
                System.IO.File.WriteAllText(dialog.FileName, sb.ToString());
                MessageBox.Show("Data was written to file: \n" + dialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

    }
}
