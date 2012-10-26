using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace BodyMedia.CoreClient.Tests
{
    public class BaseSerializationTest
    {
        protected void TestSerialization<T>(string fileName, Action<T> assertions) where T : class
        {
            using (var strm = GetEmbeddedFile(this.GetType().Assembly, fileName))
            {
                var ser = new XmlSerializer(typeof(T));
                var obj = ser.Deserialize(strm) as T;
                assertions(obj);
            }
        }
        private XmlDocument GetEmbeddedXml(Assembly assembly, string fileName)
        {
            using (var str = GetEmbeddedFile(assembly, fileName))
            {
                using (var tr = new XmlTextReader(str))
                {
                    var xml = new XmlDocument();
                    xml.Load(tr);
                    return xml;
                }
            }
        }

        private Stream GetEmbeddedFile(Assembly assembly, string fileName)
        {
            Stream str = assembly.GetManifestResourceStream(fileName);

            if (str == null)
                throw new Exception("Could not locate embedded resource '" + fileName + "' in assembly '" + assembly.GetName() + "'");
            return str;

        }
    }
}
