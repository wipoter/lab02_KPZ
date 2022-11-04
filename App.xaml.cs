using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using AutoMapper;
using Organizer.Model;
using Organizer.UI.Base;
using Organizer.UI.View;
using Organizer.UI.ViewModels;

namespace Organizer.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private DataModel dataModel;
        private DataViewModel vieawModel;
        private DataModelView dataModelView;

        [Obsolete]
        public App()
        {
            new Mapping().Create();

            dataModel = DataModel.Load();
            vieawModel = Mapper.Map<DataModel, DataViewModel>(dataModel);
            if (vieawModel.Acounts == null)
                vieawModel.Acounts = new ObservableDictionary<AccountViewModel, StudentViewModel>();

            dataModelView = new DataModelView();
            dataModelView.Accounts = vieawModel.Acounts.Keys.ToList();
            dataModelView.Students = vieawModel.Acounts.Values.ToList();
            dataModelView.ObservableDictionary = vieawModel.Acounts;

            var window = new MainWindow() { DataContext = dataModelView };
            window.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            try
            {
                dataModel = Mapper.Map<DataViewModel, DataModel>(vieawModel);
                dataModel.Save();
            }
            catch (Exception)
            {
                base.OnExit(e);
            }
        }
    }
}