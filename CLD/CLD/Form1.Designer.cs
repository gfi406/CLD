namespace CLD
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.InputData = new System.Windows.Forms.TextBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.TableBox = new System.Windows.Forms.ComboBox();
            this.CellsBox = new System.Windows.Forms.ComboBox();
            this.CellsBox2 = new System.Windows.Forms.ComboBox();
            this.ModeBox = new System.Windows.Forms.ComboBox();
            this.ConditionBox = new System.Windows.Forms.TextBox();
            this.testlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HelpSearchBox = new System.Windows.Forms.ComboBox();
            this.HelpBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 62);
            this.button2.TabIndex = 2;
            this.button2.Text = "Запрос";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.zapros_Click);
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(13, 12);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(858, 343);
            this.DGV.TabIndex = 3;
            // 
            // InputData
            // 
            this.InputData.Location = new System.Drawing.Point(165, 483);
            this.InputData.Name = "InputData";
            this.InputData.Size = new System.Drawing.Size(186, 20);
            this.InputData.TabIndex = 5;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(12, 370);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(132, 62);
            this.update_btn.TabIndex = 6;
            this.update_btn.Text = "Обновить";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // TableBox
            // 
            this.TableBox.FormattingEnabled = true;
            this.TableBox.Location = new System.Drawing.Point(165, 361);
            this.TableBox.Name = "TableBox";
            this.TableBox.Size = new System.Drawing.Size(172, 21);
            this.TableBox.TabIndex = 7;
            // 
            // CellsBox
            // 
            this.CellsBox.FormattingEnabled = true;
            this.CellsBox.Location = new System.Drawing.Point(165, 437);
            this.CellsBox.Name = "CellsBox";
            this.CellsBox.Size = new System.Drawing.Size(186, 21);
            this.CellsBox.TabIndex = 8;
            // 
            // CellsBox2
            // 
            this.CellsBox2.FormattingEnabled = true;
            this.CellsBox2.Location = new System.Drawing.Point(357, 437);
            this.CellsBox2.Name = "CellsBox2";
            this.CellsBox2.Size = new System.Drawing.Size(186, 21);
            this.CellsBox2.TabIndex = 10;
            // 
            // ModeBox
            // 
            this.ModeBox.FormattingEnabled = true;
            this.ModeBox.Location = new System.Drawing.Point(165, 388);
            this.ModeBox.Name = "ModeBox";
            this.ModeBox.Size = new System.Drawing.Size(172, 21);
            this.ModeBox.TabIndex = 9;
            // 
            // ConditionBox
            // 
            this.ConditionBox.Location = new System.Drawing.Point(357, 482);
            this.ConditionBox.Name = "ConditionBox";
            this.ConditionBox.Size = new System.Drawing.Size(186, 20);
            this.ConditionBox.TabIndex = 11;
            // 
            // testlabel
            // 
            this.testlabel.AutoSize = true;
            this.testlabel.Location = new System.Drawing.Point(12, 533);
            this.testlabel.Name = "testlabel";
            this.testlabel.Size = new System.Drawing.Size(0, 13);
            this.testlabel.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "=";
            // 
            // HelpSearchBox
            // 
            this.HelpSearchBox.FormattingEnabled = true;
            this.HelpSearchBox.Location = new System.Drawing.Point(357, 361);
            this.HelpSearchBox.Name = "HelpSearchBox";
            this.HelpSearchBox.Size = new System.Drawing.Size(172, 21);
            this.HelpSearchBox.TabIndex = 17;
            // 
            // HelpBox
            // 
            this.HelpBox.FormattingEnabled = true;
            this.HelpBox.Location = new System.Drawing.Point(357, 388);
            this.HelpBox.Name = "HelpBox";
            this.HelpBox.Size = new System.Drawing.Size(172, 21);
            this.HelpBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 568);
            this.Controls.Add(this.HelpBox);
            this.Controls.Add(this.HelpSearchBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testlabel);
            this.Controls.Add(this.ConditionBox);
            this.Controls.Add(this.CellsBox2);
            this.Controls.Add(this.ModeBox);
            this.Controls.Add(this.CellsBox);
            this.Controls.Add(this.TableBox);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.InputData);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.TextBox InputData;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.ComboBox TableBox;
        private System.Windows.Forms.ComboBox CellsBox;
        private System.Windows.Forms.ComboBox CellsBox2;
        private System.Windows.Forms.ComboBox ModeBox;
        private System.Windows.Forms.TextBox ConditionBox;
        private System.Windows.Forms.Label testlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox HelpSearchBox;
        private System.Windows.Forms.ComboBox HelpBox;
    }
}

