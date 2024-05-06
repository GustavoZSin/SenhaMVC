using System;
using System.Drawing;
using System.Windows.Forms;

namespace SenhaMVC
{
    partial class SenhaView
    {
        private GroupBox grbJogadas;
        private Button btnJogar;
        private ColorComboBox cbxCorSelecionada1;
        private ColorComboBox cbxCorSelecionada2;
        private ColorComboBox cbxCorSelecionada3;
        private ColorComboBox cbxCorSelecionada4;
        private ColorComboBox cbxCorSelecionada5;
        private DataGridView dgvJogadas;
        private DataGridView dgvResultados;
        private Label label1;
        private Label label2;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbJogadas = new GroupBox();
            cbxCorSelecionada1 = new ColorComboBox();
            cbxCorSelecionada2 = new ColorComboBox();
            cbxCorSelecionada3 = new ColorComboBox();
            cbxCorSelecionada4 = new ColorComboBox();
            cbxCorSelecionada5 = new ColorComboBox();
            btnJogar = new Button();
            dgvJogadas = new DataGridView();
            CorJogada1 = new DataGridViewTextBoxColumn();
            CorJogada2 = new DataGridViewTextBoxColumn();
            CorJogada3 = new DataGridViewTextBoxColumn();
            CorJogada4 = new DataGridViewTextBoxColumn();
            CorJogada5 = new DataGridViewTextBoxColumn();
            dgvResultados = new DataGridView();
            CorResultado1 = new DataGridViewTextBoxColumn();
            CorResultado2 = new DataGridViewTextBoxColumn();
            CorResultado3 = new DataGridViewTextBoxColumn();
            CorResultado4 = new DataGridViewTextBoxColumn();
            CorResultado5 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            grbJogadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJogadas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // grbJogadas
            // 
            grbJogadas.Controls.Add(cbxCorSelecionada1);
            grbJogadas.Controls.Add(cbxCorSelecionada2);
            grbJogadas.Controls.Add(cbxCorSelecionada3);
            grbJogadas.Controls.Add(cbxCorSelecionada4);
            grbJogadas.Controls.Add(cbxCorSelecionada5);
            grbJogadas.Controls.Add(btnJogar);
            grbJogadas.Location = new Point(13, 20);
            grbJogadas.Margin = new Padding(3, 2, 3, 2);
            grbJogadas.Name = "grbJogadas";
            grbJogadas.Padding = new Padding(3, 2, 3, 2);
            grbJogadas.Size = new Size(783, 64);
            grbJogadas.TabIndex = 0;
            grbJogadas.TabStop = false;
            grbJogadas.Text = "Jogadas";
            // 
            // cbxCorSelecionada1
            // 
            cbxCorSelecionada1.DrawMode = DrawMode.OwnerDrawFixed;
            cbxCorSelecionada1.FormattingEnabled = true;
            cbxCorSelecionada1.Location = new Point(9, 27);
            cbxCorSelecionada1.Margin = new Padding(3, 2, 3, 2);
            cbxCorSelecionada1.Name = "cbxCorSelecionada1";
            cbxCorSelecionada1.Size = new Size(108, 24);
            cbxCorSelecionada1.TabIndex = 1;
            // 
            // cbxCorSelecionada2
            // 
            cbxCorSelecionada2.DrawMode = DrawMode.OwnerDrawFixed;
            cbxCorSelecionada2.FormattingEnabled = true;
            cbxCorSelecionada2.Location = new Point(122, 27);
            cbxCorSelecionada2.Margin = new Padding(3, 2, 3, 2);
            cbxCorSelecionada2.Name = "cbxCorSelecionada2";
            cbxCorSelecionada2.Size = new Size(108, 24);
            cbxCorSelecionada2.TabIndex = 2;
            // 
            // cbxCorSelecionada3
            // 
            cbxCorSelecionada3.DrawMode = DrawMode.OwnerDrawFixed;
            cbxCorSelecionada3.FormattingEnabled = true;
            cbxCorSelecionada3.Location = new Point(234, 27);
            cbxCorSelecionada3.Margin = new Padding(3, 2, 3, 2);
            cbxCorSelecionada3.Name = "cbxCorSelecionada3";
            cbxCorSelecionada3.Size = new Size(108, 24);
            cbxCorSelecionada3.TabIndex = 3;
            // 
            // cbxCorSelecionada4
            // 
            cbxCorSelecionada4.DrawMode = DrawMode.OwnerDrawFixed;
            cbxCorSelecionada4.FormattingEnabled = true;
            cbxCorSelecionada4.Location = new Point(347, 27);
            cbxCorSelecionada4.Margin = new Padding(3, 2, 3, 2);
            cbxCorSelecionada4.Name = "cbxCorSelecionada4";
            cbxCorSelecionada4.Size = new Size(108, 24);
            cbxCorSelecionada4.TabIndex = 4;
            // 
            // cbxCorSelecionada5
            // 
            cbxCorSelecionada5.DrawMode = DrawMode.OwnerDrawFixed;
            cbxCorSelecionada5.FormattingEnabled = true;
            cbxCorSelecionada5.Location = new Point(460, 27);
            cbxCorSelecionada5.Margin = new Padding(3, 2, 3, 2);
            cbxCorSelecionada5.Name = "cbxCorSelecionada5";
            cbxCorSelecionada5.Size = new Size(108, 24);
            cbxCorSelecionada5.TabIndex = 5;
            // 
            // btnJogar
            // 
            btnJogar.Location = new Point(672, 27);
            btnJogar.Margin = new Padding(3, 2, 3, 2);
            btnJogar.Name = "btnJogar";
            btnJogar.Size = new Size(82, 22);
            btnJogar.TabIndex = 6;
            btnJogar.Text = "Jogar";
            btnJogar.UseVisualStyleBackColor = true;
            btnJogar.Click += btnJogar_Click;
            // 
            // dgvJogadas
            // 
            dgvJogadas.AllowUserToAddRows = false;
            dgvJogadas.ColumnHeadersHeight = 29;
            dgvJogadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvJogadas.Columns.AddRange(new DataGridViewColumn[] { CorJogada1, CorJogada2, CorJogada3, CorJogada4, CorJogada5 });
            dgvJogadas.Location = new Point(13, 121);
            dgvJogadas.Margin = new Padding(3, 2, 3, 2);
            dgvJogadas.Name = "dgvJogadas";
            dgvJogadas.RowHeadersWidth = 51;
            dgvJogadas.ScrollBars = ScrollBars.Vertical;
            dgvJogadas.Size = new Size(401, 307);
            dgvJogadas.TabIndex = 7;
            // 
            // CorJogada1
            // 
            CorJogada1.FillWeight = 10F;
            CorJogada1.HeaderText = "1ª Cor";
            CorJogada1.MinimumWidth = 6;
            CorJogada1.Name = "CorJogada1";
            CorJogada1.ReadOnly = true;
            CorJogada1.Resizable = DataGridViewTriState.False;
            CorJogada1.SortMode = DataGridViewColumnSortMode.NotSortable;
            CorJogada1.Width = 70;
            // 
            // CorJogada2
            // 
            CorJogada2.HeaderText = "2ª Cor";
            CorJogada2.MinimumWidth = 6;
            CorJogada2.Name = "CorJogada2";
            CorJogada2.ReadOnly = true;
            CorJogada2.SortMode = DataGridViewColumnSortMode.NotSortable;
            CorJogada2.Width = 70;
            // 
            // CorJogada3
            // 
            CorJogada3.HeaderText = "3ª Cor";
            CorJogada3.MinimumWidth = 6;
            CorJogada3.Name = "CorJogada3";
            CorJogada3.ReadOnly = true;
            CorJogada3.SortMode = DataGridViewColumnSortMode.NotSortable;
            CorJogada3.Width = 70;
            // 
            // CorJogada4
            // 
            CorJogada4.HeaderText = "4ª Cor";
            CorJogada4.MinimumWidth = 6;
            CorJogada4.Name = "CorJogada4";
            CorJogada4.ReadOnly = true;
            CorJogada4.SortMode = DataGridViewColumnSortMode.NotSortable;
            CorJogada4.Width = 70;
            // 
            // CorJogada5
            // 
            CorJogada5.HeaderText = "5ª Cor";
            CorJogada5.MinimumWidth = 6;
            CorJogada5.Name = "CorJogada5";
            CorJogada5.ReadOnly = true;
            CorJogada5.SortMode = DataGridViewColumnSortMode.NotSortable;
            CorJogada5.Width = 70;
            // 
            // dgvResultados
            // 
            dgvResultados.AllowUserToAddRows = false;
            dgvResultados.ColumnHeadersHeight = 29;
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { CorResultado1, CorResultado2, CorResultado3, CorResultado4, CorResultado5 });
            dgvResultados.Location = new Point(445, 121);
            dgvResultados.Margin = new Padding(3, 2, 3, 2);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.ScrollBars = ScrollBars.Vertical;
            dgvResultados.Size = new Size(351, 307);
            dgvResultados.TabIndex = 8;
            // 
            // CorResultado1
            // 
            CorResultado1.HeaderText = "1";
            CorResultado1.MinimumWidth = 6;
            CorResultado1.Name = "CorResultado1";
            CorResultado1.ReadOnly = true;
            CorResultado1.SortMode = DataGridViewColumnSortMode.NotSortable;
            CorResultado1.Width = 60;
            // 
            // CorResultado2
            // 
            CorResultado2.HeaderText = "2";
            CorResultado2.MinimumWidth = 6;
            CorResultado2.Name = "CorResultado2";
            CorResultado2.ReadOnly = true;
            CorResultado2.SortMode = DataGridViewColumnSortMode.NotSortable;
            CorResultado2.Width = 60;
            // 
            // CorResultado3
            // 
            CorResultado3.HeaderText = "3";
            CorResultado3.MinimumWidth = 6;
            CorResultado3.Name = "CorResultado3";
            CorResultado3.ReadOnly = true;
            CorResultado3.SortMode = DataGridViewColumnSortMode.NotSortable;
            CorResultado3.Width = 60;
            // 
            // CorResultado4
            // 
            CorResultado4.HeaderText = "4";
            CorResultado4.MinimumWidth = 6;
            CorResultado4.Name = "CorResultado4";
            CorResultado4.ReadOnly = true;
            CorResultado4.SortMode = DataGridViewColumnSortMode.NotSortable;
            CorResultado4.Width = 60;
            // 
            // CorResultado5
            // 
            CorResultado5.HeaderText = "5";
            CorResultado5.MinimumWidth = 6;
            CorResultado5.Name = "CorResultado5";
            CorResultado5.ReadOnly = true;
            CorResultado5.SortMode = DataGridViewColumnSortMode.NotSortable;
            CorResultado5.Width = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 98);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 3;
            label1.Text = "Jogadas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(445, 98);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 4;
            label2.Text = "Resultados";
            // 
            // SenhaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 444);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvResultados);
            Controls.Add(dgvJogadas);
            Controls.Add(grbJogadas);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SenhaView";
            Text = "Senha";
            grbJogadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvJogadas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Método para configurar as cores dos ColorComboBoxes
        private void ConfigureComboBoxColors()
        {
            List<ColorComboBox> comboBoxes = new List<ColorComboBox>
            {
                cbxCorSelecionada1,
                cbxCorSelecionada2,
                cbxCorSelecionada3,
                cbxCorSelecionada4,
                cbxCorSelecionada5
            };

            foreach (var comboBox in comboBoxes)
            {
                comboBox.Items.AddRange(new object[]
                {
                    "Vermelho", "Verde", "Amarelo", "Azul", "Branco", "Preto", "Rosa", "Cinza"
                });
                comboBox.SetItemBackColor(0, Color.Red);
                comboBox.SetItemBackColor(1, Color.Green);
                comboBox.SetItemBackColor(2, Color.Yellow);
                comboBox.SetItemBackColor(3, Color.Blue);
                comboBox.SetItemBackColor(4, Color.White);
                comboBox.SetItemBackColor(5, Color.Black);
                comboBox.SetItemBackColor(6, Color.Pink);
                comboBox.SetItemBackColor(7, Color.Gray);
            }
        }

        private DataGridViewTextBoxColumn CorJogada1;
        private DataGridViewTextBoxColumn CorJogada2;
        private DataGridViewTextBoxColumn CorJogada3;
        private DataGridViewTextBoxColumn CorJogada4;
        private DataGridViewTextBoxColumn CorJogada5;
        private DataGridViewTextBoxColumn CorResultado1;
        private DataGridViewTextBoxColumn CorResultado2;
        private DataGridViewTextBoxColumn CorResultado3;
        private DataGridViewTextBoxColumn CorResultado4;
        private DataGridViewTextBoxColumn CorResultado5;
    }
}
