using System.IO;
using UnityEngine;

namespace Localizatoin
{
    public class LocalizationRepository
    {
        private string _name;
        private string _filePath;

        public LocalizationRepository(string name)
        {
            _name = name;
            _filePath = Application.persistentDataPath + "/Localizatoin/" + _name + ".txt"; 
        }

        public void Save(object SaveDate)
        {
            StreamWriter streamWriter = new StreamWriter(_filePath);
            string Jfile = JsonUtility.ToJson(SaveDate);
            streamWriter.WriteAsync(Jfile);
        }
    }
}
