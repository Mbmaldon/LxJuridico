using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MaterialSkin.Animations;

namespace MaterialSkin.Controls
{
	//[System.ComponentModel.LookupBindingProperties("DataSource", "DisplayMember", "ValueMember", "LookupMember")]
	//[System.ComponentModel.LookupBindingProperties("DataSource", "DisplayMember", "ValueMember", "LookupMember")]
	public class MaterialComboBox : Control, IMaterialControl
	{
		//Properties for managing the material design properties
		[Browsable(false)]
		public int Depth { get; set; }
		[Browsable(false)]
		public MaterialSkinManager SkinManager { get { return MaterialSkinManager.Instance; } }
		[Browsable(false)]
		public MouseState MouseState { get; set; }

		public override string Text { get { return baseComboBox.Text; } set { baseComboBox.Text = value; } }
		public new object Tag { get { return baseComboBox.Tag; } set { baseComboBox.Tag = value; } }
		public int MaxLength { get { return baseComboBox.MaxLength; } set { baseComboBox.MaxLength = value; } }

		public int DropDownWidth { get { return baseComboBox.DropDownWidth; } set { baseComboBox.DropDownWidth = value; } }

		public string SelectedText { get { return baseComboBox.SelectedText; } set { baseComboBox.SelectedText = value; } }
		public string Hint { get { return baseComboBox.Hint; } set { baseComboBox.Hint = value; } }

		//public int SelectionStart { get { return baseComboBox.SelectionStart; } set { baseComboBox.SelectionStart = value; } }
		//public int SelectionLength { get { return baseComboBox.SelectionLength; } set { baseComboBox.SelectionLength = value; } }
		//public int TextLength { get { return baseTextBox.TextLength; } }

		public bool UseSystemPasswordChar { get { return baseComboBox.UseSystemPasswordChar; } set { baseComboBox.UseSystemPasswordChar = value; } }
		public char PasswordChar { get { return baseComboBox.PasswordChar; } set { baseComboBox.PasswordChar = value; } }

		public void SelectAll() { baseComboBox.SelectAll(); }
		//public void Clear() { baseTextBox.Clear(); }
		public new void Focus() { baseComboBox.Focus(); }


		#region Forwarding events to baseTextBox
		//public event EventHandler AcceptsTabChanged
		//{
		//	add
		//	{
		//		baseTextBox.Ac AcceptsTabChanged += value;
		//	}
		//	remove
		//	{
		//		baseTextBox.AcceptsTabChanged -= value;
		//	}
		//}

		public new event EventHandler AutoSizeChanged
		{
			add
			{
				baseComboBox.AutoSizeChanged += value;
			}
			remove
			{
				baseComboBox.AutoSizeChanged -= value;
			}
		}

		public new event EventHandler BackgroundImageChanged
		{
			add
			{
				baseComboBox.BackgroundImageChanged += value;
			}
			remove
			{
				baseComboBox.BackgroundImageChanged -= value;
			}
		}

		public new event EventHandler BackgroundImageLayoutChanged
		{
			add
			{
				baseComboBox.BackgroundImageLayoutChanged += value;
			}
			remove
			{
				baseComboBox.BackgroundImageLayoutChanged -= value;
			}
		}

		public new event EventHandler BindingContextChanged
		{
			add
			{
				baseComboBox.BindingContextChanged += value;
			}
			remove
			{
				baseComboBox.BindingContextChanged -= value;
			}
		}

		//public event EventHandler BorderStyleChanged
		//{
		//	add
		//	{
		//		baseTextBox.BorderStyleChanged += value;
		//	}
		//	remove
		//	{
		//		baseTextBox.BorderStyleChanged -= value;
		//	}
		//}

		public new event EventHandler CausesValidationChanged
		{
			add
			{
				baseComboBox.CausesValidationChanged += value;
			}
			remove
			{
				baseComboBox.CausesValidationChanged -= value;
			}
		}

		public new event UICuesEventHandler ChangeUICues
		{
			add
			{
				baseComboBox.ChangeUICues += value;
			}
			remove
			{
				baseComboBox.ChangeUICues -= value;
			}
		}

