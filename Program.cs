using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ndev.LicenseKey;

namespace GenerateLicenseKey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            frmGenerateLicenseKey form = new frmGenerateLicenseKey();
            form.ShowDialog();
        }
    }
}
