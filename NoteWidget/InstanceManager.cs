using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Drawing;

namespace NoteWidget
{

    // Tracks instances of a type T.
    // In the case of any note form instances they are added  into the instance tracker <NoteForm>
    static class InstanceManager<T>
    {
        private static List<T> _instances = new List<T>();

        public static int InstanceCount
        {
            get => _instances.Count;
        }
        public static void AddInstance(T instance)
        {
            _instances.Add(instance);
        }
        public static void RemoveInstance(T instance)
        {
            _instances.Remove(instance);
        }
        public static void AddInstances(IEnumerable<T> collection)
        {
            _instances.AddRange(collection);
        }
        public static List<T> Instances
        {
            get => _instances;
        }
        private static T _ParentInstance
        {
            set; get;
        } = default(T);

        public static T Parent
        {
            set
            {
                if (_ParentInstance == null) _ParentInstance = value;
                else
                    Console.WriteLine("Attempting to assign a value to the parent instance, but a value is already assigned.");
            }
          
            get => _ParentInstance;
            
        }

        #region Serialization / Deserialization of object
        private static readonly string _defaultSerializationPath = $@"C:\Users\{Environment.UserName}\Documents\NoteWidgetResources\";
        private static readonly string _defaultConfigurationFileName = "Notes.cfg";
        private static readonly string _path = Path.Combine(_defaultSerializationPath, _defaultConfigurationFileName);

        public static void SerializeNoteFormObjects(IEnumerable<NoteComponent> noteCompInstances)
        {
            // create constant for directory and file with path.
            if (!Directory.Exists(_defaultSerializationPath))
                Directory.CreateDirectory(_defaultSerializationPath);
            
            
            if (!File.Exists(_path))
                File.Create(_path).Close();
            
           

            var stringBuilder = new StringBuilder();
            foreach (var noteFormObject in noteCompInstances)
            {
                stringBuilder.Append(noteFormObject);
            }
            Debug.WriteLine($"Serialized Data::\n{stringBuilder.ToString()}");
            File.WriteAllText(_path, stringBuilder.ToString());
        }
        public static void SerializeNoteFormObjects()
        {
            // create constant for directory and file with path.
            if (!Directory.Exists(_defaultSerializationPath))
                Directory.CreateDirectory(_defaultSerializationPath);


            if (!File.Exists(_path))
                File.Create(_path).Close();



            var stringBuilder = new StringBuilder();
            foreach (var noteFormObject in _instances)
            {
                stringBuilder.Append(noteFormObject);
            }
            Debug.WriteLine($"Serialized Data::\n{stringBuilder.ToString()}");
            File.WriteAllText(_path, stringBuilder.ToString());
        }

        public static void DeSerializeNoteFormObjects()
        {
            // Properly serialized objects, now properly deserialize and reconstruct them.
            // Do at load.
            // How to convert serialized color values to useable colors. (Convert to RGB format before serialization)
            
            var sb = new StringBuilder();
            var configs = File.ReadAllText(_path);
            // name / content / pad color / title bar color / end
            Debug.WriteLine("All lines from config file: ");
            var splitDataFromConfig = configs.Split('&');
            foreach (var objectInstance in splitDataFromConfig)
            {

                var instanceProperties = objectInstance.Split('_');
                if (!String.IsNullOrWhiteSpace(instanceProperties[0]))
                {
                    var name = instanceProperties[0];
                    var content = instanceProperties[1];
                    var padColor = instanceProperties[2];
                    var titleBarColor = instanceProperties[3];

                    InstanceManager<NoteComponent>.AddInstance(new NoteComponent(name, content, Color.LightBlue, Color.Ivory));
                   
                }
               
            }
            foreach(var instance in InstanceManager<NoteComponent>.Instances)
            {
               
                    instance.Show();
           
            }
         
            


        }
        #endregion
    }
}
