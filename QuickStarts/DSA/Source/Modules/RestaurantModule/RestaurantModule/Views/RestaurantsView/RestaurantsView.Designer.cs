
//----------------------------------------------------------------------------------------
// patterns & practices - Smart Client Software Factory - Guidance Package
//
// This file was generated by the "Add View" recipe.
//
// For more information see: 
// ms-help://MS.VSCC.v90/MS.VSIPCC.v90/ms.practices.scsf.2008apr/SCSF/html/02-09-010-ModelViewPresenter_MVP.htm
//
// Latest version of this Guidance Package: http://go.microsoft.com/fwlink/?LinkId=62182
//----------------------------------------------------------------------------------------

namespace QuickStart.RestaurantModule
{
    partial class RestaurantsView
    {
        /// <summary>
        /// The presenter used by this view.
        /// </summary>
        private QuickStart.RestaurantModule.RestaurantsViewPresenter _presenter = null;

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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Restaurants", System.Windows.Forms.HorizontalAlignment.Left);
            this._restaurantsListView = new System.Windows.Forms.ListView();
            this._offlineLabel = new System.Windows.Forms.Label();
            this._errorLabel = new System.Windows.Forms.Label();
            this._retryLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // _restaurantsListView
            // 
            this._restaurantsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._restaurantsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._restaurantsListView.FullRowSelect = true;
            listViewGroup1.Header = "Restaurants";
            listViewGroup1.Name = "restaurantsGroup";
            this._restaurantsListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this._restaurantsListView.HideSelection = false;
            this._restaurantsListView.Location = new System.Drawing.Point(0, 0);
            this._restaurantsListView.MultiSelect = false;
            this._restaurantsListView.Name = "_restaurantsListView";
            this._restaurantsListView.Size = new System.Drawing.Size(146, 242);
            this._restaurantsListView.TabIndex = 1;
            this._restaurantsListView.TileSize = new System.Drawing.Size(168, 20);
            this._restaurantsListView.UseCompatibleStateImageBehavior = false;
            this._restaurantsListView.View = System.Windows.Forms.View.Tile;
            this._restaurantsListView.SelectedIndexChanged += new System.EventHandler(this._restaurantsListView_SelectedIndexChanged);
            // 
            // _offlineLabel
            // 
            this._offlineLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._offlineLabel.Location = new System.Drawing.Point(0, 149);
            this._offlineLabel.Name = "_offlineLabel";
            this._offlineLabel.Padding = new System.Windows.Forms.Padding(10);
            this._offlineLabel.Size = new System.Drawing.Size(146, 77);
            this._offlineLabel.TabIndex = 2;
            this._offlineLabel.Text = "You are working in offline mode. The restaurants list will be loaded when a conne" +
                "ction is detected.";
            this._offlineLabel.Visible = false;
            // 
            // _errorLabel
            // 
            this._errorLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._errorLabel.Location = new System.Drawing.Point(0, 0);
            this._errorLabel.Name = "_errorLabel";
            this._errorLabel.Padding = new System.Windows.Forms.Padding(10);
            this._errorLabel.Size = new System.Drawing.Size(146, 149);
            this._errorLabel.TabIndex = 3;
            this._errorLabel.Text = "There has been an error contacting the back-end service.";
            this._errorLabel.Visible = false;
            // 
            // _retryLabel
            // 
            this._retryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._retryLabel.Location = new System.Drawing.Point(0, 226);
            this._retryLabel.Name = "_retryLabel";
            this._retryLabel.Size = new System.Drawing.Size(143, 20);
            this._retryLabel.TabIndex = 4;
            this._retryLabel.TabStop = true;
            this._retryLabel.Text = "Click here to Retry.";
            this._retryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._retryLabel.Visible = false;
            this._retryLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._retryLabel_LinkClicked);
            // 
            // RestaurantsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this._offlineLabel);
            this.Controls.Add(this._retryLabel);
            this.Controls.Add(this._errorLabel);
            this.Controls.Add(this._restaurantsListView);
            this.Name = "RestaurantsView";
            this.Size = new System.Drawing.Size(146, 242);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView _restaurantsListView;
        private System.Windows.Forms.Label _offlineLabel;
        private System.Windows.Forms.Label _errorLabel;
        private System.Windows.Forms.LinkLabel _retryLabel;
    }
}

