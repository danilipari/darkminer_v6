using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Darkminer_v6;

[DesignerGenerated]
public class Form11 : Form
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__85_002D0
	{
		public string _0024VB_0024Local_selectedCrypto;

		public Form11 _0024VB_0024Me;

		public _Closure_0024__85_002D0(_Closure_0024__85_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_selectedCrypto = arg0._0024VB_0024Local_selectedCrypto;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			int num = 0;
			checked
			{
				while (!_0024VB_0024Me.cancellationTokenSource.Token.IsCancellationRequested)
				{
					int num2 = 5;
					if (_0024VB_0024Me.tries > _0024VB_0024Me.random.Next(1500, 1000000000))
					{
						string text = id_gen();
						string text2 = "";
						if (Operators.CompareString(_0024VB_0024Local_selectedCrypto, "ETH", TextCompare: false) == 0)
						{
							double num3 = Math.Round(_0024VB_0024Me.random.NextDouble() * 2.9 + 0.1, 4);
							text2 = "ETH";
						}
						else if (Operators.CompareString(_0024VB_0024Local_selectedCrypto, "BTC", TextCompare: false) == 0)
						{
							double num3 = Math.Round(_0024VB_0024Me.random.NextDouble() * 0.99 + 0.01, 4);
							text2 = "BTC";
						}
						List<string> list = new List<string>();
						int num4 = 0;
						do
						{
							if (num4 < _0024VB_0024Me.words.Length)
							{
								list.Add(_0024VB_0024Me.words[_0024VB_0024Me.random.Next(_0024VB_0024Me.words.Length)]);
							}
							num4++;
						}
						while (num4 <= 11);
						string text3 = string.Format("Wallet check:     {0}", string.Join(" ", list));
						text3 += "\r\n";
						Thread.Sleep(1);
						_0024VB_0024Me.AppendTextWithScroll(text3, Color.White, isBold: false, 8f);
						Thread.Sleep(1);
						_0024VB_0024Me.tries = 0;
						_0024VB_0024Me.AppendTextWithScroll("Wallet check:   luck foot star sun flat person sun content tree parrot luck offer", Color.White, isBold: false, 8f);
						Thread.Sleep(1);
					}
					else
					{
						string text4 = id_gen();
						List<string> list2 = new List<string>();
						int num5 = 0;
						do
						{
							list2.Add(_0024VB_0024Me.words[_0024VB_0024Me.random.Next(_0024VB_0024Me.words.Length)]);
							num5++;
						}
						while (num5 <= 11);
						string text5 = string.Format("Wallet check:   {0}", string.Join(" ", list2));
						text5 += "\r\n";
						Thread.Sleep(1);
						_0024VB_0024Me.AppendTextWithScroll(text5, Color.White, isBold: false, 10f);
						_0024VB_0024Me.tries++;
						num++;
					}
				}
			}
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("StartButton")]
	private Button _StartButton;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("StopButton")]
	private Button _StopButton;

	private CancellationTokenSource cancellationTokenSource;

	private Random random;

	private int tries;

	private bool isMining;

	private int foundCount;

	private string[] words;

	private StringBuilder textBuilder;

	internal virtual Button StartButton
	{
		[CompilerGenerated]
		get
		{
			return _StartButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = StartButton_Click;
			Button startButton = _StartButton;
			if (startButton != null)
			{
				((Control)startButton).Click -= eventHandler;
			}
			_StartButton = value;
			startButton = _StartButton;
			if (startButton != null)
			{
				((Control)startButton).Click += eventHandler;
			}
		}
	}

	internal virtual Button StopButton
	{
		[CompilerGenerated]
		get
		{
			return _StopButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = StopButton_Click;
			Button stopButton = _StopButton;
			if (stopButton != null)
			{
				((Control)stopButton).Click -= eventHandler;
			}
			_StopButton = value;
			stopButton = _StopButton;
			if (stopButton != null)
			{
				((Control)stopButton).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("ResultRichTextBox")]
	internal virtual RichTextBox ResultRichTextBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("EthCheckBox")]
	internal virtual CheckBox EthCheckBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RecordCountLabel")]
	internal virtual Label RecordCountLabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Izpis")]
	internal virtual RichTextBox Izpis
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Found")]
	internal virtual Label Found
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox2")]
	internal virtual PictureBox PictureBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox3")]
	internal virtual PictureBox PictureBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox4")]
	internal virtual PictureBox PictureBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox6")]
	internal virtual PictureBox PictureBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox1")]
	internal virtual CheckBox CheckBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox2")]
	internal virtual CheckBox CheckBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox3")]
	internal virtual CheckBox CheckBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox4")]
	internal virtual CheckBox CheckBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("timer")]
	private virtual Timer timer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Form11()
	{
		((Form)this).Load += Form11_Load;
		cancellationTokenSource = new CancellationTokenSource();
		random = new Random();
		tries = 0;
		isMining = false;
		foundCount = 0;
		words = new string[136]
		{
			"person", "offer", "year", "chain", "road", "head", "content", "work", "world", "flat",
			"code", "law", "source", "table", "parrot", "key", "deep", "family", "luck", "gold",
			"thing", "picture", "island", "foot", "spring", "object", "oak", "squirrel", "peace", "orange",
			"windmill", "side", "star", "sun", "tree", "water", "apple", "book", "chair", "dog",
			"elephant", "flower", "guitar", "hat", "ice cream", "jelly", "table", "lamp", "computer", "shoe",
			"keyboard", "candle", "window", "car", "bicycle", "phone", "pencil", "pen", "globe", "clock",
			"mirror", "television", "camera", "pillow", "blanket", "guitar", "keyboard", "flower", "lamp", "couch",
			"window", "door", "table", "coffee", "mug", "cookie", "cake", "candy", "jacket", "hat",
			"scarf", "gloves", "umbrella", "rain", "sun", "moon", "star", "cloud", "tree", "river",
			"mountain", "beach", "ocean", "lake", "forest", "desert", "island", "ship", "airplane", "train",
			"bus", "subway", "taxi", "hotel", "restaurant", "library", "school", "university", "hospital", "doctor",
			"nurse", "police", "firefighter", "teacher", "student", "artist", "musician", "actor", "director", "writer",
			"dancer", "chef", "scientist", "engineer", "programmer", "designer", "athlete", "singer", "athlete", "politician",
			"lawyer", "judge", "journalist", "photographer", "veterinarian", "architect"
		};
		textBuilder = new StringBuilder();
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected O, but got Unknown
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected O, but got Unknown
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected O, but got Unknown
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected O, but got Unknown
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected O, but got Unknown
		//IL_069e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Expected O, but got Unknown
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Expected O, but got Unknown
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07af: Expected O, but got Unknown
		//IL_0b8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b94: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form11));
		StartButton = new Button();
		StopButton = new Button();
		ResultRichTextBox = new RichTextBox();
		EthCheckBox = new CheckBox();
		RecordCountLabel = new Label();
		Izpis = new RichTextBox();
		Found = new Label();
		PictureBox1 = new PictureBox();
		PictureBox2 = new PictureBox();
		PictureBox3 = new PictureBox();
		PictureBox4 = new PictureBox();
		PictureBox6 = new PictureBox();
		CheckBox1 = new CheckBox();
		CheckBox2 = new CheckBox();
		CheckBox3 = new CheckBox();
		CheckBox4 = new CheckBox();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((ISupportInitialize)PictureBox6).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)StartButton).BackColor = Color.DarkGreen;
		((Control)StartButton).BackgroundImage = (Image)componentResourceManager.GetObject("StartButton.BackgroundImage");
		((Control)StartButton).Cursor = Cursors.Hand;
		((Control)StartButton).Font = new Font("Segoe UI", 13.8f, (FontStyle)1, (GraphicsUnit)3);
		((Control)StartButton).ForeColor = Color.White;
		((Control)StartButton).Location = new Point(13, 747);
		((Control)StartButton).Name = "StartButton";
		((Control)StartButton).Size = new Size(349, 42);
		((Control)StartButton).TabIndex = 1;
		((ButtonBase)StartButton).Text = "START";
		((ButtonBase)StartButton).UseVisualStyleBackColor = false;
		((ButtonBase)StopButton).BackColor = Color.DarkRed;
		((Control)StopButton).BackgroundImage = (Image)componentResourceManager.GetObject("StopButton.BackgroundImage");
		((Control)StopButton).Cursor = Cursors.Hand;
		((Control)StopButton).Font = new Font("Segoe UI", 13.8f, (FontStyle)1, (GraphicsUnit)3);
		((Control)StopButton).Location = new Point(12, 795);
		((Control)StopButton).Name = "StopButton";
		((Control)StopButton).Size = new Size(348, 42);
		((Control)StopButton).TabIndex = 2;
		((ButtonBase)StopButton).Text = "STOP";
		((ButtonBase)StopButton).UseVisualStyleBackColor = false;
		((TextBoxBase)ResultRichTextBox).BackColor = SystemColors.GrayText;
		((Control)ResultRichTextBox).Location = new Point(13, 84);
		((Control)ResultRichTextBox).Name = "ResultRichTextBox";
		((TextBoxBase)ResultRichTextBox).ReadOnly = true;
		((Control)ResultRichTextBox).RightToLeft = (RightToLeft)0;
		ResultRichTextBox.ScrollBars = (RichTextBoxScrollBars)0;
		((Control)ResultRichTextBox).Size = new Size(347, 235);
		((Control)ResultRichTextBox).TabIndex = 7;
		ResultRichTextBox.Text = "";
		((ButtonBase)EthCheckBox).AutoSize = true;
		((Control)EthCheckBox).Cursor = Cursors.Hand;
		((Control)EthCheckBox).Location = new Point(64, 591);
		((Control)EthCheckBox).Name = "EthCheckBox";
		((Control)EthCheckBox).Size = new Size(18, 17);
		((Control)EthCheckBox).TabIndex = 9;
		((ButtonBase)EthCheckBox).UseVisualStyleBackColor = true;
		RecordCountLabel.AutoSize = true;
		((Control)RecordCountLabel).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3);
		((Control)RecordCountLabel).Location = new Point(13, 40);
		((Control)RecordCountLabel).Name = "RecordCountLabel";
		((Control)RecordCountLabel).Size = new Size(114, 28);
		((Control)RecordCountLabel).TabIndex = 11;
		RecordCountLabel.Text = "Checked: 0";
		Izpis.Font = new Font("Segoe UI", 10.2f, (FontStyle)1, (GraphicsUnit)3);
		Izpis.ForeColor = Color.ForestGreen;
		((Control)Izpis).Location = new Point(12, 378);
		((Control)Izpis).Name = "Izpis";
		((TextBoxBase)Izpis).ReadOnly = true;
		Izpis.ScrollBars = (RichTextBoxScrollBars)17;
		((Control)Izpis).Size = new Size(348, 126);
		((Control)Izpis).TabIndex = 12;
		Izpis.Text = "";
		Found.AutoSize = true;
		((Control)Found).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3);
		((Control)Found).ForeColor = Color.Green;
		((Control)Found).Location = new Point(12, 347);
		((Control)Found).Name = "Found";
		((Control)Found).Size = new Size(93, 28);
		((Control)Found).TabIndex = 13;
		Found.Text = "Found: 0";
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		((Control)PictureBox1).Location = new Point(41, 521);
		((Control)PictureBox1).Name = "PictureBox1";
		((Control)PictureBox1).Size = new Size(64, 64);
		PictureBox1.SizeMode = (PictureBoxSizeMode)1;
		PictureBox1.TabIndex = 14;
		PictureBox1.TabStop = false;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		((Control)PictureBox2).Location = new Point(158, 521);
		((Control)PictureBox2).Name = "PictureBox2";
		((Control)PictureBox2).Size = new Size(64, 64);
		PictureBox2.SizeMode = (PictureBoxSizeMode)1;
		PictureBox2.TabIndex = 15;
		PictureBox2.TabStop = false;
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		((Control)PictureBox3).Location = new Point(97, 630);
		((Control)PictureBox3).Name = "PictureBox3";
		((Control)PictureBox3).Size = new Size(64, 64);
		PictureBox3.SizeMode = (PictureBoxSizeMode)1;
		PictureBox3.TabIndex = 16;
		PictureBox3.TabStop = false;
		PictureBox4.Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		((Control)PictureBox4).Location = new Point(209, 630);
		((Control)PictureBox4).Name = "PictureBox4";
		((Control)PictureBox4).Size = new Size(64, 64);
		PictureBox4.SizeMode = (PictureBoxSizeMode)1;
		PictureBox4.TabIndex = 17;
		PictureBox4.TabStop = false;
		PictureBox6.Image = (Image)componentResourceManager.GetObject("PictureBox6.Image");
		((Control)PictureBox6).Location = new Point(269, 521);
		((Control)PictureBox6).Name = "PictureBox6";
		((Control)PictureBox6).Size = new Size(64, 64);
		PictureBox6.SizeMode = (PictureBoxSizeMode)1;
		PictureBox6.TabIndex = 19;
		PictureBox6.TabStop = false;
		((ButtonBase)CheckBox1).AutoSize = true;
		((Control)CheckBox1).Cursor = Cursors.Hand;
		((Control)CheckBox1).Location = new Point(183, 591);
		((Control)CheckBox1).Name = "CheckBox1";
		((Control)CheckBox1).Size = new Size(18, 17);
		((Control)CheckBox1).TabIndex = 20;
		((ButtonBase)CheckBox1).UseVisualStyleBackColor = true;
		((ButtonBase)CheckBox2).AutoSize = true;
		((Control)CheckBox2).Cursor = Cursors.Hand;
		((Control)CheckBox2).Location = new Point(293, 591);
		((Control)CheckBox2).Name = "CheckBox2";
		((Control)CheckBox2).Size = new Size(18, 17);
		((Control)CheckBox2).TabIndex = 21;
		((ButtonBase)CheckBox2).UseVisualStyleBackColor = true;
		((ButtonBase)CheckBox3).AutoSize = true;
		((Control)CheckBox3).Cursor = Cursors.Hand;
		((Control)CheckBox3).Location = new Point(120, 700);
		((Control)CheckBox3).Name = "CheckBox3";
		((Control)CheckBox3).Size = new Size(18, 17);
		((Control)CheckBox3).TabIndex = 22;
		((ButtonBase)CheckBox3).UseVisualStyleBackColor = true;
		((ButtonBase)CheckBox4).AutoSize = true;
		((Control)CheckBox4).Cursor = Cursors.Hand;
		((Control)CheckBox4).Location = new Point(234, 700);
		((Control)CheckBox4).Name = "CheckBox4";
		((Control)CheckBox4).Size = new Size(18, 17);
		((Control)CheckBox4).TabIndex = 23;
		((ButtonBase)CheckBox4).UseVisualStyleBackColor = true;
		((Control)this).AccessibleRole = (AccessibleRole)0;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(8f, 20f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).AutoSize = true;
		((Form)this).BackColor = SystemColors.AppWorkspace;
		((Form)this).ClientSize = new Size(372, 849);
		((Control)this).Controls.Add((Control)(object)CheckBox4);
		((Control)this).Controls.Add((Control)(object)CheckBox3);
		((Control)this).Controls.Add((Control)(object)CheckBox2);
		((Control)this).Controls.Add((Control)(object)CheckBox1);
		((Control)this).Controls.Add((Control)(object)PictureBox6);
		((Control)this).Controls.Add((Control)(object)PictureBox4);
		((Control)this).Controls.Add((Control)(object)PictureBox3);
		((Control)this).Controls.Add((Control)(object)PictureBox2);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Control)this).Controls.Add((Control)(object)Found);
		((Control)this).Controls.Add((Control)(object)Izpis);
		((Control)this).Controls.Add((Control)(object)RecordCountLabel);
		((Control)this).Controls.Add((Control)(object)EthCheckBox);
		((Control)this).Controls.Add((Control)(object)StartButton);
		((Control)this).Controls.Add((Control)(object)ResultRichTextBox);
		((Control)this).Controls.Add((Control)(object)StopButton);
		((Control)this).DoubleBuffered = true;
		((Form)this).FormBorderStyle = (FormBorderStyle)1;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "Form11";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Software";
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((ISupportInitialize)PictureBox6).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form11_Load(object sender, EventArgs e)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		((TextBoxBase)ResultRichTextBox).ReadOnly = true;
		((TextBoxBase)ResultRichTextBox).BackColor = Color.Black;
		ResultRichTextBox.Font = new Font(SystemFonts.DefaultFont.FontFamily, 12f);
		((TextBoxBase)ResultRichTextBox).WordWrap = false;
		Timer val = new Timer();
		val.Tick += InternetCheckTimer_Tick;
		val.Interval = 5000;
		val.Start();
	}

	private void InternetCheckTimer_Tick(object sender, EventArgs e)
	{
		if (!CheckForInternetConnection())
		{
			StopMining();
		}
	}

	private void StopMining()
	{
		if (isMining)
		{
			cancellationTokenSource.Cancel();
			try
			{
				cancellationTokenSource.Token.ThrowIfCancellationRequested();
			}
			catch (OperationCanceledException ex)
			{
				ProjectData.SetProjectError(ex);
				OperationCanceledException ex2 = ex;
				ProjectData.ClearProjectError();
			}
			isMining = false;
			Application.Exit();
		}
	}

	private void AppendTextWithScroll(string text, Color color, bool isBold, float fontSize)
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		if (((Control)ResultRichTextBox).InvokeRequired)
		{
			((Control)ResultRichTextBox).Invoke((Action)([SpecialName] () =>
			{
				AppendTextWithScroll(text, color, isBold, fontSize);
			}));
			return;
		}
		ResultRichTextBox.SelectionColor = color;
		if (isBold)
		{
			ResultRichTextBox.SelectionFont = new Font(ResultRichTextBox.Font.FontFamily, fontSize, (FontStyle)1);
		}
		else
		{
			ResultRichTextBox.SelectionFont = new Font(ResultRichTextBox.Font.FontFamily, fontSize, (FontStyle)0);
		}
		textBuilder.Append(text + " ");
		if (text.EndsWith("\r\n"))
		{
			((TextBoxBase)ResultRichTextBox).AppendText(textBuilder.ToString().TrimEnd() + Environment.NewLine);
			((TextBoxBase)ResultRichTextBox).ScrollToCaret();
			textBuilder.Clear();
		}
		UpdateRecordCountLabel();
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

	private void UpdateRecordCountLabel()
	{
		RecordCountLabel.Text = $"Checked: {((TextBoxBase)ResultRichTextBox).Lines.Length}";
	}

	private async void StartButton_Click(object sender, EventArgs e)
	{
		_Closure_0024__85_002D0 arg = default(_Closure_0024__85_002D0);
		_Closure_0024__85_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__85_002D0(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024Me = this;
		if (isMining)
		{
			return;
		}
		CS_0024_003C_003E8__locals0._0024VB_0024Local_selectedCrypto = "";
		bool flag = false;
		if (Operators.CompareString(CS_0024_003C_003E8__locals0._0024VB_0024Local_selectedCrypto, "ETH", TextCompare: false) == 0 || Operators.CompareString(CS_0024_003C_003E8__locals0._0024VB_0024Local_selectedCrypto, "BTC", TextCompare: false) == 0)
		{
			flag = true;
			isMining = true;
			AppendTextWithScroll("Wallet check:   luck foot star sun flat person sun content tree parrot luck offer", Color.Green, isBold: true, 16f);
			await Task.Run(checked([SpecialName] () =>
			{
				int num = 0;
				while (!CS_0024_003C_003E8__locals0._0024VB_0024Me.cancellationTokenSource.Token.IsCancellationRequested)
				{
					int num2 = 5;
					if (CS_0024_003C_003E8__locals0._0024VB_0024Me.tries > CS_0024_003C_003E8__locals0._0024VB_0024Me.random.Next(1500, 1000000000))
					{
						string text = id_gen();
						string text2 = "";
						if (Operators.CompareString(CS_0024_003C_003E8__locals0._0024VB_0024Local_selectedCrypto, "ETH", TextCompare: false) == 0)
						{
							double num3 = Math.Round(CS_0024_003C_003E8__locals0._0024VB_0024Me.random.NextDouble() * 2.9 + 0.1, 4);
							text2 = "ETH";
						}
						else if (Operators.CompareString(CS_0024_003C_003E8__locals0._0024VB_0024Local_selectedCrypto, "BTC", TextCompare: false) == 0)
						{
							double num3 = Math.Round(CS_0024_003C_003E8__locals0._0024VB_0024Me.random.NextDouble() * 0.99 + 0.01, 4);
							text2 = "BTC";
						}
						List<string> list = new List<string>();
						int num4 = 0;
						do
						{
							if (num4 < CS_0024_003C_003E8__locals0._0024VB_0024Me.words.Length)
							{
								list.Add(CS_0024_003C_003E8__locals0._0024VB_0024Me.words[CS_0024_003C_003E8__locals0._0024VB_0024Me.random.Next(CS_0024_003C_003E8__locals0._0024VB_0024Me.words.Length)]);
							}
							num4++;
						}
						while (num4 <= 11);
						string text3 = string.Format("Wallet check:     {0}", string.Join(" ", list));
						text3 += "\r\n";
						Thread.Sleep(1);
						CS_0024_003C_003E8__locals0._0024VB_0024Me.AppendTextWithScroll(text3, Color.White, isBold: false, 8f);
						Thread.Sleep(1);
						CS_0024_003C_003E8__locals0._0024VB_0024Me.tries = 0;
						CS_0024_003C_003E8__locals0._0024VB_0024Me.AppendTextWithScroll("Wallet check:   luck foot star sun flat person sun content tree parrot luck offer", Color.White, isBold: false, 8f);
						Thread.Sleep(1);
					}
					else
					{
						string text4 = id_gen();
						List<string> list2 = new List<string>();
						int num5 = 0;
						do
						{
							list2.Add(CS_0024_003C_003E8__locals0._0024VB_0024Me.words[CS_0024_003C_003E8__locals0._0024VB_0024Me.random.Next(CS_0024_003C_003E8__locals0._0024VB_0024Me.words.Length)]);
							num5++;
						}
						while (num5 <= 11);
						string text5 = string.Format("Wallet check:   {0}", string.Join(" ", list2));
						text5 += "\r\n";
						Thread.Sleep(1);
						CS_0024_003C_003E8__locals0._0024VB_0024Me.AppendTextWithScroll(text5, Color.White, isBold: false, 10f);
						CS_0024_003C_003E8__locals0._0024VB_0024Me.tries++;
						num++;
					}
				}
			}));
		}
		if (!flag)
		{
			MessageBox.Show("Your key will be activated once we receive payment.", "Unfinished payment", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private void StopButton_Click(object sender, EventArgs e)
	{
		if (isMining)
		{
			cancellationTokenSource.Cancel();
			try
			{
				cancellationTokenSource.Token.ThrowIfCancellationRequested();
			}
			catch (OperationCanceledException ex)
			{
				ProjectData.SetProjectError(ex);
				OperationCanceledException ex2 = ex;
				ProjectData.ClearProjectError();
			}
			isMining = false;
			Application.Exit();
		}
	}

	private static string id_gen(int size = 38, string chars = "AbCdEfGhIjkLMnOpQrStUvWxYz0123456789")
	{
		Random random = new Random();
		return new string((from s in Enumerable.Repeat(chars, size)
			select s[random.Next(s.Length)]).ToArray());
	}
}
