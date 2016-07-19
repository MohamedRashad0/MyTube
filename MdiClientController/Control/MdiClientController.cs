#region Using Directives

using System;
using System.Drawing;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Runtime.InteropServices;

#endregion

namespace SmartPCUtilities.Components
{
	[ToolboxBitmap(typeof(MdiClientController))]
	public class MdiClientController : NativeWindow, IComponent, IDisposable
	{
		#region Private Fields

		private Form parentForm;
		private MdiClient mdiClient;
		private BorderStyle borderStyle;
		private Color backColor;
		private bool autoScroll;
		private Image image;
		private ContentAlignment imageAlign;
		private bool stretchImage;
		private ISite site;

		#endregion

		#region Public Constructors

		public MdiClientController() : this(null)
		{
		}

		public MdiClientController(Form parentForm)
		{
			this.site = null;
			this.parentForm = null;
			this.mdiClient = null;
			this.backColor = SystemColors.AppWorkspace;
			this.borderStyle = BorderStyle.Fixed3D;
			this.autoScroll = true;
			this.image = null;
			this.imageAlign = ContentAlignment.MiddleCenter;
			this.stretchImage = false;
			
			this.ParentForm = parentForm;
		}

		#endregion

		#region Public Events

		[Category("Appearance"), Description("Occurs when a control needs repainting.")]
		public event PaintEventHandler Paint;

		[Browsable(false)]
		public event EventHandler Disposed;

		[Browsable(false)]
		public event EventHandler HandleAssigned;

		#endregion

		#region Public Properties

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public ISite Site
		{
			get { return site; }
			set
			{
				site = value;

				if(site == null)
					return;

				IDesignerHost host = (value.GetService(typeof(IDesignerHost)) as IDesignerHost);
				if(host != null)
				{
					Form parent = host.RootComponent as Form;
					if(parent != null)
						ParentForm = parent;
				}
			}
		}

		[Browsable(false)]
		public Form ParentForm
		{
			get { return parentForm; }
			set
			{
				if(parentForm != null)
					parentForm.HandleCreated -= new EventHandler(ParentFormHandleCreated);

				parentForm = value;

				if(parentForm == null)
					return;

				if(parentForm.IsHandleCreated)
				{
					InitializeMdiClient();
					RefreshProperties();
				}
				else
					parentForm.HandleCreated += new EventHandler(ParentFormHandleCreated);
			}
		}

		[Browsable(false)]
		public MdiClient MdiClient
		{
			get { return mdiClient; }
		}

		[Category("Appearance"), DefaultValue(typeof(Color), "AppWorkspace")]
		[Description("The backcolor used to display text and graphics on the control.")]
		public Color BackColor
		{

			get
			{
				if(mdiClient != null)
					return mdiClient.BackColor;

				return backColor;
			}
			set
			{
				backColor = value;
				if(mdiClient != null)
					mdiClient.BackColor = value;
			}
		}

		[DefaultValue(BorderStyle.Fixed3D), Category("Appearance")]
		[Description("Indicates whether the MDI area should have a border.")]
		public BorderStyle BorderStyle
		{
			get { return borderStyle; }
			set
			{
				if(!Enum.IsDefined(typeof(BorderStyle), value))
					throw new InvalidEnumArgumentException("value", (int)value, typeof(BorderStyle));

				borderStyle = value;

				if(mdiClient == null)
					return;

				if(site != null && site.DesignMode)
					return;

				int style = GetWindowLong(mdiClient.Handle, GWL_STYLE);
				int exStyle = GetWindowLong(mdiClient.Handle, GWL_EXSTYLE);

				switch(borderStyle)
				{
					case BorderStyle.Fixed3D:
						exStyle |= WS_EX_CLIENTEDGE;
						style &= ~WS_BORDER;
						break;

					case BorderStyle.FixedSingle:
						exStyle &= ~WS_EX_CLIENTEDGE;
						style |= WS_BORDER;
						break;

					case BorderStyle.None:
						style &= ~WS_BORDER;
						exStyle &= ~WS_EX_CLIENTEDGE;
						break;
				}
					
				SetWindowLong(mdiClient.Handle, GWL_STYLE, style);
				SetWindowLong(mdiClient.Handle, GWL_EXSTYLE, exStyle);

				UpdateStyles();
			}
		}

		[DefaultValue(true), Category("Layout")]
		[Description("Determines whether scrollbars will appear if controls are placed outside the MDI area.")]
		public bool AutoScroll
		{
			get { return autoScroll; }
			set
			{

				autoScroll = value;
				if(mdiClient != null)
					UpdateStyles();
			}
		}

		[DefaultValue(null), Category("Appearance")]
		[Description("The image displayed in the MDI area.")]
		public Image Image
		{
			get { return image; }
			set
			{
				image = value;
				if(mdiClient != null)
					mdiClient.Invalidate();
			}
		}

