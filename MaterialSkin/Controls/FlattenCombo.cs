using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MaterialSkin.Animations;

namespace MaterialSkin.Controls
{
	public class FlattenCombo : ComboBox
	{
		private Brush BorderBrush = new SolidBrush(SystemColors.ControlLightLight);
		private Brush ArrowBrush = new SolidBrush(SystemColors.ControlText);
		private Brush DropButtonBrush = new SolidBrush(SystemColors.Control);

		private Color _borderColor = Color.Black;
		private ButtonBorderStyle _borderStyle = ButtonBorderStyle.Solid;
		private static int WM_PAINT = 0x000F;

		private Color _ButtonColor = SystemColors.Control;

		public Color ButtonColor
		{
			get { return _ButtonColor; }
			set
			{
				_ButtonColor = value;
				DropButtonBrush = new SolidBrush(this.ButtonColor);
				this.Invalidate();
			}
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);

			switch (m.Msg)
			{
				case 0xf:
					//base.BackColor = Color.Black;
					Graphics g = this.CreateGraphics();




					//------------------------------------------------------
					int lineY = this.Bottom;

					//NUEVO
					//baseTextBox.TextAlign = TextAlignment;




					if (!animationManager.IsAnimating())
					{
						//No animation
						g.FillRectangle(this.Focused ? SkinManager.ColorScheme.PrimaryBrush : SkinManager.GetDividersBrush(), this.Location.X, lineY, this.Width, this.Focused ? 2 : 1);
					}
					else
					{
						//Animate
						int animationWidth = (int)(this.Width * animationManager.GetProgress());
						int halfAnimationWidth = animationWidth / 2;
						int animationStart = this.Location.X + this.Width / 2;

						//Unfocused background
						g.FillRectangle(SkinManager.GetDividersBrush(), this.Location.X, lineY, this.Width, 1);

						//Animated focus transition
						g.FillRectangle(SkinManager.ColorScheme.PrimaryBrush, animationStart - halfAnimationWidth, lineY, animationWidth, 2);
					}


					//------------------------------------------------------













					Pen p = new Pen(Color.Black);
					g.FillRectangle(BorderBrush, this.ClientRectangle);

					//Draw the background of the dropdown button
					Rectangle rect = new Rectangle(this.Width - 17, 0, 17, this.Height);
					g.FillRectangle(DropButtonBrush, rect);

					







					//Create the path for the arrow
					System.Drawing.Drawing2D.GraphicsPath pth = new System.Drawing.Drawing2D.GraphicsPath();
					PointF TopLeft = new PointF(this.Width - 13, (this.Height - 5) / 2);
					PointF TopRight = new PointF(this.Width - 6, (this.Height - 5) / 2);
					PointF Bottom = new PointF(this.Width - 9, (this.Height + 2) / 2);
					pth.AddLine(TopLeft, TopRight);
					pth.AddLine(TopRight, Bottom);

					g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

					//Determine the arrow's color.
					if (this.DroppedDown)
					{
						ArrowBrush = new SolidBrush(SystemColors.HighlightText);

						//Rectangle dropDownBounds = new Rectangle(0, 0, Width, Height + DropDownHeight);
						////ControlPaint.DrawBorder(g, dropDownBounds, _borderColor, _borderStyle);
						//ControlPaint.DrawBorder(g, dropDownBounds, _borderColor, 1, ButtonBorderStyle.Dotted, Color.GreenYellow, 1, ButtonBorderStyle.Solid, Color.Gold, 1, ButtonBorderStyle.Dashed, Color.HotPink, 1, ButtonBorderStyle.Solid);
					}
					else
					{
						ArrowBrush = new SolidBrush(SystemColors.ControlText);
					}

					//Draw the arrow
					g.FillPath(ArrowBrush, pth);


					



					break;
				default:
					break;
			}
		}

		[Category("Appearance")]
		public Color BorderColor
		{
			get { return _borderColor; }
			set
			{
				_borderColor = value;
				Invalidate(); // causes control to be redrawn
			}
		}

		[Category("Appearance")]
		public ButtonBorderStyle BorderStyle
		{
			get { return _borderStyle; }
			set
			{
				_borderStyle = value;
				Invalidate();
			}
		}

		protected override void OnLostFocus(System.EventArgs e)
		{
			base.OnLostFocus(e);
			this.Invalidate();
		}

