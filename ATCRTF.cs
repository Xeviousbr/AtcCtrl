using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TeleBonifacio.gen;

// 1.1.5 Acionamento de URLs
// 1.1.4 Funcionamento do TAB
// 1.1.3 Previsão de erro pra caso o arquivo não exista
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

        #region rtfTexto        

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

        private void rtfTexto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                // Insere espaços equivalentes a um TAB
                int espacosParaTab = 4; // Você pode ajustar este valor conforme necessário
                rtfTexto.SelectedText = new string(' ', espacosParaTab);
            }
        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            SalvaRTF();
            if (timer1.Interval > 500)
            {
                timer1.Interval -= 100;
            }
        }

        #region Arquivo        

        public void Carrega()
        {
            try
            {
                string Texto = File.ReadAllText(caminhoDoArquivo);
                if (Criptografia)
                {
                    Texto = Cripto.Decrypt(Texto);
                }
                rtfTexto.Rtf = Texto;
            }
            catch (Exception)
            {
                // throw;
            }
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

        #endregion

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

        #region URL        

        private bool IsValidUrl(string text)
        {
            string pattern = @"^(https?:\/\/)?([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?$";
            return Regex.IsMatch(text, pattern, RegexOptions.IgnoreCase);
        }

        private string GetWordAtIndex(int index)
        {
            string text = rtfTexto.Text;
            int start = index;
            int end = index;

            while (start > 0 && !char.IsWhiteSpace(text[start - 1]))
            {
                start--;
            }

            while (end < text.Length && !char.IsWhiteSpace(text[end]))
            {
                end++;
            }

            return text.Substring(start, end - start);
        }

        private void rtfTexto_MouseMove(object sender, MouseEventArgs e)
        {
            int charIndex = rtfTexto.GetCharIndexFromPosition(e.Location);
            if (charIndex >= 0 && charIndex < rtfTexto.Text.Length)
            {
                string word = GetWordAtIndex(charIndex);
                if (IsValidUrl(word))
                {
                    rtfTexto.Cursor = Cursors.Hand;
                }
                else
                {
                    rtfTexto.Cursor = Cursors.IBeam;
                }
            }
        }

        private void rtfTexto_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo(e.LinkText) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o link: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

    }
}
