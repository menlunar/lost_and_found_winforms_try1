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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_claim = new FontAwesome.Sharp.IconButton();
            this.btn_Update = new FontAwesome.Sharp.IconButton();
            this.btn_submit = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Owner Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Location Found";
            // 
            // textBox_itemID
            // 
            this.textBox_itemID.Location = new System.Drawing.Point(280, 46);
            this.textBox_itemID.Name = "textBox_itemID";
            this.textBox_itemID.Size = new System.Drawing.Size(100, 20);
            this.textBox_itemID.TabIndex = 4;
            // 
            // textBox_itemName
            // 
            this.textBox_itemName.Location = new System.Drawing.Point(280, 79);
            this.textBox_itemName.Name = "textBox_itemName";
            this.textBox_itemName.Size = new System.Drawing.Size(100, 20);
            this.textBox_itemName.TabIndex = 5;
            // 
            // textBox_ownerName
            // 
            this.textBox_ownerName.Location = new System.Drawing.Point(280, 109);
            this.textBox_ownerName.Name = "textBox_ownerName";
            this.textBox_ownerName.Size = new System.Drawing.Size(100, 20);
            this.textBox_ownerName.TabIndex = 6;
            // 
            // textBox_locationFound
            // 
            this.textBox_locationFound.Location = new System.Drawing.Point(280, 134);
            this.textBox_locationFound.Name = "textBox_locationFound";
            this.textBox_locationFound.Size = new System.Drawing.Size(100, 20);
            this.textBox_locationFound.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(196, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(626, 234);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Search";
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(488, 46);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(143, 20);
            this.textBox_Search.TabIndex = 13;
            this.textBox_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Search_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.panel1.Controls.Add(this.btn_claim);
            this.panel1.Controls.Add(this.btn_Update);
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 438);
            this.panel1.TabIndex = 14;
            // 
            // btn_claim
            // 
            this.btn_claim.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_claim.FlatAppearance.BorderSize = 0;
            this.btn_claim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_claim.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_claim.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btn_claim.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_claim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_claim.IconSize = 30;
            this.btn_claim.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_claim.Location = new System.Drawing.Point(0, 149);
            this.btn_claim.Name = "btn_claim";
            this.btn_claim.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_claim.Size = new System.Drawing.Size(152, 45);
            this.btn_claim.TabIndex = 3;
            this.btn_claim.Text = "Item Claimed";
            this.btn_claim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_claim.UseVisualStyleBackColor = true;
            this.btn_claim.Click += new System.EventHandler(this.btn_claim_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Update.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            this.btn_Update.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Update.IconSize = 30;
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_Update.Location = new System.Drawing.Point(0, 104);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Update.Size = new System.Drawing.Size(152, 45);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Edit Log";
            this.btn_Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_submit.FlatAppearance.BorderSize = 0;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_submit.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_submit.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_submit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_submit.IconSize = 30;
            this.btn_submit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_submit.Location = new System.Drawing.Point(0, 59);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_submit.Size = new System.Drawing.Size(152, 45);
            this.btn_submit.TabIndex = 1;
            this.btn_submit.Text = "Item Found";
            this.btn_submit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click_1);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 59);
            this.panel2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
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
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_claim;
        private FontAwesome.Sharp.IconButton btn_Update;
        private FontAwesome.Sharp.IconButton btn_submit;
        private System.Windows.Forms.Panel panel2;
    }
}

