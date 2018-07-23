namespace Vurdalakov
{
    using System;
    using System.Diagnostics;
    using System.Reflection;

    public class AssemblyInformation
    {
        public String Title { get; }
        public String Description { get; set; }
        public String Configuration { get; set; }
        public String Company { get; set; }
        public String Product { get; set; }
        public String Copyright { get; set; }
        public String Trademark { get; set; }
        public String Culture { get; set; }
        public Version AssemblyVersion { get; set; }
        public Version FileVersion { get; set; }
        public Version ProductVersion { get; set; }

        public AssemblyInformation(Assembly assembly = null)
        {
            assembly = assembly ?? Assembly.GetEntryAssembly();

            this.Title = GetAttribute<AssemblyTitleAttribute>()?.Title;
            this.Description = GetAttribute<AssemblyDescriptionAttribute>()?.Description;
            this.Configuration = GetAttribute<AssemblyConfigurationAttribute>()?.Configuration;
            this.Company = GetAttribute<AssemblyCompanyAttribute>()?.Company;
            this.Product = GetAttribute<AssemblyProductAttribute>()?.Product;
            this.Copyright = GetAttribute<AssemblyCopyrightAttribute>()?.Copyright;
            this.Trademark = GetAttribute<AssemblyTrademarkAttribute>()?.Trademark;
            this.Culture = GetAttribute<AssemblyCultureAttribute>()?.Culture;

            this.AssemblyVersion = assembly.GetName().Version; // [assembly: AssemblyVersion("1.0")]
            var location = FileVersionInfo.GetVersionInfo(assembly.Location);
            this.FileVersion = new Version(location.FileVersion); // [assembly: AssemblyFileVersion("1.0")]
            this.ProductVersion = new Version(location.ProductVersion); // [assembly: AssemblyInformationalVersion("1.0")]

            T GetAttribute<T>()
            {
                var attributes = assembly.GetCustomAttributes(typeof(T), false);
                return (T)(0 == attributes.Length ? null : attributes[0]);
            }
        }
    }
}