		public new event EventHandler Click
		{
			add
			{
				baseComboBox.Click += value;
			}
			remove
			{
				baseComboBox.Click -= value;
			}
		}

		public new event EventHandler ClientSizeChanged
		{
			add
			{
				baseComboBox.ClientSizeChanged += value;
			}
			remove
			{
				baseComboBox.ClientSizeChanged -= value;
			}
		}

		public new event EventHandler ContextMenuChanged
		{
			add
			{
				baseComboBox.ContextMenuChanged += value;
			}
			remove
			{
				baseComboBox.ContextMenuChanged -= value;
			}
		}

		public new event EventHandler ContextMenuStripChanged
		{
			add
			{
				baseComboBox.ContextMenuStripChanged += value;
			}
			remove
			{
				baseComboBox.ContextMenuStripChanged -= value;
			}
		}

		public new event ControlEventHandler ControlAdded
		{
			add
			{
				baseComboBox.ControlAdded += value;
			}
			remove
			{
				baseComboBox.ControlAdded -= value;
			}
		}

		public new event ControlEventHandler ControlRemoved
		{
			add
			{
				baseComboBox.ControlRemoved += value;
			}
			remove
			{
				baseComboBox.ControlRemoved -= value;
			}
		}

		public new event EventHandler CursorChanged
		{
			add
			{
				baseComboBox.CursorChanged += value;
			}
			remove
			{
				baseComboBox.CursorChanged -= value;
			}
		}

		public new event EventHandler Disposed
		{
			add
			{
				baseComboBox.Disposed += value;
			}
			remove
			{
				baseComboBox.Disposed -= value;
			}
		}

		public new event EventHandler DockChanged
		{
			add
			{
				baseComboBox.DockChanged += value;
			}
			remove
			{
				baseComboBox.DockChanged -= value;
			}
		}

		public new event EventHandler DoubleClick
		{
			add
			{
				baseComboBox.DoubleClick += value;
			}
			remove
			{
				baseComboBox.DoubleClick -= value;
			}
		}

		public new event DragEventHandler DragDrop
		{
			add
			{
				baseComboBox.DragDrop += value;
			}
			remove
			{
				baseComboBox.DragDrop -= value;
			}
		}

		public new event DragEventHandler DragEnter
		{
			add
			{
				baseComboBox.DragEnter += value;
			}
			remove
			{
				baseComboBox.DragEnter -= value;
			}
		}

		public new event EventHandler DragLeave
		{
			add
			{
				baseComboBox.DragLeave += value;
			}
			remove
			{
				baseComboBox.DragLeave -= value;
			}
		}

		public new event DragEventHandler DragOver
		{
			add
			{
				baseComboBox.DragOver += value;
			}
			remove
			{
				baseComboBox.DragOver -= value;
			}
		}

		public new event EventHandler EnabledChanged
		{
			add
			{
				baseComboBox.EnabledChanged += value;
			}
			remove
			{
				baseComboBox.EnabledChanged -= value;
			}
		}

		public new event EventHandler Enter
		{
			add
			{
				baseComboBox.Enter += value;
			}
			remove
			{
				baseComboBox.Enter -= value;
			}
		}

		public new event EventHandler FontChanged
		{
			add
			{
				baseComboBox.FontChanged += value;
			}
			remove
			{
				baseComboBox.FontChanged -= value;
			}
		}

		public new event EventHandler ForeColorChanged
		{
			add
			{
				baseComboBox.ForeColorChanged += value;
			}
			remove
			{
				baseComboBox.ForeColorChanged -= value;
			}
		}

		public new event GiveFeedbackEventHandler GiveFeedback
		{
			add
			{
				baseComboBox.GiveFeedback += value;
			}
			remove
			{
				baseComboBox.GiveFeedback -= value;
			}
		}

		public new event EventHandler GotFocus
		{
			add
			{
				baseComboBox.GotFocus += value;
			}
			remove
			{
				baseComboBox.GotFocus -= value;
			}
		}

		public new event EventHandler HandleCreated
		{
			add
			{
				baseComboBox.HandleCreated += value;
			}
			remove
			{
				baseComboBox.HandleCreated -= value;
			}
		}

