namespace Doctors.Network
{
    class ServiceUrlscs
    {
        private const string BaseAddress = "http://nafsol.cloudapp.net/ordertaker/HttpSameelService.svc/";

        public static string GetSale()
        {
            return BaseAddress + "getsale/";
        }

        public static string PostAddListSale()
        {
           return "http://178.180.0.145/ordertaker/HttpSameelService.svc/AddLocalListSale/";
        }
    }
}
