namespace WinFormsApp
{
    partial class Пройти_ТехОсмотр
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
            this.ТОФорма_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ТОФорма_btn_пройти = new System.Windows.Forms.Button();
            this.ТОФорма_btn_неПрошёл = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ТОФорма_textBox
            // 
            this.ТОФорма_textBox.Location = new System.Drawing.Point(15, 48);
            this.ТОФорма_textBox.Name = "ТОФорма_textBox";
            this.ТОФорма_textBox.Size = new System.Drawing.Size(165, 20);
            this.ТОФорма_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Год следующего техосмотра";
            // 
            // ТОФорма_btn_пройти
            // 
            this.ТОФорма_btn_пройти.BackColor = System.Drawing.Color.ForestGreen;
            this.ТОФорма_btn_пройти.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ТОФорма_btn_пройти.Location = new System.Drawing.Point(15, 93);
            this.ТОФорма_btn_пройти.Name = "ТОФорма_btn_пройти";
            this.ТОФорма_btn_пройти.Size = new System.Drawing.Size(75, 23);
            this.ТОФорма_btn_пройти.TabIndex = 2;
            this.ТОФорма_btn_пройти.Text = "Пройти";
            this.ТОФорма_btn_пройти.UseVisualStyleBackColor = false;
            this.ТОФорма_btn_пройти.Click += new System.EventHandler(this.ТОФорма_btn_пройти_Click);
            // 
            // ТОФорма_btn_неПрошёл
            // 
            this.ТОФорма_btn_неПрошёл.BackColor = System.Drawing.Color.Red;
            this.ТОФорма_btn_неПрошёл.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ТОФорма_btn_неПрошёл.Location = new System.Drawing.Point(105, 93);
            this.ТОФорма_btn_неПрошёл.Name = "ТОФорма_btn_неПрошёл";
            this.ТОФорма_btn_неПрошёл.Size = new System.Drawing.Size(75, 23);
            this.ТОФорма_btn_неПрошёл.TabIndex = 3;
            this.ТОФорма_btn_неПрошёл.Text = "Не прошёл";
            this.ТОФорма_btn_неПрошёл.UseVisualStyleBackColor = false;
            this.ТОФорма_btn_неПрошёл.Click += new System.EventHandler(this.button2_Click);
            // 
            // Пройти_ТехОсмотр
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 144);
            this.Controls.Add(this.ТОФорма_btn_неПрошёл);
            this.Controls.Add(this.ТОФорма_btn_пройти);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ТОФорма_textBox);
            this.Name = "Пройти_ТехОсмотр";
            this.Text = "Пройти техосмотр";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ТОФорма_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ТОФорма_btn_пройти;
        private System.Windows.Forms.Button ТОФорма_btn_неПрошёл;
    }
}