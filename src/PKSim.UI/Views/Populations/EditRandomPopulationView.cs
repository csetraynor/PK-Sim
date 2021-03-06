﻿using OSPSuite.Assets;
using DevExpress.XtraTab;

using PKSim.Presentation.Presenters.Populations;

using PKSim.Presentation.Views.Populations;
using OSPSuite.Presentation;
using OSPSuite.UI.Views;

namespace PKSim.UI.Views.Populations
{
   public partial class EditRandomPopulationView : BaseMdiChildTabbedView, IEditRandomPopulationView
   {
      public EditRandomPopulationView(Shell shell) : base(shell)
      {
         InitializeComponent();
      }

      public void AttachPresenter(IEditRandomPopulationPresenter presenter)
      {
         _presenter = presenter;
      }

      public override ApplicationIcon ApplicationIcon
      {
         get { return ApplicationIcons.Population; }
      }

      public override XtraTabControl TabControl
      {
         get { return tabEditPopulation; }
      }

      protected override int TopicId => HelpId.PKSim_Population;
   }
}