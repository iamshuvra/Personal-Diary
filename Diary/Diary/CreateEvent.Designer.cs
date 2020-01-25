namespace Diary
{
    partial class CreateEvent
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtename = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.dtedate = new System.Windows.Forms.DateTimePicker();
            this.cbimportantevent = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Event Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Event Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Importancy of the Event";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Description";
            // 
            // txtename
            // 
            this.txtename.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtename.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtename.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtename.Location = new System.Drawing.Point(191, 87);
            this.txtename.Multiline = true;
            this.txtename.Name = "txtename";
            this.txtename.Size = new System.Drawing.Size(592, 25);
            this.txtename.TabIndex = 9;
            this.txtename.TextChanged += new System.EventHandler(this.Txtename_TextChanged);
            // 
            // txtdescription
            // 
            this.txtdescription.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtdescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdescription.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescription.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtdescription.Location = new System.Drawing.Point(191, 295);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(574, 93);
            this.txtdescription.TabIndex = 10;
            // 
            // dtedate
            // 
            this.dtedate.CalendarForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtedate.CalendarMonthBackground = System.Drawing.Color.DarkSlateGray;
            this.dtedate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtedate.CalendarTrailingForeColor = System.Drawing.Color.Cyan;
            this.dtedate.Location = new System.Drawing.Point(326, 159);
            this.dtedate.Name = "dtedate";
            this.dtedate.Size = new System.Drawing.Size(200, 20);
            this.dtedate.TabIndex = 11;
            this.dtedate.ValueChanged += new System.EventHandler(this.Dtedate_ValueChanged);
            // 
            // cbimportantevent
            // 
            this.cbimportantevent.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cbimportantevent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbimportantevent.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cbimportantevent.FormattingEnabled = true;
            this.cbimportantevent.Items.AddRange(new object[] {
            "High",
            "Moderate",
            "Less Important"});
            this.cbimportantevent.Location = new System.Drawing.Point(326, 229);
            this.cbimportantevent.Name = "cbimportantevent";
            this.cbimportantevent.Size = new System.Drawing.Size(121, 21);
            this.cbimportantevent.TabIndex = 12;
            this.cbimportantevent.Text = "Select Item";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(632, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbimportantevent);
            this.Controls.Add(this.dtedate);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txtename);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Name = "CreateEvent";
            this.Text = "CreateEvent";
            this.Load += new System.EventHandler(this.CreateEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtename;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.DateTimePicker dtedate;
        private System.Windows.Forms.ComboBox cbimportantevent;
        private System.Windows.Forms.Button button1;
    }
}