/*
 * Criado por SharpDevelop.
 * Usuário: POLIMIG
 * Data: 07/03/2025
 * Hora: 09:34
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Aula4_1
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtNota1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNota2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNota3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.somaLabel = new System.Windows.Forms.Label();
			this.medLabel = new System.Windows.Forms.Label();
			this.btnSoma = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.sitLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome: ";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(73, 8);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(199, 20);
			this.txtNome.TabIndex = 1;
			// 
			// txtNota1
			// 
			this.txtNota1.Location = new System.Drawing.Point(73, 34);
			this.txtNota1.Name = "txtNota1";
			this.txtNota1.Size = new System.Drawing.Size(199, 20);
			this.txtNota1.TabIndex = 3;
			this.txtNota1.Text = "0";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nota 1: ";
			// 
			// txtNota2
			// 
			this.txtNota2.Location = new System.Drawing.Point(73, 60);
			this.txtNota2.Name = "txtNota2";
			this.txtNota2.Size = new System.Drawing.Size(199, 20);
			this.txtNota2.TabIndex = 5;
			this.txtNota2.Text = "0";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Nota 2: ";
			// 
			// txtNota3
			// 
			this.txtNota3.Location = new System.Drawing.Point(73, 86);
			this.txtNota3.Name = "txtNota3";
			this.txtNota3.Size = new System.Drawing.Size(199, 20);
			this.txtNota3.TabIndex = 7;
			this.txtNota3.Text = "0";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 86);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Nota 3: ";
			// 
			// somaLabel
			// 
			this.somaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.somaLabel.Location = new System.Drawing.Point(12, 152);
			this.somaLabel.Name = "somaLabel";
			this.somaLabel.Size = new System.Drawing.Size(100, 23);
			this.somaLabel.TabIndex = 9;
			this.somaLabel.Text = "Soma: ";
			// 
			// medLabel
			// 
			this.medLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.medLabel.Location = new System.Drawing.Point(172, 152);
			this.medLabel.Name = "medLabel";
			this.medLabel.Size = new System.Drawing.Size(100, 23);
			this.medLabel.TabIndex = 9;
			this.medLabel.Text = "Média: ";
			// 
			// btnSoma
			// 
			this.btnSoma.Location = new System.Drawing.Point(12, 112);
			this.btnSoma.Name = "btnSoma";
			this.btnSoma.Size = new System.Drawing.Size(260, 23);
			this.btnSoma.TabIndex = 12;
			this.btnSoma.Text = "Calcular";
			this.btnSoma.UseVisualStyleBackColor = true;
			this.btnSoma.Click += new System.EventHandler(this.Button2Click);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(12, 204);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Situação: ";
			this.label5.Click += new System.EventHandler(this.Label5Click);
			// 
			// sitLabel
			// 
			this.sitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.sitLabel.Location = new System.Drawing.Point(85, 204);
			this.sitLabel.Name = "sitLabel";
			this.sitLabel.Size = new System.Drawing.Size(100, 23);
			this.sitLabel.TabIndex = 9;
			this.sitLabel.Click += new System.EventHandler(this.Label5Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 236);
			this.Controls.Add(this.btnSoma);
			this.Controls.Add(this.medLabel);
			this.Controls.Add(this.sitLabel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.somaLabel);
			this.Controls.Add(this.txtNota3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtNota2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNota1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(300, 250);
			this.Name = "MainForm";
			this.Text = "Aula4-1";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label sitLabel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnSoma;
		private System.Windows.Forms.Label medLabel;
		private System.Windows.Forms.Label somaLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNota3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNota2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNota1;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label label1;
	}
}
