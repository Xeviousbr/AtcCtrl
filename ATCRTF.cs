using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TeleBonifacio.gen;

namespace AtcCtrl
{
    public partial class ATCRTF : UserControl
    {

        public bool Criptografia = false;
        public string caminhoDoArquivo = "";
        private bool carregando = false;

        public ATCRTF()
        {
            InitializeComponent();
        }

        private void rtfTexto_TextChanged(object sender, EventArgs e)
        {
            if (!carregando)
            {
                if (!timer1.Enabled)
                {
                    timer1.Enabled = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            SalvaRTF();
            if (timer1.Interval > 500)
            {
                timer1.Interval -= 100;
            }
        }

        public void Carrega()
        {
            string Texto = File.ReadAllText(caminhoDoArquivo);
            if (Criptografia)
            {
                Texto = Cripto.Decrypt(Texto);
            }
            rtfTexto.Rtf = Texto;
        }

        private void SalvaRTF()
        {
            string Texto = rtfTexto.Rtf;
            if (Criptografia)
            {
                Texto = Cripto.Encrypt(Texto);
            }
            File.WriteAllText(caminhoDoArquivo, Texto);
        }

        #region Botões        

        private void toolStripButtonRedo_Click(object sender, EventArgs e)
        {
            if (rtfTexto.CanRedo)
            {
                rtfTexto.Redo();
            }
        }

        private void toolStripButtonUndo_Click(object sender, EventArgs e)
        {
            if (rtfTexto.CanUndo)
            {
                rtfTexto.Undo();
            }
        }

        private void toolStripButtonDecreaseFont_Click(object sender, EventArgs e)
        {
            float newSize = this.rtfTexto.SelectionFont.Size - 1;
            this.rtfTexto.SelectionFont = new Font(this.rtfTexto.SelectionFont.FontFamily, Math.Max(newSize, 1), this.rtfTexto.SelectionFont.Style); // Garante que o tamanho mínimo seja 1
        }

        private void toolStripButtonIncreaseFont_Click(object sender, EventArgs e)
        {
            float newSize = this.rtfTexto.SelectionFont.Size + 1;
            this.rtfTexto.SelectionFont = new Font(this.rtfTexto.SelectionFont.FontFamily, newSize, this.rtfTexto.SelectionFont.Style);
        }

        private void toolStripButtonUnderline_Click(object sender, EventArgs e)
        {
            if (rtfTexto.SelectionFont != null)
            {
                FontStyle currentStyle = rtfTexto.SelectionFont.Style;
                FontStyle newStyle;
                if (rtfTexto.SelectionFont.Underline)
                {
                    newStyle = currentStyle & ~FontStyle.Underline;
                }
                else
                {
                    newStyle = currentStyle | FontStyle.Underline;
                }
                rtfTexto.SelectionFont = new Font(rtfTexto.SelectionFont.FontFamily, rtfTexto.SelectionFont.Size, newStyle);
            }
        }

        private void toolStripButtonItalic_Click(object sender, EventArgs e)
        {
            if (rtfTexto.SelectionFont != null)
            {
                FontStyle currentStyle = rtfTexto.SelectionFont.Style;
                FontStyle newStyle;
                if (rtfTexto.SelectionFont.Italic)
                {
                    newStyle = currentStyle & ~FontStyle.Italic;
                }
                else
                {
                    newStyle = currentStyle | FontStyle.Italic;
                }
                rtfTexto.SelectionFont = new Font(rtfTexto.SelectionFont.FontFamily, rtfTexto.SelectionFont.Size, newStyle);
            }
        }

        private void toolStripButtonBold_Click(object sender, EventArgs e)
        {
            if (rtfTexto.SelectionFont != null)
            {
                FontStyle currentStyle = rtfTexto.SelectionFont.Style;
                FontStyle newStyle;
                if (rtfTexto.SelectionFont.Bold)
                {
                    newStyle = currentStyle & ~FontStyle.Bold;
                }
                else
                {
                    newStyle = currentStyle | FontStyle.Bold;
                }
                rtfTexto.SelectionFont = new Font(rtfTexto.SelectionFont.FontFamily, rtfTexto.SelectionFont.Size, newStyle);
            }
        }

        private void tsVermelho_Click(object sender, EventArgs e)
        {
            rtfTexto.SelectionColor = Color.Red;
        }

        private void tsAzul_Click(object sender, EventArgs e)
        {
            rtfTexto.SelectionColor = Color.Blue;
        }

        private void tsVerde_Click(object sender, EventArgs e)
        {
            rtfTexto.SelectionColor = Color.Green;
        }

        private void tsLaranja_Click(object sender, EventArgs e)
        {
            rtfTexto.SelectionColor = Color.Orange;
        }

        private void tsPreto_Click(object sender, EventArgs e)
        {
            rtfTexto.SelectionColor = Color.Black;
        }

        private void tsCinza_Click(object sender, EventArgs e)
        {
            rtfTexto.SelectionColor = Color.Gray;
        }

        private void toolStripButtonEncrypt_Click(object sender, EventArgs e)
        {
            //tsDescriptar.Visible = true;
            //tsEncriptar.Visible = false;
            //Criptografia = true;
            //SalvaRTF();
        }

        private void tsDescriptar_Click(object sender, EventArgs e)
        {
            //tsDescriptar.Visible = false;
            //tsEncriptar.Visible = true;
            //Criptografia = false;
            //SalvaRTF();
        }

        #endregion
    }
}