		public new event EventHandler HandleDestroyed
		{
			add
			{
				baseComboBox.HandleDestroyed += value;
			}
			remove
			{
				baseComboBox.HandleDestroyed -= value;
			}
		}

		public new event HelpEventHandler HelpRequested
		{
			add
			{
				baseComboBox.HelpRequested += value;
			}
			remove
			{
				baseComboBox.HelpRequested -= value;
			}
		}

		//public event EventHandler HideSelectionChanged
		//{
		//	add
		//	{
		//		baseTextBox.HideSelectionChanged += value;
		//	}
		//	remove
		//	{
		//		baseTextBox.HideSelectionChanged -= value;
		//	}
		//}

		public new event EventHandler ImeModeChanged
		{
			add
			{
				baseComboBox.ImeModeChanged += value;
			}
			remove
			{
				baseComboBox.ImeModeChanged -= value;
			}
		}

		public new event InvalidateEventHandler Invalidated
		{
			add
			{
				baseComboBox.Invalidated += value;
			}
			remove
			{
				baseComboBox.Invalidated -= value;
			}
		}

		public new event KeyEventHandler KeyDown
		{
			add
			{
				baseComboBox.KeyDown += value;
			}
			remove
			{
				baseComboBox.KeyDown -= value;
			}
		}

		public new event KeyPressEventHandler KeyPress
		{
			add
			{
				baseComboBox.KeyPress += value;
			}
			remove
			{
				baseComboBox.KeyPress -= value;
			}
		}

		public new event KeyEventHandler KeyUp
		{
			add
			{
				baseComboBox.KeyUp += value;
			}
			remove
			{
				baseComboBox.KeyUp -= value;
			}
		}

		public new event LayoutEventHandler Layout
		{
			add
			{
				baseComboBox.Layout += value;
			}
			remove
			{
				baseComboBox.Layout -= value;
			}
		}

		public new event EventHandler Leave
		{
			add
			{
				baseComboBox.Leave += value;
			}
			remove
			{
				baseComboBox.Leave -= value;
			}
		}

		public new event EventHandler LocationChanged
		{
			add
			{
				baseComboBox.LocationChanged += value;
			}
			remove
			{
				baseComboBox.LocationChanged -= value;
			}
		}

		public new event EventHandler LostFocus
		{
			add
			{
				baseComboBox.LostFocus += value;
			}
			remove
			{
				baseComboBox.LostFocus -= value;
			}
		}

		public new event EventHandler MarginChanged
		{
			add
			{
				baseComboBox.MarginChanged += value;
			}
			remove
			{
				baseComboBox.MarginChanged -= value;
			}
		}

		//public event EventHandler ModifiedChanged
		//{
		//	add
		//	{
		//		baseTextBox.ModifiedChanged += value;
		//	}
		//	remove
		//	{
		//		baseTextBox.ModifiedChanged -= value;
		//	}
		//}

		public new event EventHandler MouseCaptureChanged
		{
			add
			{
				baseComboBox.MouseCaptureChanged += value;
			}
			remove
			{
				baseComboBox.MouseCaptureChanged -= value;
			}
		}

		public new event MouseEventHandler MouseClick
		{
			add
			{
				baseComboBox.MouseClick += value;
			}
			remove
			{
				baseComboBox.MouseClick -= value;
			}
		}

		public new event MouseEventHandler MouseDoubleClick
		{
			add
			{
				baseComboBox.MouseDoubleClick += value;
			}
			remove
			{
				baseComboBox.MouseDoubleClick -= value;
			}
		}

		public new event MouseEventHandler MouseDown
		{
			add
			{
				baseComboBox.MouseDown += value;
			}
			remove
			{
				baseComboBox.MouseDown -= value;
			}
		}

		public new event EventHandler MouseEnter
		{
			add
			{
				baseComboBox.MouseEnter += value;
			}
			remove
			{
				baseComboBox.MouseEnter -= value;
			}
		}

