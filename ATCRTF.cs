using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TeleBonifacio.gen;

// 1.1.2 Clicando ao final da linha aplica estilo para a linha toda
// 1.1.1 Conserto do Negrito e Undu
// 1.1.0 Ressucitação do componente


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

        private void ApplyStyleToLineOrSelection(Action<Font> fontAction = null, Action colorAction = null)
        {
            int selectionStart = rtfTexto.SelectionStart;
            int selectionLength = rtfTexto.SelectionLength;

            if (selectionLength == 0)
            {
                // Não há seleção, então selecione a linha inteira
                SelectCurrentLine();
            }

            if (fontAction != null && rtfTexto.SelectionFont != null)
            {
                Font currentFont = rtfTexto.SelectionFont;
                fontAction(currentFont);
            }

            if (colorAction != null)
            {
                colorAction();
            }

            // Restaure a seleção original ou a posição do cursor
            rtfTexto.Select(selectionStart, selectionLength);
        }

        private void SelectCurrentLine()
        {
            int lineStart = rtfTexto.GetFirstCharIndexOfCurrentLine();
            int lineEnd = rtfTexto.Text.IndexOf('\n', lineStart);
            if (lineEnd == -1) lineEnd = rtfTexto.Text.Length;
            rtfTexto.Select(lineStart, lineEnd - lineStart);
        }

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
            ApplyStyleToLineOrSelection(currentFont =>
            {
                float newSize = Math.Max(currentFont.Size - 1, 1); // Garante que o tamanho mínimo seja 1
                rtfTexto.SelectionFont = new Font(currentFont.FontFamily, newSize, currentFont.Style);
            });
        }

        private void toolStripButtonIncreaseFont_Click(object sender, EventArgs e)
        {
            ApplyStyleToLineOrSelection(currentFont =>
            {
                float newSize = currentFont.Size + 1;
                rtfTexto.SelectionFont = new Font(currentFont.FontFamily, newSize, currentFont.Style);
            });
        }

        private void toolStripButtonUnderline_Click(object sender, EventArgs e)
        {
            ApplyStyleToLineOrSelection(currentFont =>
            {
                FontStyle newStyle = currentFont.Style ^ FontStyle.Underline;
                rtfTexto.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            });
        }

        private void toolStripButtonItalic_Click(object sender, EventArgs e)
        {
            ApplyStyleToLineOrSelection(currentFont =>
            {
                FontStyle newStyle = currentFont.Style ^ FontStyle.Italic;
                rtfTexto.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            });
        }

        private void toolStripButtonBold_Click(object sender, EventArgs e)
        {
            ApplyStyleToLineOrSelection(currentFont =>
            {
                FontStyle newStyle = currentFont.Style ^ FontStyle.Bold;
                rtfTexto.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            });
        }

        private void tsVermelho_Click(object sender, EventArgs e)
        {
            ApplyStyleToLineOrSelection(null, () => rtfTexto.SelectionColor = Color.Red);
        }

        private void tsAzul_Click(object sender, EventArgs e)
        {
            ApplyStyleToLineOrSelection(null, () => rtfTexto.SelectionColor = Color.Blue);
        }

        private void tsVerde_Click(object sender, EventArgs e)
        {
            ApplyStyleToLineOrSelection(null, () => rtfTexto.SelectionColor = Color.Green);
        }

        private void tsLaranja_Click(object sender, EventArgs e)
        {
            ApplyStyleToLineOrSelection(null, () => rtfTexto.SelectionColor = Color.Orange);
        }

        private void tsPreto_Click(object sender, EventArgs e)
        {
            ApplyStyleToLineOrSelection(null, () => rtfTexto.SelectionColor = Color.Black);
        }

        private void tsCinza_Click(object sender, EventArgs e)
        {
            ApplyStyleToLineOrSelection(null, () => rtfTexto.SelectionColor = Color.Gray);
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
