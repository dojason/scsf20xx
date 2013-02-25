//----------------------------------------------------------------------------------------
// patterns & practices - Smart Client Software Factory - Guidance Package
//
// This file was generated by the "Add View" recipe.
//
// For more information see: 
// ms-help://MS.VSCC.v80/MS.VSIPCC.v80/ms.scsf.2006jun/SCSF/html/03-030-Model%20View%20Presenter%20%20MVP%20.htm
//
// Latest version of this Guidance Package: http://go.microsoft.com/fwlink/?LinkId=62182
//----------------------------------------------------------------------------------------

namespace GlobalBank.BranchSystems.Module.Views
{
	partial class CustomerSummaryView
	{
		/// <summary>
		/// The presenter used by this view.
		/// </summary>
		private CustomerSummaryViewPresenter _presenter = null;

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
			if (disposing)
			{
				if (_presenter != null)
					_presenter.Dispose();

				if (components != null)
					components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerSummaryView));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this._creditCardDataGridView = new System.Windows.Forms.DataGridView();
			this.CreditCardTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.creditCardNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paymentDueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.availableBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._creditCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this._accountDataGridView = new System.Windows.Forms.DataGridView();
			this.AccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.accountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label12 = new System.Windows.Forms.Label();
			this._ssnTextBox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this._emailTextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this._homeNumberTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this._addressTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this._nameTextBox = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this._statusTextBox = new System.Windows.Forms.TextBox();
			this._reasonCodeTextBox = new System.Windows.Forms.TextBox();
			this._descriptionTextBox = new System.Windows.Forms.TextBox();
			this._timeInTextBox = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this._alertDataGridView = new System.Windows.Forms.DataGridView();
			this.alertTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.expirationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._alertBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this._serviceCompletedButton = new System.Windows.Forms.Button();
			this.groupBox3.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._creditCardDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._creditCardBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._accountDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._accountBindingSource)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._alertDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._alertBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.tableLayoutPanel2);
			resources.ApplyResources(this.groupBox3, "groupBox3");
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.TabStop = false;
			// 
			// tableLayoutPanel2
			// 
			resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
			this.tableLayoutPanel2.Controls.Add(this._creditCardDataGridView, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this._accountDataGridView, 0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			// 
			// _creditCardDataGridView
			// 
			this._creditCardDataGridView.AllowUserToAddRows = false;
			this._creditCardDataGridView.AllowUserToDeleteRows = false;
			this._creditCardDataGridView.AutoGenerateColumns = false;
			this._creditCardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._creditCardDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CreditCardTypeName,
            this.creditCardNumberDataGridViewTextBoxColumn,
            this.paymentDueDataGridViewTextBoxColumn,
            this.availableBalanceDataGridViewTextBoxColumn});
			this._creditCardDataGridView.DataSource = this._creditCardBindingSource;
			resources.ApplyResources(this._creditCardDataGridView, "_creditCardDataGridView");
			this._creditCardDataGridView.Name = "_creditCardDataGridView";
			this._creditCardDataGridView.ReadOnly = true;
			this._creditCardDataGridView.RowHeadersVisible = false;
			this._creditCardDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._creditCardDataGridView_CellDoubleClick);
			// 
			// CreditCardTypeName
			// 
			this.CreditCardTypeName.DataPropertyName = "CreditCardTypeName";
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.CreditCardTypeName.DefaultCellStyle = dataGridViewCellStyle1;
			resources.ApplyResources(this.CreditCardTypeName, "CreditCardTypeName");
			this.CreditCardTypeName.Name = "CreditCardTypeName";
			this.CreditCardTypeName.ReadOnly = true;
			// 
			// creditCardNumberDataGridViewTextBoxColumn
			// 
			this.creditCardNumberDataGridViewTextBoxColumn.DataPropertyName = "CreditCardNumber";
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.creditCardNumberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
			resources.ApplyResources(this.creditCardNumberDataGridViewTextBoxColumn, "creditCardNumberDataGridViewTextBoxColumn");
			this.creditCardNumberDataGridViewTextBoxColumn.Name = "creditCardNumberDataGridViewTextBoxColumn";
			this.creditCardNumberDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// paymentDueDataGridViewTextBoxColumn
			// 
			this.paymentDueDataGridViewTextBoxColumn.DataPropertyName = "PaymentDue";
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.paymentDueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
			resources.ApplyResources(this.paymentDueDataGridViewTextBoxColumn, "paymentDueDataGridViewTextBoxColumn");
			this.paymentDueDataGridViewTextBoxColumn.Name = "paymentDueDataGridViewTextBoxColumn";
			this.paymentDueDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// availableBalanceDataGridViewTextBoxColumn
			// 
			this.availableBalanceDataGridViewTextBoxColumn.DataPropertyName = "AvailableBalance";
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.availableBalanceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
			resources.ApplyResources(this.availableBalanceDataGridViewTextBoxColumn, "availableBalanceDataGridViewTextBoxColumn");
			this.availableBalanceDataGridViewTextBoxColumn.Name = "availableBalanceDataGridViewTextBoxColumn";
			this.availableBalanceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// _creditCardBindingSource
			// 
			this._creditCardBindingSource.DataSource = typeof(GlobalBank.Infrastructure.Interface.BusinessEntities.CreditCard);
			// 
			// _accountDataGridView
			// 
			this._accountDataGridView.AllowUserToAddRows = false;
			this._accountDataGridView.AllowUserToDeleteRows = false;
			this._accountDataGridView.AllowUserToOrderColumns = true;
			this._accountDataGridView.AutoGenerateColumns = false;
			this._accountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._accountDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountType,
            this.accountNumberDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn});
			this._accountDataGridView.DataSource = this._accountBindingSource;
			resources.ApplyResources(this._accountDataGridView, "_accountDataGridView");
			this._accountDataGridView.Name = "_accountDataGridView";
			this._accountDataGridView.ReadOnly = true;
			this._accountDataGridView.RowHeadersVisible = false;
			// 
			// AccountType
			// 
			this.AccountType.DataPropertyName = "AccountType";
			resources.ApplyResources(this.AccountType, "AccountType");
			this.AccountType.Name = "AccountType";
			this.AccountType.ReadOnly = true;
			// 
			// accountNumberDataGridViewTextBoxColumn
			// 
			this.accountNumberDataGridViewTextBoxColumn.DataPropertyName = "AccountNumber";
			resources.ApplyResources(this.accountNumberDataGridViewTextBoxColumn, "accountNumberDataGridViewTextBoxColumn");
			this.accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
			this.accountNumberDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// balanceDataGridViewTextBoxColumn
			// 
			this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
			resources.ApplyResources(this.balanceDataGridViewTextBoxColumn, "balanceDataGridViewTextBoxColumn");
			this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
			this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// _accountBindingSource
			// 
			this._accountBindingSource.DataSource = typeof(GlobalBank.Infrastructure.Interface.BusinessEntities.Account);
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this._ssnTextBox);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this._emailTextBox);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this._homeNumberTextBox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this._addressTextBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this._nameTextBox);
			resources.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			// 
			// label12
			// 
			resources.ApplyResources(this.label12, "label12");
			this.label12.Name = "label12";
			// 
			// _ssnTextBox
			// 
			resources.ApplyResources(this._ssnTextBox, "_ssnTextBox");
			this._ssnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._ssnTextBox.Name = "_ssnTextBox";
			this._ssnTextBox.ReadOnly = true;
			// 
			// label11
			// 
			resources.ApplyResources(this.label11, "label11");
			this.label11.Name = "label11";
			// 
			// _emailTextBox
			// 
			resources.ApplyResources(this._emailTextBox, "_emailTextBox");
			this._emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._emailTextBox.Name = "_emailTextBox";
			this._emailTextBox.ReadOnly = true;
			// 
			// label8
			// 
			resources.ApplyResources(this.label8, "label8");
			this.label8.Name = "label8";
			// 
			// _homeNumberTextBox
			// 
			resources.ApplyResources(this._homeNumberTextBox, "_homeNumberTextBox");
			this._homeNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._homeNumberTextBox.Name = "_homeNumberTextBox";
			this._homeNumberTextBox.ReadOnly = true;
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// _addressTextBox
			// 
			resources.ApplyResources(this._addressTextBox, "_addressTextBox");
			this._addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._addressTextBox.Name = "_addressTextBox";
			this._addressTextBox.ReadOnly = true;
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// _nameTextBox
			// 
			resources.ApplyResources(this._nameTextBox, "_nameTextBox");
			this._nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._nameTextBox.Name = "_nameTextBox";
			this._nameTextBox.ReadOnly = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Controls.Add(this._statusTextBox);
			this.groupBox4.Controls.Add(this._reasonCodeTextBox);
			this.groupBox4.Controls.Add(this._descriptionTextBox);
			this.groupBox4.Controls.Add(this._timeInTextBox);
			resources.ApplyResources(this.groupBox4, "groupBox4");
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.TabStop = false;
			// 
			// label6
			// 
			resources.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// _statusTextBox
			// 
			resources.ApplyResources(this._statusTextBox, "_statusTextBox");
			this._statusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._statusTextBox.Name = "_statusTextBox";
			this._statusTextBox.ReadOnly = true;
			// 
			// _reasonCodeTextBox
			// 
			resources.ApplyResources(this._reasonCodeTextBox, "_reasonCodeTextBox");
			this._reasonCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._reasonCodeTextBox.Name = "_reasonCodeTextBox";
			this._reasonCodeTextBox.ReadOnly = true;
			// 
			// _descriptionTextBox
			// 
			resources.ApplyResources(this._descriptionTextBox, "_descriptionTextBox");
			this._descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._descriptionTextBox.Name = "_descriptionTextBox";
			this._descriptionTextBox.ReadOnly = true;
			// 
			// _timeInTextBox
			// 
			resources.ApplyResources(this._timeInTextBox, "_timeInTextBox");
			this._timeInTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._timeInTextBox.Name = "_timeInTextBox";
			this._timeInTextBox.ReadOnly = true;
			// 
			// groupBox2
			// 
			resources.ApplyResources(this.groupBox2, "groupBox2");
			this.groupBox2.Controls.Add(this._alertDataGridView);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.TabStop = false;
			// 
			// _alertDataGridView
			// 
			this._alertDataGridView.AllowUserToAddRows = false;
			this._alertDataGridView.AllowUserToDeleteRows = false;
			this._alertDataGridView.AutoGenerateColumns = false;
			this._alertDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this._alertDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._alertDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alertTypeDataGridViewTextBoxColumn,
            this.expirationDateDataGridViewTextBoxColumn});
			this._alertDataGridView.DataSource = this._alertBindingSource;
			resources.ApplyResources(this._alertDataGridView, "_alertDataGridView");
			this._alertDataGridView.Name = "_alertDataGridView";
			this._alertDataGridView.ReadOnly = true;
			this._alertDataGridView.RowHeadersVisible = false;
			// 
			// alertTypeDataGridViewTextBoxColumn
			// 
			this.alertTypeDataGridViewTextBoxColumn.DataPropertyName = "AlertType";
			this.alertTypeDataGridViewTextBoxColumn.FillWeight = 30F;
			resources.ApplyResources(this.alertTypeDataGridViewTextBoxColumn, "alertTypeDataGridViewTextBoxColumn");
			this.alertTypeDataGridViewTextBoxColumn.Name = "alertTypeDataGridViewTextBoxColumn";
			this.alertTypeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// expirationDateDataGridViewTextBoxColumn
			// 
			this.expirationDateDataGridViewTextBoxColumn.DataPropertyName = "ExpirationDate";
			this.expirationDateDataGridViewTextBoxColumn.FillWeight = 30F;
			resources.ApplyResources(this.expirationDateDataGridViewTextBoxColumn, "expirationDateDataGridViewTextBoxColumn");
			this.expirationDateDataGridViewTextBoxColumn.Name = "expirationDateDataGridViewTextBoxColumn";
			this.expirationDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// _alertBindingSource
			// 
			this._alertBindingSource.DataSource = typeof(GlobalBank.Infrastructure.Interface.BusinessEntities.Alert);
			// 
			// _serviceCompletedButton
			// 
			resources.ApplyResources(this._serviceCompletedButton, "_serviceCompletedButton");
			this._serviceCompletedButton.Name = "_serviceCompletedButton";
			this._serviceCompletedButton.UseVisualStyleBackColor = true;
			this._serviceCompletedButton.Click += new System.EventHandler(this._serviceCompletedButton_Click);
			// 
			// CustomerSummaryView
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this._serviceCompletedButton);
			this.Name = "CustomerSummaryView";
			this.groupBox3.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._creditCardDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._creditCardBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._accountDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._accountBindingSource)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._alertDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._alertBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox _ssnTextBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox _emailTextBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox _homeNumberTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox _addressTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox _nameTextBox;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox _statusTextBox;
		private System.Windows.Forms.TextBox _reasonCodeTextBox;
		private System.Windows.Forms.TextBox _descriptionTextBox;
		private System.Windows.Forms.TextBox _timeInTextBox;
		private System.Windows.Forms.DataGridView _accountDataGridView;
		private System.Windows.Forms.DataGridView _alertDataGridView;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.DataGridView _creditCardDataGridView;
		private System.Windows.Forms.BindingSource _creditCardBindingSource;
		private System.Windows.Forms.BindingSource _accountBindingSource;
		private System.Windows.Forms.BindingSource _alertBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn alertTypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button _serviceCompletedButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn CreditCardTypeName;
		private System.Windows.Forms.DataGridViewTextBoxColumn creditCardNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn paymentDueDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn availableBalanceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn AccountType;
		private System.Windows.Forms.DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;

	}
}
