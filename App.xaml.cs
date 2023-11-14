namespace Lessons_Net_Maui;

public partial class App : Application
{
	public static PersonRepository PersonRepo { get; private set; }
	public App(PersonRepository repo)
	{
		InitializeComponent();

		MainPage = new AppShell();

		PersonRepo = repo;
	}
}
