namespace Reservation2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addBox = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtfirstName = new System.Windows.Forms.TextBox();
            this.txtlastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtroomID = new System.Windows.Forms.TextBox();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.filterBox = new System.Windows.Forms.Button();
            this.deleteBox = new System.Windows.Forms.Button();
            this.updateBox = new System.Windows.Forms.Button();
            this.txtUpdateBox = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.lblCustomerid = new System.Windows.Forms.Label();
            this.selectBox = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 206);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Yellow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 206);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DataGridView1_RowStateChanged);
            // 
            // addBox
            // 
            this.addBox.BackColor = System.Drawing.Color.Aqua;
            this.addBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addBox.Location = new System.Drawing.Point(270, 15);
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(114, 31);
            this.addBox.TabIndex = 1;
            this.addBox.Text = "EKLE";
            this.addBox.UseVisualStyleBackColor = false;
            this.addBox.Click += new System.EventHandler(this.AddBox_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirstName.Location = new System.Drawing.Point(59, 35);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(54, 19);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "İsim : ";
            // 
            // txtfirstName
            // 
            this.txtfirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtfirstName.Location = new System.Drawing.Point(119, 31);
            this.txtfirstName.Name = "txtfirstName";
            this.txtfirstName.Size = new System.Drawing.Size(113, 26);
            this.txtfirstName.TabIndex = 3;
            // 
            // txtlastName
            // 
            this.txtlastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtlastName.Location = new System.Drawing.Point(119, 79);
            this.txtlastName.Name = "txtlastName";
            this.txtlastName.Size = new System.Drawing.Size(113, 26);
            this.txtlastName.TabIndex = 5;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastName.Location = new System.Drawing.Point(25, 79);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(88, 19);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Soy İsim : ";
            // 
            // txtroomID
            // 
            this.txtroomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtroomID.Location = new System.Drawing.Point(119, 121);
            this.txtroomID.Name = "txtroomID";
            this.txtroomID.Size = new System.Drawing.Size(113, 26);
            this.txtroomID.TabIndex = 5;
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRoomNo.Location = new System.Drawing.Point(33, 125);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(80, 19);
            this.lblRoomNo.TabIndex = 4;
            this.lblRoomNo.Text = "Oda No : ";
            // 
            // filterBox
            // 
            this.filterBox.BackColor = System.Drawing.Color.Aqua;
            this.filterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filterBox.Location = new System.Drawing.Point(401, 15);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(114, 31);
            this.filterBox.TabIndex = 6;
            this.filterBox.Text = "FİLTRELE";
            this.filterBox.UseVisualStyleBackColor = false;
            this.filterBox.Click += new System.EventHandler(this.FilterBox_Click);
            // 
            // deleteBox
            // 
            this.deleteBox.BackColor = System.Drawing.Color.Aqua;
            this.deleteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteBox.Location = new System.Drawing.Point(535, 15);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(114, 31);
            this.deleteBox.TabIndex = 7;
            this.deleteBox.Text = "SİL";
            this.deleteBox.UseVisualStyleBackColor = false;
            this.deleteBox.Click += new System.EventHandler(this.DeleteBox_Click);
            // 
            // updateBox
            // 
            this.updateBox.BackColor = System.Drawing.Color.Aqua;
            this.updateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateBox.Location = new System.Drawing.Point(664, 14);
            this.updateBox.Name = "updateBox";
            this.updateBox.Size = new System.Drawing.Size(114, 33);
            this.updateBox.TabIndex = 8;
            this.updateBox.Text = "GÜNCELLE";
            this.updateBox.UseVisualStyleBackColor = false;
            this.updateBox.Click += new System.EventHandler(this.UpdateBox_Click);
            // 
            // txtUpdateBox
            // 
            this.txtUpdateBox.BackColor = System.Drawing.Color.Aqua;
            this.txtUpdateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateBox.Location = new System.Drawing.Point(412, 72);
            this.txtUpdateBox.Name = "txtUpdateBox";
            this.txtUpdateBox.Size = new System.Drawing.Size(210, 33);
            this.txtUpdateBox.TabIndex = 9;
            this.txtUpdateBox.Text = " TEXT İLE GÜNCELLE";
            this.txtUpdateBox.UseVisualStyleBackColor = false;
            this.txtUpdateBox.Click += new System.EventHandler(this.TxtupdateBox_Click);
            // 
            // idBox
            // 
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idBox.Location = new System.Drawing.Point(119, 169);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(113, 26);
            this.idBox.TabIndex = 10;
            // 
            // lblCustomerid
            // 
            this.lblCustomerid.AutoSize = true;
            this.lblCustomerid.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerid.Location = new System.Drawing.Point(-3, 173);
            this.lblCustomerid.Name = "lblCustomerid";
            this.lblCustomerid.Size = new System.Drawing.Size(116, 19);
            this.lblCustomerid.TabIndex = 11;
            this.lblCustomerid.Text = "Customer id : ";
            // 
            // selectBox
            // 
            this.selectBox.BackColor = System.Drawing.Color.Aqua;
            this.selectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectBox.Location = new System.Drawing.Point(455, 136);
            this.selectBox.Name = "selectBox";
            this.selectBox.Size = new System.Drawing.Size(114, 33);
            this.selectBox.TabIndex = 12;
            this.selectBox.Text = "GÖSTER";
            this.selectBox.UseVisualStyleBackColor = false;
            this.selectBox.Click += new System.EventHandler(this.SelectBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectBox);
            this.Controls.Add(this.lblCustomerid);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.txtUpdateBox);
            this.Controls.Add(this.updateBox);
            this.Controls.Add(this.deleteBox);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.txtroomID);
            this.Controls.Add(this.lblRoomNo);
            this.Controls.Add(this.txtlastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtfirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.addBox);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addBox;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtfirstName;
        private System.Windows.Forms.TextBox txtlastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtroomID;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Button filterBox;
        private System.Windows.Forms.Button deleteBox;
        private System.Windows.Forms.Button updateBox;
        private System.Windows.Forms.Button txtUpdateBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label lblCustomerid;
        private System.Windows.Forms.Button selectBox;
    }
}

