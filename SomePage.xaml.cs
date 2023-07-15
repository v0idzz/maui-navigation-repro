using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maui_navigation_repro;

public partial class SomePage : ContentPage
{
    public SomePage()
    {
        InitializeComponent();
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        DisplayAlert("OnNavigatedTo", Title, "OK");
        base.OnNavigatedTo(args);
    }
}