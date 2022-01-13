namespace New_KR_1
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFaultModeling = new System.Windows.Forms.Button();
            this.buttonCalcAttenuation = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.dragControl1 = new New_KR_1.DragControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.Wheat;
            this.buttonExit.Location = new System.Drawing.Point(600, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(55, 25);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 25);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonFaultModeling);
            this.panel2.Controls.Add(this.buttonCalcAttenuation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 25);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сеть бизнес центра";
            // 
            // buttonFaultModeling
            // 
            this.buttonFaultModeling.FlatAppearance.BorderSize = 0;
            this.buttonFaultModeling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFaultModeling.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFaultModeling.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonFaultModeling.Location = new System.Drawing.Point(400, 0);
            this.buttonFaultModeling.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFaultModeling.Name = "buttonFaultModeling";
            this.buttonFaultModeling.Size = new System.Drawing.Size(255, 25);
            this.buttonFaultModeling.TabIndex = 3;
            this.buttonFaultModeling.Text = "Моделирование повреждений сети";
            this.buttonFaultModeling.UseVisualStyleBackColor = true;
            this.buttonFaultModeling.Click += new System.EventHandler(this.buttonFaultModeling_Click);
            // 
            // buttonCalcAttenuation
            // 
            this.buttonCalcAttenuation.BackColor = System.Drawing.Color.Wheat;
            this.buttonCalcAttenuation.FlatAppearance.BorderSize = 0;
            this.buttonCalcAttenuation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalcAttenuation.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcAttenuation.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonCalcAttenuation.Location = new System.Drawing.Point(145, 0);
            this.buttonCalcAttenuation.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCalcAttenuation.Name = "buttonCalcAttenuation";
            this.buttonCalcAttenuation.Size = new System.Drawing.Size(255, 25);
            this.buttonCalcAttenuation.TabIndex = 3;
            this.buttonCalcAttenuation.Text = "Расчёт затуханий в сети";
            this.buttonCalcAttenuation.UseVisualStyleBackColor = false;
            this.buttonCalcAttenuation.Click += new System.EventHandler(this.buttonCalcAttenuation_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 50);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(655, 350);
            this.panelContainer.TabIndex = 3;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panel1;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(655, 400);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCalcAttenuation;
        private System.Windows.Forms.Button buttonFaultModeling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DragControl dragControl1;
        private System.Windows.Forms.Panel panelContainer;
    }
}

