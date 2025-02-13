using System.Diagnostics;
using Uno.UI.RemoteControl.Messaging.IdeChannel;

namespace helper;

    public sealed partial class StartPage : Page
    {
        public StartPage()
        {
            this.InitializeComponent();
        }
        private void CheckLTSP_Click(object sender, RoutedEventArgs e)
        {
            CheckPackage("ltsp");
        }
        private void CheckLibreOffice_Click(object sender, RoutedEventArgs e)
        {
            CheckPackage("libreoffice");
        }
        void CheckPackage(string packageName)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "/bin/bash";
            proc.StartInfo.Arguments = $"-c \"apt list {packageName}\"";
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();

            string result = proc.StandardOutput.ReadToEnd();
            //ResultTextBlock.Text = result;
            if (result.Contains("Installed"))
            {
                ResultTextBlock.Text =  $"Package '{packageName}' is installed:\n{result}";

            }
            else
            {
                ResultTextBlock.Text =  $"Package '{packageName}' is not installed.";
            }
            }
        private void Check_Click(object sender, RoutedEventArgs e)
        {
           Process proc = new Process();
           proc.StartInfo.FileName = "/bin/bash";
           proc.StartInfo.Arguments = "-c \"apt list ltsp ipxe dnsmasq nfs-kernel-server openssh-server squashfs-tools net-tools ethtool epoptes firefox libreoffice openjdk-11-jdk-headless isc-dhcp-server\"";
           proc.StartInfo.RedirectStandardOutput = true;
           proc.StartInfo.UseShellExecute = false;
           proc.StartInfo.CreateNoWindow = true;
           proc.Start();

           string result = proc.StandardOutput.ReadToEnd();
           ResultTextBlock.Text = result;
        }
        private void Install_Click(object sender, RoutedEventArgs e)
        {
           Process proc = new Process();
           proc.StartInfo.FileName = "/bin/bash";
           proc.StartInfo.Arguments = "-c \"apt install ltsp ipxe dnsmasq nfs-kernel-server openssh-server squashfs-tools net-tools ethtool epoptes firefox libreoffice openjdk-11-jdk-headless isc-dhcp-server\"";
           proc.StartInfo.RedirectStandardOutput = true;
           proc.StartInfo.UseShellExecute = false;
           proc.StartInfo.CreateNoWindow = true;
           proc.Start();

           string result = proc.StandardOutput.ReadToEnd();
           ResultTextBlock.Text = result;
        }
    }