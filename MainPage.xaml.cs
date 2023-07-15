namespace maui_navigation_repro;

public partial class MainPage
{
    public MainPage()
    {
        InitializeComponent();

        for (var i = 0; i < 8; i++)
        {
            Children.Add(new SomePage
            {
                Title = i.ToString()
            });
        }
    }
}