namespace UniformAllocationTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            UniformDatabase.InitializeDatabase();

            ID.DataPropertyName = "UniformID";

            dgforms.AutoGenerateColumns = false;

            LoadUniforms(); 

        
        }
        private void LoadUniforms()
        {
            dgforms.DataSource = UniformDatabase.GetUniforms();
        }
        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
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
            if(!int.TryParse(txtQty.Text, out quantity))
            {
                MessageBox.Show("Quantity must be a number.");
                return;
            }
            UniformDatabase.AddUniform(
                txtItemType.Text, txtSize.Text, quantity);

            LoadUniforms();



            MessageBox.Show("Uniform Added Successfully!!!");

            txtItemType.Clear();
            txtSize.Clear();
            txtQty.Clear();
        }
    }
}
