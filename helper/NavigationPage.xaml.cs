namespace helper;
public sealed partial class NavigationPage : Page
{
    public NavigationPage()
    {
        InitializeComponent();
        NavMenu.SelectedItem = NavMenu.MenuItems[0];
    }
    private void NavMenu_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
    {
        if(args.SelectedItemContainer != null)
        {
        string selectedTag = args.SelectedItemContainer.Tag.ToString();
        switch (selectedTag)
        {
            case "ltsp":
                contentFrame.Navigate(typeof(MainPage));
                break;
            case "StartPage":
                contentFrame.Navigate(typeof(StartPage));
                break;
            default:
                break;
        }
        }
    }
}