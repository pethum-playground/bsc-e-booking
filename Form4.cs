using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace e_booking
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            ApplyRoundedBorders();
        }

        private void ApplyRoundedBorders()
        {
            panelUsername.Paint += (sender, e) => DrawRoundedBorder(sender, e, 20, Color.White, 2);
            panelPassword.Paint += (sender, e) => DrawRoundedBorder(sender, e, 20, Color.White, 2);

            btnLogin.Paint += (sender, e) => DrawButton(sender, e, 10, Color.RoyalBlue, 2);

            txtUsername.Paint += (sender, e) => DrawRoundedBorder(sender, e, 10, Color.Black, 2);
            txtPassword.Paint += (sender, e) => DrawRoundedBorder(sender, e, 10, Color.Black, 2);

            btnLogin.MouseEnter += (sender, e) => btnLogin.Invalidate();
            btnLogin.MouseLeave += (sender, e) => btnLogin.Invalidate();
        }

        private void DrawRoundedBorder(object sender, PaintEventArgs e, int borderRadius, Color borderColor, float borderWidth)
        {
            Control control = sender as Control;
            if (control != null)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (GraphicsPath path = new GraphicsPath())
                {
                    float r = borderRadius;
                    RectangleF rect = new RectangleF(0, 0, control.Width, control.Height);
                    path.AddArc(rect.X, rect.Y, r, r, 180, 90);
                    path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
                    path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
                    path.CloseFigure();
                    control.Region = new Region(path);
                    using (SolidBrush brush = new SolidBrush(control.BackColor))
                    {
                        e.Graphics.FillPath(brush, path);
                    }
                    using (Pen pen = new Pen(borderColor, borderWidth))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }
        }

        private void DrawButton(object sender, PaintEventArgs e, int borderRadius, Color borderColor, float borderWidth)
        {
            Button button = sender as Button;
            if (button != null)
            {
                Color backColor = button.BackColor;
                Color penColor = borderColor;

                if (button.ClientRectangle.Contains(button.PointToClient(Cursor.Position)))
                {
                    backColor = Color.LightSkyBlue;
                    penColor = Color.LightSkyBlue;
                }

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (GraphicsPath path = new GraphicsPath())
                {
                    float r = borderRadius;
                    RectangleF rect = new RectangleF(0, 0, button.Width, button.Height);
                    path.AddArc(rect.X, rect.Y, r, r, 180, 90);
                    path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
                    path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
                    path.CloseFigure();
                    button.Region = new Region(path);
                    using (SolidBrush brush = new SolidBrush(backColor))
                    {
                        e.Graphics.FillPath(brush, path);
                    }
                    using (Pen pen = new Pen(penColor, borderWidth))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                    TextRenderer.DrawText(e.Graphics, button.Text, button.Font, Rectangle.Round(rect), button.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            //ApiService apiService = new ApiService();

            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void eyeIcon_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void forgotpwd_clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://sspr.kln.ac.lk/Password/Reset",
                UseShellExecute = true
            });
        }
    }
}
