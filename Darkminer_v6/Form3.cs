using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Darkminer_v6;

[DesignerGenerated]
public class Form3 : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ContextMenuStrip1")]
	internal virtual ContextMenuStrip ContextMenuStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button2_Click;
			Button button = _Button2;
			if (button != null)
			{
				((Control)button).Click -= eventHandler;
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				((Control)button).Click += eventHandler;
			}
		}
	}

	public Form3()
	{
		((Form)this).Load += Form3_Load;
		InitializeComponent();
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
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected O, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected O, but got Unknown
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Expected O, but got Unknown
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected O, but got Unknown
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected O, but got Unknown
		//IL_068d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Expected O, but got Unknown
		//IL_074e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Expected O, but got Unknown
		//IL_0903: Unknown result type (might be due to invalid IL or missing references)
		//IL_090d: Expected O, but got Unknown
		//IL_0913: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form3));
		Label1 = new Label();
		ContextMenuStrip1 = new ContextMenuStrip(components);
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Label6 = new Label();
		Label8 = new Label();
		Label9 = new Label();
		Label10 = new Label();
		Label11 = new Label();
		Label7 = new Label();
		Button2 = new Button();
		((Control)this).SuspendLayout();
		Label1.AutoSize = true;
		((Control)Label1).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3);
		((Control)Label1).Location = new Point(5, 7);
		((Control)Label1).Name = "Label1";
		((Control)Label1).Size = new Size(299, 21);
		((Control)Label1).TabIndex = 1;
		Label1.Text = "You have activated the FREE trial key‼\ufe0f\r\n";
		((ToolStrip)ContextMenuStrip1).ImageScalingSize = new Size(20, 20);
		((Control)ContextMenuStrip1).Name = "ContextMenuStrip1";
		((Control)ContextMenuStrip1).Size = new Size(61, 4);
		Label2.AutoSize = true;
		((Control)Label2).Font = new Font("Segoe UI Semibold", 10.8f, (FontStyle)3, (GraphicsUnit)3);
		((Control)Label2).Location = new Point(5, 46);
		((Control)Label2).Name = "Label2";
		((Control)Label2).Size = new Size(309, 40);
		((Control)Label2).TabIndex = 3;
		Label2.Text = "What's the difference between Free verison \r\nand Full version !?";
		Label3.AutoSize = true;
		((Control)Label3).Font = new Font("Segoe UI", 10.2f, (FontStyle)1, (GraphicsUnit)3);
		((Control)Label3).Location = new Point(100, 190);
		((Control)Label3).Name = "Label3";
		((Control)Label3).Size = new Size(107, 19);
		((Control)Label3).TabIndex = 4;
		Label3.Text = "FULL VERISON:";
		Label4.AutoSize = true;
		((Control)Label4).Font = new Font("Segoe UI Semibold", 9f, (FontStyle)1, (GraphicsUnit)3);
		((Control)Label4).Location = new Point(100, 214);
		((Control)Label4).Name = "Label4";
		((Control)Label4).Size = new Size(166, 60);
		((Control)Label4).TabIndex = 5;
		Label4.Text = "✅ 6 blockchains\r\n✅ 60,000,000 checks per day\r\n✅ Withdrawals\r\n✅ Updates";
		Label5.AutoSize = true;
		((Control)Label5).Font = new Font("Segoe UI", 10.2f, (FontStyle)1, (GraphicsUnit)3);
		((Control)Label5).Location = new Point(100, 98);
		((Control)Label5).Name = "Label5";
		((Control)Label5).Size = new Size(106, 19);
		((Control)Label5).TabIndex = 6;
		Label5.Text = "FREE VERISON:";
		Label6.AutoSize = true;
		((Control)Label6).Font = new Font("Segoe UI Semibold", 9f, (FontStyle)1, (GraphicsUnit)3);
		((Control)Label6).Location = new Point(100, 122);
		((Control)Label6).Name = "Label6";
		((Control)Label6).Size = new Size(149, 60);
		((Control)Label6).TabIndex = 7;
		Label6.Text = "❌ 1 blockchain (Bitcoin)\r\n❌ 600,000 checks per day\r\n❌ No Withdrawals\r\n❌ No Updates";
		Label8.AutoSize = true;
		((Control)Label8).Font = new Font("Segoe UI Black", 14.25f, (FontStyle)1, (GraphicsUnit)3);
		((Control)Label8).ForeColor = Color.Red;
		((Control)Label8).Location = new Point(47, 412);
		((Control)Label8).Name = "Label8";
		((Control)Label8).Size = new Size(219, 25);
		((Control)Label8).TabIndex = 9;
		Label8.Text = "WANT FULL VERISON?";
		Label9.AutoSize = true;
		((Control)Label9).Font = new Font("Segoe UI Semibold", 10.8f, (FontStyle)3, (GraphicsUnit)3);
		((Control)Label9).Location = new Point(5, 286);
		((Control)Label9).Name = "Label9";
		((Control)Label9).Size = new Size(275, 20);
		((Control)Label9).TabIndex = 11;
		Label9.Text = "How does FREE verison found look like?";
		Label10.AutoSize = true;
		((Control)Label10).Font = new Font("Segoe UI", 10.8f, (FontStyle)5, (GraphicsUnit)3);
		((Control)Label10).ForeColor = Color.FromArgb(0, 192, 0);
		((Control)Label10).Location = new Point(5, 304);
		((Control)Label10).Name = "Label10";
		((Control)Label10).Size = new Size(240, 20);
		((Control)Label10).TabIndex = 12;
		Label10.Text = "btc 0.01339 = 359.15$ | LOCKED";
		Label11.AutoSize = true;
		((Control)Label11).Font = new Font("Segoe UI Semibold", 10.8f, (FontStyle)3, (GraphicsUnit)3);
		((Control)Label11).Location = new Point(5, 343);
		((Control)Label11).Name = "Label11";
		((Control)Label11).Size = new Size(275, 20);
		((Control)Label11).TabIndex = 13;
		Label11.Text = "How does FULL verison found look like?";
		Label7.AutoSize = true;
		((Control)Label7).Font = new Font("Segoe UI", 10.8f, (FontStyle)5, (GraphicsUnit)3);
		((Control)Label7).ForeColor = Color.FromArgb(0, 192, 0);
		((Control)Label7).Location = new Point(5, 362);
		((Control)Label7).Name = "Label7";
		((Control)Label7).Size = new Size(361, 20);
		((Control)Label7).TabIndex = 14;
		Label7.Text = "btc 0.01339 = 359.15$ | chain offer person year ...";
		((ButtonBase)Button2).BackColor = Color.FromArgb(0, 192, 192);
		((Control)Button2).Cursor = Cursors.Hand;
		((Control)Button2).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3);
		((Control)Button2).ForeColor = SystemColors.ActiveCaptionText;
		((Control)Button2).Location = new Point(90, 452);
		((Control)Button2).Name = "Button2";
		((Control)Button2).Size = new Size(132, 28);
		((Control)Button2).TabIndex = 15;
		((ButtonBase)Button2).Text = "CONTACT US";
		((ButtonBase)Button2).UseVisualStyleBackColor = false;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(7f, 15f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).ClientSize = new Size(317, 492);
		((Control)this).Controls.Add((Control)(object)Button2);
		((Control)this).Controls.Add((Control)(object)Label7);
		((Control)this).Controls.Add((Control)(object)Label11);
		((Control)this).Controls.Add((Control)(object)Label10);
		((Control)this).Controls.Add((Control)(object)Label9);
		((Control)this).Controls.Add((Control)(object)Label8);
		((Control)this).Controls.Add((Control)(object)Label6);
		((Control)this).Controls.Add((Control)(object)Label5);
		((Control)this).Controls.Add((Control)(object)Label4);
		((Control)this).Controls.Add((Control)(object)Label3);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Form)this).FormBorderStyle = (FormBorderStyle)1;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).Margin = new Padding(3, 2, 3, 2);
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "Form3";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Info";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form3_Load(object sender, EventArgs e)
	{
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		string fileName = "https://t.me/CryptoAgentBot";
		try
		{
			Process.Start(new ProcessStartInfo(fileName)
			{
				UseShellExecute = true,
				Verb = "open"
			});
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("I can't open the website. Contact us on Telegram @CryptoAgentBot");
			ProjectData.ClearProjectError();
		}
	}
}
