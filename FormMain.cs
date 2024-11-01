using IMControls.CustomControls;
using System.Runtime.InteropServices;

namespace PassGenerator
{
   public partial class FormMain : Form
   {

      [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
      private extern static void ReleaseCapture();

      [DllImport("user32.dll", EntryPoint = "SendMessage")]
      private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


      public FormMain()
      {
         InitializeComponent();
         ResetComponents();
         SetCheckBoxEvent();

         this.MouseDown += (sender, e) =>
         {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
         };
      }

      private void SetCheckBoxEvent()
      {
         foreach (var item in this.Controls.OfType<IMSwitchButton>())
         {
            item.CheckedChanged += CheckBoxOnChanged;
         }
      }

      Random random = new();
      string[] source;

      private void ResetComponents()
      {
         trackBar1.Value = 6;
         lbl_Tamanho.Text = trackBar1.Value.ToString();
      }

      private void CheckBoxOnChanged(object sender, EventArgs e)
      {
         source = new string[this.Controls.OfType<IMSwitchButton>().Where(x => x.Checked).Count()];
         Array.Clear(source);
         foreach (var item in this.Controls.OfType<IMSwitchButton>().Where(x => x.Checked))
         {
            for (int i = 0; i < 4; i++)
            {
               if (source[i] == null)
               {
                  source[i] = item.Tag!.ToString();
                  break;
               }
            }
         }
         btn_Gerar_Click(sender, e);
      }

      private void btn_Close_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      private void FormMain_Load(object sender, EventArgs e)
      {
         check_Numbers.Checked = false;
         check_Numbers.Checked = true;
         btn_Gerar_Click(sender, e);
      }

      private void trackBar1_Scroll(object sender, EventArgs e)
      {
         lbl_Tamanho.Text = trackBar1.Value.ToString();
         check_Numbers.Checked = false;
         check_Numbers.Checked = true;
         btn_Gerar_Click(sender, e);
      }

      private void btn_Gerar_Click(object sender, EventArgs e)
      {
         txt_Senha.Texts = string.Empty;
         for (int i = 0; i < Convert.ToInt32("0" + lbl_Tamanho.Text); i++)
         {
            var randomPass = source[random.Next(source.Length)];
            txt_Senha.Texts += randomPass[random.Next(randomPass.Length)];
         }

      }

      private void btn_Copy_Click(object sender, EventArgs e)
      {
         if (txt_Senha.Texts.Length > 0)
            Clipboard.SetText(txt_Senha.Texts.Trim());
      }

      private void FormMain_Shown(object sender, EventArgs e)
      {
         btn_Gerar.Focus();
      }
   }
}
