namespace calculaterapp
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.lblheding = new System.Windows.Forms.Label();
            this.lblnumber1 = new System.Windows.Forms.Label();
            this.txtnumber1 = new System.Windows.Forms.TextBox();
            this.txtnumber2 = new System.Windows.Forms.TextBox();
            this.lblnumber2 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnmod = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.lbltitleans = new System.Windows.Forms.Label();
            this.lblanswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblheding
            // 
            this.lblheding.AutoSize = true;
            this.lblheding.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheding.Location = new System.Drawing.Point(167, 24);
            this.lblheding.Name = "lblheding";
            this.lblheding.Size = new System.Drawing.Size(201, 26);
            this.lblheding.TabIndex = 0;
            this.lblheding.Text = "Basic Calculator";
            this.lblheding.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblnumber1
            // 
            this.lblnumber1.AutoSize = true;
            this.lblnumber1.Location = new System.Drawing.Point(23, 97);
            this.lblnumber1.Name = "lblnumber1";
            this.lblnumber1.Size = new System.Drawing.Size(99, 23);
            this.lblnumber1.TabIndex = 1;
            this.lblnumber1.Text = "Number 1";
            // 
            // txtnumber1
            // 
            this.txtnumber1.Location = new System.Drawing.Point(141, 97);
            this.txtnumber1.Name = "txtnumber1";
            this.txtnumber1.Size = new System.Drawing.Size(100, 30);
            this.txtnumber1.TabIndex = 1;
            // 
            // txtnumber2
            // 
            this.txtnumber2.Location = new System.Drawing.Point(141, 161);
            this.txtnumber2.Name = "txtnumber2";
            this.txtnumber2.Size = new System.Drawing.Size(100, 30);
            this.txtnumber2.TabIndex = 2;
            // 
            // lblnumber2
            // 
            this.lblnumber2.AutoSize = true;
            this.lblnumber2.Location = new System.Drawing.Point(23, 161);
            this.lblnumber2.Name = "lblnumber2";
            this.lblnumber2.Size = new System.Drawing.Size(99, 23);
            this.lblnumber2.TabIndex = 3;
            this.lblnumber2.Text = "Number 2";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Silver;
            this.btnadd.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(320, 97);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(77, 30);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnmod
            // 
            this.btnmod.BackColor = System.Drawing.Color.Silver;
            this.btnmod.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmod.Location = new System.Drawing.Point(320, 216);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(77, 30);
            this.btnmod.TabIndex = 7;
            this.btnmod.Text = "%";
            this.btnmod.UseVisualStyleBackColor = false;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // btndiv
            // 
            this.btndiv.BackColor = System.Drawing.Color.Silver;
            this.btndiv.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiv.Location = new System.Drawing.Point(438, 154);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(77, 30);
            this.btndiv.TabIndex = 6;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = false;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnmul
            // 
            this.btnmul.BackColor = System.Drawing.Color.Silver;
            this.btnmul.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmul.Location = new System.Drawing.Point(320, 154);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(77, 30);
            this.btnmul.TabIndex = 5;
            this.btnmul.Text = "*";
            this.btnmul.UseVisualStyleBackColor = false;
            this.btnmul.Click += new System.EventHandler(this.btnmul_Click);
            // 
            // btnsub
            // 
            this.btnsub.BackColor = System.Drawing.Color.Silver;
            this.btnsub.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsub.Location = new System.Drawing.Point(438, 97);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(77, 30);
            this.btnsub.TabIndex = 4;
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = false;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // lbltitleans
            // 
            this.lbltitleans.AutoSize = true;
            this.lbltitleans.Location = new System.Drawing.Point(148, 223);
            this.lbltitleans.Name = "lbltitleans";
            this.lbltitleans.Size = new System.Drawing.Size(78, 23);
            this.lbltitleans.TabIndex = 10;
            this.lbltitleans.Text = "Answer";
            // 
            // lblanswer
            // 
            this.lblanswer.AutoSize = true;
            this.lblanswer.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanswer.Location = new System.Drawing.Point(148, 267);
            this.lblanswer.Name = "lblanswer";
            this.lblanswer.Size = new System.Drawing.Size(37, 25);
            this.lblanswer.TabIndex = 11;
            this.lblanswer.Text = "     ";
            this.lblanswer.Visible = false;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(556, 348);
            this.Controls.Add(this.lblanswer);
            this.Controls.Add(this.lbltitleans);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtnumber2);
            this.Controls.Add(this.lblnumber2);
            this.Controls.Add(this.txtnumber1);
            this.Controls.Add(this.lblnumber1);
            this.Controls.Add(this.lblheding);
            this.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.home_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblheding;
        private System.Windows.Forms.Label lblnumber1;
        private System.Windows.Forms.TextBox txtnumber1;
        private System.Windows.Forms.TextBox txtnumber2;
        private System.Windows.Forms.Label lblnumber2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Label lbltitleans;
        private System.Windows.Forms.Label lblanswer;
    }
}

