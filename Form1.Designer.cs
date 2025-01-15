namespace no_me_truene
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DISPOSITIVOS = new System.Windows.Forms.ToolStripDropDownButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cOMPUTADORAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sMARTPHONEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tABLETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSeparator1,
            this.DISPOSITIVOS});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(294, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarToolStripMenuItem,
            this.agendarToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borrarToolStripMenuItem.Text = "Borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // DISPOSITIVOS
            // 
            this.DISPOSITIVOS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DISPOSITIVOS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOMPUTADORAToolStripMenuItem,
            this.sMARTPHONEToolStripMenuItem,
            this.tABLETToolStripMenuItem,
            this.oTROToolStripMenuItem});
            this.DISPOSITIVOS.Image = ((System.Drawing.Image)(resources.GetObject("DISPOSITIVOS.Image")));
            this.DISPOSITIVOS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DISPOSITIVOS.Name = "DISPOSITIVOS";
            this.DISPOSITIVOS.Size = new System.Drawing.Size(93, 22);
            this.DISPOSITIVOS.Text = "DISPOSITIVOS";
            this.DISPOSITIVOS.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese su nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // cOMPUTADORAToolStripMenuItem
            // 
            this.cOMPUTADORAToolStripMenuItem.Name = "cOMPUTADORAToolStripMenuItem";
            this.cOMPUTADORAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cOMPUTADORAToolStripMenuItem.Text = "COMPUTADORA";
            this.cOMPUTADORAToolStripMenuItem.Click += new System.EventHandler(this.cOMPUTADORAToolStripMenuItem_Click);
            // 
            // sMARTPHONEToolStripMenuItem
            // 
            this.sMARTPHONEToolStripMenuItem.Name = "sMARTPHONEToolStripMenuItem";
            this.sMARTPHONEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sMARTPHONEToolStripMenuItem.Text = "SMARTPHONE";
            this.sMARTPHONEToolStripMenuItem.Click += new System.EventHandler(this.sMARTPHONEToolStripMenuItem_Click);
            // 
            // tABLETToolStripMenuItem
            // 
            this.tABLETToolStripMenuItem.Name = "tABLETToolStripMenuItem";
            this.tABLETToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tABLETToolStripMenuItem.Text = "TABLET";
            this.tABLETToolStripMenuItem.Click += new System.EventHandler(this.tABLETToolStripMenuItem_Click);
            // 
            // oTROToolStripMenuItem
            // 
            this.oTROToolStripMenuItem.Name = "oTROToolStripMenuItem";
            this.oTROToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oTROToolStripMenuItem.Text = "OTRO";
            this.oTROToolStripMenuItem.Click += new System.EventHandler(this.oTROToolStripMenuItem_Click);
            // 
            // agendarToolStripMenuItem
            // 
            this.agendarToolStripMenuItem.Name = "agendarToolStripMenuItem";
            this.agendarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agendarToolStripMenuItem.Text = "Agendar";
            this.agendarToolStripMenuItem.Click += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(162, 159);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(120, 15);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 6;
            this.progressBar2.Click += new System.EventHandler(this.timer1_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 186);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton DISPOSITIVOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripMenuItem cOMPUTADORAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sMARTPHONEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tABLETToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Timer timer1;
    }
}

