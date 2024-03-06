namespace LV1
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
            this.lb1_vrijeme = new System.Windows.Forms.Label();
            this.btn_start_stop = new System.Windows.Forms.Button();
            this.lbReadItems = new System.Windows.Forms.ListBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.lbWarning = new System.Windows.Forms.Label();
            this.textBoxHour = new System.Windows.Forms.TextBox();
            this.textBoxMinute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb1_vrijeme
            // 
            this.lb1_vrijeme.AutoSize = true;
            this.lb1_vrijeme.Font = new System.Drawing.Font("Segoe UI", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb1_vrijeme.Location = new System.Drawing.Point(56, 51);
            this.lb1_vrijeme.Name = "lb1_vrijeme";
            this.lb1_vrijeme.Size = new System.Drawing.Size(201, 71);
            this.lb1_vrijeme.TabIndex = 0;
            this.lb1_vrijeme.Text = "vrijeme";
            // 
            // btn_start_stop
            // 
            this.btn_start_stop.Location = new System.Drawing.Point(584, 353);
            this.btn_start_stop.Name = "btn_start_stop";
            this.btn_start_stop.Size = new System.Drawing.Size(136, 49);
            this.btn_start_stop.TabIndex = 1;
            this.btn_start_stop.Text = "Pokreni";
            this.btn_start_stop.UseVisualStyleBackColor = true;
            this.btn_start_stop.Click += new System.EventHandler(this.btn_start_stop_Click);
            // 
            // lbReadItems
            // 
            this.lbReadItems.FormattingEnabled = true;
            this.lbReadItems.ItemHeight = 20;
            this.lbReadItems.Location = new System.Drawing.Point(374, 51);
            this.lbReadItems.Name = "lbReadItems";
            this.lbReadItems.Size = new System.Drawing.Size(346, 264);
            this.lbReadItems.TabIndex = 2;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(74, 182);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(125, 27);
            this.textBoxInput.TabIndex = 3;
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.Location = new System.Drawing.Point(74, 382);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(50, 20);
            this.lbWarning.TabIndex = 4;
            this.lbWarning.Text = "label1";
            // 
            // textBoxHour
            // 
            this.textBoxHour.Location = new System.Drawing.Point(144, 255);
            this.textBoxHour.Name = "textBoxHour";
            this.textBoxHour.Size = new System.Drawing.Size(50, 27);
            this.textBoxHour.TabIndex = 5;
            // 
            // textBoxMinute
            // 
            this.textBoxMinute.Location = new System.Drawing.Point(144, 288);
            this.textBoxMinute.Name = "textBoxMinute";
            this.textBoxMinute.Size = new System.Drawing.Size(51, 27);
            this.textBoxMinute.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Critical value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hours:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Minutes:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMinute);
            this.Controls.Add(this.textBoxHour);
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.lbReadItems);
            this.Controls.Add(this.btn_start_stop);
            this.Controls.Add(this.lb1_vrijeme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb1_vrijeme;
        private Button btn_start_stop;
        private ListBox lbReadItems;
        private TextBox textBoxInput;
        private Label lbWarning;
        private TextBox textBoxHour;
        private TextBox textBoxMinute;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}