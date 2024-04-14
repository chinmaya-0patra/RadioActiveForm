namespace RadioActiveForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            String qualification;
            if(btech.Checked == true)
            {
                qualification = btech.Text;
                MessageBox.Show(qualification);
            }
            if (be.Checked == true)
            {
                qualification = be.Text;
                MessageBox.Show(qualification);
            }
            if (bca.Checked == true)
            {
                qualification = bca.Text;
                MessageBox.Show(qualification);
            }
            if (mca.Checked == true)
            {
                qualification = mca.Text;
                MessageBox.Show(qualification);
            }
            string gender;
            if (male.Checked == true) 
            { 
                gender = male.Text;
                MessageBox.Show(gender);
            }
            if (female.Checked == true)
            {
                gender = female.Text;
                MessageBox.Show(gender);
            }
            if (others.Checked == true)
            {
                gender = others.Text;
                MessageBox.Show(gender);
            }
        }
    }
}
