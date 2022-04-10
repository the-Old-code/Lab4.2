
namespace OOP_42
{
    partial class Form_main
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
            this.tb_A = new System.Windows.Forms.TextBox();
            this.tb_B = new System.Windows.Forms.TextBox();
            this.tb_C = new System.Windows.Forms.TextBox();
            this.num_A = new System.Windows.Forms.NumericUpDown();
            this.num_B = new System.Windows.Forms.NumericUpDown();
            this.num_C = new System.Windows.Forms.NumericUpDown();
            this.track_A = new System.Windows.Forms.TrackBar();
            this.track_B = new System.Windows.Forms.TrackBar();
            this.track_C = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.num_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_C)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_A
            // 
            this.tb_A.Location = new System.Drawing.Point(139, 156);
            this.tb_A.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_A.Name = "tb_A";
            this.tb_A.Size = new System.Drawing.Size(133, 22);
            this.tb_A.TabIndex = 0;
            this.tb_A.Text = "0";
            this.tb_A.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_A_KeyDown);
            // 
            // tb_B
            // 
            this.tb_B.Location = new System.Drawing.Point(364, 156);
            this.tb_B.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_B.Name = "tb_B";
            this.tb_B.Size = new System.Drawing.Size(133, 22);
            this.tb_B.TabIndex = 1;
            this.tb_B.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_B_KeyDown);
            // 
            // tb_C
            // 
            this.tb_C.Location = new System.Drawing.Point(597, 156);
            this.tb_C.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_C.Name = "tb_C";
            this.tb_C.Size = new System.Drawing.Size(133, 22);
            this.tb_C.TabIndex = 2;
            this.tb_C.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_C_KeyDown);
            // 
            // num_A
            // 
            this.num_A.Location = new System.Drawing.Point(139, 218);
            this.num_A.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num_A.Name = "num_A";
            this.num_A.Size = new System.Drawing.Size(135, 22);
            this.num_A.TabIndex = 3;
            this.num_A.ValueChanged += new System.EventHandler(this.num_A_ValueChanged);
            // 
            // num_B
            // 
            this.num_B.Location = new System.Drawing.Point(364, 218);
            this.num_B.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num_B.Name = "num_B";
            this.num_B.Size = new System.Drawing.Size(135, 22);
            this.num_B.TabIndex = 4;
            this.num_B.ValueChanged += new System.EventHandler(this.num_B_ValueChanged);
            // 
            // num_C
            // 
            this.num_C.Location = new System.Drawing.Point(597, 218);
            this.num_C.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num_C.Name = "num_C";
            this.num_C.Size = new System.Drawing.Size(135, 22);
            this.num_C.TabIndex = 5;
            this.num_C.ValueChanged += new System.EventHandler(this.num_C_ValueChanged);
            // 
            // track_A
            // 
            this.track_A.LargeChange = 50;
            this.track_A.Location = new System.Drawing.Point(139, 279);
            this.track_A.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.track_A.Maximum = 100;
            this.track_A.Name = "track_A";
            this.track_A.Size = new System.Drawing.Size(135, 56);
            this.track_A.SmallChange = 10;
            this.track_A.TabIndex = 6;
            this.track_A.Scroll += new System.EventHandler(this.track_A_Scroll);
            // 
            // track_B
            // 
            this.track_B.Location = new System.Drawing.Point(364, 279);
            this.track_B.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.track_B.Maximum = 100;
            this.track_B.Name = "track_B";
            this.track_B.Size = new System.Drawing.Size(135, 56);
            this.track_B.TabIndex = 7;
            this.track_B.Scroll += new System.EventHandler(this.track_B_Scroll);
            // 
            // track_C
            // 
            this.track_C.Location = new System.Drawing.Point(597, 279);
            this.track_C.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.track_C.Maximum = 100;
            this.track_C.Name = "track_C";
            this.track_C.Size = new System.Drawing.Size(135, 56);
            this.track_C.TabIndex = 8;
            this.track_C.Scroll += new System.EventHandler(this.track_C_Scroll);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 418);
            this.Controls.Add(this.track_C);
            this.Controls.Add(this.track_B);
            this.Controls.Add(this.track_A);
            this.Controls.Add(this.num_C);
            this.Controls.Add(this.num_B);
            this.Controls.Add(this.num_A);
            this.Controls.Add(this.tb_C);
            this.Controls.Add(this.tb_B);
            this.Controls.Add(this.tb_A);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_main";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.num_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_C)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_A;
        private System.Windows.Forms.TextBox tb_B;
        private System.Windows.Forms.TextBox tb_C;
        private System.Windows.Forms.NumericUpDown num_A;
        private System.Windows.Forms.NumericUpDown num_B;
        private System.Windows.Forms.NumericUpDown num_C;
        private System.Windows.Forms.TrackBar track_A;
        private System.Windows.Forms.TrackBar track_B;
        private System.Windows.Forms.TrackBar track_C;
    }
}

