﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequireJsNet.Configuration
{
    using System.IO;

    internal static class ConfigHelpers
    {
        public static ConfigType GetReaderType(string path)
        {
            var extension = Path.GetExtension(path);
            if (string.IsNullOrEmpty(extension))
            {
                throw new Exception(string.Format("No extension specified for file {0}.", path));
            }

            extension = extension.ToLowerInvariant();
            switch (extension)
            {
                case ".config":
                    return ConfigType.Xml;
                case ".xml":
                    return ConfigType.Xml;
                case ".json":
                    return ConfigType.Json;
                default:
                    throw new Exception(string.Format("Unknown file extension {0}.", extension));
            }
        }
    }
}
