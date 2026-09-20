namespace UniformAllocationTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUnifID = new TextBox();
            txtItemType = new TextBox();
            txtSize = new TextBox();
            txtQty = new TextBox();
            label4 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            dgforms = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            ItemType = new DataGridViewTextBoxColumn();
            Size = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgforms).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 136);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Uniform ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 181);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Item Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 221);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "Size:";
            // 
            // txtUnifID
            // 
            txtUnifID.Location = new Point(191, 136);
            txtUnifID.Name = "txtUnifID";
            txtUnifID.Size = new Size(93, 23);
            txtUnifID.TabIndex = 3;
            // 
            // txtItemType
            // 
            txtItemType.Location = new Point(191, 178);
            txtItemType.Name = "txtItemType";
            txtItemType.Size = new Size(93, 23);
            txtItemType.TabIndex = 4;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(191, 221);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(93, 23);
            txtSize.TabIndex = 5;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(191, 266);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(93, 23);
            txtQty.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 269);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 7;
            label4.Text = "Quantity:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(105, 319);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 33);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(102, 356);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(80, 31);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(196, 319);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 31);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(196, 356);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 31);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgforms
            // 
            dgforms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgforms.Columns.AddRange(new DataGridViewColumn[] { ID, ItemType, Size, Qty });
            dgforms.Location = new Point(306, 129);
            dgforms.Name = "dgforms";
            dgforms.Size = new Size(466, 258);
            dgforms.TabIndex = 12;
            dgforms.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // ItemType
            // 
            ItemType.HeaderText = "ItemType";
            ItemType.Name = "ItemType";
            // 
            // Size
            // 
            Size.HeaderText = "Size";
            Size.Name = "Size";
            // 
            // Qty
            // 
            Qty.HeaderText = "Qty Avail";
            Qty.Name = "Qty";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Thistle;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Sylfaen", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(209, 37);
            label5.Name = "label5";
            label5.Size = new Size(419, 44);
            label5.TabIndex = 13;
            label5.Text = "Uniform Allocation Tracker";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.Location = new Point(327, 90);
            label6.Name = "label6";
            label6.Size = new Size(188, 25);
            label6.TabIndex = 14;
            label6.Text = "By Redelle Baylosis";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 451);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dgforms);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(txtQty);
            Controls.Add(txtSize);
            Controls.Add(txtItemType);
            Controls.Add(txtUnifID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgforms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUnifID;
        private TextBox txtItemType;
        private TextBox txtSize;
        private TextBox txtQty;
        private Label label4;
        private Button btnAdd;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgforms;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ItemType;
        private DataGridViewTextBoxColumn Size;
        private DataGridViewTextBoxColumn Qty;
        private Label label5;
        private Label label6;
    }
}
