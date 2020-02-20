using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace ProjectManagmentForm {
	public partial class Form1 : Form {

		StreamWriter _stdOutWriter;
		public Form1( ) {
			InitializeComponent( );
		}

		private void Form1_Load( object sender, EventArgs e ) {
			//var stdout = Console.OpenStandardOutput();
			//_stdOutWriter = new StreamWriter(stdout);
			//_stdOutWriter.AutoFlush = true;
			//AllocConsole( );
			//_stdOutWriter.WriteLine("Ciao xoxo");

		}
		//[DllImport("kernel32.dll", SetLastError = true)]
		//[return: MarshalAs(UnmanagedType.Bool)]
		//static extern bool AllocConsole( );
	}
}
