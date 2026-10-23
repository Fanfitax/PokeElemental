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
            Criatura a = new Criatura("Aitana", Tipo.Fuego, 100);
            Criatura agua = new Criatura("Mia", Tipo.Agua, 100);
            Criatura aire = new Criatura("Brisa", Tipo.Aire, 100);
            MovimientoDano llamarada = new MovimientoDano("Llamarada", Tipo.Fuego, 10, 40);

            MessageBox.Show(llamarada.Ejecutar(a, agua));
            MessageBox.Show(llamarada.Ejecutar(a, aire));
            MessageBox.Show(llamarada.Ejecutar(a, a));
            MessageBox.Show(agua.VidaActual + " / " + aire.VidaActual + " / " + a.VidaActual);


            
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	}
}