		public new event EventHandler MouseHover
		{
			add
			{
				baseComboBox.MouseHover += value;
			}
			remove
			{
				baseComboBox.MouseHover -= value;
			}
		}

		public new event EventHandler MouseLeave
		{
			add
			{
				baseComboBox.MouseLeave += value;
			}
			remove
			{
				baseComboBox.MouseLeave -= value;
			}
		}

		public new event MouseEventHandler MouseMove
		{
			add
			{
				baseComboBox.MouseMove += value;
			}
			remove
			{
				baseComboBox.MouseMove -= value;
			}
		}

		[Browsable(true)]
		public event EventHandler SelectionChangeCommitted
		{
			add
			{
				baseComboBox.SelectionChangeCommitted += value;
			}
			remove
			{
				baseComboBox.SelectionChangeCommitted -= value;
			}
		}


		public new event MouseEventHandler MouseUp
		{
			add
			{
				baseComboBox.MouseUp += value;
			}
			remove
			{
				baseComboBox.MouseUp -= value;
			}
		}

		public new event MouseEventHandler MouseWheel
		{
			add
			{
				baseComboBox.MouseWheel += value;
			}
			remove
			{
				baseComboBox.MouseWheel -= value;
			}
		}

		public new event EventHandler Move
		{
			add
			{
				baseComboBox.Move += value;
			}
			remove
			{
				baseComboBox.Move -= value;
			}
		}

		//public event EventHandler MultilineChanged
		//{
		//	add
		//	{
		//		baseTextBox.MultilineChanged += value;
		//	}
		//	remove
		//	{
		//		baseTextBox.MultilineChanged -= value;
		//	}
		//}

		public new event EventHandler PaddingChanged
		{
			add
			{
				baseComboBox.PaddingChanged += value;
			}
			remove
			{
				baseComboBox.PaddingChanged -= value;
			}
		}

		public new event PaintEventHandler Paint
		{
			add
			{
				baseComboBox.Paint += value;
			}
			remove
			{
				baseComboBox.Paint -= value;
			}
		}

		public new event EventHandler ParentChanged
		{
			add
			{
				baseComboBox.ParentChanged += value;
			}
			remove
			{
				baseComboBox.ParentChanged -= value;
			}
		}

		public new event PreviewKeyDownEventHandler PreviewKeyDown
		{
			add
			{
				baseComboBox.PreviewKeyDown += value;
			}
			remove
			{
				baseComboBox.PreviewKeyDown -= value;
			}
		}

		public new event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp
		{
			add
			{
				baseComboBox.QueryAccessibilityHelp += value;
			}
			remove
			{
				baseComboBox.QueryAccessibilityHelp -= value;
			}
		}

		public new event QueryContinueDragEventHandler QueryContinueDrag
		{
			add
			{
				baseComboBox.QueryContinueDrag += value;
			}
			remove
			{
				baseComboBox.QueryContinueDrag -= value;
			}
		}

		//public event EventHandler ReadOnlyChanged
		//{
		//	add
		//	{
		//		baseTextBox.ReadOnlyChanged += value;
		//	}
		//	remove
		//	{
		//		baseTextBox.ReadOnlyChanged -= value;
		//	}
		//}

		public new event EventHandler RegionChanged
		{
			add
			{
				baseComboBox.RegionChanged += value;
			}
			remove
			{
				baseComboBox.RegionChanged -= value;
			}
		}

		public new event EventHandler Resize
		{
			add
			{
				baseComboBox.Resize += value;
			}
			remove
			{
				baseComboBox.Resize -= value;
			}
		}

		public new event EventHandler RightToLeftChanged
		{
			add
			{
				baseComboBox.RightToLeftChanged += value;
			}
			remove
			{
				baseComboBox.RightToLeftChanged -= value;
			}
		}

		public new event EventHandler SizeChanged
		{
			add
			{
				baseComboBox.SizeChanged += value;
			}
			remove
			{
				baseComboBox.SizeChanged -= value;
			}
		}

		public new event EventHandler StyleChanged
		{
			add
			{
				baseComboBox.StyleChanged += value;
			}
			remove
			{
				baseComboBox.StyleChanged -= value;
			}
		}

