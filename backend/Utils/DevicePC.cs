using System.Runtime.InteropServices;

namespace Utils
{
    public static class DevicePC {
        public static bool IsPCType(this OSPlatform oSPlatform) {
            var result = RuntimeInformation.IsOSPlatform(oSPlatform);
            return result;
        }
    }
}