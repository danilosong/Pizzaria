namespace WindowsFormsApplication4
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
            this.btnpedido = new System.Windows.Forms.Button();
            this.lstresumo = new System.Windows.Forms.ListBox();
            this.cbosabor1 = new System.Windows.Forms.ComboBox();
            this.cbobebida2 = new System.Windows.Forms.ComboBox();
            this.cbobebida3 = new System.Windows.Forms.ComboBox();
            this.cbobebida1 = new System.Windows.Forms.ComboBox();
            this.txtqtd1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbosabor5 = new System.Windows.Forms.ComboBox();
            this.cbosabor4 = new System.Windows.Forms.ComboBox();
            this.cbosabor3 = new System.Windows.Forms.ComboBox();
            this.cbosabor2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtqtd5 = new System.Windows.Forms.TextBox();
            this.txtqtd4 = new System.Windows.Forms.TextBox();
            this.txtqtd3 = new System.Windows.Forms.TextBox();
            this.txtqtd2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtqtdbeb3 = new System.Windows.Forms.TextBox();
            this.txtqtdbeb2 = new System.Windows.Forms.TextBox();
            this.txtqtdbeb1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkrecheextra = new System.Windows.Forms.CheckBox();
            this.chkbordrecheio = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbcredito = new System.Windows.Forms.RadioButton();
            this.rdbdebito = new System.Windows.Forms.RadioButton();
            this.rdbcheque = new System.Windows.Forms.RadioButton();
            this.rdbdinheiro = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.btncalc = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txttotalpagar = new System.Windows.Forms.TextBox();
            this.txtdesconto = new System.Windows.Forms.TextBox();
            this.txttotalpedido = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnpedido
            // 
            this.btnpedido.Location = new System.Drawing.Point(6, 19);
            this.btnpedido.Name = "btnpedido";
            this.btnpedido.Size = new System.Drawing.Size(106, 39);
            this.btnpedido.TabIndex = 0;
            this.btnpedido.Text = "Novo pedido";
            this.btnpedido.UseVisualStyleBackColor = true;
            this.btnpedido.Click += new System.EventHandler(this.btnpedido_Click);
            // 
            // lstresumo
            // 
            this.lstresumo.FormattingEnabled = true;
            this.lstresumo.Location = new System.Drawing.Point(6, 19);
            this.lstresumo.Name = "lstresumo";
            this.lstresumo.Size = new System.Drawing.Size(244, 212);
            this.lstresumo.TabIndex = 1;
            this.lstresumo.SelectedIndexChanged += new System.EventHandler(this.lstresumo_SelectedIndexChanged);
            // 
            // cbosabor1
            // 
            this.cbosabor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosabor1.FormattingEnabled = true;
            this.cbosabor1.Location = new System.Drawing.Point(6, 28);
            this.cbosabor1.Name = "cbosabor1";
            this.cbosabor1.Size = new System.Drawing.Size(121, 21);
            this.cbosabor1.TabIndex = 2;
            this.cbosabor1.SelectedIndexChanged += new System.EventHandler(this.cbosabor1_SelectedIndexChanged_1);
            // 
            // cbobebida2
            // 
            this.cbobebida2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobebida2.FormattingEnabled = true;
            this.cbobebida2.Location = new System.Drawing.Point(5, 57);
            this.cbobebida2.Name = "cbobebida2";
            this.cbobebida2.Size = new System.Drawing.Size(121, 21);
            this.cbobebida2.TabIndex = 2;
            // 
            // cbobebida3
            // 
            this.cbobebida3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobebida3.FormattingEnabled = true;
            this.cbobebida3.Location = new System.Drawing.Point(5, 84);
            this.cbobebida3.Name = "cbobebida3";
            this.cbobebida3.Size = new System.Drawing.Size(121, 21);
            this.cbobebida3.TabIndex = 2;
            // 
            // cbobebida1
            // 
            this.cbobebida1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobebida1.FormattingEnabled = true;
            this.cbobebida1.Location = new System.Drawing.Point(5, 29);
            this.cbobebida1.Name = "cbobebida1";
            this.cbobebida1.Size = new System.Drawing.Size(121, 21);
            this.cbobebida1.TabIndex = 2;
            // 
            // txtqtd1
            // 
            this.txtqtd1.Location = new System.Drawing.Point(133, 29);
            this.txtqtd1.Name = "txtqtd1";
            this.txtqtd1.Size = new System.Drawing.Size(59, 20);
            this.txtqtd1.TabIndex = 3;
            this.txtqtd1.Text = "0";
            this.txtqtd1.TextChanged += new System.EventHandler(this.txtqtd1_TextChanged_1);
            this.txtqtd1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqtd1_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbosabor5);
            this.groupBox1.Controls.Add(this.cbosabor4);
            this.groupBox1.Controls.Add(this.cbosabor3);
            this.groupBox1.Controls.Add(this.cbosabor2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbosabor1);
            this.groupBox1.Controls.Add(this.txtqtd5);
            this.groupBox1.Controls.Add(this.txtqtd4);
            this.groupBox1.Controls.Add(this.txtqtd3);
            this.groupBox1.Controls.Add(this.txtqtd2);
            this.groupBox1.Controls.Add(this.txtqtd1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 174);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbosabor5
            // 
            this.cbosabor5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosabor5.FormattingEnabled = true;
            this.cbosabor5.Location = new System.Drawing.Point(6, 136);
            this.cbosabor5.Name = "cbosabor5";
            this.cbosabor5.Size = new System.Drawing.Size(121, 21);
            this.cbosabor5.TabIndex = 6;
            // 
            // cbosabor4
            // 
            this.cbosabor4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosabor4.FormattingEnabled = true;
            this.cbosabor4.Location = new System.Drawing.Point(6, 111);
            this.cbosabor4.Name = "cbosabor4";
            this.cbosabor4.Size = new System.Drawing.Size(121, 21);
            this.cbosabor4.TabIndex = 6;
            // 
            // cbosabor3
            // 
            this.cbosabor3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosabor3.FormattingEnabled = true;
            this.cbosabor3.Location = new System.Drawing.Point(6, 84);
            this.cbosabor3.Name = "cbosabor3";
            this.cbosabor3.Size = new System.Drawing.Size(121, 21);
            this.cbosabor3.TabIndex = 6;
            // 
            // cbosabor2
            // 
            this.cbosabor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosabor2.FormattingEnabled = true;
            this.cbosabor2.Location = new System.Drawing.Point(6, 56);
            this.cbosabor2.Name = "cbosabor2";
            this.cbosabor2.Size = new System.Drawing.Size(121, 21);
            this.cbosabor2.TabIndex = 6;
            this.cbosabor2.SelectedIndexChanged += new System.EventHandler(this.cbosabor2_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sabor";
            // 
            // txtqtd5
            // 
            this.txtqtd5.Location = new System.Drawing.Point(133, 137);
            this.txtqtd5.Name = "txtqtd5";
            this.txtqtd5.Size = new System.Drawing.Size(59, 20);
            this.txtqtd5.TabIndex = 3;
            this.txtqtd5.Text = "0";
            this.txtqtd5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqtd5_KeyPress);
            // 
            // txtqtd4
            // 
            this.txtqtd4.Location = new System.Drawing.Point(133, 110);
            this.txtqtd4.Name = "txtqtd4";
            this.txtqtd4.Size = new System.Drawing.Size(59, 20);
            this.txtqtd4.TabIndex = 3;
            this.txtqtd4.Text = "0";
            this.txtqtd4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqtd4_KeyPress);
            // 
            // txtqtd3
            // 
            this.txtqtd3.Location = new System.Drawing.Point(133, 83);
            this.txtqtd3.Name = "txtqtd3";
            this.txtqtd3.Size = new System.Drawing.Size(59, 20);
            this.txtqtd3.TabIndex = 3;
            this.txtqtd3.Text = "0";
            this.txtqtd3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqtd3_KeyPress);
            // 
            // txtqtd2
            // 
            this.txtqtd2.Location = new System.Drawing.Point(133, 57);
            this.txtqtd2.Name = "txtqtd2";
            this.txtqtd2.Size = new System.Drawing.Size(59, 20);
            this.txtqtd2.TabIndex = 3;
            this.txtqtd2.Text = "0";
            this.txtqtd2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqtd2_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbobebida1);
            this.groupBox2.Controls.Add(this.cbobebida2);
            this.groupBox2.Controls.Add(this.cbobebida3);
            this.groupBox2.Controls.Add(this.txtqtdbeb3);
            this.groupBox2.Controls.Add(this.txtqtdbeb2);
            this.groupBox2.Controls.Add(this.txtqtdbeb1);
            this.groupBox2.Location = new System.Drawing.Point(234, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 118);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bebida";
            // 
            // txtqtdbeb3
            // 
            this.txtqtdbeb3.Location = new System.Drawing.Point(132, 84);
            this.txtqtdbeb3.Name = "txtqtdbeb3";
            this.txtqtdbeb3.Size = new System.Drawing.Size(59, 20);
            this.txtqtdbeb3.TabIndex = 3;
            this.txtqtdbeb3.Text = "0";
            this.txtqtdbeb3.TextChanged += new System.EventHandler(this.txtqtdbeb3_TextChanged);
            this.txtqtdbeb3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqtdbeb3_KeyPress);
            // 
            // txtqtdbeb2
            // 
            this.txtqtdbeb2.Location = new System.Drawing.Point(132, 58);
            this.txtqtdbeb2.Name = "txtqtdbeb2";
            this.txtqtdbeb2.Size = new System.Drawing.Size(59, 20);
            this.txtqtdbeb2.TabIndex = 3;
            this.txtqtdbeb2.Text = "0";
            this.txtqtdbeb2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqtdbeb2_KeyPress);
            // 
            // txtqtdbeb1
            // 
            this.txtqtdbeb1.Location = new System.Drawing.Point(132, 30);
            this.txtqtdbeb1.Name = "txtqtdbeb1";
            this.txtqtdbeb1.Size = new System.Drawing.Size(59, 20);
            this.txtqtdbeb1.TabIndex = 3;
            this.txtqtdbeb1.Text = "0";
            this.txtqtdbeb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqtdbeb1_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkrecheextra);
            this.groupBox3.Controls.Add(this.chkbordrecheio);
            this.groupBox3.Location = new System.Drawing.Point(234, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 57);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // chkrecheextra
            // 
            this.chkrecheextra.AutoSize = true;
            this.chkrecheextra.Location = new System.Drawing.Point(107, 23);
            this.chkrecheextra.Name = "chkrecheextra";
            this.chkrecheextra.Size = new System.Drawing.Size(92, 17);
            this.chkrecheextra.TabIndex = 0;
            this.chkrecheextra.Text = "Recheio extra";
            this.chkrecheextra.UseVisualStyleBackColor = true;
            // 
            // chkbordrecheio
            // 
            this.chkbordrecheio.AutoSize = true;
            this.chkbordrecheio.Location = new System.Drawing.Point(4, 23);
            this.chkbordrecheio.Name = "chkbordrecheio";
            this.chkbordrecheio.Size = new System.Drawing.Size(102, 17);
            this.chkbordrecheio.TabIndex = 0;
            this.chkbordrecheio.Text = "Borda recheada";
            this.chkbordrecheio.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbcredito);
            this.groupBox4.Controls.Add(this.rdbdebito);
            this.groupBox4.Controls.Add(this.rdbcheque);
            this.groupBox4.Controls.Add(this.rdbdinheiro);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(12, 192);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(422, 65);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // rdbcredito
            // 
            this.rdbcredito.AutoSize = true;
            this.rdbcredito.Location = new System.Drawing.Point(313, 38);
            this.rdbcredito.Name = "rdbcredito";
            this.rdbcredito.Size = new System.Drawing.Size(105, 17);
            this.rdbcredito.TabIndex = 1;
            this.rdbcredito.TabStop = true;
            this.rdbcredito.Text = "cartão de crédito";
            this.rdbcredito.UseVisualStyleBackColor = true;
            // 
            // rdbdebito
            // 
            this.rdbdebito.AutoSize = true;
            this.rdbdebito.Location = new System.Drawing.Point(191, 38);
            this.rdbdebito.Name = "rdbdebito";
            this.rdbdebito.Size = new System.Drawing.Size(103, 17);
            this.rdbdebito.TabIndex = 1;
            this.rdbdebito.TabStop = true;
            this.rdbdebito.Text = "Cartão de débito";
            this.rdbdebito.UseVisualStyleBackColor = true;
            // 
            // rdbcheque
            // 
            this.rdbcheque.AutoSize = true;
            this.rdbcheque.Location = new System.Drawing.Point(99, 38);
            this.rdbcheque.Name = "rdbcheque";
            this.rdbcheque.Size = new System.Drawing.Size(62, 17);
            this.rdbcheque.TabIndex = 1;
            this.rdbcheque.TabStop = true;
            this.rdbcheque.Text = "Cheque";
            this.rdbcheque.UseVisualStyleBackColor = true;
            // 
            // rdbdinheiro
            // 
            this.rdbdinheiro.AutoSize = true;
            this.rdbdinheiro.Location = new System.Drawing.Point(7, 38);
            this.rdbdinheiro.Name = "rdbdinheiro";
            this.rdbdinheiro.Size = new System.Drawing.Size(64, 17);
            this.rdbdinheiro.TabIndex = 1;
            this.rdbdinheiro.TabStop = true;
            this.rdbdinheiro.Text = "Dinheiro";
            this.rdbdinheiro.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Forma de pagamento";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnsair);
            this.groupBox5.Controls.Add(this.btncalc);
            this.groupBox5.Controls.Add(this.btnpedido);
            this.groupBox5.Location = new System.Drawing.Point(13, 259);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(417, 73);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(305, 19);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(106, 39);
            this.btnsair.TabIndex = 0;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(152, 19);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(106, 39);
            this.btncalc.TabIndex = 0;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.txttotalpagar);
            this.groupBox6.Controls.Add(this.txtdesconto);
            this.groupBox6.Controls.Add(this.txttotalpedido);
            this.groupBox6.Controls.Add(this.lstresumo);
            this.groupBox6.Location = new System.Drawing.Point(451, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(256, 320);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Resumo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Total a pagar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Desconto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Total do pedido:";
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.Location = new System.Drawing.Point(150, 294);
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.Size = new System.Drawing.Size(100, 20);
            this.txttotalpagar.TabIndex = 2;
            this.txttotalpagar.TextChanged += new System.EventHandler(this.txttotalpagar_TextChanged);
            // 
            // txtdesconto
            // 
            this.txtdesconto.Location = new System.Drawing.Point(150, 269);
            this.txtdesconto.Name = "txtdesconto";
            this.txtdesconto.Size = new System.Drawing.Size(100, 20);
            this.txtdesconto.TabIndex = 2;
            this.txtdesconto.TextChanged += new System.EventHandler(this.txtdesconto_TextChanged);
            // 
            // txttotalpedido
            // 
            this.txttotalpedido.Location = new System.Drawing.Point(150, 243);
            this.txttotalpedido.Name = "txttotalpedido";
            this.txttotalpedido.ReadOnly = true;
            this.txttotalpedido.Size = new System.Drawing.Size(100, 20);
            this.txttotalpedido.TabIndex = 2;
            this.txttotalpedido.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 495);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "pizzaria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpedido;
        private System.Windows.Forms.ListBox lstresumo;
        private System.Windows.Forms.ComboBox cbosabor1;
        private System.Windows.Forms.ComboBox cbobebida2;
        private System.Windows.Forms.ComboBox cbobebida3;
        private System.Windows.Forms.ComboBox cbobebida1;
        private System.Windows.Forms.TextBox txtqtd1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtqtd5;
        private System.Windows.Forms.TextBox txtqtd4;
        private System.Windows.Forms.TextBox txtqtd3;
        private System.Windows.Forms.TextBox txtqtd2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtqtdbeb3;
        private System.Windows.Forms.TextBox txtqtdbeb2;
        private System.Windows.Forms.TextBox txtqtdbeb1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkrecheextra;
        private System.Windows.Forms.CheckBox chkbordrecheio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdbcredito;
        private System.Windows.Forms.RadioButton rdbdebito;
        private System.Windows.Forms.RadioButton rdbcheque;
        private System.Windows.Forms.RadioButton rdbdinheiro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtdesconto;
        private System.Windows.Forms.TextBox txttotalpedido;
        private System.Windows.Forms.TextBox txttotalpagar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbosabor5;
        private System.Windows.Forms.ComboBox cbosabor4;
        private System.Windows.Forms.ComboBox cbosabor3;
        private System.Windows.Forms.ComboBox cbosabor2;
    }
}

