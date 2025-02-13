using helper.Models;

namespace helper.Data;

public static class HelperData
{
    public static IList<Models.Package> MainPackages { get; private set; }
    public static IList<Models.Package> ToolPackages { get; private set; }
    public static IList<Models.Package> ExtrasPackages { get; private set; }

    static HelperData()
    {
        MainPackages = new List<Models.Package>();
        ToolPackages = new List<Models.Package>();
        ExtrasPackages = new List<Models.Package>();
        MainPackages.Add(new Models.Package { Id = 1, Name = "ltsp" });
        MainPackages.Add(new Models.Package { Id = 2, Name = "ipxe" });
        MainPackages.Add(new Models.Package { Id = 3, Name = "dnsmasq" });
        MainPackages.Add(new Models.Package { Id = 4, Name = "nfs-kernel-server" });
        MainPackages.Add(new Models.Package { Id = 5, Name = "openssh-server" });
        MainPackages.Add(new Models.Package { Id = 6, Name = "squashfs-tools" });
        MainPackages.Add(new Models.Package { Id = 7, Name = "net-tools" });
        MainPackages.Add(new Models.Package { Id = 8, Name = "ethtool" });
        MainPackages.Add(new Models.Package { Id = 9, Name = "epoptes" });
        MainPackages.Add(new Models.Package { Id = 12, Name = "isc-dhcp-server" });
        ToolPackages.Add(new Models.Package { Id = 10, Name = "libreoffice" });
        ToolPackages.Add(new Models.Package { Id = 11, Name = "openjdk-11-jdk-headless" });
        ToolPackages.Add(new Models.Package { Id = 13, Name = "firefox" });
        ToolPackages.Add(new Models.Package {Id = 14, Name="putty"});
        ExtrasPackages.Add(new Models.Package {Id = 15, Name="shotwell"});
        ExtrasPackages.Add(new Models.Package {Id = 16, Name="evince"});
        ExtrasPackages.Add(new Models.Package {Id = 17, Name="simple-scan"});
    }
}