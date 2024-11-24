namespace WinFormsAppTabla
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelPrincipal = new Panel();
            richTextBoxresultados = new RichTextBox();
            buttonver = new Button();
            textBoxnum = new TextBox();
            labelNumero = new Label();
            labelTitulo = new Label();
            label1 = new Label();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(255, 255, 192);
            panelPrincipal.BackgroundImage = Properties.Resources.c2242b4f9937c1592ad45b8098638572;
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Controls.Add(richTextBoxresultados);
            panelPrincipal.Controls.Add(buttonver);
            panelPrincipal.Controls.Add(textBoxnum);
            panelPrincipal.Controls.Add(labelNumero);
            panelPrincipal.Controls.Add(labelTitulo);
            panelPrincipal.Location = new Point(12, 12);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(776, 426);
            panelPrincipal.TabIndex = 0;
            panelPrincipal.Paint += panelPrincipal_Paint;
            // 
            // richTextBoxresultados
            // 
            richTextBoxresultados.BackColor = Color.White;
            richTextBoxresultados.Font = new Font("SimSun-ExtB", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            richTextBoxresultados.Location = new Point(499, 100);
            richTextBoxresultados.Name = "richTextBoxresultados";
            richTextBoxresultados.Size = new Size(249, 299);
            richTextBoxresultados.TabIndex = 4;
            richTextBoxresultados.Text = "";
            // 
            // buttonver
            // 
            buttonver.Location = new Point(355, 197);
            buttonver.Name = "buttonver";
            buttonver.Size = new Size(75, 23);
            buttonver.TabIndex = 3;
            buttonver.Text = "ver tabla";
            buttonver.UseVisualStyleBackColor = true;
            buttonver.Click += buttonver_Click;
            // 
            // textBoxnum
            // 
            textBoxnum.Location = new Point(342, 168);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(100, 23);
            textBoxnum.TabIndex = 2;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.BackColor = Color.SeaGreen;
            labelNumero.Font = new Font("Yu Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelNumero.ForeColor = Color.White;
            labelNumero.Location = new Point(304, 135);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(166, 21);
            labelNumero.TabIndex = 1;
            labelNumero.Text = "Cual tabla quieres? ";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.SeaGreen;
            labelTitulo.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(304, 100);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(169, 21);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Tabla de Multiplicar";
            labelTitulo.Click += labelTitulo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaGreen;
            label1.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(294, 397);
            label1.Name = "label1";
            label1.Size = new Size(190, 17);
            label1.TabIndex = 5;
            label1.Text = "Jose Arturo Picazo Zaragoza";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelPrincipal);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelTitulo;
        private Button buttonver;
        private TextBox textBoxnum;
        private Label labelNumero;
        private RichTextBox richTextBoxresultados;
        private Label label1;
    }
}
