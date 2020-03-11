/*
 * Created by SharpDevelop.
 * User: Christopher
 * Date: 30/09/2019
 * Time: 03:19 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ejemplo8_multiplicacion_matrices
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
		public static String Inversa(double[,] matrix, int filas, int columnas){
			String salida = "";
			double [,]  identidad = new double [filas,columnas];
			
			for (int i = 0; i < filas; i++) {
				for (int j = 0; j <columnas ; j++) {
					if(i==j){
						identidad[i,j]=1;
					}else{
						identidad[i,j]=0;
					}
				}
			}
			for (int fpivot = 0; fpivot <filas; fpivot++) {
				double nor = matrix[fpivot, fpivot]; //si es 0 no tiene inversa
				
				for (int i = 0; i < columnas; i++)
				{
					
					matrix[fpivot, i] = matrix[fpivot, i] / nor;
					identidad[fpivot,i]=identidad[fpivot,i]/nor;
					
					
				}
				if(nor!=0){
					double valor;
					for (int j = 0; j < filas; j++) {
						
						if(fpivot!=j){
							valor = -1*matrix[j,fpivot];
							for (int k = 0; k < columnas; k++) {
								matrix[j,k] = valor*matrix[fpivot,k]+matrix[j,k];
								identidad[j,k] = valor*identidad[fpivot,k]+identidad[j,k];
							}
						}
					}
					
				}else{
					MessageBox.Show("La matriz no tiene inversa");
					return salida="";
				}
			}
			
			for (int i = 0; i < filas; i++) {
				for (int j = 0; j <columnas; j++) {
					
					salida+=identidad[i,j]+" | ";
					
				}
				
				salida+="|";
				
				salida=salida.Substring(0,salida.Length-3);
				
				salida+=Environment.NewLine;
			}
			return salida;
			
		}
		public static Boolean Llenado(double [,]Matriz, TextBox txt){
			try{
				for (int i = 0; i < txt.Lines.Length ; i++) {
					String cadena = txt.Lines[i];
					String []aux = cadena.Split(',');
					for (int j = 0; j < aux.Length; j++) {
						if (!aux[j].Equals(""))
							Matriz[i,j] = Convert.ToInt32(aux[j]);
					}
				}
			} catch(Exception e){
				MessageBox.Show("Error en formato de entrada");
				return false;
			}
			return true;
		}
		
		void ButtonCalcularClick(object sender, EventArgs e)
			
		{
			textBoxC.Text="";
			byte filasA = 0, colA = 0, filasB = 0, colB = 0;
			if (textBoxA.Lines.Length > 0 && textBoxB.Lines.Length > 0){
				filasA = Convert.ToByte(textBoxA.Lines.Length);
				filasB = Convert.ToByte(textBoxB.Lines.Length);
				colA =  Convert.ToByte(textBoxA.Lines[0].Split(',').Length);
				colB =  Convert.ToByte(textBoxB.Lines[0].Split(',').Length);
				
				
				if (colA == filasB){
					
					double [,] A =  new double[filasA,colA];
					double [,] B =  new double[filasB,colB];
					double [,] C =  new double[filasA,colB];
					bool salA = Llenado(A,textBoxA);
					bool salB = Llenado(B,textBoxB);
					
					if (salA==true && salB==true)
					{
						//multiplicar
						
						for (int i = 0; i < filasA; i++) { //recorre las filas de la matriz A
							for (int j = 0; j < colB; j++) { // reccorre las columnas de la matriz B
								C[i,j]=0;
								for (int z = 0; z < colA; z++) { //recorremos hasta que se terminen las columnas de A
									C[i,j]=A[i,z]*B[z,j]+C[i,j];
								}
							}
						}
						//mostramos
						for (int i = 0; i < filasA; i++) {
							for (int j = 0; j <colB; j++) {
								
								textBoxC.Text+=+C[i,j]+",";
								
							}
							
							
							textBoxC.Text=textBoxC.Text.Substring(0,textBoxC.Text.Length-1);
							textBoxC.Text+=Environment.NewLine;
							
						}
					} else {
						MessageBox.Show("Error en formato de entrada de alguna de las matrices");
					}
				} else
					MessageBox.Show("Las columnas de A deben ser igual a las filas de B");
			} else
				MessageBox.Show("Las matrices no pueden ser nulas");
		}
		
		void ButtonLimpiarClick(object sender, EventArgs e)
		{
			//Limpiamos los textBox
			textBoxA.Text="";
			textBoxB.Text="";
			textBoxC.Text="";
		}
		
		void ButtonSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void TabControl1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void ButtonCalcularInversaClick(object sender, EventArgs e)
		{
			byte filasA = 0, colA=0;
			filasA = Convert.ToByte(textBoxAInversa.Lines.Length);
			colA =  Convert.ToByte(textBoxAInversa.Lines[0].Split(',').Length);
			double [,] A =  new double[filasA,colA];
			if (filasA==colA) {
				
				bool salAI = Llenado(A,textBoxAInversa);
				textBoxInversa.Text=Inversa(A,filasA,colA);
				
				
			}else
				MessageBox.Show("La matriz debe de ser cuadrada :}");
			
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
textBoxInversa.Text="";
textBoxAInversa.Text="";
		}
	}
}
