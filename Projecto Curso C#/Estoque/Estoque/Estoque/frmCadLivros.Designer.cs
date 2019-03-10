namespace WindowsFormsApplication1
{
    partial class frmCadLivros
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadLivros));
            System.Windows.Forms.Label iDLivrosLabel;
            System.Windows.Forms.Label titulo_do_livroLabel;
            System.Windows.Forms.Label autorLabel;
            System.Windows.Forms.Label tombamentoLabel;
            System.Windows.Forms.Label preço_de_FabricaLabel;
            System.Windows.Forms.Label anoLabel;
            System.Windows.Forms.Label capaLabel;
            System.Windows.Forms.Label comentáriosLabel;
            System.Windows.Forms.Label resenhaLabel;
            System.Windows.Forms.Label resenhaLabel1;
            System.Windows.Forms.Label comentáriosLabel1;
            System.Windows.Forms.Label autorLabel1;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cadastroLivrosDataSet = new WindowsFormsApplication1.CadastroLivrosDataSet();
            this.livrosCadastrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livrosCadastrosTableAdapter = new WindowsFormsApplication1.CadastroLivrosDataSetTableAdapters.LivrosCadastrosTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.CadastroLivrosDataSetTableAdapters.TableAdapterManager();
            this.livrosCadastrosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.livrosCadastrosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDLivrosTextBox = new System.Windows.Forms.TextBox();
            this.titulo_do_livroTextBox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.tombamentoTextBox = new System.Windows.Forms.TextBox();
            this.preço_de_FabricaTextBox = new System.Windows.Forms.TextBox();
            this.anoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.capaTextBox = new System.Windows.Forms.TextBox();
            this.comentáriosListBox = new System.Windows.Forms.ListBox();
            this.resenhaListBox = new System.Windows.Forms.ListBox();
            this.resenhaListBox1 = new System.Windows.Forms.ListBox();
            this.comentáriosListBox1 = new System.Windows.Forms.ListBox();
            this.autorTextBox1 = new System.Windows.Forms.TextBox();
            iDLivrosLabel = new System.Windows.Forms.Label();
            titulo_do_livroLabel = new System.Windows.Forms.Label();
            autorLabel = new System.Windows.Forms.Label();
            tombamentoLabel = new System.Windows.Forms.Label();
            preço_de_FabricaLabel = new System.Windows.Forms.Label();
            anoLabel = new System.Windows.Forms.Label();
            capaLabel = new System.Windows.Forms.Label();
            comentáriosLabel = new System.Windows.Forms.Label();
            resenhaLabel = new System.Windows.Forms.Label();
            resenhaLabel1 = new System.Windows.Forms.Label();
            comentáriosLabel1 = new System.Windows.Forms.Label();
            autorLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroLivrosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosCadastrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosCadastrosBindingNavigator)).BeginInit();
            this.livrosCadastrosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 233);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Cadastre seus livros aqui");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(96, 525);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 62);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(493, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(183, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(275, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 495);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage1.Controls.Add(resenhaLabel);
            this.tabPage1.Controls.Add(this.resenhaListBox);
            this.tabPage1.Controls.Add(iDLivrosLabel);
            this.tabPage1.Controls.Add(this.iDLivrosTextBox);
            this.tabPage1.Controls.Add(titulo_do_livroLabel);
            this.tabPage1.Controls.Add(this.titulo_do_livroTextBox);
            this.tabPage1.Controls.Add(autorLabel);
            this.tabPage1.Controls.Add(this.autorTextBox);
            this.tabPage1.Controls.Add(tombamentoLabel);
            this.tabPage1.Controls.Add(this.tombamentoTextBox);
            this.tabPage1.Controls.Add(preço_de_FabricaLabel);
            this.tabPage1.Controls.Add(this.preço_de_FabricaTextBox);
            this.tabPage1.Controls.Add(anoLabel);
            this.tabPage1.Controls.Add(this.anoDateTimePicker);
            this.tabPage1.Controls.Add(capaLabel);
            this.tabPage1.Controls.Add(this.capaTextBox);
            this.tabPage1.Controls.Add(comentáriosLabel);
            this.tabPage1.Controls.Add(this.comentáriosListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(545, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Gerais";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage2.Controls.Add(autorLabel1);
            this.tabPage2.Controls.Add(this.autorTextBox1);
            this.tabPage2.Controls.Add(comentáriosLabel1);
            this.tabPage2.Controls.Add(this.comentáriosListBox1);
            this.tabPage2.Controls.Add(resenhaLabel1);
            this.tabPage2.Controls.Add(this.resenhaListBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(545, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comentários";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(461, 312);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Imagem Capa";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipTitle = "Cadastramento de livros";
            // 
            // cadastroLivrosDataSet
            // 
            this.cadastroLivrosDataSet.DataSetName = "CadastroLivrosDataSet";
            this.cadastroLivrosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livrosCadastrosBindingSource
            // 
            this.livrosCadastrosBindingSource.DataMember = "LivrosCadastros";
            this.livrosCadastrosBindingSource.DataSource = this.cadastroLivrosDataSet;
            // 
            // livrosCadastrosTableAdapter
            // 
            this.livrosCadastrosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LivrosCadastrosTableAdapter = this.livrosCadastrosTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.CadastroLivrosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // livrosCadastrosBindingNavigator
            // 
            this.livrosCadastrosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.livrosCadastrosBindingNavigator.BindingSource = this.livrosCadastrosBindingSource;
            this.livrosCadastrosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.livrosCadastrosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.livrosCadastrosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.livrosCadastrosBindingNavigatorSaveItem});
            this.livrosCadastrosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.livrosCadastrosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.livrosCadastrosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.livrosCadastrosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.livrosCadastrosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.livrosCadastrosBindingNavigator.Name = "livrosCadastrosBindingNavigator";
            this.livrosCadastrosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.livrosCadastrosBindingNavigator.Size = new System.Drawing.Size(828, 25);
            this.livrosCadastrosBindingNavigator.TabIndex = 3;
            this.livrosCadastrosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // livrosCadastrosBindingNavigatorSaveItem
            // 
            this.livrosCadastrosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.livrosCadastrosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("livrosCadastrosBindingNavigatorSaveItem.Image")));
            this.livrosCadastrosBindingNavigatorSaveItem.Name = "livrosCadastrosBindingNavigatorSaveItem";
            this.livrosCadastrosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.livrosCadastrosBindingNavigatorSaveItem.Text = "Save Data";
            this.livrosCadastrosBindingNavigatorSaveItem.Click += new System.EventHandler(this.livrosCadastrosBindingNavigatorSaveItem_Click);
            // 
            // iDLivrosLabel
            // 
            iDLivrosLabel.AutoSize = true;
            iDLivrosLabel.Location = new System.Drawing.Point(28, 19);
            iDLivrosLabel.Name = "iDLivrosLabel";
            iDLivrosLabel.Size = new System.Drawing.Size(49, 13);
            iDLivrosLabel.TabIndex = 0;
            iDLivrosLabel.Text = "IDLivros:";
            // 
            // iDLivrosTextBox
            // 
            this.iDLivrosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosCadastrosBindingSource, "IDLivros", true));
            this.iDLivrosTextBox.Location = new System.Drawing.Point(125, 16);
            this.iDLivrosTextBox.Name = "iDLivrosTextBox";
            this.iDLivrosTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDLivrosTextBox.TabIndex = 1;
            // 
            // titulo_do_livroLabel
            // 
            titulo_do_livroLabel.AutoSize = true;
            titulo_do_livroLabel.Location = new System.Drawing.Point(28, 45);
            titulo_do_livroLabel.Name = "titulo_do_livroLabel";
            titulo_do_livroLabel.Size = new System.Drawing.Size(73, 13);
            titulo_do_livroLabel.TabIndex = 2;
            titulo_do_livroLabel.Text = "Titulo do livro:";
            // 
            // titulo_do_livroTextBox
            // 
            this.titulo_do_livroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosCadastrosBindingSource, "Titulo do livro", true));
            this.titulo_do_livroTextBox.Location = new System.Drawing.Point(125, 42);
            this.titulo_do_livroTextBox.Name = "titulo_do_livroTextBox";
            this.titulo_do_livroTextBox.Size = new System.Drawing.Size(200, 20);
            this.titulo_do_livroTextBox.TabIndex = 3;
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Location = new System.Drawing.Point(28, 71);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(35, 13);
            autorLabel.TabIndex = 4;
            autorLabel.Text = "Autor:";
            // 
            // autorTextBox
            // 
            this.autorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosCadastrosBindingSource, "Autor", true));
            this.autorTextBox.Location = new System.Drawing.Point(125, 68);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(200, 20);
            this.autorTextBox.TabIndex = 5;
            // 
            // tombamentoLabel
            // 
            tombamentoLabel.AutoSize = true;
            tombamentoLabel.Location = new System.Drawing.Point(28, 97);
            tombamentoLabel.Name = "tombamentoLabel";
            tombamentoLabel.Size = new System.Drawing.Size(72, 13);
            tombamentoLabel.TabIndex = 6;
            tombamentoLabel.Text = "Tombamento:";
            // 
            // tombamentoTextBox
            // 
            this.tombamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosCadastrosBindingSource, "Tombamento", true));
            this.tombamentoTextBox.Location = new System.Drawing.Point(125, 94);
            this.tombamentoTextBox.Name = "tombamentoTextBox";
            this.tombamentoTextBox.Size = new System.Drawing.Size(200, 20);
            this.tombamentoTextBox.TabIndex = 7;
            // 
            // preço_de_FabricaLabel
            // 
            preço_de_FabricaLabel.AutoSize = true;
            preço_de_FabricaLabel.Location = new System.Drawing.Point(28, 123);
            preço_de_FabricaLabel.Name = "preço_de_FabricaLabel";
            preço_de_FabricaLabel.Size = new System.Drawing.Size(91, 13);
            preço_de_FabricaLabel.TabIndex = 8;
            preço_de_FabricaLabel.Text = "Preço de Fabrica:";
            // 
            // preço_de_FabricaTextBox
            // 
            this.preço_de_FabricaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosCadastrosBindingSource, "Preço de Fabrica", true));
            this.preço_de_FabricaTextBox.Location = new System.Drawing.Point(125, 120);
            this.preço_de_FabricaTextBox.Name = "preço_de_FabricaTextBox";
            this.preço_de_FabricaTextBox.Size = new System.Drawing.Size(200, 20);
            this.preço_de_FabricaTextBox.TabIndex = 9;
            // 
            // anoLabel
            // 
            anoLabel.AutoSize = true;
            anoLabel.Location = new System.Drawing.Point(28, 150);
            anoLabel.Name = "anoLabel";
            anoLabel.Size = new System.Drawing.Size(29, 13);
            anoLabel.TabIndex = 10;
            anoLabel.Text = "Ano:";
            // 
            // anoDateTimePicker
            // 
            this.anoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.livrosCadastrosBindingSource, "Ano", true));
            this.anoDateTimePicker.Location = new System.Drawing.Point(125, 146);
            this.anoDateTimePicker.Name = "anoDateTimePicker";
            this.anoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.anoDateTimePicker.TabIndex = 11;
            // 
            // capaLabel
            // 
            capaLabel.AutoSize = true;
            capaLabel.Location = new System.Drawing.Point(28, 175);
            capaLabel.Name = "capaLabel";
            capaLabel.Size = new System.Drawing.Size(35, 13);
            capaLabel.TabIndex = 12;
            capaLabel.Text = "Capa:";
            // 
            // capaTextBox
            // 
            this.capaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosCadastrosBindingSource, "Capa", true));
            this.capaTextBox.Location = new System.Drawing.Point(125, 172);
            this.capaTextBox.Name = "capaTextBox";
            this.capaTextBox.Size = new System.Drawing.Size(200, 20);
            this.capaTextBox.TabIndex = 13;
            // 
            // comentáriosLabel
            // 
            comentáriosLabel.AutoSize = true;
            comentáriosLabel.Location = new System.Drawing.Point(28, 343);
            comentáriosLabel.Name = "comentáriosLabel";
            comentáriosLabel.Size = new System.Drawing.Size(68, 13);
            comentáriosLabel.TabIndex = 16;
            comentáriosLabel.Text = "Comentários:";
            // 
            // comentáriosListBox
            // 
            this.comentáriosListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.livrosCadastrosBindingSource, "Comentários", true));
            this.comentáriosListBox.FormattingEnabled = true;
            this.comentáriosListBox.Location = new System.Drawing.Point(125, 325);
            this.comentáriosListBox.Name = "comentáriosListBox";
            this.comentáriosListBox.Size = new System.Drawing.Size(200, 95);
            this.comentáriosListBox.TabIndex = 17;
            // 
            // resenhaLabel
            // 
            resenhaLabel.AutoSize = true;
            resenhaLabel.Location = new System.Drawing.Point(28, 206);
            resenhaLabel.Name = "resenhaLabel";
            resenhaLabel.Size = new System.Drawing.Size(53, 13);
            resenhaLabel.TabIndex = 17;
            resenhaLabel.Text = "Resenha:";
            // 
            // resenhaListBox
            // 
            this.resenhaListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.livrosCadastrosBindingSource, "Resenha", true));
            this.resenhaListBox.FormattingEnabled = true;
            this.resenhaListBox.Location = new System.Drawing.Point(125, 206);
            this.resenhaListBox.Name = "resenhaListBox";
            this.resenhaListBox.Size = new System.Drawing.Size(200, 95);
            this.resenhaListBox.TabIndex = 18;
            // 
            // resenhaLabel1
            // 
            resenhaLabel1.AutoSize = true;
            resenhaLabel1.Location = new System.Drawing.Point(20, 19);
            resenhaLabel1.Name = "resenhaLabel1";
            resenhaLabel1.Size = new System.Drawing.Size(53, 13);
            resenhaLabel1.TabIndex = 0;
            resenhaLabel1.Text = "Resenha:";
            // 
            // resenhaListBox1
            // 
            this.resenhaListBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.livrosCadastrosBindingSource, "Resenha", true));
            this.resenhaListBox1.FormattingEnabled = true;
            this.resenhaListBox1.Location = new System.Drawing.Point(116, 19);
            this.resenhaListBox1.Name = "resenhaListBox1";
            this.resenhaListBox1.Size = new System.Drawing.Size(400, 134);
            this.resenhaListBox1.TabIndex = 1;
            // 
            // comentáriosLabel1
            // 
            comentáriosLabel1.AutoSize = true;
            comentáriosLabel1.Location = new System.Drawing.Point(20, 167);
            comentáriosLabel1.Name = "comentáriosLabel1";
            comentáriosLabel1.Size = new System.Drawing.Size(68, 13);
            comentáriosLabel1.TabIndex = 2;
            comentáriosLabel1.Text = "Comentários:";
            comentáriosLabel1.Click += new System.EventHandler(this.comentáriosLabel1_Click);
            // 
            // comentáriosListBox1
            // 
            this.comentáriosListBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.livrosCadastrosBindingSource, "Comentários", true));
            this.comentáriosListBox1.FormattingEnabled = true;
            this.comentáriosListBox1.Location = new System.Drawing.Point(116, 167);
            this.comentáriosListBox1.Name = "comentáriosListBox1";
            this.comentáriosListBox1.Size = new System.Drawing.Size(400, 121);
            this.comentáriosListBox1.TabIndex = 3;
            // 
            // autorLabel1
            // 
            autorLabel1.AutoSize = true;
            autorLabel1.Location = new System.Drawing.Point(20, 346);
            autorLabel1.Name = "autorLabel1";
            autorLabel1.Size = new System.Drawing.Size(35, 13);
            autorLabel1.TabIndex = 4;
            autorLabel1.Text = "Autor:";
            // 
            // autorTextBox1
            // 
            this.autorTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosCadastrosBindingSource, "Autor", true));
            this.autorTextBox1.Location = new System.Drawing.Point(86, 346);
            this.autorTextBox1.Name = "autorTextBox1";
            this.autorTextBox1.Size = new System.Drawing.Size(430, 20);
            this.autorTextBox1.TabIndex = 5;
            // 
            // frmCadLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 614);
            this.Controls.Add(this.livrosCadastrosBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCadLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Livros";
            this.Load += new System.EventHandler(this.frmCadLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroLivrosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosCadastrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosCadastrosBindingNavigator)).EndInit();
            this.livrosCadastrosBindingNavigator.ResumeLayout(false);
            this.livrosCadastrosBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolTip toolTip1;
        private CadastroLivrosDataSet cadastroLivrosDataSet;
        private System.Windows.Forms.BindingSource livrosCadastrosBindingSource;
        private CadastroLivrosDataSetTableAdapters.LivrosCadastrosTableAdapter livrosCadastrosTableAdapter;
        private CadastroLivrosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator livrosCadastrosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton livrosCadastrosBindingNavigatorSaveItem;
        private System.Windows.Forms.ListBox resenhaListBox;
        private System.Windows.Forms.TextBox iDLivrosTextBox;
        private System.Windows.Forms.TextBox titulo_do_livroTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox tombamentoTextBox;
        private System.Windows.Forms.TextBox preço_de_FabricaTextBox;
        private System.Windows.Forms.DateTimePicker anoDateTimePicker;
        private System.Windows.Forms.TextBox capaTextBox;
        private System.Windows.Forms.ListBox comentáriosListBox;
        private System.Windows.Forms.TextBox autorTextBox1;
        private System.Windows.Forms.ListBox comentáriosListBox1;
        private System.Windows.Forms.ListBox resenhaListBox1;
    }
}