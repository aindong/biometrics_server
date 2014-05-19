using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Riss.Devices;

namespace biometrics_server.IConvert
{
    class ConvertObject
    {

        private ConvertObject() { }

        //convert IP to number
        public static int ConvertIPAddressToNumber(string strIPAddress)
        {
            string[] arrayIP = strIPAddress.Split('.');
            int sip1 = Int32.Parse(arrayIP[0]);
            int sip2 = Int32.Parse(arrayIP[1]);
            int sip3 = Int32.Parse(arrayIP[2]);
            int sip4 = Int32.Parse(arrayIP[3]);
            int tmpIpNumber;
            tmpIpNumber = (sip1 << 24) + (sip2 << 16) + (sip3 << 8) + sip4;
            return tmpIpNumber;
        }

        //convert number to ip
        public static string ConvertNumberToIPAddress(int intIPAddress)
        {
            byte[] bs = BitConverter.GetBytes(intIPAddress);
            return string.Format("{0}.{1}.{2}.{3}", bs[3], bs[2], bs[1], bs[0]);
        }

        //check if the ip is correct
        public static bool IsCorrenctIP(string ip)
        {
            if (Regex.IsMatch(ip, "[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}"))
            {
                string[] ips = ip.Split('.');
                if (4 == ips.Length)
                {
                    if (Int32.Parse(ips[0]) < 256 && Int32.Parse(ips[1]) < 256
                        && Int32.Parse(ips[2]) < 256 && Int32.Parse(ips[3]) < 256)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //check if the arguement is an int
        public static bool IsInt(string content)
        {
            if (Regex.IsMatch(content, "^\\d+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //convert byte to hex
        public static string ConvertByteToHex(byte[] bytes)
        {
            string result = string.Empty;
            for (int i = 0; i < bytes.Length; i++)
            {
                result += "-" + Convert.ToString(bytes[i], 16).PadLeft(2, '0');
            }
            return result.Remove(0, 1).ToUpper();
        }

        //log message types
        public static string SLogType(int opertationType) {
            string message = string.Empty;

            switch (opertationType) {
                case 1:
                    message = "Registered user";
                    break;
                case 2:
                    message = "Register super administrator";
                    break;
                case 3:
                    message = "Register registrar";
                    break;
                case 4:
                    message = "Register query member";
                    break;
                case 5:
                    message = "Delete fingerprint";
                    break;
                case 6:
                    message = "Remove the password";
                    break;
                case 7:
                    message = "Delete the card number";
                    break;
                case 8:
                    message = "Remove access to records";
                    break;
                case 9:
                    message = "Remove records";
                    break;
                case 10:
                    message = "Set system information";
                    break;
                case 11:
                    message = "Setup time";
                    break;
                case 12:
                    message = "Set the record information";
                    break;
                case 13:
                    message = "Set the communications and information";
                    break;
                case 14:
                    message = "Set the access control information";
                    break;
                case 15:
                    message = "Set the user type";
                    break;
                case 16:
                    message = "Set the attendance time";
                    break;
            }
            return message;
        }

        public static string IOMode(int mode) {
            string message = string.Empty;

            switch (mode) {
                case 0:
                    message = "Check in";
                    break;
                case 1:
                    message = "Clock in";
                    break;
                case 2:
                    message = "Clock out";
                    break;
                case 3:
                    message = "Customer in";
                    break;
                case 4:
                    message = "Customer out";
                    break;
                case 5:
                    message = "Out";
                    break;
                case 6:
                    message = "In";
                    break;
                case 7:
                    message = "User defined 1";
                    break;
                case 8:
                    message = "User defined 2";
                    break;
                case 12:
                    message = "Button open";
                    break;
                case 13:
                    message = "Software open";
                    break;
                case 14:
                    message = "Keep open";
                    break;
                case 15:
                    message = "Keep close";
                    break;
                case 16:
                    message = "Auto mode";
                    break;
                case 17:
                    message = "Open in";
                    break;
                case 18:
                    message = "Open out";
                    break;
                case 19:
                    message = "Overtime open alarm";
                    break;
                case 20:
                    message = "Forced open alarm";
                    break;
                case 21:
                    message = "Antihijack alarm";
                    break;
                case 22:
                    message = "Input action 1";
                    break;
                case 23:
                    message = "Input action 2";
                    break;
                case 24:
                    message = "Output action 1";
                    break;
                case 25:
                    message = "Output action 2";
                    break;
                case 26:
                    message = "Invalid time";
                    break;
                case 27:
                    message = "Invalid date";
                    break;
                case 31:
                    message = "Illegal operation";
                    break;
            }
            return message;
        }

        public static string GLogType(int opertationType) {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 4; i++) {
                if (0 != Zd2911Utils.BitCheck(opertationType, i)) {
                    switch (i) {
                        case 0:
                            sb.Append("F ");
                            break;
                        case 1:
                            sb.Append("P ");
                            break;
                        case 2:
                            sb.Append("C ");
                            break;
                        case 3:
                            sb.Append("I ");
                            break;
                    }
                }
            }
            return sb.ToString();
        }

        

    }
}
