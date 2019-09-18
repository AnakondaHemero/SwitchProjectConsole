namespace WinFormTask.WinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_x = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            this.label_z = new System.Windows.Forms.Label();
            this.label_r = new System.Windows.Forms.Label();
            this.button_obch = new System.Windows.Forms.Button();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.textBox_z = new System.Windows.Forms.TextBox();
            this.textBox_r = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_x.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_x.Location = new System.Drawing.Point(63, 33);
            this.label_x.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(39, 33);
            this.label_x.TabIndex = 0;
            this.label_x.Text = "x=";
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_y.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_y.Location = new System.Drawing.Point(63, 87);
            this.label_y.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(39, 33);
            this.label_y.TabIndex = 1;
            this.label_y.Text = "y=";
            // 
            // label_z
            // 
            this.label_z.AutoSize = true;
            this.label_z.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label_z.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_z.Location = new System.Drawing.Point(63, 145);
            this.label_z.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_z.Name = "label_z";
            this.label_z.Size = new System.Drawing.Size(39, 33);
            this.label_z.TabIndex = 2;
            this.label_z.Text = "z=";
            // 
            // label_r
            // 
            this.label_r.AutoSize = true;
            this.label_r.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label_r.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_r.Location = new System.Drawing.Point(63, 301);
            this.label_r.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_r.Name = "label_r";
            this.label_r.Size = new System.Drawing.Size(36, 33);
            this.label_r.TabIndex = 3;
            this.label_r.Text = "r=";
            // 
            // button_obch
            // 
            this.button_obch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_obch.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_obch.Location = new System.Drawing.Point(89, 199);
            this.button_obch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_obch.Name = "button_obch";
            this.button_obch.Size = new System.Drawing.Size(209, 69);
            this.button_obch.TabIndex = 4;
            this.button_obch.Text = "Обчислити";
            this.button_obch.UseVisualStyleBackColor = false;
            this.button_obch.Click += new System.EventHandler(this.Button_obch_Click);
            // 
            // textBox_x
            // 
            this.textBox_x.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_x.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_x.Location = new System.Drawing.Point(146, 26);
            this.textBox_x.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(296, 40);
            this.textBox_x.TabIndex = 5;
            // 
            // textBox_y
            // 
            this.textBox_y.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_y.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_y.Location = new System.Drawing.Point(146, 80);
            this.textBox_y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(296, 40);
            this.textBox_y.TabIndex = 6;
            // 
            // textBox_z
            // 
            this.textBox_z.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_z.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_z.Location = new System.Drawing.Point(146, 138);
            this.textBox_z.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_z.Name = "textBox_z";
            this.textBox_z.Size = new System.Drawing.Size(296, 40);
            this.textBox_z.TabIndex = 7;
            // 
            // textBox_r
            // 
            this.textBox_r.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_r.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_r.Location = new System.Drawing.Point(146, 298);
            this.textBox_r.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_r.Name = "textBox_r";
            this.textBox_r.ReadOnly = true;
            this.textBox_r.Size = new System.Drawing.Size(296, 40);
            this.textBox_r.TabIndex = 8;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(292, 378);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(275, 33);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Козакевич Н.О. ІПЗ-19-1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(590, 438);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBox_r);
            this.Controls.Add(this.textBox_z);
            this.Controls.Add(this.textBox_y);
            this.Controls.Add(this.textBox_x);
            this.Controls.Add(this.button_obch);
            this.Controls.Add(this.label_r);
            this.Controls.Add(this.label_z);
            this.Controls.Add(this.label_y);
            this.Controls.Add(this.label_x);
            this.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1260, 650);
            this.MinimumSize = new System.Drawing.Size(395, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практична робота №2, Завдання1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.Label label_z;
        private System.Windows.Forms.Label label_r;
        private System.Windows.Forms.Button button_obch;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.TextBox textBox_z;
        private System.Windows.Forms.TextBox textBox_r;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

