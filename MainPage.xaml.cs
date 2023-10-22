using System.Diagnostics;

namespace Lessons_Net_Maui;

public partial class MainPage : ContentPage
{
    // файл для хранения заметок
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

	public MainPage()
	{
		InitializeComponent();

        editor.Text = File.Exists(_fileName)?File.ReadAllText(_fileName):string.Empty;

        // проверка существует ли файл, используемый для хранения заметок
        if (File.Exists(_fileName))
        {
            editor.Text=File.ReadAllText(_fileName);
        }
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Debug.WriteLine("Clicked !");
    }

    int count = 0;
    private void Button_Clicked_1(object sender, EventArgs e)
    {
        count++;
        currentLabel.Text = $"current count: {count}";
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

