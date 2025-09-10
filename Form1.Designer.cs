namespace Registrations
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.passtextbox = new System.Windows.Forms.TextBox();
            this.branchtextbox = new System.Windows.Forms.ComboBox();
            this.citytextbox = new System.Windows.Forms.ListBox();
            this.malebutton = new System.Windows.Forms.RadioButton();
            this.femalebutton = new System.Windows.Forms.RadioButton();
            this.registerbutton = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(345, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(508, 43);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Student Registration Form";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(332, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(341, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(332, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Branch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(332, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(332, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Gender";
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(502, 128);
            this.nametextbox.Multiline = true;
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(142, 42);
            this.nametextbox.TabIndex = 12;
            this.nametextbox.TextChanged += new System.EventHandler(this.nametextbox_TextChanged);
            // 
            // passtextbox
            // 
            this.passtextbox.Location = new System.Drawing.Point(502, 206);
            this.passtextbox.Multiline = true;
            this.passtextbox.Name = "passtextbox";
            this.passtextbox.Size = new System.Drawing.Size(142, 42);
            this.passtextbox.TabIndex = 15;
            // 
            // branchtextbox
            // 
            this.branchtextbox.FormattingEnabled = true;
            this.branchtextbox.Items.AddRange(new object[] {
            "Betch CE",
            "Btech Civil",
            "Btech IT"});
            this.branchtextbox.Location = new System.Drawing.Point(502, 268);
            this.branchtextbox.Name = "branchtextbox";
            this.branchtextbox.Size = new System.Drawing.Size(142, 24);
            this.branchtextbox.TabIndex = 16;
            // 
            // citytextbox
            // 
            this.citytextbox.FormattingEnabled = true;
            this.citytextbox.ItemHeight = 16;
            this.citytextbox.Items.AddRange(new object[] {
            "Amreli ",
            "Surat",
            "Morbi",
            "Ahmedabad ",
            "Gandhinagar "});
            this.citytextbox.Location = new System.Drawing.Point(503, 330);
            this.citytextbox.Name = "citytextbox";
            this.citytextbox.Size = new System.Drawing.Size(141, 36);
            this.citytextbox.TabIndex = 17;
            // 
            // malebutton
            // 
            this.malebutton.AutoSize = true;
            this.malebutton.Location = new System.Drawing.Point(497, 407);
            this.malebutton.Name = "malebutton";
            this.malebutton.Size = new System.Drawing.Size(58, 20);
            this.malebutton.TabIndex = 18;
            this.malebutton.TabStop = true;
            this.malebutton.Text = "Male";
            this.malebutton.UseVisualStyleBackColor = true;
            this.malebutton.CheckedChanged += new System.EventHandler(this.Male_CheckedChanged);
            // 
            // femalebutton
            // 
            this.femalebutton.AutoSize = true;
            this.femalebutton.Location = new System.Drawing.Point(586, 407);
            this.femalebutton.Name = "femalebutton";
            this.femalebutton.Size = new System.Drawing.Size(74, 20);
            this.femalebutton.TabIndex = 19;
            this.femalebutton.TabStop = true;
            this.femalebutton.Text = "Female";
            this.femalebutton.UseVisualStyleBackColor = true;
            this.femalebutton.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
            // 
            // registerbutton
            // 
            this.registerbutton.Location = new System.Drawing.Point(497, 459);
            this.registerbutton.Name = "registerbutton";
            this.registerbutton.Size = new System.Drawing.Size(147, 44);
            this.registerbutton.TabIndex = 20;
            this.registerbutton.Text = "register";
            this.registerbutton.UseVisualStyleBackColor = true;
            this.registerbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(323, 459);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(147, 44);
            this.update.TabIndex = 21;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(670, 459);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(147, 44);
            this.delete.TabIndex = 22;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1420, 713);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.registerbutton);
            this.Controls.Add(this.femalebutton);
            this.Controls.Add(this.malebutton);
            this.Controls.Add(this.citytextbox);
            this.Controls.Add(this.branchtextbox);
            this.Controls.Add(this.passtextbox);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.TextBox passtextbox;
        private System.Windows.Forms.ComboBox branchtextbox;
        private System.Windows.Forms.ListBox citytextbox;
        private System.Windows.Forms.RadioButton malebutton;
        private System.Windows.Forms.RadioButton femalebutton;
        private System.Windows.Forms.Button registerbutton;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
    }
}

