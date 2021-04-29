
namespace ElegantView
{
    partial class AddProductionForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxKind = new System.Windows.Forms.TextBox();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вид";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Размер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Цвет";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(132, 36);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(176, 22);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxKind
            // 
            this.textBoxKind.Location = new System.Drawing.Point(132, 64);
            this.textBoxKind.Name = "textBoxKind";
            this.textBoxKind.Size = new System.Drawing.Size(176, 22);
            this.textBoxKind.TabIndex = 6;
            // 
            // textBoxGender
            // 
            this.textBoxGender.Location = new System.Drawing.Point(132, 92);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.Size = new System.Drawing.Size(176, 22);
            this.textBoxGender.TabIndex = 7;
            this.textBoxGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(132, 120);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(176, 22);
            this.textBoxSize.TabIndex = 8;
            this.textBoxSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(132, 150);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(176, 22);
            this.textBoxColor.TabIndex = 9;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(175, 190);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(132, 29);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AddProductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 237);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.textBoxGender);
            this.Controls.Add(this.textBoxKind);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddProductionForm";
            this.Text = "Добавление продукции";
            this.Load += new System.EventHandler(this.AddProductionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxKind;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Button buttonAdd;
    }
}