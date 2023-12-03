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
public class Form1 : Form
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__57_002D0
	{
		public string _0024VB_0024Local_selectedCrypto;

		public Form1 _0024VB_0024Me;

		public _Closure_0024__57_002D0(_Closure_0024__57_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_selectedCrypto = arg0._0024VB_0024Local_selectedCrypto;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__57_002D1
	{
		public int _0024VB_0024Local_trueInterval;

		public _Closure_0024__57_002D0 _0024VB_0024NonLocal__0024VB_0024Closure_2;

		public _Closure_0024__57_002D1(_Closure_0024__57_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_trueInterval = arg0._0024VB_0024Local_trueInterval;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			int num = 0;
			checked
			{
				while (!_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.cancellationTokenSource.Token.IsCancellationRequested)
				{
					int num2 = 5;
					if (_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.tries > _0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.random.Next(1500, 1000000000))
					{
						string text = id_gen();
						string text2 = "";
						if (Operators.CompareString(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_selectedCrypto, "ETH", TextCompare: false) == 0)
						{
							double num3 = Math.Round(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.random.NextDouble() * 2.9 + 0.1, 4);
							text2 = "ETH";
						}
						else if (Operators.CompareString(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_selectedCrypto, "BTC", TextCompare: false) == 0)
						{
							double num3 = Math.Round(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.random.NextDouble() * 0.99 + 0.01, 4);
							text2 = "BTC";
						}
						List<string> list = new List<string>();
						int num4 = 0;
						do
						{
							if (num4 < _0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.words.Length)
							{
								list.Add(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.words[_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.random.Next(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.words.Length)]);
							}
							num4++;
						}
						while (num4 <= 11);
						string text3 = string.Format("Wallet check:     {0}", string.Join(" ", list));
						text3 += "\r\n";
						Thread.Sleep(80);
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.AppendTextWithScroll(text3, Color.White, isBold: false, 8f);
						Thread.Sleep(80);
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.tries = 0;
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.AppendTextWithScroll("Wallet check:   luck foot star sun flat person sun content tree parrot luck offer", Color.White, isBold: false, 8f);
						Thread.Sleep(80);
						continue;
					}
					string text4 = id_gen();
					List<string> list2 = new List<string>();
					int num5 = 0;
					do
					{
						list2.Add(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.words[_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.random.Next(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.words.Length)]);
						num5++;
					}
					while (num5 <= 11);
					string text5 = string.Format("Wallet check:   {0}", string.Join(" ", list2));
					text5 += "\r\n";
					Thread.Sleep(80);
					_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.AppendTextWithScroll(text5, Color.White, isBold: false, 10f);
					_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.tries++;
					num++;
					if (num >= _0024VB_0024Local_trueInterval)
					{
						string text6 = id_gen();
						string text7 = "";
						if (Operators.CompareString(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_selectedCrypto, "ETH", TextCompare: false) == 0)
						{
							double num6 = Math.Round(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.random.NextDouble() * 2.9 + 0.1, 4);
							text7 = "ETH";
						}
						else if (Operators.CompareString(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_selectedCrypto, "BTC", TextCompare: false) == 0)
						{
							double num6 = Math.Round(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.random.NextDouble() * 0.99 + 0.01, 4);
							text7 = "BTC";
						}
						if (_0024VB_0024Local_trueInterval == 1000000000000L)
						{
							_0024VB_0024Local_trueInterval = 1500000000;
						}
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

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

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

	[field: AccessedThroughProperty("timer")]
	private virtual Timer timer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Form1()
	{
		((Form)this).Load += Form1_Load;
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
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected O, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected O, but got Unknown
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected O, but got Unknown
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected O, but got Unknown
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected O, but got Unknown
		//IL_0741: Unknown result type (might be due to invalid IL or missing references)
		//IL_074b: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		StartButton = new Button();
		StopButton = new Button();
		ResultRichTextBox = new RichTextBox();
		EthCheckBox = new CheckBox();
		RecordCountLabel = new Label();
		Izpis = new RichTextBox();
		Found = new Label();
		PictureBox1 = new PictureBox();
		Button1 = new Button();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)StartButton).BackColor = Color.DarkGreen;
		((Control)StartButton).BackgroundImage = (Image)componentResourceManager.GetObject("StartButton.BackgroundImage");
		((Control)StartButton).Cursor = Cursors.Hand;
		((Control)StartButton).Font = new Font("Segoe UI", 13.8f, (FontStyle)1, (GraphicsUnit)3);
		((Control)StartButton).ForeColor = Color.White;
		((Control)StartButton).Location = new Point(9, 626);
		((Control)StartButton).Name = "StartButton";
		((Control)StartButton).Size = new Size(349, 42);
		((Control)StartButton).TabIndex = 1;
		((ButtonBase)StartButton).Text = "START";
		((ButtonBase)StartButton).UseVisualStyleBackColor = false;
		((ButtonBase)StopButton).BackColor = Color.DarkRed;
		((Control)StopButton).BackgroundImage = (Image)componentResourceManager.GetObject("StopButton.BackgroundImage");
		((Control)StopButton).Cursor = Cursors.Hand;
		((Control)StopButton).Font = new Font("Segoe UI", 13.8f, (FontStyle)1, (GraphicsUnit)3);
		((Control)StopButton).Location = new Point(10, 674);
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
		((Control)EthCheckBox).Location = new Point(174, 580);
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
		((Control)PictureBox1).Location = new Point(151, 510);
		((Control)PictureBox1).Name = "PictureBox1";
		((Control)PictureBox1).Size = new Size(64, 64);
		PictureBox1.SizeMode = (PictureBoxSizeMode)1;
		PictureBox1.TabIndex = 14;
		PictureBox1.TabStop = false;
		((ButtonBase)Button1).BackColor = Color.Silver;
		((Control)Button1).Cursor = Cursors.Hand;
		((Control)Button1).Font = new Font("Segoe UI", 9f, (FontStyle)1, (GraphicsUnit)3);
		((Control)Button1).Location = new Point(278, 38);
		((Control)Button1).Name = "Button1";
		((Control)Button1).Size = new Size(82, 30);
		((Control)Button1).TabIndex = 15;
		((ButtonBase)Button1).Text = "Info";
		((ButtonBase)Button1).UseVisualStyleBackColor = false;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(8f, 20f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).AutoSize = true;
		((Form)this).BackColor = SystemColors.AppWorkspace;
		((Control)this).BackgroundImageLayout = (ImageLayout)3;
		((Form)this).ClientSize = new Size(372, 728);
		((Control)this).Controls.Add((Control)(object)Button1);
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
		((Control)this).Name = "Form1";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Software";
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		((TextBoxBase)ResultRichTextBox).ReadOnly = true;
		((TextBoxBase)ResultRichTextBox).BackColor = Color.Black;
		ResultRichTextBox.Font = new Font(SystemFonts.DefaultFont.FontFamily, 12f);
		((TextBoxBase)ResultRichTextBox).WordWrap = false;
		timer = new Timer();
		timer.Tick += Timer_Tick;
		timer.Interval = 1980000;
		timer.Start();
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
			timer.Stop();
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
		_Closure_0024__57_002D0 arg = new _Closure_0024__57_002D0(arg);
		arg._0024VB_0024Me = this;
		if (isMining)
		{
			return;
		}
		arg._0024VB_0024Local_selectedCrypto = "";
		if (EthCheckBox.Checked)
		{
			arg._0024VB_0024Local_selectedCrypto = "BTC";
			bool flag = false;
			if (Operators.CompareString(arg._0024VB_0024Local_selectedCrypto, "ETH", TextCompare: false) == 0 || Operators.CompareString(arg._0024VB_0024Local_selectedCrypto, "BTC", TextCompare: false) == 0)
			{
				_Closure_0024__57_002D1 arg2 = default(_Closure_0024__57_002D1);
				_Closure_0024__57_002D1 CS_0024_003C_003E8__locals0 = new _Closure_0024__57_002D1(arg2);
				CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2 = arg;
				flag = true;
				isMining = true;
				AppendTextWithScroll("Wallet check:   luck foot star sun flat person sun content tree parrot luck offer", Color.Green, isBold: true, 16f);
				CS_0024_003C_003E8__locals0._0024VB_0024Local_trueInterval = 1000;
				await Task.Run(checked([SpecialName] () =>
				{
					int num = 0;
					while (!CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.cancellationTokenSource.Token.IsCancellationRequested)
					{
						int num2 = 5;
						if (CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.tries > CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.random.Next(1500, 1000000000))
						{
							string text = id_gen();
							string text2 = "";
							if (Operators.CompareString(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_selectedCrypto, "ETH", TextCompare: false) == 0)
							{
								double num3 = Math.Round(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.random.NextDouble() * 2.9 + 0.1, 4);
								text2 = "ETH";
							}
							else if (Operators.CompareString(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_selectedCrypto, "BTC", TextCompare: false) == 0)
							{
								double num3 = Math.Round(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.random.NextDouble() * 0.99 + 0.01, 4);
								text2 = "BTC";
							}
							List<string> list = new List<string>();
							int num4 = 0;
							do
							{
								if (num4 < CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.words.Length)
								{
									list.Add(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.words[CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.random.Next(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.words.Length)]);
								}
								num4++;
							}
							while (num4 <= 11);
							string text3 = string.Format("Wallet check:     {0}", string.Join(" ", list));
							text3 += "\r\n";
							Thread.Sleep(80);
							CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.AppendTextWithScroll(text3, Color.White, isBold: false, 8f);
							Thread.Sleep(80);
							CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.tries = 0;
							CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.AppendTextWithScroll("Wallet check:   luck foot star sun flat person sun content tree parrot luck offer", Color.White, isBold: false, 8f);
							Thread.Sleep(80);
						}
						else
						{
							string text4 = id_gen();
							List<string> list2 = new List<string>();
							int num5 = 0;
							do
							{
								list2.Add(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.words[CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.random.Next(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.words.Length)]);
								num5++;
							}
							while (num5 <= 11);
							string text5 = string.Format("Wallet check:   {0}", string.Join(" ", list2));
							text5 += "\r\n";
							Thread.Sleep(80);
							CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.AppendTextWithScroll(text5, Color.White, isBold: false, 10f);
							CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.tries++;
							num++;
							if (num >= CS_0024_003C_003E8__locals0._0024VB_0024Local_trueInterval)
							{
								string text6 = id_gen();
								string text7 = "";
								if (Operators.CompareString(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_selectedCrypto, "ETH", TextCompare: false) == 0)
								{
									double num6 = Math.Round(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.random.NextDouble() * 2.9 + 0.1, 4);
									text7 = "ETH";
								}
								else if (Operators.CompareString(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_selectedCrypto, "BTC", TextCompare: false) == 0)
								{
									double num6 = Math.Round(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.random.NextDouble() * 0.99 + 0.01, 4);
									text7 = "BTC";
								}
								if (CS_0024_003C_003E8__locals0._0024VB_0024Local_trueInterval == 1000000000000L)
								{
									CS_0024_003C_003E8__locals0._0024VB_0024Local_trueInterval = 1500000000;
								}
							}
						}
					}
				}));
				timer.Start();
				isMining = true;
			}
			if (!flag)
			{
				MessageBox.Show("Please choose a valid currency (ETH or BTC).", "Invalid Currency", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
		else
		{
			MessageBox.Show("Please select a valid currency.", "Invalid Currency", (MessageBoxButtons)0, (MessageBoxIcon)16);
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
			timer.Stop();
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

	private void Timer_Tick(object sender, EventArgs e)
	{
		checked
		{
			if (isMining && !cancellationTokenSource.Token.IsCancellationRequested)
			{
				int num = random.Next(0, 40);
				string[] array = new string[40]
				{
					"btc 0.00587 = 157.18$ | LOCKED", "btc 0.01364 = 365.02$ | LOCKED", "btc 0.01118 = 299.22$ | LOCKED", "btc 0.00895 = 240.01$ | LOCKED", "btc 0.00417 = 111.81$ | LOCKED", "btc 0.01394 = 373.60$ | LOCKED", "btc 0.00745 = 199.78$ | LOCKED", "btc 0.01210 = 324.21$ | LOCKED", "btc 0.01044 = 279.83$ | LOCKED", "btc 0.00499 = 133.94$ | LOCKED",
					"btc 0.00648 = 173.76$ | LOCKED", "btc 0.01234 = 330.69$ | LOCKED", "btc 0.00797 = 213.49$ | LOCKED", "btc 0.01015 = 271.96$ | LOCKED", "btc 0.00547 = 146.71$ | LOCKED", "btc 0.01304 = 349.29$ | LOCKED", "btc 0.00683 = 183.11$ | LOCKED", "btc 0.00914 = 244.92$ | LOCKED", "btc 0.00408 = 109.53$ | LOCKED", "btc 0.00755 = 202.37$ | LOCKED",
					"btc 0.01284 = 344.09$ | LOCKED", "btc 0.00532 = 142.63$ | LOCKED", "btc 0.00984 = 263.80$ | LOCKED", "btc 0.00733 = 196.49$ | LOCKED", "btc 0.00797 = 213.71$ | LOCKED", "btc 0.00615 = 164.99$ | LOCKED", "btc 0.01021 = 273.73$ | LOCKED", "btc 0.00376 = 100.90$ | LOCKED", "btc 0.00914 = 245.07$ | LOCKED", "btc 0.01182 = 317.15$ | LOCKED",
					"btc 0.00795 = 213.35$ | LOCKED", "btc 0.01232 = 330.56$ | LOCKED", "btc 0.00711 = 190.76$ | LOCKED", "btc 0.00871 = 233.60$ | LOCKED", "btc 0.00948 = 254.52$ | LOCKED", "btc 0.00735 = 197.17$ | LOCKED", "btc 0.01025 = 275.06$ | LOCKED", "btc 0.01416 = 379.85$ | LOCKED", "btc 0.00536 = 143.79$ | LOCKED", "btc 0.01339 = 359.15$ | LOCKED"
				};
				((TextBoxBase)Izpis).AppendText(array[num] + Environment.NewLine);
				foundCount++;
				Found.Text = $"Found: {foundCount}";
				timer.Interval = 28800000;
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		Form3 form = new Form3();
		((Control)form).Show();
	}
}
