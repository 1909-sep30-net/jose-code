using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

//git addon can be used by using commands on the bottom right corner, you can stage and commit files and press SYNC to save changes.
namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            //"" you need to escape characters with \
            //@ you dont need to do so.
            var xmlfilepath = @"C:\revature\persons.xml";

           // var data = GetInitialData();

            var data = DeserializeXmlToFile(xmlfilepath);

            ModifyData(data);

            SerializeXmlToFile(xmlfilepath, data);
        }

        private static void ModifyData(List<person>data)
        {
            var person = data[0];
            person.id += 10;
        }

        private static List<person> DeserializeXmlToFile(string xmlfilepath)
        {
            var serializer = new XmlSerializer(typeof(List<person>));
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(xmlfilepath, FileMode.Open);
                return (List<person>)serializer.Deserialize(fileStream);

            }
            catch (IOException e)
            {
                Console.WriteLine($"Error while opening {xmlfilepath} for writing");

            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error while serializing {xmlfilepath} for operations");

            }
            //Finally block always runs whether no exception, handled exception, or unhandled exception
            finally
            {
                fileStream?.Dispose();
            }
        }

        private static void SerializeXmlToFile(string xmlfilepath, List<person> data)
        {
            var serializer = new XmlSerializer(typeof(List<person>));
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(xmlfilepath, FileMode.Create);
                serializer.Serialize(fileStream, data);
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error while opening {xmlfilepath} for writing");

            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error while opening {xmlfilepath} for operations");

            }
            //Finally block always runs whether no exception, handled exception, or unhandled exception
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Dispose();
                }
            }
        }

        public static List<person> GetInitialData()
        {
            return new List<person>
            {
                new person
                {
                    id = 1,
                    Name = "Billy",
                    Address = new Address
                 {
                     Street = "123 Main St",
                     City = "Dallas",
                     State = "TX"
                 }

                }
            };
         }
    }
}
