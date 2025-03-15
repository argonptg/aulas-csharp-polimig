/*
 * Criado por SharpDevelop.
 * Usuário: POLIMIG
 * Data: 07/03/2025
 * Hora: 09:34
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace Aula4_1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button2Click(object sender, EventArgs e)
		{		
			
			string nome = txtNome.Text;
			double nota1 = double.Parse(txtNota1.Text);
			double nota2 = double.Parse(txtNota2.Text);
			double nota3 = double.Parse(txtNota3.Text);
			
			double media = Math.Round((nota1 + nota2 + nota3)/3, 1);
			double soma = nota1 + nota2 + nota3;
			
			medLabel.Text = "Media: " + media.ToString();			
			somaLabel.Text = "Soma: " + soma.ToString();
			
			if (media >= 60) {
				sitLabel.ForeColor = Color.DarkGreen;
				sitLabel.Text = "Aprovado!";
			} else {
				sitLabel.ForeColor = Color.Red;
				sitLabel.Text = "Reprovado!";
			}
		}
		
		void Label5Click(object sender, EventArgs e)
		{
			
		}
	}
}