		[Category("Appearance"), DefaultValue(ContentAlignment.MiddleCenter)]
		[Description("Determines the position of the image in the MDI area.")]
		public ContentAlignment ImageAlign
		{
			get { return imageAlign; }
			set
			{
				if(!Enum.IsDefined(typeof(ContentAlignment), value))
					throw new InvalidEnumArgumentException("value", (int)value, typeof(ContentAlignment));

				imageAlign = value;
				if(mdiClient != null)
					mdiClient.Invalidate();
			}
		}

		[Category("Appearance"), DefaultValue(false)]
		[Description("Determines whether the image should be scaled to fill the MDI area.")]
		public bool StretchImage
		{
			get { return stretchImage; }
			set
			{
				stretchImage = value;
				if(mdiClient != null)
					mdiClient.Invalidate();
			}
		}

		[Browsable(false)]
		public new IntPtr Handle
		{
			get { return base.Handle; }
		}

		#endregion

		#region Public Methods

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		public void RenewMdiClient()
		{
			InitializeMdiClient();
			RefreshProperties();
		}

		#endregion

		#region Protected Methods

		protected virtual void Dispose(bool disposing)
		{
			if(disposing)
			{
				lock(this)
				{
					if(site != null && site.Container != null)
						site.Container.Remove(this);

					if(Disposed != null)
						Disposed(this, EventArgs.Empty);
				}
			}
		}

		protected override void WndProc(ref Message m)
		{
			switch(m.Msg)
			{
				case WM_ERASEBKGND:
					return;

				case WM_PAINT:

					PAINTSTRUCT paintStruct = new PAINTSTRUCT();
					IntPtr screenHdc = BeginPaint(m.HWnd, ref paintStruct);

					using(Graphics screenGraphics = Graphics.FromHdc(screenHdc)) 
					{
						Rectangle clipRect = new Rectangle(
							paintStruct.rcPaint.left,
							paintStruct.rcPaint.top,
							paintStruct.rcPaint.right - paintStruct.rcPaint.left,
							paintStruct.rcPaint.bottom - paintStruct.rcPaint.top);

						int width = (mdiClient.ClientRectangle.Width > 0 ? mdiClient.ClientRectangle.Width : 0);
						int height = (mdiClient.ClientRectangle.Height > 0 ? mdiClient.ClientRectangle.Height : 0);
						using(Image i = new Bitmap(width, height))
						{
							using(Graphics g = Graphics.FromImage(i))
							{

								IntPtr hdc = g.GetHdc();
								Message printClientMessage =
									Message.Create(m.HWnd, WM_PRINTCLIENT, hdc, IntPtr.Zero);  
								DefWndProc(ref printClientMessage);
								g.ReleaseHdc(hdc);

								if(image != null)
									DrawImage(g, clipRect);

								OnPaint(new PaintEventArgs(g, clipRect));
							}

							screenGraphics.DrawImage(i, mdiClient.ClientRectangle);
						}
					}

					EndPaint(m.HWnd, ref paintStruct);
					return;
					
				case WM_SIZE:

					mdiClient.Invalidate();
					break;
					

				case WM_NCCALCSIZE:

					if(!autoScroll)
						ShowScrollBar(m.HWnd, SB_BOTH, 0 );
					break;
			}
		
			base.WndProc(ref m);
		}

		protected virtual void OnPaint(PaintEventArgs e)
		{
			if(Paint != null)
				Paint(this, e);
		}

		protected virtual void OnHandleAssigned(EventArgs e)
		{
			if(HandleAssigned != null)
				HandleAssigned(this, e);
		}

		#endregion

		#region Private Methods

		private void InitializeMdiClient()
		{
			if(mdiClient != null)
				mdiClient.HandleDestroyed -= new EventHandler(MdiClientHandleDestroyed);

			if(parentForm == null)
				return;

			for(int i = 0; i < parentForm.Controls.Count; i++)
			{
				mdiClient = parentForm.Controls[i] as MdiClient;
				if(mdiClient != null)
				{
					ReleaseHandle();
					AssignHandle(mdiClient.Handle);

					OnHandleAssigned(EventArgs.Empty);

					mdiClient.HandleDestroyed += new EventHandler(MdiClientHandleDestroyed);
				}
			}
		}

		private void DrawImage(Graphics g, Rectangle clipRect)
		{
			if(stretchImage)
				g.DrawImage(image, mdiClient.ClientRectangle);
			else
			{
				Point pt = Point.Empty;
				switch(imageAlign)
				{
					case ContentAlignment.TopLeft:
						pt = new Point(0, 0);
						break;
					case ContentAlignment.TopCenter:
						pt = new Point((mdiClient.ClientRectangle.Width / 2) - (image.Width / 2), 0);
						break;
					case ContentAlignment.TopRight:
						pt = new Point(mdiClient.ClientRectangle.Width - image.Width, 0);
						break;
					case ContentAlignment.MiddleLeft:
						pt = new Point(0,
							(mdiClient.ClientRectangle.Height / 2) - (image.Height / 2));
						break;
					case ContentAlignment.MiddleCenter:
						pt = new Point((mdiClient.ClientRectangle.Width / 2) - (image.Width / 2),
							(mdiClient.ClientRectangle.Height / 2) - (image.Height / 2));
						break;
					case ContentAlignment.MiddleRight:
						pt = new Point(mdiClient.ClientRectangle.Width - image.Width,
							(mdiClient.ClientRectangle.Height / 2) - (image.Height / 2));
						break;
					case ContentAlignment.BottomLeft:
						pt = new Point(0, mdiClient.ClientRectangle.Height - image.Height);
						break;
					case ContentAlignment.BottomCenter:
						pt = new Point((mdiClient.ClientRectangle.Width / 2) - (image.Width / 2),
							mdiClient.ClientRectangle.Height - image.Height);
						break;
					case ContentAlignment.BottomRight:
						pt = new Point(mdiClient.ClientRectangle.Width - image.Width,
							mdiClient.ClientRectangle.Height - image.Height);
						break;
				}

				g.DrawImage(image, new Rectangle(pt, image.Size));
			}
		}

