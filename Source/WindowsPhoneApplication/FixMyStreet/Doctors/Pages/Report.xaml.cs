using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using FixMyStreet.Classes;
//using Microsoft.Phone.Maps.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace FixMyStreet.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Report : Page
    {
        private List<string> listOfAreas;
        public Report()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Areas areas = new Areas();
            listOfAreas = areas.ArealList();
            autoBox.ItemsSource = listOfAreas;
            
        }

        private void AutoBox_OnTextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.Reason== AutoSuggestionBoxTextChangeReason.UserInput)
            {
                //var enteredText = autoBox.Text?.ToLower();
                var enteredText = "Sector";
                
                //var foundText = listOfAreas.Find(x => x.StartsWith(enteredText));
            }
        }

        private void AutoBox_OnSuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {

            Areas areas = new Areas();
            var ar = args;            
            string selectedIte="";
            LvDetail.ItemsSource = areas.ArealDetailSectorF();
            //if (selectedIte == "Sector F")
            //{
            //    LvDetail.ItemsSource = areas.ArealDetailSectorF();
            //}
            //if (selectedIte == "Sector G")
            //{
            //    LvDetail.ItemsSource = areas.ArealDetailSectorG();
            //}
        }

        private void AreaMap_OnLoaded(object sender, RoutedEventArgs e)
        {
            //Microsoft.Phone.Maps.MapsSettings.ApplicationContext.ApplicationId
        }

        private void LvDetail_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            var item = LvDetail.SelectedItem;
        }
    }
}
