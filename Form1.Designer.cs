namespace Visual_Lab3
{
    partial class Form1
    {
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
            this.numberbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.typebox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.destinationbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ddbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.atbox = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.filter = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.func = new System.Windows.Forms.Button();
            this.apply = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // numberbox
            // 
            this.numberbox.Location = new System.Drawing.Point(97, 12);
            this.numberbox.Name = "numberbox";
            this.numberbox.Size = new System.Drawing.Size(160, 23);
            this.numberbox.TabIndex = 1;
            this.numberbox.TextChanged += new System.EventHandler(this.numberbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type";
            // 
            // typebox
            // 
            this.typebox.Location = new System.Drawing.Point(97, 41);
            this.typebox.Name = "typebox";
            this.typebox.Size = new System.Drawing.Size(160, 23);
            this.typebox.TabIndex = 3;
            this.typebox.TextChanged += new System.EventHandler(this.typebox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Destination";
            // 
            // destinationbox
            // 
            this.destinationbox.Location = new System.Drawing.Point(97, 70);
            this.destinationbox.Name = "destinationbox";
            this.destinationbox.Size = new System.Drawing.Size(160, 23);
            this.destinationbox.TabIndex = 5;
            this.destinationbox.TextChanged += new System.EventHandler(this.destinationbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Arrival date";
            // 
            // adbox
            // 
            this.adbox.Location = new System.Drawing.Point(97, 159);
            this.adbox.Name = "adbox";
            this.adbox.Size = new System.Drawing.Size(160, 23);
            this.adbox.TabIndex = 11;
            this.adbox.TextChanged += new System.EventHandler(this.adbox_TextChanged);
            this.adbox.LostFocus += new System.EventHandler(this.trytoparsedate);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Departure time";
            // 
            // dtbox
            // 
            this.dtbox.Location = new System.Drawing.Point(97, 130);
            this.dtbox.Name = "dtbox";
            this.dtbox.Size = new System.Drawing.Size(160, 23);
            this.dtbox.TabIndex = 9;
            this.dtbox.TextChanged += new System.EventHandler(this.dtbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Departure date";
            // 
            // ddbox
            // 
            this.ddbox.Location = new System.Drawing.Point(97, 101);
            this.ddbox.Name = "ddbox";
            this.ddbox.Size = new System.Drawing.Size(160, 23);
            this.ddbox.TabIndex = 7;
            this.ddbox.TextChanged += new System.EventHandler(this.ddbox_TextChanged);
            this.ddbox.LostFocus += new System.EventHandler(this.trytoparsedate);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Arrival time";
            // 
            // atbox
            // 
            this.atbox.Location = new System.Drawing.Point(97, 188);
            this.atbox.Name = "atbox";
            this.atbox.Size = new System.Drawing.Size(160, 23);
            this.atbox.TabIndex = 13;
            this.atbox.TextChanged += new System.EventHandler(this.atbox_TextChanged);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(182, 413);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 15;
            this.save.Text = "Save File";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(182, 384);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 16;
            this.open.Text = "Open File";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(5, 415);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(108, 23);
            this.add.TabIndex = 17;
            this.add.Text = "Add new";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // filter
            // 
            this.filter.Location = new System.Drawing.Point(5, 260);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(108, 23);
            this.filter.TabIndex = 18;
            this.filter.Text = "Filter";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(5, 318);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(108, 23);
            this.delete.TabIndex = 19;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // func
            // 
            this.func.Location = new System.Drawing.Point(5, 289);
            this.func.Name = "func";
            this.func.Size = new System.Drawing.Size(108, 23);
            this.func.TabIndex = 20;
            this.func.Text = "Function";
            this.func.UseVisualStyleBackColor = true;
            this.func.Click += new System.EventHandler(this.func_Click);
            // 
            // apply
            // 
            this.apply.Location = new System.Drawing.Point(119, 260);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(138, 81);
            this.apply.TabIndex = 21;
            this.apply.Text = "Apply changes";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.AutoArrange = false;
            this.listView1.Location = new System.Drawing.Point(263, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(238, 426);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.func);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.add);
            this.Controls.Add(this.open);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.atbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ddbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.destinationbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox numberbox;
        private Label label1;
        private Label label2;
        private TextBox typebox;
        private Label label3;
        private TextBox destinationbox;
        private Label label4;
        private TextBox adbox;
        private Label label5;
        private TextBox dtbox;
        private Label label6;
        private TextBox ddbox;
        private Label label7;
        private TextBox atbox;
        private Button save;
        private Button open;
        private Button add;
        private Button filter;
        private Button delete;
        private Button func;
        private Button apply;
        private ListView listView1;
    }
}