		protected override void OnGotFocus(System.EventArgs e)
		{
			base.OnGotFocus(e);
			this.Invalidate();
		}
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.Invalidate();
		}


		////-------------------------------------------------------------------------------------

		[Browsable(false)]
		public MaterialSkinManager SkinManager { get { return MaterialSkinManager.Instance; } }

		private readonly AnimationManager animationManager;

		public FlattenCombo()
		{
			SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.DoubleBuffer, true);

			animationManager = new AnimationManager
			{
				Increment = 0.06,
				AnimationType = AnimationType.EaseInOut,
				InterruptAnimation = false
			};
			animationManager.OnAnimationProgress += sender => Invalidate();

			//this.Font = SkinManager.ROBOTO_REGULAR_11;
			//this.ForeColor = SkinManager.GetPrimaryTextColor();

			//// --------------------------------

			//if (!Controls.Contains(this) && !DesignMode)
			//{
			//	Controls.Add(this);
			//}

			//this.GotFocus += (sender, args) => animationManager.StartNewAnimation(AnimationDirection.In);
			//this.LostFocus += (sender, args) => animationManager.StartNewAnimation(AnimationDirection.Out);
			//BackColorChanged += (sender, args) =>
			//{
			//	this.BackColor = BackColor;
			//	this.ForeColor = SkinManager.GetPrimaryTextColor();
			//};

			////Fix for tabstop
			////baseComboBox.TabStop = true;
			//this.TabStop = false;
		}

		//private readonly BaseComboBox baseComboBox;


		//public FlattenCombo()
		//{
		//	SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.DoubleBuffer, true);

		//	animationManager = new AnimationManager
		//	{
		//		Increment = 0.06,
		//		AnimationType = AnimationType.EaseInOut,
		//		InterruptAnimation = false
		//	};
		//	animationManager.OnAnimationProgress += sender => Invalidate();

		//	baseComboBox = new BaseComboBox
		//	{
		//		//BorderStyle = BorderStyle.None,

		//		Font = SkinManager.ROBOTO_REGULAR_11,
		//		ForeColor = SkinManager.GetPrimaryTextColor(),
		//		Location = new Point(0, 0),
		//		Width = Width,
		//		Height = Height - 57
		//		//FlatStyle = FlatStyle.Flat,
		//		//DropDownStyle = ComboBoxStyle.DropDownList

		//		//Multiline = false,
		//		//TextAlign = HorizontalAlignment.Left
		//	};

		//	if (!Controls.Contains(baseComboBox) && !DesignMode)
		//	{
		//		Controls.Add(baseComboBox);
		//	}

		//	baseComboBox.GotFocus += (sender, args) => animationManager.StartNewAnimation(AnimationDirection.In);
		//	baseComboBox.LostFocus += (sender, args) => animationManager.StartNewAnimation(AnimationDirection.Out);
		//	BackColorChanged += (sender, args) =>
		//	{
		//		baseComboBox.BackColor = BackColor;
		//		baseComboBox.ForeColor = SkinManager.GetPrimaryTextColor();
		//	};

		//	//Fix for tabstop
		//	baseComboBox.TabStop = true;
		//	this.TabStop = false;
		//}

		//protected override void OnPaint(PaintEventArgs pevent)
		//{
		//	var g = pevent.Graphics;
		//	g.Clear(Parent.BackColor);

		//	//int lineY = baseComboBox.Bottom + 3;
		//	int lineY = baseComboBox.Bottom;

		//	//NUEVO
		//	//baseTextBox.TextAlign = TextAlignment;

		//	if (!animationManager.IsAnimating())
		//	{
		//		//No animation
		//		g.FillRectangle(baseComboBox.Focused ? SkinManager.ColorScheme.PrimaryBrush : SkinManager.GetDividersBrush(), baseComboBox.Location.X, lineY, baseComboBox.Width, baseComboBox.Focused ? 2 : 1);
		//	}
		//	else
		//	{
		//		//Animate
		//		int animationWidth = (int)(baseComboBox.Width * animationManager.GetProgress());
		//		int halfAnimationWidth = animationWidth / 2;
		//		int animationStart = baseComboBox.Location.X + baseComboBox.Width / 2;

		//		//Unfocused background
		//		g.FillRectangle(SkinManager.GetDividersBrush(), baseComboBox.Location.X, lineY, baseComboBox.Width, 1);

		//		//Animated focus transition
		//		g.FillRectangle(SkinManager.ColorScheme.PrimaryBrush, animationStart - halfAnimationWidth, lineY, animationWidth, 2);
		//	}
		//}

		////protected override void OnResize(EventArgs e)
		////{
		////	base.OnResize(e);

		////	baseComboBox.Location = new Point(0, 0);
		////	baseComboBox.Width = Width;

		////	//Height = baseComboBox.Height + 5;
		////	Height = baseComboBox.Height + 2;
		////}

		//protected override void OnCreateControl()
		//{
		//	base.OnCreateControl();

		//	baseComboBox.BackColor = Parent.BackColor;
		//	baseComboBox.ForeColor = SkinManager.GetPrimaryTextColor();
		//}




		//private class BaseComboBox : ComboBox
		//{
		//	[DllImport("user32.dll", CharSet = CharSet.Auto)]
		//	private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);

		//	private const int EM_SETCUEBANNER = 0x1501;
		//	private const char EmptyChar = (char)0;
		//	private const char VisualStylePasswordChar = '\u25CF';
		//	private const char NonVisualStylePasswordChar = '\u002A';

		//	private string hint = string.Empty;
		//	public string Hint
		//	{
		//		get { return hint; }
		//		set
		//		{
		//			hint = value;
		//			SendMessage(Handle, EM_SETCUEBANNER, (int)IntPtr.Zero, Hint);
		//		}
		//	}

		//	private char passwordChar = EmptyChar;
		//	public char PasswordChar
		//	{
		//		get { return passwordChar; }
		//		set
		//		{
		//			passwordChar = value;
		//			SetBasePasswordChar();
		//		}
		//	}

		//	public new void SelectAll()
		//	{
		//		BeginInvoke((MethodInvoker)delegate ()
		//		{
		//			base.Focus();
		//			base.SelectAll();
		//		});
		//	}

		//	public new void Focus()
		//	{
		//		BeginInvoke((MethodInvoker)delegate ()
		//		{
		//			base.Focus();
		//		});
		//	}

		//	private char useSystemPasswordChar = EmptyChar;
		//	public bool UseSystemPasswordChar
		//	{
		//		get { return useSystemPasswordChar != EmptyChar; }
		//		set
		//		{
		//			if (value)
		//			{
		//				useSystemPasswordChar = Application.RenderWithVisualStyles ? VisualStylePasswordChar : NonVisualStylePasswordChar;
		//			}
		//			else
		//			{
		//				useSystemPasswordChar = EmptyChar;
		//			}

		//			SetBasePasswordChar();
		//		}
		//	}

		//	private void SetBasePasswordChar()
		//	{
		//		//base.PasswordChar = UseSystemPasswordChar ? useSystemPasswordChar : passwordChar;
		//	}

		//	public BaseComboBox()
		//	{
		//		MaterialContextMenuStrip cms = new TextBoxContextMenuStrip();
		//		cms.Opening += ContextMenuStripOnOpening;
		//		//cms.OnItemClickStart += ContextMenuStripOnItemClickStart;

		//		ContextMenuStrip = cms;
		//	}

		//	private void ContextMenuStripOnOpening(object sender, CancelEventArgs cancelEventArgs)
		//	{
		//		var strip = sender as TextBoxContextMenuStrip;
		//		if (strip != null)
		//		{
		//			//strip.undo.Enabled = CanUndo;
		//			strip.cut.Enabled = !string.IsNullOrEmpty(SelectedText);
		//			strip.copy.Enabled = !string.IsNullOrEmpty(SelectedText);
		//			strip.paste.Enabled = Clipboard.ContainsText();
		//			strip.delete.Enabled = !string.IsNullOrEmpty(SelectedText);
		//			strip.selectAll.Enabled = !string.IsNullOrEmpty(Text);
		//		}
		//	}
		//}

		//private class TextBoxContextMenuStrip : MaterialContextMenuStrip
		//{
		//	public readonly ToolStripItem undo = new MaterialToolStripMenuItem { Text = "Undo" };
		//	public readonly ToolStripItem seperator1 = new ToolStripSeparator();
		//	public readonly ToolStripItem cut = new MaterialToolStripMenuItem { Text = "Cut" };
		//	public readonly ToolStripItem copy = new MaterialToolStripMenuItem { Text = "Copy" };
		//	public readonly ToolStripItem paste = new MaterialToolStripMenuItem { Text = "Paste" };
		//	public readonly ToolStripItem delete = new MaterialToolStripMenuItem { Text = "Delete" };
		//	public readonly ToolStripItem seperator2 = new ToolStripSeparator();
		//	public readonly ToolStripItem selectAll = new MaterialToolStripMenuItem { Text = "Select All" };

		//	public TextBoxContextMenuStrip()
		//	{
		//		Items.AddRange(new[]
		//		{
		//			undo,
		//			seperator1,
		//			cut,
		//			copy,
		//			paste,
		//			delete,
		//			seperator2,
		//			selectAll
		//		});
		//	}
		//}
	}
}