		public new event EventHandler SystemColorsChanged
		{
			add
			{
				baseComboBox.SystemColorsChanged += value;
			}
			remove
			{
				baseComboBox.SystemColorsChanged -= value;
			}
		}

		public new event EventHandler TabIndexChanged
		{
			add
			{
				baseComboBox.TabIndexChanged += value;
			}
			remove
			{
				baseComboBox.TabIndexChanged -= value;
			}
		}

		public new event EventHandler TabStopChanged
		{
			add
			{
				baseComboBox.TabStopChanged += value;
			}
			remove
			{
				baseComboBox.TabStopChanged -= value;
			}
		}

		//public event EventHandler TextAlignChanged
		//{
		//	add
		//	{
		//		baseTextBox.TextAlignChanged += value;
		//	}
		//	remove
		//	{
		//		baseTextBox.TextAlignChanged -= value;
		//	}
		//}

		public new event EventHandler TextChanged
		{
			add
			{
				baseComboBox.TextChanged += value;
			}
			remove
			{
				baseComboBox.TextChanged -= value;
			}
		}

		public new event EventHandler Validated
		{
			add
			{
				baseComboBox.Validated += value;
			}
			remove
			{
				baseComboBox.Validated -= value;
			}
		}

		public new event CancelEventHandler Validating
		{
			add
			{
				baseComboBox.Validating += value;
			}
			remove
			{
				baseComboBox.Validating -= value;
			}
		}

		public new event EventHandler VisibleChanged
		{
			add
			{
				baseComboBox.VisibleChanged += value;
			}
			remove
			{
				baseComboBox.VisibleChanged -= value;
			}
		}

		//public

        public object SelectedItem
        {
            get { return ((ComboBox)baseComboBox).SelectedItem; }
            set { ((ComboBox)baseComboBox).SelectedItem = value; }
        }

		public int SelectedIndex
		{
			get { return ((ComboBox)baseComboBox).SelectedIndex; }
			set { ((ComboBox)baseComboBox).SelectedIndex = value; }
		}

		public object SelectedValue
		{
			get { return ((ComboBox)baseComboBox).SelectedValue; }
			set { ((ComboBox)baseComboBox).SelectedValue = value; }
		}

		//public object SelectedValue
		//{
		//	get { return (object)GetValue(SelectedValueProperty); }
		//	set { SetValue(SelectedValueProperty, value); }
		//}

		//public object SelectedValue
		//{
		//	get { return (object)GetValue(SelectedValueProperty); }
		//	set { SetValue(SelectedValueProperty, value); }
		//}

		public object DataSource
		{
			get { return baseComboBox.DataSource; }
			set { baseComboBox.DataSource = value; }
		}

		public string DisplayMember
		{
			get { return baseComboBox.DisplayMember; }
			set { baseComboBox.DisplayMember = value; }
		}

		public string ValueMember
		{
			get { return baseComboBox.ValueMember; }
			set { baseComboBox.ValueMember = value; }
		}

		//public string LookupMember
		//{
		//	get { return baseComboBox.SelectedValue.ToString(); }
		//	set { baseComboBox.SelectedValue = value; }
		//}

