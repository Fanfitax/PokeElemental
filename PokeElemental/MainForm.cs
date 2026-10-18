/*
 * Created by SharpDevelop.
 * User: Steffany
 * Date: 10/16/2026
 * Time: 8:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PokeElemental
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
			Text = "PokeElemental";
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(960, 640);
            Criatura c = new Criatura("Aitana", Tipo.Fuego,100);
            c.RecibirDano(1000);
            MessageBox.Show(c.VidaActual.ToString());
            c.Curar(1000);
            MessageBox.Show(c.VidaActual.ToString());

			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	}
}
