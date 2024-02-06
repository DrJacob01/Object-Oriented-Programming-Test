namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Example usage of the Car class
            Car myCar = new Car("Ford","KA",2022,2.5f);
            myCar.DisplayCarInfo();
        }

    }
}