		[Description("The items in the UserControl's ComboBox."), DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
		 Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design", typeof(System.Drawing.Design.UITypeEditor))]
		public System.Windows.Forms.ComboBox.ObjectCollection Items
		{
			get
			{
				return baseComboBox.Items;
			}
		}

		//bool readOnly;
		//public bool ReadOnly
		//{
		//	get { return readOnly; }
		//	set
		//	{
		//		readOnly = value;
  //              baseComboBox.ReadOnly = value;
		//	}
		//}

		//private CharacterCasing charactercasing = CharacterCasing.Normal;
		//public CharacterCasing CharacterCasing
		//{
		//	get
		//	{ return charactercasing; }
		//	set
		//	{
		//		charactercasing = value;
		//		baseTextBox.CharacterCasing = value;
		//	}
		//}

		//protected override void OnKeyPress(KeyPressEventArgs e)
		//{
		//	if (charactercasing == CharacterCasing.Lower)
		//		e.KeyChar = char.ToLowerInvariant(e.KeyChar);
		//	else if (charactercasing == CharacterCasing.Upper)
		//		e.KeyChar = char.ToUpperInvariant(e.KeyChar);

		//	base.OnKeyPress(e);
		//}

		//HorizontalAlignment ALNType;
		//public HorizontalAlignment TextAlignment
		//{
		//	get
		//	{
		//		return ALNType;
		//	}
		//	set
		//	{
		//		ALNType = value;
		//		Invalidate();
		//	}
		//}

		#endregion

		private readonly AnimationManager animationManager;

		private readonly BaseComboBox baseComboBox;
		public MaterialComboBox()
		{
			SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.DoubleBuffer, true);

			animationManager = new AnimationManager
			{
				Increment = 0.06,
				AnimationType = AnimationType.EaseInOut,
				InterruptAnimation = false
			};
			animationManager.OnAnimationProgress += sender => Invalidate();

			baseComboBox = new BaseComboBox
			{
				//BorderStyle = BorderStyle.None,

				Font = SkinManager.ROBOTO_REGULAR_11,
				ForeColor = SkinManager.GetPrimaryTextColor(),
				Location = new Point(0, 0),
				Width = Width,
				Height = Height - 57,
				FlatStyle = FlatStyle.Flat,
				DropDownStyle = ComboBoxStyle.DropDownList

				//Multiline = false,
				//TextAlign = HorizontalAlignment.Left
			};

			if (!Controls.Contains(baseComboBox) && !DesignMode)
			{
				Controls.Add(baseComboBox);
			}

			baseComboBox.GotFocus += (sender, args) => animationManager.StartNewAnimation(AnimationDirection.In);
			baseComboBox.LostFocus += (sender, args) => animationManager.StartNewAnimation(AnimationDirection.Out);
			BackColorChanged += (sender, args) =>
			{
				baseComboBox.BackColor = BackColor;
				baseComboBox.ForeColor = SkinManager.GetPrimaryTextColor();
			};

			//Fix for tabstop
			baseComboBox.TabStop = true;
			this.TabStop = false;
		}

		protected override void OnPaint(PaintEventArgs pevent)
		{
			var g = pevent.Graphics;
			g.Clear(Parent.BackColor);

			//int lineY = baseComboBox.Bottom + 3;
			int lineY = baseComboBox.Bottom;

			//NUEVO
			//baseTextBox.TextAlign = TextAlignment;

			if (!animationManager.IsAnimating())
			{
				//No animation
				g.FillRectangle(baseComboBox.Focused ? SkinManager.ColorScheme.PrimaryBrush : SkinManager.GetDividersBrush(), baseComboBox.Location.X, lineY, baseComboBox.Width, baseComboBox.Focused ? 2 : 1);
			}
			else
			{
				//Animate
				int animationWidth = (int)(baseComboBox.Width * animationManager.GetProgress());
				int halfAnimationWidth = animationWidth / 2;
				int animationStart = baseComboBox.Location.X + baseComboBox.Width / 2;

				//Unfocused background
				g.FillRectangle(SkinManager.GetDividersBrush(), baseComboBox.Location.X, lineY, baseComboBox.Width, 1);

				//Animated focus transition
				g.FillRectangle(SkinManager.ColorScheme.PrimaryBrush, animationStart - halfAnimationWidth, lineY, animationWidth, 2);
			}
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);

			baseComboBox.Location = new Point(0, 0);
			baseComboBox.Width = Width;

			//Height = baseComboBox.Height + 5;
			Height = baseComboBox.Height + 2;
		}

		protected override void OnCreateControl()
		{
			base.OnCreateControl();

			baseComboBox.BackColor = Parent.BackColor;
			baseComboBox.ForeColor = SkinManager.GetPrimaryTextColor();
		}

		private class BaseComboBox : ComboBox
		{
			[DllImport("user32.dll", CharSet = CharSet.Auto)]
			private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);

			private const int EM_SETCUEBANNER = 0x1501;
			private const char EmptyChar = (char)0;
			private const char VisualStylePasswordChar = '\u25CF';
			private const char NonVisualStylePasswordChar = '\u002A';

