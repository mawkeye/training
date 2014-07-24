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

// Die Elementvorlage "Leere Seite" ist unter http://go.microsoft.com/fwlink/?LinkId=391641 dokumentiert.

namespace TipCalculator
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet werden kann oder auf die innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private TipClass Tip;

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

            Tip = new TipClass();
            
        }

        /// <summary>
        /// Wird aufgerufen, wenn diese Seite in einem Rahmen angezeigt werden soll.
        /// </summary>
        /// <param name="e">Ereignisdaten, die beschreiben, wie diese Seite erreicht wurde.
        /// Dieser Parameter wird normalerweise zum Konfigurieren der Seite verwendet.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Seite vorbereiten, um sie hier anzuzeigen.

            // TODO: Wenn Ihre Anwendung mehrere Seiten enthält, stellen Sie sicher, dass
            // die Hardware-Zurück-Taste behandelt wird, indem Sie das
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed-Ereignis registrieren.
            // Wenn Sie den NavigationHelper verwenden, der bei einigen Vorlagen zur Verfügung steht,
            // wird dieses Ereignis für Sie behandelt.
        }

        private void BillAmountTextBox_OnLostFocus(object sender, RoutedEventArgs e)
        {
            BillAmountTextBox.Text = Tip.BillAmount;
            //throw new NotImplementedException();
        }

        private void BillAmountTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            //TODO FIX THIS!!

            performCalculation();
            //throw new NotImplementedException();
        }

        private void BillAmountTextBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            BillAmountTextBox.Text = "";
            //throw new NotImplementedException();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            performCalculation();
            //throw new NotImplementedException();
        }

        private void performCalculation()
        {
            var selectedRadio = MyStackPanel.Children.OfType<RadioButton>().FirstOrDefault(r => r.IsChecked == true);

            Tip.CalculateTip(BillAmountTextBox.Text, double.Parse(selectedRadio.Tag.ToString()));

            AmountToTipTextBlock.Text = Tip.TipAmount;
            TotalTextBlock.Text = Tip.TotalAmount;
        }
    }
}
