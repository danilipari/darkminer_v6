using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Darkminer_v6.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Darkminer_v6;

[DesignerGenerated]
public class Form2 : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	internal virtual TextBox TextBox1
	{
		[CompilerGenerated]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			KeyEventHandler val = new KeyEventHandler(TextBox1_KeyUp);
			TextBox textBox = _TextBox1;
			if (textBox != null)
			{
				((Control)textBox).KeyUp -= val;
			}
			_TextBox1 = value;
			textBox = _TextBox1;
			if (textBox != null)
			{
				((Control)textBox).KeyUp += val;
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button1_Click;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).Click -= eventHandler;
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).Click += eventHandler;
			}
		}
	}

	public Form2()
	{
		((Form)this).Load += Form2_Load;
		InitializeComponent();
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)MyProject.Forms.Form2);
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		TextBox1 = new TextBox();
		Label1 = new Label();
		Button1 = new Button();
		((Control)this).SuspendLayout();
		((TextBoxBase)TextBox1).BackColor = Color.Silver;
		((Control)TextBox1).Cursor = Cursors.IBeam;
		((Control)TextBox1).Location = new Point(26, 106);
		((Control)TextBox1).Name = "TextBox1";
		((Control)TextBox1).Size = new Size(381, 27);
		((Control)TextBox1).TabIndex = 0;
		Label1.AutoSize = true;
		((Control)Label1).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3);
		((Control)Label1).Location = new Point(120, 60);
		((Control)Label1).Name = "Label1";
		((Control)Label1).Size = new Size(205, 28);
		((Control)Label1).TabIndex = 1;
		Label1.Text = " Your activation key:";
		((ButtonBase)Button1).BackColor = Color.Green;
		((Control)Button1).Cursor = Cursors.Hand;
		((Control)Button1).ForeColor = SystemColors.Control;
		((Control)Button1).Location = new Point(435, 106);
		((Control)Button1).Name = "Button1";
		((Control)Button1).Size = new Size(146, 27);
		((Control)Button1).TabIndex = 2;
		((ButtonBase)Button1).Text = "Activate";
		((ButtonBase)Button1).UseVisualStyleBackColor = false;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(8f, 20f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).ClientSize = new Size(593, 242);
		((Control)this).Controls.Add((Control)(object)Button1);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)TextBox1);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "Form2";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Activation";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		bool createdNew = default(bool);
		switch (TextBox1.Text)
		{
		case "Q79UZWGAH22P9DSW41LAY":
			OpenForm1(ref createdNew);
			break;
		case "X8R7JK9P2T3L6VW3F1Q":
			OpenForm4(ref createdNew);
			break;
		case "ZM5A5B4C2D9E8G7H6I5Y":
			OpenForm5(ref createdNew);
			break;
		case "4T3N1O2P3Q4R5U6V7W8X":
			OpenForm6(ref createdNew);
			break;
		case "9Y0Z3A2B1C0D9S8W7X6Y":
			OpenForm7(ref createdNew);
			break;
		case "5Z4F3G2H1I0J9K8L7M6N":
			OpenForm8(ref createdNew);
			break;
		case "O5P4Q3R2S1T0U9V8W7X6":
			OpenForm9(ref createdNew);
			break;
		case "A5B4C2D9E8G7H6I5Y4T3N":
			OpenForm11(ref createdNew);
			break;
		case "9B8C7D6E5F4G3H2I1J0K":
			OpenForm12(ref createdNew);
			break;
		case "L1M2N3O4P5Q6R7S8T9U0V":
			OpenForm13(ref createdNew);
			break;
		case "H1I2J3K4L5M6N7O8P9Q0R":
			OpenForm14(ref createdNew);
			break;
		case "X8R7JK9P2T0L6VW3F1QZM":
			OpenForm15(ref createdNew);
			break;
		case "X8R7JK9P2T0L6VW3F1999":
			OpenForm16(ref createdNew);
			break;
		case "Y5Z4A3B2C1D0E9F8G7H6":
			OpenForm10(ref createdNew);
			break;
		default:
			MessageBox.Show("Wrong key. Please try again.", "Wrong key", (MessageBoxButtons)0, (MessageBoxIcon)16);
			break;
		}
	}

	private void OpenForm1(ref bool createdNew)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		Mutex mutex = new Mutex(initiallyOwned: true, "{Wallet-Cracker-Form1}", out createdNew);
		if (mutex.WaitOne(0, exitContext: false))
		{
			if (CheckForInternetConnection())
			{
				((Control)this).Hide();
				Form1 form = new Form1();
				((Form)form).ShowDialog();
				((Form)this).Close();
				mutex.ReleaseMutex();
			}
			else
			{
				MessageBox.Show("The program requires an internet connection to run.", "No internet connection", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
	}

	private void OpenForm4(ref bool createdNew)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		Mutex mutex = new Mutex(initiallyOwned: true, "{Wallet-Cracker-Form4}", out createdNew);
		if (mutex.WaitOne(0, exitContext: false))
		{
			if (CheckForInternetConnection())
			{
				((Control)this).Hide();
				Form4 form = new Form4();
				((Form)form).ShowDialog();
				((Form)this).Close();
				mutex.ReleaseMutex();
			}
			else
			{
				MessageBox.Show("The program requires an internet connection to run.", "No internet connection", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
	}

	private void OpenForm5(ref bool createdNew)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		Mutex mutex = new Mutex(initiallyOwned: true, "{Wallet-Cracker-Form5}", out createdNew);
		if (mutex.WaitOne(0, exitContext: false))
		{
			if (CheckForInternetConnection())
			{
				((Control)this).Hide();
				Form5 form = new Form5();
				((Form)form).ShowDialog();
				((Form)this).Close();
				mutex.ReleaseMutex();
			}
			else
			{
				MessageBox.Show("The program requires an internet connection to run.", "No internet connection", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
	}

	private void OpenForm6(ref bool createdNew)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		Mutex mutex = new Mutex(initiallyOwned: true, "{Wallet-Cracker-Form6}", out createdNew);
		if (mutex.WaitOne(0, exitContext: false))
		{
			if (CheckForInternetConnection())
			{
				((Control)this).Hide();
				Form6 form = new Form6();
				((Form)form).ShowDialog();
				((Form)this).Close();
				mutex.ReleaseMutex();
			}
			else
			{
				MessageBox.Show("The program requires an internet connection to run.", "No internet connection", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
	}

	private void OpenForm7(ref bool createdNew)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		Mutex mutex = new Mutex(initiallyOwned: true, "{Wallet-Cracker-Form7}", out createdNew);
		if (mutex.WaitOne(0, exitContext: false))
		{
			if (CheckForInternetConnection())
			{
				((Control)this).Hide();
				Form7 form = new Form7();
				((Form)form).ShowDialog();
				((Form)this).Close();
				mutex.ReleaseMutex();
			}
			else
			{
				MessageBox.Show("The program requires an internet connection to run.", "No internet connection", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
	}

	private void OpenForm8(ref bool createdNew)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		Mutex mutex = new Mutex(initiallyOwned: true, "{Wallet-Cracker-Form8}", out createdNew);
		if (mutex.WaitOne(0, exitContext: false))
		{
			if (CheckForInternetConnection())
			{
				((Control)this).Hide();
				Form8 form = new Form8();
				((Form)form).ShowDialog();
				((Form)this).Close();
				mutex.ReleaseMutex();
			}
			else
			{
				MessageBox.Show("The program requires an internet connection to run.", "No internet connection", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
	}

	private void OpenForm9(ref bool createdNew)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		Mutex mutex = new Mutex(initiallyOwned: true, "{Wallet-Cracker-Form9}", out createdNew);
		if (mutex.WaitOne(0, exitContext: false))
		{
			if (CheckForInternetConnection())
			{
				((Control)this).Hide();
				Form9 form = new Form9();
				((Form)form).ShowDialog();
				((Form)this).Close();
				mutex.ReleaseMutex();
			}
			else
			{
				MessageBox.Show("The program requires an internet connection to run.", "No internet connection", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
	}

	private void OpenForm10(ref bool createdNew)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		Mutex mutex = new Mutex(initiallyOwned: true, "{Wallet-Cracker-Form10}", out createdNew);
		if (mutex.WaitOne(0, exitContext: false))
		{
			if (CheckForInternetConnection())
			{
				((Control)this).Hide();
				Form10 form = new Form10();
				((Form)form).ShowDialog();
				((Form)this).Close();
				mutex.ReleaseMutex();
			}
			else
			{
				MessageBox.Show("The program requires an internet connection to run.", "No internet connection", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
	}

	private void OpenForm11(ref bool createdNew)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		Mutex mutex = new Mutex(initiallyOwned: true, "{Wallet-Cracker-Form11}", out createdNew);
		if (mutex.WaitOne(0, exitContext: false))
		{
			if (CheckForInternetConnection())
			{
				((Control)this).Hide();
				Form11 form = new Form11();
				((Form)form).ShowDialog();
				((Form)this).Close();
				mutex.ReleaseMutex();
			}
			else
			{
				MessageBox.Show("The program requires an internet connection to run.", "No internet connection", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
	}

	private void OpenForm12(ref bool createdNew)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		Mutex mutex = new Mutex(initiallyOwned: true, "{Wallet-Cracker-Form12}", out createdNew);
		if (mutex.WaitOne(0, exitContext: false))
		{
			if (CheckForInternetConnection())
			{
				((Control)this).Hide();
				Form12 form = new Form12();
				((Form)form).ShowDialog();
				((Form)this).Close();
				mutex.ReleaseMutex();
			}
			else
			{
				MessageBox.Show("The program requires an internet connection to run.", "No internet connection", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
	}

	private void OpenForm13(ref bool createdNew)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		Mutex mutex = new Mutex(initiallyOwned: true, "{Wallet-Cracker-Form13}", out createdNew);
		if (mutex.WaitOne(0, exitContext: false))
		{
			if (CheckForInternetConnection())
			{
				((Control)this).Hide();
				Form13 form = new Form13();
				((Form)form).ShowDialog();
				((Form)this).Close();
				mutex.ReleaseMutex();
			}
			else
			{
				MessageBox.Show("The program requires an internet connection to run.", "No internet connection", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
	}

	private void OpenForm16(ref bool createdNew)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		Mutex mutex = new Mutex(initiallyOwned: true, "{Wallet-Cracker-Form16}", out createdNew);
		if (mutex.WaitOne(0, exitContext: false))
		{
			if (CheckForInternetConnection())
			{
				((Control)this).Hide();
				Form16 form = new Form16();
				((Form)form).ShowDialog();
				((Form)this).Close();
				mutex.ReleaseMutex();
			}
			else
			{
				MessageBox.Show("The program requires an internet connection to run.", "No internet connection", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
	}

	private void OpenForm14(ref bool createdNew)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		Mutex mutex = new Mutex(initiallyOwned: true, "{Wallet-Cracker-Form14}", out createdNew);
		if (mutex.WaitOne(0, exitContext: false))
		{
			if (CheckForInternetConnection())
			{
				((Control)this).Hide();
				Form14 form = new Form14();
				((Form)form).ShowDialog();
				((Form)this).Close();
				mutex.ReleaseMutex();
			}
			else
			{
				MessageBox.Show("The program requires an internet connection to run.", "No internet connection", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
	}

	private void OpenForm15(ref bool createdNew)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		Mutex mutex = new Mutex(initiallyOwned: true, "{Wallet-Cracker-Form15}", out createdNew);
		if (mutex.WaitOne(0, exitContext: false))
		{
			if (CheckForInternetConnection())
			{
				((Control)this).Hide();
				Form15 form = new Form15();
				((Form)form).ShowDialog();
				((Form)this).Close();
				mutex.ReleaseMutex();
			}
			else
			{
				MessageBox.Show("The program requires an internet connection to run.", "No internet connection", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
	}

	private void TextBox1_KeyUp(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 13)
		{
			Button1.PerformClick();
		}
	}

	private bool CheckForInternetConnection()
	{
		bool result;
		try
		{
			WebRequest webRequest = WebRequest.Create("http://www.google.com");
			WebResponse response = webRequest.GetResponse();
			result = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void Form2_Load(object sender, EventArgs e)
	{
	}
}
