namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.Windows.Forms.Label contatos_IDLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label companiaLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label clienteLabel;
            System.Windows.Forms.Label ultima_chamadaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pessoasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contadosDBDataSet = new WindowsFormsApplication1.ContadosDBDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pessoasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.contatos_IDTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.companiaTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.clienteCheckBox = new System.Windows.Forms.CheckBox();
            this.ultima_chamadaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pessoasTableAdapter = new WindowsFormsApplication1.ContadosDBDataSetTableAdapters.PessoasTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.ContadosDBDataSetTableAdapters.TableAdapterManager();
            contatos_IDLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            companiaLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            clienteLabel = new System.Windows.Forms.Label();
            ultima_chamadaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingNavigator)).BeginInit();
            this.pessoasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contadosDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // contatos_IDLabel
            // 
            contatos_IDLabel.AutoSize = true;
            contatos_IDLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contatos_IDLabel.Location = new System.Drawing.Point(19, 86);
            contatos_IDLabel.Name = "contatos_IDLabel";
            contatos_IDLabel.Size = new System.Drawing.Size(91, 18);
            contatos_IDLabel.TabIndex = 2;
            contatos_IDLabel.Text = "Contatos ID:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(24, 127);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(48, 18);
            nomeLabel.TabIndex = 4;
            nomeLabel.Text = "Nome:";
            // 
            // companiaLabel
            // 
            companiaLabel.AutoSize = true;
            companiaLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            companiaLabel.Location = new System.Drawing.Point(24, 153);
            companiaLabel.Name = "companiaLabel";
            companiaLabel.Size = new System.Drawing.Size(76, 18);
            companiaLabel.TabIndex = 6;
            companiaLabel.Text = "Compania:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefoneLabel.Location = new System.Drawing.Point(24, 184);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(67, 18);
            telefoneLabel.TabIndex = 8;
            telefoneLabel.Text = "Telefone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(24, 218);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 18);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "Email:";
            // 
            // clienteLabel
            // 
            clienteLabel.AutoSize = true;
            clienteLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            clienteLabel.Location = new System.Drawing.Point(24, 254);
            clienteLabel.Name = "clienteLabel";
            clienteLabel.Size = new System.Drawing.Size(57, 18);
            clienteLabel.TabIndex = 12;
            clienteLabel.Text = "Cliente:";
            clienteLabel.Click += new System.EventHandler(this.clienteLabel_Click);
            // 
            // ultima_chamadaLabel
            // 
            ultima_chamadaLabel.AutoSize = true;
            ultima_chamadaLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ultima_chamadaLabel.Location = new System.Drawing.Point(24, 302);
            ultima_chamadaLabel.Name = "ultima_chamadaLabel";
            ultima_chamadaLabel.Size = new System.Drawing.Size(118, 18);
            ultima_chamadaLabel.TabIndex = 14;
            ultima_chamadaLabel.Text = "Ultima chamada:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(669, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pessoasBindingNavigator
            // 
            this.pessoasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pessoasBindingNavigator.BindingSource = this.pessoasBindingSource;
            this.pessoasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pessoasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pessoasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pessoasBindingNavigatorSaveItem});
            this.pessoasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pessoasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pessoasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pessoasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pessoasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pessoasBindingNavigator.Name = "pessoasBindingNavigator";
            this.pessoasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pessoasBindingNavigator.Size = new System.Drawing.Size(823, 25);
            this.pessoasBindingNavigator.TabIndex = 1;
            this.pessoasBindingNavigator.Text = "bindingNavigator1";
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
            // pessoasBindingSource
            // 
            this.pessoasBindingSource.DataMember = "Pessoas";
            this.pessoasBindingSource.DataSource = this.contadosDBDataSet;
            // 
            // contadosDBDataSet
            // 
            this.contadosDBDataSet.DataSetName = "ContadosDBDataSet";
            this.contadosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pessoasBindingNavigatorSaveItem
            // 
            this.pessoasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pessoasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pessoasBindingNavigatorSaveItem.Image")));
            this.pessoasBindingNavigatorSaveItem.Name = "pessoasBindingNavigatorSaveItem";
            this.pessoasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pessoasBindingNavigatorSaveItem.Text = "Save Data";
            this.pessoasBindingNavigatorSaveItem.Click += new System.EventHandler(this.pessoasBindingNavigatorSaveItem_Click);
            // 
            // contatos_IDTextBox
            // 
            this.contatos_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Contatos ID", true));
            this.contatos_IDTextBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contatos_IDTextBox.Location = new System.Drawing.Point(116, 86);
            this.contatos_IDTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.contatos_IDTextBox.Multiline = true;
            this.contatos_IDTextBox.Name = "contatos_IDTextBox";
            this.contatos_IDTextBox.Size = new System.Drawing.Size(57, 20);
            this.contatos_IDTextBox.TabIndex = 3;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(116, 120);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 25);
            this.nomeTextBox.TabIndex = 5;
            this.nomeTextBox.Text = "Digite seu nome";
            this.nomeTextBox.TextChanged += new System.EventHandler(this.nomeTextBox_TextChanged);
            // 
            // companiaTextBox
            // 
            this.companiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Compania", true));
            this.companiaTextBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companiaTextBox.Location = new System.Drawing.Point(116, 150);
            this.companiaTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.companiaTextBox.Name = "companiaTextBox";
            this.companiaTextBox.Size = new System.Drawing.Size(200, 25);
            this.companiaTextBox.TabIndex = 7;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Telefone", true));
            this.telefoneTextBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneTextBox.Location = new System.Drawing.Point(116, 181);
            this.telefoneTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(200, 25);
            this.telefoneTextBox.TabIndex = 9;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(116, 212);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 25);
            this.emailTextBox.TabIndex = 11;
            // 
            // clienteCheckBox
            // 
            this.clienteCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.pessoasBindingSource, "Cliente", true));
            this.clienteCheckBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteCheckBox.Location = new System.Drawing.Point(116, 249);
            this.clienteCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.clienteCheckBox.Name = "clienteCheckBox";
            this.clienteCheckBox.Size = new System.Drawing.Size(200, 24);
            this.clienteCheckBox.TabIndex = 13;
            this.clienteCheckBox.Text = "Sim";
            this.clienteCheckBox.UseVisualStyleBackColor = true;
            // 
            // ultima_chamadaDateTimePicker
            // 
            this.ultima_chamadaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pessoasBindingSource, "Ultima chamada", true));
            this.ultima_chamadaDateTimePicker.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultima_chamadaDateTimePicker.Location = new System.Drawing.Point(148, 297);
            this.ultima_chamadaDateTimePicker.Name = "ultima_chamadaDateTimePicker";
            this.ultima_chamadaDateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.ultima_chamadaDateTimePicker.TabIndex = 15;
            // 
            // pessoasTableAdapter
            // 
            this.pessoasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PessoasTableAdapter = this.pessoasTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.ContadosDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(823, 596);
            this.Controls.Add(contatos_IDLabel);
            this.Controls.Add(this.contatos_IDTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(companiaLabel);
            this.Controls.Add(this.companiaTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(clienteLabel);
            this.Controls.Add(this.clienteCheckBox);
            this.Controls.Add(ultima_chamadaLabel);
            this.Controls.Add(this.ultima_chamadaDateTimePicker);
            this.Controls.Add(this.pessoasBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Agenda Simples";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingNavigator)).EndInit();
            this.pessoasBindingNavigator.ResumeLayout(false);
            this.pessoasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contadosDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ContadosDBDataSet contadosDBDataSet;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private ContadosDBDataSetTableAdapters.PessoasTableAdapter pessoasTableAdapter;
        private ContadosDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pessoasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pessoasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox contatos_IDTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox companiaTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.CheckBox clienteCheckBox;
        private System.Windows.Forms.DateTimePicker ultima_chamadaDateTimePicker;
    }
}

