using System;
using System.IO;
using photoniced.device.interfaces.services;

namespace photoniced.device.services
{
    public class DevicePathService : IDevicePathService
    {
        public static bool path_valid(string path)
        {
            if (path == null)
              return false;
            try
            {
                Path.GetDirectoryName(path);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static FileInfo get_file(string path)
        {
            if (!path_valid(path))
            {
                throw new InvalidDataException();
            }

            return new FileInfo(path);
        }
    }
}