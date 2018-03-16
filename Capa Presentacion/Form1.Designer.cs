﻿namespace Capa_Presentacion
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Bases de Datos");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Login/Group Roles");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("TableSpaces");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Servidor SGDB", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Servidores", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.treeViewSGDB = new System.Windows.Forms.TreeView();
            this.labelNombreDB = new System.Windows.Forms.Label();
            this.tabControlConsultas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgResultadoConsulta = new System.Windows.Forms.DataGridView();
            this.tabControlConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultadoConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewSGDB
            // 
            this.treeViewSGDB.Location = new System.Drawing.Point(2, 4);
            this.treeViewSGDB.Name = "treeViewSGDB";
            treeNode6.Name = "NodoBasesDeDatos";
            treeNode6.Text = "Bases de Datos";
            treeNode7.Name = "NodoLogin";
            treeNode7.Text = "Login/Group Roles";
            treeNode8.Name = "NodoTableSpaces";
            treeNode8.Text = "TableSpaces";
            treeNode9.Name = "NodoNombreServidor";
            treeNode9.Text = "Servidor SGDB";
            treeNode10.Name = "NodoServidor";
            treeNode10.Text = "Servidores";
            this.treeViewSGDB.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.treeViewSGDB.Size = new System.Drawing.Size(213, 501);
            this.treeViewSGDB.TabIndex = 0;
            this.treeViewSGDB.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSGDB_AfterSelect);
            this.treeViewSGDB.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewSGDB_NodeMouseClick);
            // 
            // labelNombreDB
            // 
            this.labelNombreDB.AutoSize = true;
            this.labelNombreDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreDB.Location = new System.Drawing.Point(222, 491);
            this.labelNombreDB.Name = "labelNombreDB";
            this.labelNombreDB.Size = new System.Drawing.Size(0, 16);
            this.labelNombreDB.TabIndex = 1;
            // 
            // tabControlConsultas
            // 
            this.tabControlConsultas.Controls.Add(this.tabPage1);
            this.tabControlConsultas.Location = new System.Drawing.Point(212, 25);
            this.tabControlConsultas.Name = "tabControlConsultas";
            this.tabControlConsultas.SelectedIndex = 0;
            this.tabControlConsultas.Size = new System.Drawing.Size(768, 339);
            this.tabControlConsultas.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(760, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Consulta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgResultadoConsulta
            // 
            this.dtgResultadoConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultadoConsulta.Location = new System.Drawing.Point(216, 366);
            this.dtgResultadoConsulta.Name = "dtgResultadoConsulta";
            this.dtgResultadoConsulta.ReadOnly = true;
            this.dtgResultadoConsulta.Size = new System.Drawing.Size(760, 150);
            this.dtgResultadoConsulta.TabIndex = 4;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 520);
            this.Controls.Add(this.dtgResultadoConsulta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControlConsultas);
            this.Controls.Add(this.labelNombreDB);
            this.Controls.Add(this.treeViewSGDB);
            this.Name = "Principal";
            this.Text = "Principal";
            this.tabControlConsultas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultadoConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewSGDB;
        private System.Windows.Forms.Label labelNombreDB;
        private System.Windows.Forms.TabControl tabControlConsultas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgResultadoConsulta;
    }
}

