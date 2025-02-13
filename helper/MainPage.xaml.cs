using System.Collections.ObjectModel;
using System.Diagnostics;
using helper.Data;

namespace helper;

public sealed partial class MainPage : Page
{
    List<Models.Result> results = new();
    private ObservableCollection<Models.Result> resultsCollection = new();  
    public MainPage()
    {
        this.InitializeComponent();
    }
    private void CheckSystem_Click(object sender, RoutedEventArgs e)
    {
        var packages = HelperData.Packages;
        foreach (var package in packages)
        {
            CheckPackages(package.Name);
        }
        GetResults();
    }
    private void Install_Click(object sender, RoutedEventArgs e)
    {
        var selectedItem = ResultsListView.SelectedItem as Models.Result;
        InstallPackage(selectedItem.PackageName);
    }
    private void InstallPackage(string packageName)
    {
        Process proc = new Process();
        proc.StartInfo.FileName = "/bin/bash";
        proc.StartInfo.Arguments = $"-c \"apt install {packageName}\"";
        proc.StartInfo.RedirectStandardOutput = true;
        proc.StartInfo.UseShellExecute = false;
        proc.StartInfo.CreateNoWindow = true;
        proc.Start();
        string result = proc.StandardOutput.ReadToEnd();
    }
    private void CheckPackages(string packageName)
    {
        Process proc = new Process();
        proc.StartInfo.FileName = "/bin/bash";
        proc.StartInfo.Arguments = $"-c \"apt list {packageName}\"";
        proc.StartInfo.RedirectStandardOutput = true;
        proc.StartInfo.UseShellExecute = false;
        proc.StartInfo.CreateNoWindow = true;
        proc.Start();
        string result = proc.StandardOutput.ReadToEnd();
        bool resultInstalled;
        if (result.Contains("installed"))
        {
            //ResultTextBlock.Text =  $"Package '{packageName}' is installed:\n{result}";
            resultInstalled = true;
        }
        else
        {
            resultInstalled = false;
           // ResultTextBlock.Text =  $"Package '{packageName}' is not installed.";
        }
            var newResult = new Models.Result
            {
                PackageName = packageName,
                IsInstalled = resultInstalled
            };
            results.Add(newResult);
    }
    private void GetResults()
    {
        foreach(var result in results)
        {
            resultsCollection.Add(result);
        }
        ResultsListView.ItemsSource = resultsCollection;    
    }

}
