namespace Diary
{
    partial class ModifyEvent
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
            this.txtmodi = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmodiname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtmodidate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbmodiimportantevent = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmodidescription = new System.Windows.Forms.TextBox();
            this.modibtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Event ID";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtmodi
            // 
            this.txtmodi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtmodi.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodi.Location = new System.Drawing.Point(207, 37);
            this.txtmodi.Name = "txtmodi";
            this.txtmodi.Size = new System.Drawing.Size(319, 29);
            this.txtmodi.TabIndex = 9;
            this.txtmodi.TextChanged += new System.EventHandler(this.Txtmodi_TextChanged);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(572, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 44);
            this.button4.TabIndex = 11;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Event Name";
            // 
            // txtmodiname
            // 
            this.txtmodiname.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtmodiname.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodiname.Location = new System.Drawing.Point(207, 93);
            this.txtmodiname.Name = "txtmodiname";
            this.txtmodiname.Size = new System.Drawing.Size(592, 29);
            this.txtmodiname.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Event Date";
            // 
            // dtmodidate
            // 
            this.dtmodidate.Location = new System.Drawing.Point(207, 162);
            this.dtmodidate.Name = "dtmodidate";
            this.dtmodidate.Size = new System.Drawing.Size(200, 20);
            this.dtmodidate.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Importancy of the Event";
            // 
            // cbmodiimportantevent
            // 
            this.cbmodiimportantevent.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cbmodiimportantevent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmodiimportantevent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmodiimportantevent.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cbmodiimportantevent.FormattingEnabled = true;
            this.cbmodiimportantevent.Items.AddRange(new object[] {
            "High",
            "Moderate",
            "Less Important"});
            this.cbmodiimportantevent.Location = new System.Drawing.Point(326, 241);
            this.cbmodiimportantevent.Name = "cbmodiimportantevent";
            this.cbmodiimportantevent.Size = new System.Drawing.Size(121, 21);
            this.cbmodiimportantevent.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Description";
            // 
            // txtmodidescription
            // 
            this.txtmodidescription.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtmodidescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmodidescription.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodidescription.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtmodidescription.Location = new System.Drawing.Point(189, 279);
            this.txtmodidescription.Multiline = true;
            this.txtmodidescription.Name = "txtmodidescription";
            this.txtmodidescription.Size = new System.Drawing.Size(574, 93);
            this.txtmodidescription.TabIndex = 19;
            // 
            // modibtn
            // 
            this.modibtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.modibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modibtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modibtn.Location = new System.Drawing.Point(642, 394);
            this.modibtn.Name = "modibtn";
            this.modibtn.Size = new System.Drawing.Size(121, 44);
            this.modibtn.TabIndex = 20;
            this.modibtn.Text = "Confirm";
            this.modibtn.UseVisualStyleBackColor = true;
            this.modibtn.Click += new System.EventHandler(this.Modibtn_Click);
            // 
            // ModifyEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.modibtn);
            this.Controls.Add(this.txtmodidescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbmodiimportantevent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtmodidate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmodiname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtmodi);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Name = "ModifyEvent";
            this.Text = "ModifyEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmodi;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmodiname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtmodidate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbmodiimportantevent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmodidescription;
        private System.Windows.Forms.Button modibtn;
    }
}