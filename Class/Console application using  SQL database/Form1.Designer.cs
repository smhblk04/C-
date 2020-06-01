namespace AdoNetDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblstockAmount = new System.Windows.Forms.Label();
            this.lblunitPrice = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxstockAmount = new System.Windows.Forms.TextBox();
            this.tbxunitPrice = new System.Windows.Forms.TextBox();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblunitPriceUpdate = new System.Windows.Forms.Label();
            this.tbxstockAmountUpdate = new System.Windows.Forms.TextBox();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.tbxunitPriceUpdate = new System.Windows.Forms.TextBox();
            this.lblstockAmountUpdate = new System.Windows.Forms.Label();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(72, 92);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 102;
            this.dgwProducts.RowTemplate.Height = 40;
            this.dgwProducts.Size = new System.Drawing.Size(1564, 414);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(91, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 32);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblstockAmount
            // 
            this.lblstockAmount.AutoSize = true;
            this.lblstockAmount.Location = new System.Drawing.Point(91, 219);
            this.lblstockAmount.Name = "lblstockAmount";
            this.lblstockAmount.Size = new System.Drawing.Size(191, 32);
            this.lblstockAmount.TabIndex = 2;
            this.lblstockAmount.Text = "Stock Amount";
            // 
            // lblunitPrice
            // 
            this.lblunitPrice.AutoSize = true;
            this.lblunitPrice.Location = new System.Drawing.Point(91, 361);
            this.lblunitPrice.Name = "lblunitPrice";
            this.lblunitPrice.Size = new System.Drawing.Size(138, 32);
            this.lblunitPrice.TabIndex = 3;
            this.lblunitPrice.Text = "Unit Price";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(330, 76);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(220, 38);
            this.tbxName.TabIndex = 4;
            // 
            // tbxstockAmount
            // 
            this.tbxstockAmount.Location = new System.Drawing.Point(330, 213);
            this.tbxstockAmount.Name = "tbxstockAmount";
            this.tbxstockAmount.Size = new System.Drawing.Size(220, 38);
            this.tbxstockAmount.TabIndex = 6;
            // 
            // tbxunitPrice
            // 
            this.tbxunitPrice.Location = new System.Drawing.Point(330, 358);
            this.tbxunitPrice.Name = "tbxunitPrice";
            this.tbxunitPrice.Size = new System.Drawing.Size(220, 38);
            this.tbxunitPrice.TabIndex = 5;
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.lblunitPrice);
            this.gbxAdd.Controls.Add(this.tbxstockAmount);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Controls.Add(this.tbxunitPrice);
            this.gbxAdd.Controls.Add(this.lblstockAmount);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Location = new System.Drawing.Point(72, 578);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(744, 526);
            this.gbxAdd.TabIndex = 7;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a product";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(330, 445);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(220, 63);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.lblunitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.tbxstockAmountUpdate);
            this.gbxUpdate.Controls.Add(this.lblNameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxunitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.lblstockAmountUpdate);
            this.gbxUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(892, 578);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(744, 526);
            this.gbxUpdate.TabIndex = 8;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update a product";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(330, 445);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(220, 63);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblunitPriceUpdate
            // 
            this.lblunitPriceUpdate.AutoSize = true;
            this.lblunitPriceUpdate.Location = new System.Drawing.Point(91, 364);
            this.lblunitPriceUpdate.Name = "lblunitPriceUpdate";
            this.lblunitPriceUpdate.Size = new System.Drawing.Size(138, 32);
            this.lblunitPriceUpdate.TabIndex = 3;
            this.lblunitPriceUpdate.Text = "Unit Price";
            // 
            // tbxstockAmountUpdate
            // 
            this.tbxstockAmountUpdate.Location = new System.Drawing.Point(330, 210);
            this.tbxstockAmountUpdate.Name = "tbxstockAmountUpdate";
            this.tbxstockAmountUpdate.Size = new System.Drawing.Size(220, 38);
            this.tbxstockAmountUpdate.TabIndex = 6;
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(91, 79);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(90, 32);
            this.lblNameUpdate.TabIndex = 1;
            this.lblNameUpdate.Text = "Name";
            // 
            // tbxunitPriceUpdate
            // 
            this.tbxunitPriceUpdate.Location = new System.Drawing.Point(330, 361);
            this.tbxunitPriceUpdate.Name = "tbxunitPriceUpdate";
            this.tbxunitPriceUpdate.Size = new System.Drawing.Size(220, 38);
            this.tbxunitPriceUpdate.TabIndex = 5;
            // 
            // lblstockAmountUpdate
            // 
            this.lblstockAmountUpdate.AutoSize = true;
            this.lblstockAmountUpdate.Location = new System.Drawing.Point(91, 216);
            this.lblstockAmountUpdate.Name = "lblstockAmountUpdate";
            this.lblstockAmountUpdate.Size = new System.Drawing.Size(191, 32);
            this.lblstockAmountUpdate.TabIndex = 2;
            this.lblstockAmountUpdate.Text = "Stock Amount";
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(330, 76);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(220, 38);
            this.tbxNameUpdate.TabIndex = 4;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(1222, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(220, 61);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1690, 1132);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblstockAmount;
        private System.Windows.Forms.Label lblunitPrice;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxunitPrice;
        private System.Windows.Forms.TextBox tbxstockAmount;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblunitPriceUpdate;
        private System.Windows.Forms.TextBox tbxstockAmountUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.TextBox tbxunitPriceUpdate;
        private System.Windows.Forms.Label lblstockAmountUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Button btnRemove;
    }
}

