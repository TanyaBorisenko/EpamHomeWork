using System.IO;
using System.Xml.Serialization;

namespace EpamHomeWork
{
    public static class XmlMachineSerializer
    {
        private static readonly string RootProjectPath =
            Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName;

        public static void SerializeMachines<T>(T entities, string fileName, string directoryName = null)
        {
            var formatter = new XmlSerializer(typeof(T));
            if (directoryName != null)
            {
                Directory.CreateDirectory(Path.Combine(RootProjectPath, directoryName));
            }

            using var fs = new FileStream(Path.Combine(RootProjectPath, directoryName ?? string.Empty, fileName),
                FileMode.OpenOrCreate);
            formatter.Serialize(fs, entities);
        }
    }
}