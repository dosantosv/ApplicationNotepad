using Microsoft.Win32;
using System.IO;
using System.Windows;
namespace ApplicationNotepad
{
    /// <summary>
    /// Interaction logic for NotepadView.xaml
    /// </summary>
    public partial class NotepadView : Window
    {
        public NotepadView()
        {
            InitializeComponent();
        }

        private void ButtonOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = GetOpenFileDialogFilter()
            };

            if (openFileDialog.ShowDialog() is true)
                txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new()
            {
                Filter = GetOpenFileDialogFilter()
            };

            if (saveFileDialog.ShowDialog() is true)
                File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
        }

        private string GetOpenFileDialogFilter()
        {
            return "Text files (*.txt)|*.txt|All files (*.*)|*.*";
        }
    }
}
