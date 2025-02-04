namespace GPACalculator1
{
    public partial class Form1 : Form
    {
        private GPACalculator gpaCalculator = new GPACalculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAddGPA_Click(object sender, EventArgs e)
        {
            double gpa;
            if (double.TryParse(txtGPA.Text, out gpa))
            {
                bool result = gpaCalculator.SetGPA(gpa);  // เพิ่ม GPA ลงใน GPACalculator
                if (result)
                {
                    UpdateGPAInfo();
                }
                else
                {
                    MessageBox.Show("Invalid GPA. Please enter a value between 0 and 4.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid GPA.");
            }
        }

        private void UpdateGPAInfo()
        {
            // แสดงผล GPA เฉลี่ย, GPA สูงสุด และ GPA ต่ำสุด
            lblAverage.Text = "Average GPA: " + gpaCalculator.GetGPAx().ToString("F2");
            lblMaxGPA.Text = "Max GPA: " + gpaCalculator.GetMaxGPA().ToString("F2");
            lblMinGPA.Text = "Min GPA: " + gpaCalculator.GetMinGPA().ToString("F2");
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            // ล้างค่าใน TextBox
            txtGPA.Clear();

            // รีเซ็ตค่า Label
            lblAverage.Text = "Average GPA: ";
            lblMaxGPA.Text = "Max GPA: ";
            lblMinGPA.Text = "Min GPA: ";

            // รีเซ็ตค่าของ GPACalculator
            gpaCalculator = new GPACalculator();
        }

        private void txtGPA_TextChanged(object sender, EventArgs e)
        {
            double gpa;
            if (double.TryParse(txtGPA.Text, out gpa))
            {
                // แสดงผล GPA ขณะที่กรอกข้อมูล
                lblAverage.Text = "Average GPA: " + gpaCalculator.GetGPAx().ToString("F2");
                lblMaxGPA.Text = "Max GPA: " + gpaCalculator.GetMaxGPA().ToString("F2");
                lblMinGPA.Text = "Min GPA: " + gpaCalculator.GetMinGPA().ToString("F2");
            }
        }
    }
}
