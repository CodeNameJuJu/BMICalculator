
namespace BMICalc
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
            this.label1 = new System.Windows.Forms.Label();
            this.IDlbl = new System.Windows.Forms.Label();
            this.heightlbl = new System.Windows.Forms.Label();
            this.weightlbl = new System.Windows.Forms.Label();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.HeightTxt = new System.Windows.Forms.TextBox();
            this.WeightTxt = new System.Windows.Forms.TextBox();
            this.CalBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.patientInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Srchbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMI Calculator";
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Location = new System.Drawing.Point(79, 81);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(73, 17);
            this.IDlbl.TabIndex = 1;
            this.IDlbl.Text = "Patient ID:";
            // 
            // heightlbl
            // 
            this.heightlbl.AutoSize = true;
            this.heightlbl.Location = new System.Drawing.Point(79, 112);
            this.heightlbl.Name = "heightlbl";
            this.heightlbl.Size = new System.Drawing.Size(74, 17);
            this.heightlbl.TabIndex = 2;
            this.heightlbl.Text = "Height(m):";
            // 
            // weightlbl
            // 
            this.weightlbl.AutoSize = true;
            this.weightlbl.Location = new System.Drawing.Point(79, 140);
            this.weightlbl.Name = "weightlbl";
            this.weightlbl.Size = new System.Drawing.Size(56, 17);
            this.weightlbl.TabIndex = 3;
            this.weightlbl.Text = "Weight:";
            // 
            // IdTxt
            // 
            this.IdTxt.Location = new System.Drawing.Point(178, 78);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(153, 22);
            this.IdTxt.TabIndex = 4;
            this.IdTxt.Validating += new System.ComponentModel.CancelEventHandler(this.IdTxt_Validating);
            // 
            // HeightTxt
            // 
            this.HeightTxt.Location = new System.Drawing.Point(178, 109);
            this.HeightTxt.Name = "HeightTxt";
            this.HeightTxt.Size = new System.Drawing.Size(153, 22);
            this.HeightTxt.TabIndex = 5;
            this.HeightTxt.Validating += new System.ComponentModel.CancelEventHandler(this.HeightTxt_Validating);
            // 
            // WeightTxt
            // 
            this.WeightTxt.Location = new System.Drawing.Point(178, 137);
            this.WeightTxt.Name = "WeightTxt";
            this.WeightTxt.Size = new System.Drawing.Size(153, 22);
            this.WeightTxt.TabIndex = 6;
            this.WeightTxt.Validating += new System.ComponentModel.CancelEventHandler(this.WeightTxt_Validating);
            // 
            // CalBtn
            // 
            this.CalBtn.Location = new System.Drawing.Point(12, 195);
            this.CalBtn.Name = "CalBtn";
            this.CalBtn.Size = new System.Drawing.Size(94, 39);
            this.CalBtn.TabIndex = 7;
            this.CalBtn.Text = "Calculate";
            this.CalBtn.UseVisualStyleBackColor = true;
            this.CalBtn.Click += new System.EventHandler(this.CalBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(112, 195);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(107, 39);
            this.ClearBtn.TabIndex = 9;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // patientInfoBindingSource
            // 
            this.patientInfoBindingSource.DataMember = "PatientInfo";
            // 
            // Srchbtn
            // 
            this.Srchbtn.Location = new System.Drawing.Point(225, 195);
            this.Srchbtn.Name = "Srchbtn";
            this.Srchbtn.Size = new System.Drawing.Size(94, 39);
            this.Srchbtn.TabIndex = 11;
            this.Srchbtn.Text = "Search";
            this.Srchbtn.UseVisualStyleBackColor = true;
            this.Srchbtn.Click += new System.EventHandler(this.Srchbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 260);
            this.Controls.Add(this.Srchbtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CalBtn);
            this.Controls.Add(this.WeightTxt);
            this.Controls.Add(this.HeightTxt);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.weightlbl);
            this.Controls.Add(this.heightlbl);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.Label heightlbl;
        private System.Windows.Forms.Label weightlbl;
        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.TextBox HeightTxt;
        private System.Windows.Forms.TextBox WeightTxt;
        private System.Windows.Forms.Button CalBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.BindingSource patientInfoBindingSource;
        private System.Windows.Forms.Button Srchbtn;
    }
}

