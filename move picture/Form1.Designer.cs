namespace move_picture
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
            this.btnright = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnleft = new System.Windows.Forms.Button();
            this.btndown = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnright
            // 
            this.btnright.Location = new System.Drawing.Point(98, 3);
            this.btnright.Name = "btnright";
            this.btnright.Size = new System.Drawing.Size(90, 33);
            this.btnright.TabIndex = 1;
            this.btnright.Text = "Move right";
            this.btnright.UseVisualStyleBackColor = true;
            this.btnright.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::move_picture_1.Properties.Resources.liverpool;
            this.pictureBox1.Location = new System.Drawing.Point(324, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnleft
            // 
            this.btnleft.Location = new System.Drawing.Point(3, 3);
            this.btnleft.Name = "btnleft";
            this.btnleft.Size = new System.Drawing.Size(89, 33);
            this.btnleft.TabIndex = 2;
            this.btnleft.Text = "Move left";
            this.btnleft.UseVisualStyleBackColor = true;
            this.btnleft.Click += new System.EventHandler(this.button2_Click);
            // 
            // btndown
            // 
            this.btndown.Location = new System.Drawing.Point(3, 42);
            this.btndown.Name = "btndown";
            this.btndown.Size = new System.Drawing.Size(89, 41);
            this.btndown.TabIndex = 3;
            this.btndown.Text = "Move down";
            this.btndown.UseVisualStyleBackColor = true;
            this.btndown.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnup
            // 
            this.btnup.Location = new System.Drawing.Point(98, 42);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(90, 41);
            this.btnup.TabIndex = 4;
            this.btnup.Text = "Move up";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.button4_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnleft, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btndown, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnright, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnup, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.37037F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.62963F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(191, 86);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(931, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "rotateright";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnright;
        private System.Windows.Forms.Button btnleft;
        private System.Windows.Forms.Button btndown;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
    }
}

