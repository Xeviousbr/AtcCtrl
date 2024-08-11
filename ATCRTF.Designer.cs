
using System.Windows.Forms;

namespace AtcCtrl
{
    partial class ATCRTF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATCRTF));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonIncreaseFont = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDecreaseFont = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRedo = new System.Windows.Forms.ToolStripButton();
            this.tsVermelho = new System.Windows.Forms.ToolStripButton();
            this.tsAzul = new System.Windows.Forms.ToolStripButton();
            this.tsVerde = new System.Windows.Forms.ToolStripButton();
            this.tsLaranja = new System.Windows.Forms.ToolStripButton();
            this.tsPreto = new System.Windows.Forms.ToolStripButton();
            this.tsCinza = new System.Windows.Forms.ToolStripButton();
            this.tsEncriptar = new System.Windows.Forms.ToolStripButton();
            this.tsDescriptar = new System.Windows.Forms.ToolStripButton();
            this.rtfTexto = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBold,
            this.toolStripButtonItalic,
            this.toolStripButtonUnderline,
            this.toolStripButtonIncreaseFont,
            this.toolStripButtonDecreaseFont,
            this.toolStripButtonUndo,
            this.toolStripButtonRedo,
            this.tsVermelho,
            this.tsAzul,
            this.tsVerde,
            this.tsLaranja,
            this.tsPreto,
            this.tsCinza,
            this.tsEncriptar,
            this.tsDescriptar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonBold
            // 
            this.toolStripButtonBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBold.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBold.Image")));
            this.toolStripButtonBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBold.Name = "toolStripButtonBold";
            this.toolStripButtonBold.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBold.Text = "Negrito";
            // 
            // toolStripButtonItalic
            // 
            this.toolStripButtonItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonItalic.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonItalic.Image")));
            this.toolStripButtonItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonItalic.Name = "toolStripButtonItalic";
            this.toolStripButtonItalic.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonItalic.Text = "Itálico";
            this.toolStripButtonItalic.Click += new System.EventHandler(this.toolStripButtonItalic_Click);
            // 
            // toolStripButtonUnderline
            // 
            this.toolStripButtonUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUnderline.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUnderline.Image")));
            this.toolStripButtonUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUnderline.Name = "toolStripButtonUnderline";
            this.toolStripButtonUnderline.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUnderline.Text = "Sublinhado";
            this.toolStripButtonUnderline.Click += new System.EventHandler(this.toolStripButtonUnderline_Click);
            // 
            // toolStripButtonIncreaseFont
            // 
            this.toolStripButtonIncreaseFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonIncreaseFont.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIncreaseFont.Image")));
            this.toolStripButtonIncreaseFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIncreaseFont.Name = "toolStripButtonIncreaseFont";
            this.toolStripButtonIncreaseFont.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonIncreaseFont.Text = "Aumentar Fonte";
            this.toolStripButtonIncreaseFont.Click += new System.EventHandler(this.toolStripButtonIncreaseFont_Click);
            // 
            // toolStripButtonDecreaseFont
            // 
            this.toolStripButtonDecreaseFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDecreaseFont.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDecreaseFont.Image")));
            this.toolStripButtonDecreaseFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDecreaseFont.Name = "toolStripButtonDecreaseFont";
            this.toolStripButtonDecreaseFont.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDecreaseFont.Text = "Reduzir Fonte";
            this.toolStripButtonDecreaseFont.Click += new System.EventHandler(this.toolStripButtonDecreaseFont_Click);
            // 
            // toolStripButtonUndo
            // 
            this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUndo.Image")));
            this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUndo.Text = "Desfazer";
            // 
            // toolStripButtonRedo
            // 
            this.toolStripButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRedo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRedo.Image")));
            this.toolStripButtonRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRedo.Name = "toolStripButtonRedo";
            this.toolStripButtonRedo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRedo.Text = "Refazer";
            this.toolStripButtonRedo.Click += new System.EventHandler(this.toolStripButtonRedo_Click);
            // 
            // tsVermelho
            // 
            this.tsVermelho.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsVermelho.Image = ((System.Drawing.Image)(resources.GetObject("tsVermelho.Image")));
            this.tsVermelho.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsVermelho.Name = "tsVermelho";
            this.tsVermelho.Size = new System.Drawing.Size(23, 22);
            this.tsVermelho.Text = "Vermelho";
            this.tsVermelho.Click += new System.EventHandler(this.tsVermelho_Click);
            // 
            // tsAzul
            // 
            this.tsAzul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAzul.Image = ((System.Drawing.Image)(resources.GetObject("tsAzul.Image")));
            this.tsAzul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAzul.Name = "tsAzul";
            this.tsAzul.Size = new System.Drawing.Size(23, 22);
            this.tsAzul.Text = "Azul";
            this.tsAzul.Click += new System.EventHandler(this.tsAzul_Click);
            // 
            // tsVerde
            // 
            this.tsVerde.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsVerde.Image = ((System.Drawing.Image)(resources.GetObject("tsVerde.Image")));
            this.tsVerde.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsVerde.Name = "tsVerde";
            this.tsVerde.Size = new System.Drawing.Size(23, 22);
            this.tsVerde.Text = "Verde";
            this.tsVerde.Click += new System.EventHandler(this.tsVerde_Click);
            // 
            // tsLaranja
            // 
            this.tsLaranja.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsLaranja.Image = ((System.Drawing.Image)(resources.GetObject("tsLaranja.Image")));
            this.tsLaranja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLaranja.Name = "tsLaranja";
            this.tsLaranja.Size = new System.Drawing.Size(23, 22);
            this.tsLaranja.Text = "Laranja";
            this.tsLaranja.Click += new System.EventHandler(this.tsLaranja_Click);
            // 
            // tsPreto
            // 
            this.tsPreto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsPreto.Image = ((System.Drawing.Image)(resources.GetObject("tsPreto.Image")));
            this.tsPreto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPreto.Name = "tsPreto";
            this.tsPreto.Size = new System.Drawing.Size(23, 22);
            this.tsPreto.Text = "Preto";
            this.tsPreto.Click += new System.EventHandler(this.tsPreto_Click);
            // 
            // tsCinza
            // 
            this.tsCinza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsCinza.Image = ((System.Drawing.Image)(resources.GetObject("tsCinza.Image")));
            this.tsCinza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCinza.Name = "tsCinza";
            this.tsCinza.Size = new System.Drawing.Size(23, 22);
            this.tsCinza.Text = "Cinza";
            this.tsCinza.Click += new System.EventHandler(this.tsCinza_Click);
            // 
            // tsEncriptar
            // 
            this.tsEncriptar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEncriptar.Image = ((System.Drawing.Image)(resources.GetObject("tsEncriptar.Image")));
            this.tsEncriptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEncriptar.Name = "tsEncriptar";
            this.tsEncriptar.Size = new System.Drawing.Size(23, 22);
            this.tsEncriptar.Text = "Ligar Encriptação";
            this.tsEncriptar.Visible = false;
            this.tsEncriptar.Click += new System.EventHandler(this.toolStripButtonEncrypt_Click);
            // 
            // tsDescriptar
            // 
            this.tsDescriptar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDescriptar.Image = ((System.Drawing.Image)(resources.GetObject("tsDescriptar.Image")));
            this.tsDescriptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDescriptar.Name = "tsDescriptar";
            this.tsDescriptar.Size = new System.Drawing.Size(23, 22);
            this.tsDescriptar.Text = "Desligar Encriptação";
            this.tsDescriptar.Visible = false;
            this.tsDescriptar.Click += new System.EventHandler(this.tsDescriptar_Click);
            // 
            // rtfTexto
            // 
            this.rtfTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfTexto.Location = new System.Drawing.Point(0, 25);
            this.rtfTexto.Name = "rtfTexto";
            this.rtfTexto.Size = new System.Drawing.Size(800, 425);
            this.rtfTexto.TabIndex = 1;
            this.rtfTexto.Text = "";
            this.rtfTexto.TextChanged += new System.EventHandler(this.rtfTexto_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ATCRTF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtfTexto);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ATCRTF";
            this.Size = new System.Drawing.Size(800, 450);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        //private void InitializeComponent()
        //{
        //    this.button1 = new System.Windows.Forms.Button();
        //    this.SuspendLayout();
        //    // 
        //    // button1
        //    // 
        //    this.button1.Location = new System.Drawing.Point(145, 78);
        //    this.button1.Name = "button1";
        //    this.button1.Size = new System.Drawing.Size(75, 23);
        //    this.button1.TabIndex = 0;
        //    this.button1.Text = "button1";
        //    this.button1.UseVisualStyleBackColor = true;
        //    // 
        //    // UserControl1
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.Controls.Add(this.button1);
        //    this.Name = "UserControl1";
        //    this.Size = new System.Drawing.Size(800, 450);
        //    this.ResumeLayout(false);

        //}

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RichTextBox rtfTexto;
        private ToolStripButton toolStripButtonBold;
        private ToolStripButton toolStripButtonItalic;
        private ToolStripButton toolStripButtonUnderline;
        private ToolStripButton toolStripButtonIncreaseFont;
        private ToolStripButton toolStripButtonDecreaseFont;
        private ToolStripButton toolStripButtonUndo;
        private ToolStripButton toolStripButtonRedo;
        private ToolStripButton tsVermelho;
        private ToolStripButton tsAzul;
        private ToolStripButton tsVerde;
        private ToolStripButton tsLaranja;
        private ToolStripButton tsPreto;
        private ToolStripButton tsCinza;
        private ToolStripButton tsEncriptar;
        private ToolStripButton tsDescriptar;
        private Timer timer1;
    }
}
