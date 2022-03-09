using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CusomMessageBox
{
    /// <summary>
    /// Per utilizzare questo controllo personalizzato in un file XAML, eseguire i passaggi 1a o 1b e 2.
    ///
    /// Passaggio 1a) Utilizzo di questo controllo personalizzato in un file XAML esistente nel progetto corrente.
    /// Aggiungere questo attributo XmlNamespace all'elemento radice del file di markup dove 
    /// deve essere utilizzato:
    ///
    ///     xmlns:MyNamespace="clr-namespace:CusomMessageBox"
    ///
    ///
    /// Passaggio 1b) Utilizzo del controllo personalizzato in un file XAML esistente in un progetto diverso.
    /// Aggiungere questo attributo XmlNamespace all'elemento radice del file di markup dove 
    /// deve essere utilizzato:
    ///
    ///     xmlns:MyNamespace="clr-namespace:CusomMessageBox;assembly=CusomMessageBox"
    ///
    /// Sarà inoltre necessario aggiungere nel progetto in cui si trova il file XAML
    /// un riferimento a questo progetto, quindi ricompilare per evitare errori di compilazione:
    ///
    ///     In Esplora soluzioni, fare clic con il pulsante destro del mouse sul progetto di destinazione, quindi scegliere
    ///     "Aggiungi riferimento"->"Progetti"->[Selezionare questo progetto]
    ///
    ///
    /// Passaggio 2)
    /// Utilizzare il controllo nel file XAML.
    ///
    ///     <MyNamespace:CustomControl1/>
    ///
    /// </summary>
    public sealed class MaterialMessageBox
    {
        internal static MessageBoxResult result;
        public static MessageBoxResult Show(string messageBoxText)
        {
            MMBox myBox = new MMBox();
            myBox.Content.Text= messageBoxText;
            myBox.Title = "MaterialMessageBox";
            myBox.setNoneButtons();
            myBox.ShowDialog();
            return result;
        }
        
        public static MessageBoxResult Show(string messageBoxText, string caption)
        {
            MMBox myBox = new MMBox();
            myBox.Content.Text = messageBoxText;
            myBox.Title = caption;
            myBox.setNoneButtons();
            myBox.ShowDialog();
            return result;
        }

        public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button)
        {
            MMBox myBox = new MMBox();
            myBox.Content.Text = messageBoxText;
            myBox.Title = caption;
            myBox.setButtons(button);
            myBox.ShowDialog();
            return result;
        }

        public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon)
        {
            MMBox myBox = new MMBox();
            myBox.Content.Text = messageBoxText;
            myBox.Title = caption;
            myBox.setButtons(button);
            myBox.setIcon(icon);
            myBox.ShowDialog();
            return result;
        }
        public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult)
        {
            MMBox myBox = new MMBox();
            myBox.Content.Text = messageBoxText;
            myBox.Title = caption;
            myBox.setButtons(button, defaultResult);
            myBox.setIcon(icon);
            myBox.ShowDialog();
            return result;
        }

        //public static MessageBoxResult Show(Window owner, string messageBoxText);
        //public static MessageBoxResult Show(Window owner, string messageBoxText, string caption);
        //public static MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button);
        //public static MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon);
        //public static MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult);
        //public static MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult, MessageBoxOptions options);

    }
}
