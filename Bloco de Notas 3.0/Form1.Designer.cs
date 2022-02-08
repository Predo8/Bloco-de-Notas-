namespace Bloco_de_Notas_3._0
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaJanelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.configurarPáginaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.recortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.localizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locolizarProximaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localizarAnteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.substituirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irParaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.selecionarTudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horaDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quebraAutomáticaDeLinhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ampliarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reduzirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarZoomPadrãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraDeStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripInformacoes = new System.Windows.Forms.StatusStrip();
            this.richTextBoxConteudo = new System.Windows.Forms.RichTextBox();
            this.openFileDialogAbrir = new System.Windows.Forms.OpenFileDialog();
            this.printDocumentConteudo = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialogConfiguraPagina = new System.Windows.Forms.PageSetupDialog();
            this.printDialogImprimir = new System.Windows.Forms.PrintDialog();
            this.menuStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatarToolStripMenuItem,
            this.exibirToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStripPrincipal.Size = new System.Drawing.Size(832, 28);
            this.menuStripPrincipal.TabIndex = 0;
            this.menuStripPrincipal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.novaJanelaToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.salvarComoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.configurarPáginaToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.toolStripMenuItem3,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // novaJanelaToolStripMenuItem
            // 
            this.novaJanelaToolStripMenuItem.Name = "novaJanelaToolStripMenuItem";
            this.novaJanelaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.novaJanelaToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.novaJanelaToolStripMenuItem.Text = "Nova Janela";
            this.novaJanelaToolStripMenuItem.Click += new System.EventHandler(this.novaJanelaToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.salvarComoToolStripMenuItem.Text = "Salvar Como...";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.salvarComoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(272, 6);
            // 
            // configurarPáginaToolStripMenuItem
            // 
            this.configurarPáginaToolStripMenuItem.Name = "configurarPáginaToolStripMenuItem";
            this.configurarPáginaToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.configurarPáginaToolStripMenuItem.Text = "Configurar Página...";
            this.configurarPáginaToolStripMenuItem.Click += new System.EventHandler(this.configurarPáginaToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.imprimirToolStripMenuItem.Text = "Imprimir...";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(272, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desfazerToolStripMenuItem,
            this.toolStripMenuItem2,
            this.recortarToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.toolStripMenuItem4,
            this.localizarToolStripMenuItem,
            this.locolizarProximaToolStripMenuItem,
            this.localizarAnteriorToolStripMenuItem,
            this.substituirToolStripMenuItem,
            this.irParaToolStripMenuItem,
            this.toolStripMenuItem5,
            this.selecionarTudoToolStripMenuItem,
            this.horaDataToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.desfazerToolStripMenuItem.Text = "Desfazer";
            this.desfazerToolStripMenuItem.Click += new System.EventHandler(this.desfazerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(270, 6);
            // 
            // recortarToolStripMenuItem
            // 
            this.recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            this.recortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.recortarToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.recortarToolStripMenuItem.Text = "Recortar";
            this.recortarToolStripMenuItem.Click += new System.EventHandler(this.recortarToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.colarToolStripMenuItem.Text = "Colar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(270, 6);
            // 
            // localizarToolStripMenuItem
            // 
            this.localizarToolStripMenuItem.Name = "localizarToolStripMenuItem";
            this.localizarToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F";
            this.localizarToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.localizarToolStripMenuItem.Text = "Localizar";
            // 
            // locolizarProximaToolStripMenuItem
            // 
            this.locolizarProximaToolStripMenuItem.Name = "locolizarProximaToolStripMenuItem";
            this.locolizarProximaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.locolizarProximaToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.locolizarProximaToolStripMenuItem.Text = "Locolizar Proxima";
            // 
            // localizarAnteriorToolStripMenuItem
            // 
            this.localizarAnteriorToolStripMenuItem.Name = "localizarAnteriorToolStripMenuItem";
            this.localizarAnteriorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.localizarAnteriorToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.localizarAnteriorToolStripMenuItem.Text = "Localizar Anterior";
            // 
            // substituirToolStripMenuItem
            // 
            this.substituirToolStripMenuItem.Name = "substituirToolStripMenuItem";
            this.substituirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.substituirToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.substituirToolStripMenuItem.Text = "Substituir...";
            // 
            // irParaToolStripMenuItem
            // 
            this.irParaToolStripMenuItem.Name = "irParaToolStripMenuItem";
            this.irParaToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+G";
            this.irParaToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.irParaToolStripMenuItem.Text = "Ir para...";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(270, 6);
            // 
            // selecionarTudoToolStripMenuItem
            // 
            this.selecionarTudoToolStripMenuItem.Name = "selecionarTudoToolStripMenuItem";
            this.selecionarTudoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selecionarTudoToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.selecionarTudoToolStripMenuItem.Text = "Selecionar Tudo";
            this.selecionarTudoToolStripMenuItem.Click += new System.EventHandler(this.selecionarTudoToolStripMenuItem_Click);
            // 
            // horaDataToolStripMenuItem
            // 
            this.horaDataToolStripMenuItem.Name = "horaDataToolStripMenuItem";
            this.horaDataToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.horaDataToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.horaDataToolStripMenuItem.Text = "Hora/Data";
            this.horaDataToolStripMenuItem.Click += new System.EventHandler(this.horaDataToolStripMenuItem_Click);
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quebraAutomáticaDeLinhaToolStripMenuItem,
            this.fonteToolStripMenuItem});
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.formatarToolStripMenuItem.Text = "Formatar";
            // 
            // quebraAutomáticaDeLinhaToolStripMenuItem
            // 
            this.quebraAutomáticaDeLinhaToolStripMenuItem.Name = "quebraAutomáticaDeLinhaToolStripMenuItem";
            this.quebraAutomáticaDeLinhaToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.quebraAutomáticaDeLinhaToolStripMenuItem.Text = "Quebra Automática de linha";
            this.quebraAutomáticaDeLinhaToolStripMenuItem.Click += new System.EventHandler(this.quebraAutomáticaDeLinhaToolStripMenuItem_Click);
            // 
            // fonteToolStripMenuItem
            // 
            this.fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            this.fonteToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.fonteToolStripMenuItem.Text = "Fonte...";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.barraDeStatusToolStripMenuItem});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ampliarToolStripMenuItem,
            this.reduzirToolStripMenuItem,
            this.restaurarZoomPadrãoToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // ampliarToolStripMenuItem
            // 
            this.ampliarToolStripMenuItem.Name = "ampliarToolStripMenuItem";
            this.ampliarToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.ampliarToolStripMenuItem.Text = "Ampliar";
            // 
            // reduzirToolStripMenuItem
            // 
            this.reduzirToolStripMenuItem.Name = "reduzirToolStripMenuItem";
            this.reduzirToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.reduzirToolStripMenuItem.Text = "Reduzir";
            // 
            // restaurarZoomPadrãoToolStripMenuItem
            // 
            this.restaurarZoomPadrãoToolStripMenuItem.Name = "restaurarZoomPadrãoToolStripMenuItem";
            this.restaurarZoomPadrãoToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.restaurarZoomPadrãoToolStripMenuItem.Text = "Restaurar Zoom  Padrão";
            // 
            // barraDeStatusToolStripMenuItem
            // 
            this.barraDeStatusToolStripMenuItem.Name = "barraDeStatusToolStripMenuItem";
            this.barraDeStatusToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.barraDeStatusToolStripMenuItem.Text = "Barra de status";
            // 
            // statusStripInformacoes
            // 
            this.statusStripInformacoes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripInformacoes.Location = new System.Drawing.Point(0, 411);
            this.statusStripInformacoes.Name = "statusStripInformacoes";
            this.statusStripInformacoes.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStripInformacoes.Size = new System.Drawing.Size(832, 22);
            this.statusStripInformacoes.TabIndex = 1;
            this.statusStripInformacoes.Text = "statusStrip1";
            // 
            // richTextBoxConteudo
            // 
            this.richTextBoxConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxConteudo.Location = new System.Drawing.Point(0, 28);
            this.richTextBoxConteudo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxConteudo.Name = "richTextBoxConteudo";
            this.richTextBoxConteudo.Size = new System.Drawing.Size(832, 383);
            this.richTextBoxConteudo.TabIndex = 2;
            this.richTextBoxConteudo.Text = "";
            this.richTextBoxConteudo.TextChanged += new System.EventHandler(this.richTextBoxConteudo_TextChanged);
            // 
            // openFileDialogAbrir
            // 
            this.openFileDialogAbrir.InitialDirectory = "C:";
            this.openFileDialogAbrir.Title = "Abrir Arquivo";
            // 
            // pageSetupDialogConfiguraPagina
            // 
            this.pageSetupDialogConfiguraPagina.Document = this.printDocumentConteudo;
            // 
            // printDialogImprimir
            // 
            this.printDialogImprimir.Document = this.printDocumentConteudo;
            this.printDialogImprimir.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 433);
            this.Controls.Add(this.richTextBoxConteudo);
            this.Controls.Add(this.statusStripInformacoes);
            this.Controls.Add(this.menuStripPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Bloco de Notas 3.0  do Predo";
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripInformacoes;
        private System.Windows.Forms.RichTextBox richTextBoxConteudo;
        private System.Windows.Forms.ToolStripMenuItem novaJanelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configurarPáginaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem recortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem localizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locolizarProximaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localizarAnteriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem substituirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irParaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem selecionarTudoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horaDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quebraAutomáticaDeLinhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ampliarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reduzirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarZoomPadrãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barraDeStatusToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogAbrir;
        private System.Drawing.Printing.PrintDocument printDocumentConteudo;
        private System.Windows.Forms.PageSetupDialog pageSetupDialogConfiguraPagina;
        private System.Windows.Forms.PrintDialog printDialogImprimir;
    }
}

