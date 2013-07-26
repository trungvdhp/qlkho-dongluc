using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace QLK_DongLuc.Helper
{
    public static class MachineHelper
    {
        /// <summary>
        /// Get Machine Info
        /// </summary>
        /// <returns>Machine Info String</returns>
        public static string GetMachineInfo()
        {
            string info = System.Net.Dns.GetHostName();

            foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (networkInterface.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (var ip in networkInterface.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            info += "|" + networkInterface.GetPhysicalAddress().ToString() + "|" + ip.Address.ToString();

                            return info;
                        }
                    }
                }
            }

            return info;
        }
    }
}
