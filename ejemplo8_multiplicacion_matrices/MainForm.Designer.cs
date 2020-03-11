/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 30/09/2019
 * Time: 03:19 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ejemplo8_multiplicacion_matrices
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.buttonSalir = new System.Windows.Forms.Button();
			this.buttonCalcular = new System.Windows.Forms.Button();
			this.buttonLimpiar = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxC = new System.Windows.Forms.TextBox();
			this.textBoxB = new System.Windows.Forms.TextBox();
			this.textBoxA = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.buttonCalcularInversa = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxInversa = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxAInversa = new System.Windows.Forms.TextBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(637, 317);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.buttonSalir);
			this.tabPage1.Controls.Add(this.buttonCalcular);
			this.tabPage1.Controls.Add(this.buttonLimpiar);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.textBoxC);
			this.tabPage1.Controls.Add(this.textBoxB);
			this.tabPage1.Controls.Add(this.textBoxA);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(629, 291);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Multiplicación de matrices";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// buttonSalir
			// 
			this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSalir.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSalir.Location = new System.Drawing.Point(484, 236);
			this.buttonSalir.Name = "buttonSalir";
			this.buttonSalir.Size = new System.Drawing.Size(99, 33);
			this.buttonSalir.TabIndex = 10;
			this.buttonSalir.Text = "Salir";
			this.buttonSalir.UseVisualStyleBackColor = true;
			this.buttonSalir.Click += new System.EventHandler(this.ButtonSalirClick);
			// 
			// buttonCalcular
			// 
			this.buttonCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCalcular.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCalcular.Location = new System.Drawing.Point(209, 236);
			this.buttonCalcular.Name = "buttonCalcular";
			this.buttonCalcular.Size = new System.Drawing.Size(99, 33);
			this.buttonCalcular.TabIndex = 9;
			this.buttonCalcular.Text = "Calcular";
			this.buttonCalcular.UseVisualStyleBackColor = true;
			this.buttonCalcular.Click += new System.EventHandler(this.ButtonCalcularClick);
			// 
			// buttonLimpiar
			// 
			this.buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLimpiar.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLimpiar.Location = new System.Drawing.Point(27, 236);
			this.buttonLimpiar.Name = "buttonLimpiar";
			this.buttonLimpiar.Size = new System.Drawing.Size(99, 33);
			this.buttonLimpiar.TabIndex = 8;
			this.buttonLimpiar.Text = "Limpiar";
			this.buttonLimpiar.UseVisualStyleBackColor = true;
			this.buttonLimpiar.Click += new System.EventHandler(this.ButtonLimpiarClick);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(386, 111);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(25, 23);
			this.label5.TabIndex = 7;
			this.label5.Text = "=";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(178, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(25, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "X";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(455, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "RESULTADO";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(209, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Matriz B";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(27, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Matriz A";
			// 
			// textBoxC
			// 
			this.textBoxC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxC.Location = new System.Drawing.Point(455, 62);
			this.textBoxC.Multiline = true;
			this.textBoxC.Name = "textBoxC";
			this.textBoxC.ReadOnly = true;
			this.textBoxC.Size = new System.Drawing.Size(128, 114);
			this.textBoxC.TabIndex = 2;
			this.textBoxC.WordWrap = false;
			// 
			// textBoxB
			// 
			this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxB.Location = new System.Drawing.Point(209, 62);
			this.textBoxB.Multiline = true;
			this.textBoxB.Name = "textBoxB";
			this.textBoxB.Size = new System.Drawing.Size(137, 114);
			this.textBoxB.TabIndex = 1;
			this.textBoxB.Text = "2,4,3\r\n1,2,1\r\n3,0,4\r\n2,1,5";
			// 
			// textBoxA
			// 
			this.textBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxA.Location = new System.Drawing.Point(27, 62);
			this.textBoxA.Multiline = true;
			this.textBoxA.Name = "textBoxA";
			this.textBoxA.Size = new System.Drawing.Size(135, 114);
			this.textBoxA.TabIndex = 0;
			this.textBoxA.Text = "2,3,1,1\r\n4,2,-2,2\r\n4,1,0,3\r\n3,4,2,1";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.button1);
			this.tabPage2.Controls.Add(this.button2);
			this.tabPage2.Controls.Add(this.buttonCalcularInversa);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.textBoxInversa);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.textBoxAInversa);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(629, 291);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Inversa de una matriz";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(505, 232);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(99, 33);
			this.button1.TabIndex = 12;
			this.button1.Text = "Salir";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(49, 232);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(99, 33);
			this.button2.TabIndex = 11;
			this.button2.Text = "Limpiar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// buttonCalcularInversa
			// 
			this.buttonCalcularInversa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCalcularInversa.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCalcularInversa.Location = new System.Drawing.Point(234, 232);
			this.buttonCalcularInversa.Name = "buttonCalcularInversa";
			this.buttonCalcularInversa.Size = new System.Drawing.Size(99, 33);
			this.buttonCalcularInversa.TabIndex = 10;
			this.buttonCalcularInversa.Text = "Calcular";
			this.buttonCalcularInversa.UseVisualStyleBackColor = true;
			this.buttonCalcularInversa.Click += new System.EventHandler(this.ButtonCalcularInversaClick);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(329, 56);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(113, 16);
			this.label7.TabIndex = 6;
			this.label7.Text = "Matriz Inversa";
			// 
			// textBoxInversa
			// 
			this.textBoxInversa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxInversa.Location = new System.Drawing.Point(329, 75);
			this.textBoxInversa.Multiline = true;
			this.textBoxInversa.Name = "textBoxInversa";
			this.textBoxInversa.Size = new System.Drawing.Size(266, 134);
			this.textBoxInversa.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(49, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 16);
			this.label6.TabIndex = 4;
			this.label6.Text = "Matriz A";
			// 
			// textBoxAInversa
			// 
			this.textBoxAInversa.Location = new System.Drawing.Point(49, 75);
			this.textBoxAInversa.Multiline = true;
			this.textBoxAInversa.Name = "textBoxAInversa";
			this.textBoxAInversa.Size = new System.Drawing.Size(133, 112);
			this.textBoxAInversa.TabIndex = 0;
			this.textBoxAInversa.Text = "2,1\r\n1,4";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(657, 341);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Operaciones con matrices";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxInversa;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button buttonCalcularInversa;
		private System.Windows.Forms.TextBox textBoxAInversa;
		private System.Windows.Forms.Button buttonSalir;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button buttonLimpiar;
		private System.Windows.Forms.Button buttonCalcular;
		private System.Windows.Forms.TextBox textBoxA;
		private System.Windows.Forms.TextBox textBoxB;
		private System.Windows.Forms.TextBox textBoxC;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
	}
}
