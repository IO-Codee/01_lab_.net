namespace Lab_1_Ilchenko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Підписатися на подію DataSizeChanged
            dataSizeTextBox1.DataSizeChanged += OnDataSizeChanged;
        }

        private void use_button_Click(object sender, EventArgs e)
        {
            dataSizeTextBox1.Text = null;
        }

        private void output_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OnDataSizeChanged(long dataSizeInBytes)
        {

            text_label_1.Text = $"Розмір даних: {dataSizeInBytes} байт";
        }
    }
}
