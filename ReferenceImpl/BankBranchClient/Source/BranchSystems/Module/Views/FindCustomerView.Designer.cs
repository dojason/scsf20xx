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
	partial class FindCustomerView
	{
		/// <summary>
		/// The presenter used by this view.
		/// </summary>
		private FindCustomerViewPresenter _presenter = null;

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindCustomerView));
			this._firstNameTextBox = new System.Windows.Forms.TextBox();
			this._lastNameTextBox = new System.Windows.Forms.TextBox();
			this._middleInitialTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this._streetTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this._cityTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this._stateTextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this._homeNumberTextBox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this._workNumberTextBox = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this._cellNumberTextBox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this._emailTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this._zipTextBox = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this._ssnTextBox = new System.Windows.Forms.TextBox();
			this._cancelButton = new System.Windows.Forms.Button();
			this._findButton = new System.Windows.Forms.Button();
			this._errorLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// _firstNameTextBox
			// 
			resources.ApplyResources(this._firstNameTextBox, "_firstNameTextBox");
			this._firstNameTextBox.Name = "_firstNameTextBox";
			this._firstNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._firstNameTextBox_KeyPress);
			// 
			// _lastNameTextBox
			// 
			resources.ApplyResources(this._lastNameTextBox, "_lastNameTextBox");
			this._lastNameTextBox.Name = "_lastNameTextBox";
			this._lastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._lastNameTextBox_KeyPress);
			// 
			// _middleInitialTextBox
			// 
			resources.ApplyResources(this._middleInitialTextBox, "_middleInitialTextBox");
			this._middleInitialTextBox.Name = "_middleInitialTextBox";
			this._middleInitialTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._middleInitialTextBox_KeyPress);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// _streetTextBox
			// 
			resources.ApplyResources(this._streetTextBox, "_streetTextBox");
			this._streetTextBox.Name = "_streetTextBox";
			// 
			// label6
			// 
			resources.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			// 
			// _cityTextBox
			// 
			resources.ApplyResources(this._cityTextBox, "_cityTextBox");
			this._cityTextBox.Name = "_cityTextBox";
			this._cityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._cityTextBox_KeyPress);
			// 
			// label7
			// 
			resources.ApplyResources(this.label7, "label7");
			this.label7.Name = "label7";
			// 
			// _stateTextBox
			// 
			resources.ApplyResources(this._stateTextBox, "_stateTextBox");
			this._stateTextBox.Name = "_stateTextBox";
			this._stateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._stateTextBox_KeyPress);
			// 
			// label8
			// 
			resources.ApplyResources(this.label8, "label8");
			this.label8.Name = "label8";
			// 
			// _homeNumberTextBox
			// 
			resources.ApplyResources(this._homeNumberTextBox, "_homeNumberTextBox");
			this._homeNumberTextBox.Name = "_homeNumberTextBox";
			// 
			// label9
			// 
			resources.ApplyResources(this.label9, "label9");
			this.label9.Name = "label9";
			// 
			// _workNumberTextBox
			// 
			resources.ApplyResources(this._workNumberTextBox, "_workNumberTextBox");
			this._workNumberTextBox.Name = "_workNumberTextBox";
			// 
			// label10
			// 
			resources.ApplyResources(this.label10, "label10");
			this.label10.Name = "label10";
			// 
			// _cellNumberTextBox
			// 
			resources.ApplyResources(this._cellNumberTextBox, "_cellNumberTextBox");
			this._cellNumberTextBox.Name = "_cellNumberTextBox";
			// 
			// label11
			// 
			resources.ApplyResources(this.label11, "label11");
			this.label11.Name = "label11";
			// 
			// _emailTextBox
			// 
			resources.ApplyResources(this._emailTextBox, "_emailTextBox");
			this._emailTextBox.Name = "_emailTextBox";
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			// 
			// _zipTextBox
			// 
			resources.ApplyResources(this._zipTextBox, "_zipTextBox");
			this._zipTextBox.Name = "_zipTextBox";
			this._zipTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._zipTextBox_KeyPress);
			// 
			// label12
			// 
			resources.ApplyResources(this.label12, "label12");
			this.label12.Name = "label12";
			// 
			// _ssnTextBox
			// 
			resources.ApplyResources(this._ssnTextBox, "_ssnTextBox");
			this._ssnTextBox.Name = "_ssnTextBox";
			// 
			// _cancelButton
			// 
			this._cancelButton.CausesValidation = false;
			this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			resources.ApplyResources(this._cancelButton, "_cancelButton");
			this._cancelButton.Name = "_cancelButton";
			this._cancelButton.UseVisualStyleBackColor = true;
			this._cancelButton.Click += new System.EventHandler(this._cancelButton_Click);
			// 
			// _findButton
			// 
			resources.ApplyResources(this._findButton, "_findButton");
			this._findButton.Name = "_findButton";
			this._findButton.UseVisualStyleBackColor = true;
			this._findButton.Click += new System.EventHandler(this._findButton_Click);
			// 
			// _errorLabel
			// 
			this._errorLabel.ForeColor = System.Drawing.Color.Red;
			resources.ApplyResources(this._errorLabel, "_errorLabel");
			this._errorLabel.Name = "_errorLabel";
			// 
			// FindCustomerView
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._errorLabel);
			this.Controls.Add(this._findButton);
			this.Controls.Add(this._cancelButton);
			this.Controls.Add(this.label12);
			this.Controls.Add(this._ssnTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this._zipTextBox);
			this.Controls.Add(this.label11);
			this.Controls.Add(this._emailTextBox);
			this.Controls.Add(this.label10);
			this.Controls.Add(this._cellNumberTextBox);
			this.Controls.Add(this.label9);
			this.Controls.Add(this._workNumberTextBox);
			this.Controls.Add(this.label8);
			this.Controls.Add(this._homeNumberTextBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this._stateTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this._cityTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this._streetTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._middleInitialTextBox);
			this.Controls.Add(this._lastNameTextBox);
			this.Controls.Add(this._firstNameTextBox);
			this.Name = "FindCustomerView";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox _firstNameTextBox;
		private System.Windows.Forms.TextBox _lastNameTextBox;
		private System.Windows.Forms.TextBox _middleInitialTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox _streetTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox _cityTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox _stateTextBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox _homeNumberTextBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox _workNumberTextBox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox _cellNumberTextBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox _emailTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox _zipTextBox;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox _ssnTextBox;
		private System.Windows.Forms.Button _cancelButton;
		private System.Windows.Forms.Button _findButton;
		private System.Windows.Forms.Label _errorLabel;
	}
}

