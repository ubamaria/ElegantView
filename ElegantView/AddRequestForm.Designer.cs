
namespace ElegantView
{
    partial class AddRequestForm
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
            this.comboBoxProd = new System.Windows.Forms.ComboBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxCust = new System.Windows.Forms.TextBox();
            this.textBoxEx = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Продукция";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Заказчик";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Исполнитель";
            // 
            // comboBoxProd
            // 
            this.comboBoxProd.FormattingEnabled = true;
            this.comboBoxProd.Location = new System.Drawing.Point(118, 43);
            this.comboBoxProd.Name = "comboBoxProd";
            this.comboBoxProd.Size = new System.Drawing.Size(228, 24);
            this.comboBoxProd.TabIndex = 4;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(118, 74);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(228, 22);
            this.textBoxCount.TabIndex = 5;
            this.textBoxCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxCust
            // 
            this.textBoxCust.Location = new System.Drawing.Point(118, 103);
            this.textBoxCust.Name = "textBoxCust";
            this.textBoxCust.Size = new System.Drawing.Size(228, 22);
            this.textBoxCust.TabIndex = 6;
            // 
            // textBoxEx
            // 
            this.textBoxEx.Location = new System.Drawing.Point(118, 135);
            this.textBoxEx.Name = "textBoxEx";
            this.textBoxEx.Size = new System.Drawing.Size(228, 22);
            this.textBoxEx.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // AddRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 250);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxEx);
            this.Controls.Add(this.textBoxCust);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.comboBoxProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddRequestForm";
            this.Text = "Формирование заявки";
            this.Load += new System.EventHandler(this.AddRequestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxProd;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxCust;
        private System.Windows.Forms.TextBox textBoxEx;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}