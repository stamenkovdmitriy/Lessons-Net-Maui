using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace Lessons_Net_Maui;

public partial class Note : ContentPage
{
    // файл для хранения заметок
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

    public Note()
    {
        InitializeComponent();

        editor.Text = File.Exists(_fileName) ? File.ReadAllText(_fileName) : string.Empty;

        // проверка существует ли файл, используемый для хранения заметок
        if (File.Exists(_fileName))
        {
            editor.Text = File.ReadAllText(_fileName);
        }
    }

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        File.WriteAllText(_fileName, editor.Text);
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        if (File.Exists(_fileName))
        {
            File.Delete(_fileName);
        }
        editor.Text = string.Empty;
    }
}