		private void UpdateStyles()
		{
			
			SetWindowPos(mdiClient.Handle, IntPtr.Zero, 0, 0, 0, 0,
				SWP_NOACTIVATE | SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER |
				SWP_NOOWNERZORDER | SWP_FRAMECHANGED);
		}

		private void MdiClientHandleDestroyed(object sender, EventArgs e)
		{
			if(mdiClient != null)
			{
				mdiClient.HandleDestroyed -= new EventHandler(MdiClientHandleDestroyed);
				mdiClient = null;
			}

			ReleaseHandle();
		}

		private void ParentFormHandleCreated(object sender, EventArgs e)
		{
			parentForm.HandleCreated -= new EventHandler(ParentFormHandleCreated);
			InitializeMdiClient();
			RefreshProperties();
		}

		private void RefreshProperties()
		{
			BackColor = backColor;
			BorderStyle = borderStyle;
			AutoScroll = autoScroll;
			Image = image;
			ImageAlign = imageAlign;
			StretchImage = stretchImage;
		}

		#endregion

		#region Win32

		private const int WM_PAINT			= 0x000F;
		private const int WM_ERASEBKGND		= 0x0014;
		private const int WM_NCPAINT		= 0x0085;
		private const int WM_THEMECHANGED	= 0x031A;
		private const int WM_NCCALCSIZE		= 0x0083;
		private const int WM_SIZE			= 0x0005;
		private const int WM_PRINTCLIENT	= 0x0318;

		private const uint SWP_NOSIZE			= 0x0001;
		private const uint SWP_NOMOVE			= 0x0002;
		private const uint SWP_NOZORDER			= 0x0004;
		private const uint SWP_NOREDRAW			= 0x0008;
		private const uint SWP_NOACTIVATE		= 0x0010;
		private const uint SWP_FRAMECHANGED		= 0x0020;
		private const uint SWP_SHOWWINDOW		= 0x0040;
		private const uint SWP_HIDEWINDOW		= 0x0080;
		private const uint SWP_NOCOPYBITS		= 0x0100;
		private const uint SWP_NOOWNERZORDER	= 0x0200;
		private const uint SWP_NOSENDCHANGING	= 0x0400;

		private const int WS_BORDER			= 0x00800000;
		private const int WS_EX_CLIENTEDGE	= 0x00000200;
		private const int WS_DISABLED		= 0x08000000;

		private const int GWL_STYLE		= -16;
		private const int GWL_EXSTYLE	= -20;

		private const int SB_HORZ	= 0;
		private const int SB_VERT	= 1;
		private const int SB_CTL	= 2;
		private const int SB_BOTH	= 3;


		[StructLayout(LayoutKind.Sequential)]
		private struct RECT
		{
			public int left;
			public int top;
			public int right;
			public int bottom;
	  
			public RECT(Rectangle rect) 
			{
				this.left = rect.Left;
				this.top = rect.Top;
				this.right = rect.Right;
				this.bottom = rect.Bottom;
			}

			public RECT(int left, int top, int right, int bottom) 
			{
				this.left = left;
				this.top = top;
				this.right = right;
				this.bottom = bottom;
			}
		}

		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		private struct PAINTSTRUCT
		{
			public IntPtr hdc;
			public int fErase;
			public RECT rcPaint;
			public int fRestore;
			public int fIncUpdate;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst=32)] public byte[] rgbReserved;
		}

		[StructLayout(LayoutKind.Sequential)]
		private struct NCCALCSIZE_PARAMS
		{
			public RECT rgrc0, rgrc1, rgrc2;
			public IntPtr lppos;
		}

		[DllImport("user32.dll")]
		private static extern int ShowScrollBar(IntPtr hWnd, int wBar, int bShow);

		[DllImport("user32.dll")]
		private static extern IntPtr BeginPaint(IntPtr hWnd, ref PAINTSTRUCT paintStruct);

		[DllImport("user32.dll")]
		private static extern bool EndPaint(IntPtr hWnd, ref PAINTSTRUCT paintStruct);

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern int GetWindowLong(IntPtr hWnd, int Index);

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern int SetWindowLong(IntPtr hWnd, int Index, int Value);

		[DllImport("user32.dll", ExactSpelling = true)]
		private static extern int SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

		#endregion
	}
}