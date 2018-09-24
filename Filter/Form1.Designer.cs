namespace SaveJson
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            this.personBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.personBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            birthdayLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingNavigator)).BeginInit();
            this.personBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // personBindingNavigator
            // 
            this.personBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personBindingNavigator.BindingSource = this.personBindingSource;
            this.personBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.personBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.personBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.personBindingNavigatorSaveItem});
            this.personBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.personBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personBindingNavigator.Name = "personBindingNavigator";
            this.personBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personBindingNavigator.Size = new System.Drawing.Size(216, 25);
            this.personBindingNavigator.TabIndex = 0;
            this.personBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
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
            this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 22);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
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
            this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
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
            this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Löschen";
            // 
            // personBindingNavigatorSaveItem
            // 
            this.personBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personBindingNavigatorSaveItem.Enabled = false;
            this.personBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personBindingNavigatorSaveItem.Image")));
            this.personBindingNavigatorSaveItem.Name = "personBindingNavigatorSaveItem";
            this.personBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.personBindingNavigatorSaveItem.Text = "Daten speichern";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(26, 51);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(48, 13);
            birthdayLabel.TabIndex = 1;
            birthdayLabel.Text = "Birthday:";
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Birthday", true));
            this.birthdayTextBox.Location = new System.Drawing.Point(80, 48);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(100, 20);
            this.birthdayTextBox.TabIndex = 2;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(26, 77);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 13);
            genderLabel.TabIndex = 3;
            genderLabel.Text = "Gender:";
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(80, 74);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(100, 20);
            this.genderTextBox.TabIndex = 4;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(26, 103);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 5;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(80, 100);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 6;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(26, 129);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(80, 126);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(SaveJson.Person);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 226);
            this.Controls.Add(this.button1);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.personBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.personBindingNavigator)).EndInit();
            this.personBindingNavigator.ResumeLayout(false);
            this.personBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.BindingNavigator personBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton personBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button button1;
    }
}

