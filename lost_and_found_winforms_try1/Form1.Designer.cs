namespace lost_and_found_winforms_try1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_itemID = new System.Windows.Forms.TextBox();
            this.textBox_itemName = new System.Windows.Forms.TextBox();
            this.textBox_ownerName = new System.Windows.Forms.TextBox();
            this.textBox_locationFound = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_claim = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Owner Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Location Found";
            // 
            // textBox_itemID
            // 
            this.textBox_itemID.Location = new System.Drawing.Point(120, 46);
            this.textBox_itemID.Name = "textBox_itemID";
            this.textBox_itemID.Size = new System.Drawing.Size(100, 20);
            this.textBox_itemID.TabIndex = 4;
            // 
            // textBox_itemName
            // 
            this.textBox_itemName.Location = new System.Drawing.Point(120, 79);
            this.textBox_itemName.Name = "textBox_itemName";
            this.textBox_itemName.Size = new System.Drawing.Size(100, 20);
            this.textBox_itemName.TabIndex = 5;
            // 
            // textBox_ownerName
            // 
            this.textBox_ownerName.Location = new System.Drawing.Point(120, 109);
            this.textBox_ownerName.Name = "textBox_ownerName";
            this.textBox_ownerName.Size = new System.Drawing.Size(100, 20);
            this.textBox_ownerName.TabIndex = 6;
            // 
            // textBox_locationFound
            // 
            this.textBox_locationFound.Location = new System.Drawing.Point(120, 138);
            this.textBox_locationFound.Name = "textBox_locationFound";
            this.textBox_locationFound.Size = new System.Drawing.Size(100, 20);
            this.textBox_locationFound.TabIndex = 7;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(246, 44);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(87, 23);
            this.btn_submit.TabIndex = 8;
            this.btn_submit.Text = "Item Found";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_claim
            // 
            this.btn_claim.Location = new System.Drawing.Point(246, 76);
            this.btn_claim.Name = "btn_claim";
            this.btn_claim.Size = new System.Drawing.Size(87, 23);
            this.btn_claim.TabIndex = 9;
            this.btn_claim.Text = "Item Claimed";
            this.btn_claim.UseVisualStyleBackColor = true;
            this.btn_claim.Click += new System.EventHandler(this.btn_claim_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(555, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(246, 107);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(87, 23);
            this.btn_Update.TabIndex = 11;
            this.btn_Update.Text = "Edit";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 381);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_claim);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.textBox_locationFound);
            this.Controls.Add(this.textBox_ownerName);
            this.Controls.Add(this.textBox_itemName);
            this.Controls.Add(this.textBox_itemID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lost and Found";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_itemID;
        private System.Windows.Forms.TextBox textBox_itemName;
        private System.Windows.Forms.TextBox textBox_ownerName;
        private System.Windows.Forms.TextBox textBox_locationFound;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_claim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Update;
    }
}

