namespace UniformAllocationTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            UniformDatabase.InitializeDatabase();



            dgforms.AutoGenerateColumns = false;

            LoadUniforms();


        }
        private void LoadUniforms()
        {
            dgforms.DataSource = UniformDatabase.GetUniforms();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtItemType.Text == "" || txtSize.Text == "" || txtQty.Text == "")
            {
                MessageBox.Show("Please Complete All Fields!!!");
                return;
            }

            int quantity;
            if (!int.TryParse(txtQty.Text, out quantity))
            {
                MessageBox.Show("Quantity must be a number.");
                return;
            }
            UniformDatabase.AddUniform(
                txtItemType.Text, txtSize.Text, quantity);

            LoadUniforms();



            MessageBox.Show("Uniform Added Successfully!!!");
            //once uniform is added, form will automatically clear for next one
            txtItemType.Clear();
            txtSize.Clear();
            txtQty.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItemType.Clear();
            txtSize.Clear();
            txtQty.Clear();
            txtUnifID.Clear();
            txtItemType.Focus();
        }
    }
}
