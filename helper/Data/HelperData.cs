using helper.Models;

namespace helper.Data;

public static class HelperData
{
    public static IList<Models.Package> Packages { get; private set; }

    static HelperData()
    {
        Packages = new List<Models.Package>();
        Packages.Add(new Models.Package { Id = 1, Name = "ltsp" });
        Packages.Add(new Models.Package { Id = 2, Name = "ipxe" });
        Packages.Add(new Models.Package { Id = 3, Name = "dnsmasq" });
        Packages.Add(new Models.Package { Id = 4, Name = "nfs-kernel-server" });
        Packages.Add(new Models.Package { Id = 5, Name = "openssh-server" });
        Packages.Add(new Models.Package { Id = 6, Name = "squashfs-tools" });
        Packages.Add(new Models.Package { Id = 7, Name = "net-tools" });
        Packages.Add(new Models.Package { Id = 8, Name = "ethtool" });
        Packages.Add(new Models.Package { Id = 9, Name = "epoptes" });
        Packages.Add(new Models.Package { Id = 12, Name = "isc-dhcp-server" });
        Packages.Add(new Models.Package { Id = 10, Name = "libreoffice" });
        Packages.Add(new Models.Package { Id = 11, Name = "openjdk-11-jdk-headless" });
        Packages.Add(new Models.Package { Id = 13, Name = "firefox" });
        Packages.Add(new Models.Package {Id = 14, Name="putty"});
        Packages.Add(new Models.Package {Id = 15, Name="shotwell"});
        Packages.Add(new Models.Package {Id = 16, Name="evince"});
        Packages.Add(new Models.Package {Id = 17, Name="simple-scan"});
    }
}