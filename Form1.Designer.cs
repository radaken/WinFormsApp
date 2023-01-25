namespace WinFormsApp
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
            this.button_ВыписатьШтраф = new System.Windows.Forms.Button();
            this.button_ПройтиТО = new System.Windows.Forms.Button();
            this.button_получитьДанныеОбАвто = new System.Windows.Forms.Button();
            this.button_получитьФИО = new System.Windows.Forms.Button();
            this.button_продатьАвто = new System.Windows.Forms.Button();
            this.textBox_марка = new System.Windows.Forms.TextBox();
            this.label_марка = new System.Windows.Forms.Label();
            this.label_модель = new System.Windows.Forms.Label();
            this.textBox_модель = new System.Windows.Forms.TextBox();
            this.label_годВыпуска = new System.Windows.Forms.Label();
            this.textBox_годВыпуска = new System.Windows.Forms.TextBox();
            this.label_годТО = new System.Windows.Forms.Label();
            this.textBox_годТО = new System.Windows.Forms.TextBox();
            this.label_владелец = new System.Windows.Forms.Label();
            this.textBox_ФИОВладельца = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.carDBBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WinFormsApp.Database1DataSet();
            this.carDBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carDBTableAdapter = new WinFormsApp.Database1DataSetTableAdapters.carDBTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label_fineamount = new System.Windows.Forms.Label();
            this.btn_Создать = new System.Windows.Forms.Button();
            this.btn_Очистить = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carDBBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDBBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ВыписатьШтраф
            // 
            this.button_ВыписатьШтраф.Location = new System.Drawing.Point(23, 316);
            this.button_ВыписатьШтраф.Name = "button_ВыписатьШтраф";
            this.button_ВыписатьШтраф.Size = new System.Drawing.Size(124, 45);
            this.button_ВыписатьШтраф.TabIndex = 0;
            this.button_ВыписатьШтраф.Text = "Выписать штраф";
            this.button_ВыписатьШтраф.UseVisualStyleBackColor = true;
            this.button_ВыписатьШтраф.Click += new System.EventHandler(this.button_ВыписатьШтраф_Click);
            // 
            // button_ПройтиТО
            // 
            this.button_ПройтиТО.Location = new System.Drawing.Point(153, 316);
            this.button_ПройтиТО.Name = "button_ПройтиТО";
            this.button_ПройтиТО.Size = new System.Drawing.Size(118, 45);
            this.button_ПройтиТО.TabIndex = 1;
            this.button_ПройтиТО.Text = "Пройти ТО";
            this.button_ПройтиТО.UseVisualStyleBackColor = true;
            this.button_ПройтиТО.Click += new System.EventHandler(this.button_ПройтиТО_Click);
            // 
            // button_получитьДанныеОбАвто
            // 
            this.button_получитьДанныеОбАвто.Location = new System.Drawing.Point(26, 459);
            this.button_получитьДанныеОбАвто.Name = "button_получитьДанныеОбАвто";
            this.button_получитьДанныеОбАвто.Size = new System.Drawing.Size(248, 46);
            this.button_получитьДанныеОбАвто.TabIndex = 2;
            this.button_получитьДанныеОбАвто.Text = "Получить данные об авто";
            this.button_получитьДанныеОбАвто.UseVisualStyleBackColor = true;
            this.button_получитьДанныеОбАвто.Click += new System.EventHandler(this.button_получитьДанныеОбАвто_Click);
            // 
            // button_получитьФИО
            // 
            this.button_получитьФИО.Location = new System.Drawing.Point(153, 367);
            this.button_получитьФИО.Name = "button_получитьФИО";
            this.button_получитьФИО.Size = new System.Drawing.Size(118, 45);
            this.button_получитьФИО.TabIndex = 3;
            this.button_получитьФИО.Text = "Получить ФИО владельца";
            this.button_получитьФИО.UseVisualStyleBackColor = true;
            this.button_получитьФИО.Click += new System.EventHandler(this.button_получитьФИО_Click);
            // 
            // button_продатьАвто
            // 
            this.button_продатьАвто.Location = new System.Drawing.Point(23, 367);
            this.button_продатьАвто.Name = "button_продатьАвто";
            this.button_продатьАвто.Size = new System.Drawing.Size(124, 45);
            this.button_продатьАвто.TabIndex = 4;
            this.button_продатьАвто.Text = "Продать авто";
            this.button_продатьАвто.UseVisualStyleBackColor = true;
            this.button_продатьАвто.Click += new System.EventHandler(this.button_продатьАвто_Click);
            // 
            // textBox_марка
            // 
            this.textBox_марка.Location = new System.Drawing.Point(23, 40);
            this.textBox_марка.Name = "textBox_марка";
            this.textBox_марка.Size = new System.Drawing.Size(248, 20);
            this.textBox_марка.TabIndex = 5;
            this.textBox_марка.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_марка
            // 
            this.label_марка.AutoSize = true;
            this.label_марка.Location = new System.Drawing.Point(23, 21);
            this.label_марка.Name = "label_марка";
            this.label_марка.Size = new System.Drawing.Size(40, 13);
            this.label_марка.TabIndex = 6;
            this.label_марка.Text = "Марка";
            // 
            // label_модель
            // 
            this.label_модель.AutoSize = true;
            this.label_модель.Location = new System.Drawing.Point(23, 71);
            this.label_модель.Name = "label_модель";
            this.label_модель.Size = new System.Drawing.Size(46, 13);
            this.label_модель.TabIndex = 8;
            this.label_модель.Text = "Модель";
            // 
            // textBox_модель
            // 
            this.textBox_модель.Location = new System.Drawing.Point(23, 90);
            this.textBox_модель.Name = "textBox_модель";
            this.textBox_модель.Size = new System.Drawing.Size(248, 20);
            this.textBox_модель.TabIndex = 7;
            this.textBox_модель.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_годВыпуска
            // 
            this.label_годВыпуска.AutoSize = true;
            this.label_годВыпуска.Location = new System.Drawing.Point(23, 120);
            this.label_годВыпуска.Name = "label_годВыпуска";
            this.label_годВыпуска.Size = new System.Drawing.Size(71, 13);
            this.label_годВыпуска.TabIndex = 10;
            this.label_годВыпуска.Text = "Год выпуска";
            // 
            // textBox_годВыпуска
            // 
            this.textBox_годВыпуска.Location = new System.Drawing.Point(23, 139);
            this.textBox_годВыпуска.Name = "textBox_годВыпуска";
            this.textBox_годВыпуска.Size = new System.Drawing.Size(248, 20);
            this.textBox_годВыпуска.TabIndex = 9;
            this.textBox_годВыпуска.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_годТО
            // 
            this.label_годТО.AutoSize = true;
            this.label_годТО.Location = new System.Drawing.Point(23, 174);
            this.label_годТО.Name = "label_годТО";
            this.label_годТО.Size = new System.Drawing.Size(113, 13);
            this.label_годТО.TabIndex = 12;
            this.label_годТО.Text = "Год прохождения ТО";
            // 
            // textBox_годТО
            // 
            this.textBox_годТО.Location = new System.Drawing.Point(23, 193);
            this.textBox_годТО.Name = "textBox_годТО";
            this.textBox_годТО.Size = new System.Drawing.Size(248, 20);
            this.textBox_годТО.TabIndex = 11;
            this.textBox_годТО.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_владелец
            // 
            this.label_владелец.AutoSize = true;
            this.label_владелец.Location = new System.Drawing.Point(23, 230);
            this.label_владелец.Name = "label_владелец";
            this.label_владелец.Size = new System.Drawing.Size(92, 13);
            this.label_владелец.TabIndex = 14;
            this.label_владелец.Text = "ФИО Владельца";
            // 
            // textBox_ФИОВладельца
            // 
            this.textBox_ФИОВладельца.Location = new System.Drawing.Point(23, 249);
            this.textBox_ФИОВладельца.Name = "textBox_ФИОВладельца";
            this.textBox_ФИОВладельца.Size = new System.Drawing.Size(248, 20);
            this.textBox_ФИОВладельца.TabIndex = 13;
            this.textBox_ФИОВладельца.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.carDBBindingSource2;
            this.comboBox1.DisplayMember = "Id";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 428);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "Id";
            // 
            // carDBBindingSource2
            // 
            this.carDBBindingSource2.DataMember = "carDB";
            this.carDBBindingSource2.DataSource = this.database1DataSetBindingSource;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carDBBindingSource1
            // 
            this.carDBBindingSource1.DataMember = "carDB";
            this.carDBBindingSource1.DataSource = this.database1DataSetBindingSource;
            // 
            // carDBBindingSource
            // 
            this.carDBBindingSource.DataMember = "carDB";
            this.carDBBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // carDBTableAdapter
            // 
            this.carDBTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Сумма штрафов:";
            // 
            // label_fineamount
            // 
            this.label_fineamount.AutoSize = true;
            this.label_fineamount.Location = new System.Drawing.Point(121, 285);
            this.label_fineamount.Name = "label_fineamount";
            this.label_fineamount.Size = new System.Drawing.Size(0, 13);
            this.label_fineamount.TabIndex = 17;
            // 
            // btn_Создать
            // 
            this.btn_Создать.Location = new System.Drawing.Point(153, 511);
            this.btn_Создать.Name = "btn_Создать";
            this.btn_Создать.Size = new System.Drawing.Size(121, 46);
            this.btn_Создать.TabIndex = 18;
            this.btn_Создать.Text = "Создать новый";
            this.btn_Создать.UseVisualStyleBackColor = true;
            this.btn_Создать.Click += new System.EventHandler(this.btn_Создать_Click);
            // 
            // btn_Очистить
            // 
            this.btn_Очистить.Location = new System.Drawing.Point(26, 511);
            this.btn_Очистить.Name = "btn_Очистить";
            this.btn_Очистить.Size = new System.Drawing.Size(121, 46);
            this.btn_Очистить.TabIndex = 19;
            this.btn_Очистить.Text = "Очистить форму";
            this.btn_Очистить.UseVisualStyleBackColor = true;
            this.btn_Очистить.Click += new System.EventHandler(this.btn_Очистить_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 569);
            this.Controls.Add(this.btn_Очистить);
            this.Controls.Add(this.btn_Создать);
            this.Controls.Add(this.label_fineamount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_владелец);
            this.Controls.Add(this.textBox_ФИОВладельца);
            this.Controls.Add(this.label_годТО);
            this.Controls.Add(this.textBox_годТО);
            this.Controls.Add(this.label_годВыпуска);
            this.Controls.Add(this.textBox_годВыпуска);
            this.Controls.Add(this.label_модель);
            this.Controls.Add(this.textBox_модель);
            this.Controls.Add(this.label_марка);
            this.Controls.Add(this.textBox_марка);
            this.Controls.Add(this.button_продатьАвто);
            this.Controls.Add(this.button_получитьФИО);
            this.Controls.Add(this.button_получитьДанныеОбАвто);
            this.Controls.Add(this.button_ПройтиТО);
            this.Controls.Add(this.button_ВыписатьШтраф);
            this.Name = "Form1";
            this.Text = "WinFormsApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carDBBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDBBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ВыписатьШтраф;
        private System.Windows.Forms.Button button_ПройтиТО;
        private System.Windows.Forms.Button button_получитьДанныеОбАвто;
        private System.Windows.Forms.Button button_получитьФИО;
        private System.Windows.Forms.Button button_продатьАвто;
        private System.Windows.Forms.TextBox textBox_марка;
        private System.Windows.Forms.Label label_марка;
        private System.Windows.Forms.Label label_модель;
        private System.Windows.Forms.TextBox textBox_модель;
        private System.Windows.Forms.Label label_годВыпуска;
        private System.Windows.Forms.TextBox textBox_годВыпуска;
        private System.Windows.Forms.Label label_годТО;
        private System.Windows.Forms.TextBox textBox_годТО;
        private System.Windows.Forms.Label label_владелец;
        private System.Windows.Forms.TextBox textBox_ФИОВладельца;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource carDBBindingSource;
        private Database1DataSetTableAdapters.carDBTableAdapter carDBTableAdapter;
        private System.Windows.Forms.BindingSource carDBBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_fineamount;
        private System.Windows.Forms.Button btn_Создать;
        private System.Windows.Forms.Button btn_Очистить;
        private System.Windows.Forms.BindingSource carDBBindingSource2;
    }
}