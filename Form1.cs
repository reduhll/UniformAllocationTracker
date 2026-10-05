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

        //clears the input field after clicking button clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItemType.Clear();
            txtSize.Clear();
            txtQty.Clear();
            txtUnifID.Clear();
            txtItemType.Focus();
        }

        //Data will show on input field once table data is pressed
        private void dgforms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgforms.Rows[e.RowIndex];

                txtUnifID.Text = row.Cells["colID"].Value?.ToString();
                txtItemType.Text = row.Cells["colItemType"].Value?.ToString();
                txtSize.Text = row.Cells["colSize"].Value?.ToString();
                txtQty.Text = row.Cells["colQty"].Value?.ToString();
            }
        }

        //Updating fields

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUnifID.Text == "" || txtItemType.Text == "" ||
                txtSize.Text == "" || txtQty.Text == "")
                //if selected is empty, user is required to refill fields
            {
                MessageBox.Show("Please Select Record and Complete Fields..");
                return;
            }

                int uniformID;
                int quantity;

                if (!int.TryParse(txtUnifID.Text, out uniformID) || !int.TryParse(txtQty.Text, out quantity))
                {
                    MessageBox.Show("Quantity input is invalid. Pls Try Again!");
                    return;
                }

                UniformDatabase.UpdateUniform(
                    uniformID, txtItemType.Text, txtSize.Text, quantity);
                LoadUniforms();

                MessageBox.Show("Success! Uniform Information is Updated!");
            
        }
    }
}
