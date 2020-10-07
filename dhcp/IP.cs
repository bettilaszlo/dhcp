using System;

namespace dhcp
{
   class IP
    {
        public string IPSzoveg { get; private set; }
        public int OK1 { get; private set; }
        public int OK2 { get; private set; }
        public int OK3 { get; private set; }
        public int OK4 { get; private set; }
        public string CimPluszEgy()
        {
            if (OK4 < 255)
            {
                OK4++;
            }
            IPSzoveg = OK1.ToString() + "." + OK2 + "." + OK3 + "." + OK4.ToString();
            return IPSzoveg;
        }
        //192.168.10.100
        public IP(string cim)
        {
            IPSzoveg = cim;

            string[] adat = cim.Split('.');
            OK1 = Convert.ToInt32(adat[0]);
            OK2 = Convert.ToInt32(adat[1]);
            OK3 = Convert.ToInt32(adat[2]);
            OK4 = Convert.ToInt32(adat[3]);
        }
    }
}