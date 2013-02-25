//===============================================================================
// Microsoft patterns & practices
// Smart Client Software Factory 2010
//===============================================================================
// Copyright (c) Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
//===============================================================================
//----------------------------------------------------------------------------------------
// patterns & practices - Smart Client Software Factory - Guidance Package
//
// This file was generated by the "Add View" recipe.
//
// This class is the concrete implementation of a View in the Model-View-Presenter 
// pattern. Communication between the Presenter and this class is acheived through 
// an interface to facilitate separation and testability.
// Note that the Presenter generated by the same recipe, will automatically be created
// by CAB through [CreateNew] and bidirectional references will be added.
//
// For more information see:
// ms-help://MS.VSCC.v80/MS.VSIPCC.v80/ms.scsf.2006jun/SCSF/html/03-030-Model%20View%20Presenter%20%20MVP%20.htm
//
// Latest version of this Guidance Package: http://go.microsoft.com/fwlink/?LinkId=62182
//----------------------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Windows.Forms;
using GlobalBank.Infrastructure.Interface.BusinessEntities;
using GlobalBank.Infrastructure.UI;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.ObjectBuilder;

namespace GlobalBank.BranchSystems.Module.Views
{
	[SmartPart]
	public partial class OfficerPanelView : UserControl, IOfficerPanelView, ISmartPartInfoProvider
	{
		public OfficerPanelView()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Sets the presenter. The dependency injection system will automatically
		/// create a new presenter for you.
		/// </summary>
		[CreateNew]
		public OfficerPanelViewPresenter Presenter
		{
			set
			{
				_presenter = value;
				_presenter.View = this;
			}
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			_presenter.OnViewReady();
		}

		public ISmartPartInfo GetSmartPartInfo(Type smartPartInfoType)
		{
			return
				new IconSmartPartInfo("", Properties.Resources.MyCustomersQueueViewDescription,
				                      Properties.Resources.MyCustomersQueueViewIcon);
		}

		public void ShowQueue(QueueEntry[] queue)
		{
			_queueBindingSource.DataSource = queue;
		}

		public void SelectServicedCustomer(QueueEntry customer)
		{
			for (int i = 0; i < _queueBindingSource.List.Count; i++)
			{
				QueueEntry entry = _queueBindingSource.List[i] as QueueEntry;
				if (entry.QueueEntryID == customer.QueueEntryID)
				{
					_queueBindingSource.Position = i;
					break;
				}
			}
		}

		private void _officerQueueListBox_DoubleClick(object sender, EventArgs e)
		{
			if (_officerQueueListBox.SelectedItem != null)
				_presenter.ServiceCustomer((QueueEntry) _officerQueueListBox.SelectedItem);
		}

		private void _updateQueueTimer_Tick(object sender, EventArgs e)
		{
			_presenter.UpdateQueue();
		}

		private void _officerQueueListBox_DrawItem(object sender, DrawItemEventArgs e)
		{
			if (e.Index == -1) return;

			e.DrawBackground();
			SolidBrush brush = new SolidBrush(_officerQueueListBox.ForeColor);
			QueueEntry item = _officerQueueListBox.Items[e.Index] as QueueEntry;
			if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
				brush.Color = item.Person is WalkIn ? Color.YellowGreen : SystemColors.HighlightText;
			else
				brush.Color = item.Person is WalkIn ? Color.Green : _officerQueueListBox.ForeColor;
			e.Graphics.DrawString(item.VisitorName, e.Font, brush, e.Bounds, StringFormat.GenericDefault);
			e.DrawFocusRectangle();
		}

		private void _officerQueueListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			NotifySelectionChanged();
		}

		private void NotifySelectionChanged()
		{
			if (_officerQueueListBox.SelectedItem != null)
			{
				_presenter.NewEntrySelected((QueueEntry) _officerQueueListBox.SelectedItem);
			}
		}
	}
}
