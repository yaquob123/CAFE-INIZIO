namespace CAFE_INIZIO
{
    partial class Costumer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Costumer));
            this.label6 = new System.Windows.Forms.Label();
            this.CustGenCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CustNameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CustomerDGV = new System.Windows.Forms.DataGridView();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLOGOUT = new System.Windows.Forms.Button();
            this.btnORDER = new System.Windows.Forms.Button();
            this.btnCOSTUMER = new System.Windows.Forms.Button();
            this.btnPRODUCT = new System.Windows.Forms.Button();
            this.btnEMPLOYEE = new System.Windows.Forms.Button();
            this.btnHOME = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(356, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "CUSTOMER LIST";
            // 
            // CustGenCB
            // 
            this.CustGenCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustGenCB.FormattingEnabled = true;
            this.CustGenCB.Items.AddRange(new object[] {
            "MALE",
            "FEMALE",
            "OTHER"});
            this.CustGenCB.Location = new System.Drawing.Point(151, 67);
            this.CustGenCB.Name = "CustGenCB";
            this.CustGenCB.Size = new System.Drawing.Size(121, 24);
            this.CustGenCB.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "GENDER";
            // 
            // CustNameTb
            // 
            this.CustNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNameTb.Location = new System.Drawing.Point(6, 68);
            this.CustNameTb.Name = "CustNameTb";
            this.CustNameTb.Size = new System.Drawing.Size(121, 22);
            this.CustNameTb.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "CUSTOMER";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.CustomerDGV);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnDELETE);
            this.panel3.Controls.Add(this.btnEDIT);
            this.panel3.Controls.Add(this.btnSAVE);
            this.panel3.Controls.Add(this.CustGenCB);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.CustNameTb);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(961, 385);
            this.panel3.TabIndex = 7;
            // 
            // CustomerDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerDGV.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.CustomerDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDGV.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CustomerDGV.Location = new System.Drawing.Point(12, 144);
            this.CustomerDGV.Name = "CustomerDGV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CustomerDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.PeachPuff;
            this.CustomerDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CustomerDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CustomerDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.CustomerDGV.Size = new System.Drawing.Size(930, 233);
            this.CustomerDGV.TabIndex = 27;
            this.CustomerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDGV_CellClick);
            // 
            // btnDELETE
            // 
            this.btnDELETE.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDELETE.Image = global::CAFE_INIZIO.Properties.Resources.exitbutton;
            this.btnDELETE.Location = new System.Drawing.Point(529, 48);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(89, 42);
            this.btnDELETE.TabIndex = 25;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDELETE.UseVisualStyleBackColor = false;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnEDIT
            // 
            this.btnEDIT.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEDIT.Image = global::CAFE_INIZIO.Properties.Resources.view;
            this.btnEDIT.Location = new System.Drawing.Point(420, 48);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(89, 42);
            this.btnEDIT.TabIndex = 24;
            this.btnEDIT.Text = "EDIT";
            this.btnEDIT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEDIT.UseVisualStyleBackColor = false;
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
            // 
            // btnSAVE
            // 
            this.btnSAVE.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSAVE.Image = global::CAFE_INIZIO.Properties.Resources.add;
            this.btnSAVE.Location = new System.Drawing.Point(308, 48);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(89, 42);
            this.btnSAVE.TabIndex = 23;
            this.btnSAVE.Text = "SAVE";
            this.btnSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSAVE.UseVisualStyleBackColor = false;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "NAME";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnLOGOUT);
            this.panel1.Controls.Add(this.btnORDER);
            this.panel1.Controls.Add(this.btnCOSTUMER);
            this.panel1.Controls.Add(this.btnPRODUCT);
            this.panel1.Controls.Add(this.btnEMPLOYEE);
            this.panel1.Controls.Add(this.btnHOME);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 471);
            this.panel1.TabIndex = 2;
            // 
            // btnLOGOUT
            // 
            this.btnLOGOUT.Image = global::CAFE_INIZIO.Properties.Resources.exitbutton;
            this.btnLOGOUT.Location = new System.Drawing.Point(504, 12);
            this.btnLOGOUT.Name = "btnLOGOUT";
            this.btnLOGOUT.Size = new System.Drawing.Size(76, 68);
            this.btnLOGOUT.TabIndex = 6;
            this.btnLOGOUT.Text = "LOGOUT";
            this.btnLOGOUT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLOGOUT.UseVisualStyleBackColor = true;
            this.btnLOGOUT.Click += new System.EventHandler(this.btnLOGOUT_Click);
            // 
            // btnORDER
            // 
            this.btnORDER.Image = global::CAFE_INIZIO.Properties.Resources.orders;
            this.btnORDER.Location = new System.Drawing.Point(422, 12);
            this.btnORDER.Name = "btnORDER";
            this.btnORDER.Size = new System.Drawing.Size(76, 68);
            this.btnORDER.TabIndex = 5;
            this.btnORDER.Text = "ORDER";
            this.btnORDER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnORDER.UseVisualStyleBackColor = true;
            this.btnORDER.Click += new System.EventHandler(this.btnORDER_Click);
            // 
            // btnCOSTUMER
            // 
            this.btnCOSTUMER.Image = global::CAFE_INIZIO.Properties.Resources.costumer;
            this.btnCOSTUMER.Location = new System.Drawing.Point(340, 12);
            this.btnCOSTUMER.Name = "btnCOSTUMER";
            this.btnCOSTUMER.Size = new System.Drawing.Size(76, 68);
            this.btnCOSTUMER.TabIndex = 4;
            this.btnCOSTUMER.Text = "COSTUMER";
            this.btnCOSTUMER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCOSTUMER.UseVisualStyleBackColor = true;
            this.btnCOSTUMER.Click += new System.EventHandler(this.btnCOSTUMER_Click);
            // 
            // btnPRODUCT
            // 
            this.btnPRODUCT.Image = global::CAFE_INIZIO.Properties.Resources.iced_coffee;
            this.btnPRODUCT.Location = new System.Drawing.Point(258, 12);
            this.btnPRODUCT.Name = "btnPRODUCT";
            this.btnPRODUCT.Size = new System.Drawing.Size(76, 68);
            this.btnPRODUCT.TabIndex = 3;
            this.btnPRODUCT.Text = "PRODUCT";
            this.btnPRODUCT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPRODUCT.UseVisualStyleBackColor = true;
            this.btnPRODUCT.Click += new System.EventHandler(this.btnPRODUCT_Click);
            // 
            // btnEMPLOYEE
            // 
            this.btnEMPLOYEE.Image = global::CAFE_INIZIO.Properties.Resources.user;
            this.btnEMPLOYEE.Location = new System.Drawing.Point(176, 12);
            this.btnEMPLOYEE.Name = "btnEMPLOYEE";
            this.btnEMPLOYEE.Size = new System.Drawing.Size(76, 68);
            this.btnEMPLOYEE.TabIndex = 2;
            this.btnEMPLOYEE.Text = "EMPLOYEE";
            this.btnEMPLOYEE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEMPLOYEE.UseVisualStyleBackColor = true;
            this.btnEMPLOYEE.Click += new System.EventHandler(this.btnEMPLOYEE_Click);
            // 
            // btnHOME
            // 
            this.btnHOME.Image = global::CAFE_INIZIO.Properties.Resources.house;
            this.btnHOME.Location = new System.Drawing.Point(94, 12);
            this.btnHOME.Name = "btnHOME";
            this.btnHOME.Size = new System.Drawing.Size(76, 68);
            this.btnHOME.TabIndex = 1;
            this.btnHOME.Text = "HOME";
            this.btnHOME.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHOME.UseVisualStyleBackColor = true;
            this.btnHOME.Click += new System.EventHandler(this.btnHOME_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::CAFE_INIZIO.Properties.Resources.Header;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(76, 68);
            this.panel2.TabIndex = 0;
            // 
            // Costumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 468);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Costumer";
            this.Text = "Costumer";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.ComboBox CustGenCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CustNameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLOGOUT;
        private System.Windows.Forms.Button btnORDER;
        private System.Windows.Forms.Button btnCOSTUMER;
        private System.Windows.Forms.Button btnPRODUCT;
        private System.Windows.Forms.Button btnEMPLOYEE;
        private System.Windows.Forms.Button btnHOME;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView CustomerDGV;
    }
}