			private string hint = string.Empty;
			public string Hint
			{
				get { return hint; }
				set
				{
					hint = value;
					SendMessage(Handle, EM_SETCUEBANNER, (int)IntPtr.Zero, Hint);
				}
			}

			private char passwordChar = EmptyChar;
			public char PasswordChar
			{
				get { return passwordChar; }
				set
				{
					passwordChar = value;
					SetBasePasswordChar();
				}
			}

			public new void SelectAll()
			{
				BeginInvoke((MethodInvoker)delegate ()
				{
					base.Focus();
					base.SelectAll();
				});
			}

			public new void Focus()
			{
				BeginInvoke((MethodInvoker)delegate ()
				{
					base.Focus();
				});
			}

			private char useSystemPasswordChar = EmptyChar;
			public bool UseSystemPasswordChar
			{
				get { return useSystemPasswordChar != EmptyChar; }
				set
				{
					if (value)
					{
						useSystemPasswordChar = Application.RenderWithVisualStyles ? VisualStylePasswordChar : NonVisualStylePasswordChar;
					}
					else
					{
						useSystemPasswordChar = EmptyChar;
					}

					SetBasePasswordChar();
				}
			}

			private void SetBasePasswordChar()
			{
				//base.PasswordChar = UseSystemPasswordChar ? useSystemPasswordChar : passwordChar;
			}

			public BaseComboBox()
			{
				MaterialContextMenuStrip cms = new TextBoxContextMenuStrip();
				cms.Opening += ContextMenuStripOnOpening;
				//cms.OnItemClickStart += ContextMenuStripOnItemClickStart;

				ContextMenuStrip = cms;
			}

			//private void ContextMenuStripOnItemClickStart(object sender, ToolStripItemClickedEventArgs toolStripItemClickedEventArgs)
			//{
			//	switch (toolStripItemClickedEventArgs.ClickedItem.Text)
			//	{
			//		case "Undo":
			//			Undo();
			//			break;
			//		case "Cut":
			//			Cut();
			//			break;
			//		case "Copy":
			//			Copy();
			//			break;
			//		case "Paste":
			//			Paste();
			//			break;
			//		case "Delete":
			//			SelectedText = string.Empty;
			//			break;
			//		case "Select All":
			//			SelectAll();
			//			break;
			//	}
			//}

			private void ContextMenuStripOnOpening(object sender, CancelEventArgs cancelEventArgs)
			{
				var strip = sender as TextBoxContextMenuStrip;
				if (strip != null)
				{
					//strip.undo.Enabled = CanUndo;
					strip.cut.Enabled = !string.IsNullOrEmpty(SelectedText);
					strip.copy.Enabled = !string.IsNullOrEmpty(SelectedText);
					strip.paste.Enabled = Clipboard.ContainsText();
					strip.delete.Enabled = !string.IsNullOrEmpty(SelectedText);
					strip.selectAll.Enabled = !string.IsNullOrEmpty(Text);
				}
			}
		}

		private class TextBoxContextMenuStrip : MaterialContextMenuStrip
		{
			public readonly ToolStripItem undo = new MaterialToolStripMenuItem { Text = "Undo" };
			public readonly ToolStripItem seperator1 = new ToolStripSeparator();
			public readonly ToolStripItem cut = new MaterialToolStripMenuItem { Text = "Cut" };
			public readonly ToolStripItem copy = new MaterialToolStripMenuItem { Text = "Copy" };
			public readonly ToolStripItem paste = new MaterialToolStripMenuItem { Text = "Paste" };
			public readonly ToolStripItem delete = new MaterialToolStripMenuItem { Text = "Delete" };
			public readonly ToolStripItem seperator2 = new ToolStripSeparator();
			public readonly ToolStripItem selectAll = new MaterialToolStripMenuItem { Text = "Select All" };

			public TextBoxContextMenuStrip()
			{
				Items.AddRange(new[]
				{
					undo,
					seperator1,
					cut,
					copy,
					paste,
					delete,
					seperator2,
					selectAll
				});
			}
		}
	}
}