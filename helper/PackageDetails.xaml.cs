namespace helper;

public sealed partial class PackageDetails : Page
{
    public PackageDetails()
    {
        this.InitializeComponent();
    }
    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        base.OnNavigatedTo(e);
        if(e.Parameter is ListViewItem selectedItem)
        {
            details.Text = selectedItem.Content.ToString();
        }
    }
}