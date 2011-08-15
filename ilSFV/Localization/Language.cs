using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ilSFV.Localization
{
    public static partial class Language
    {
        public static event EventHandler Changed;

        public static string[] GetLanguages()
        {
            var dict = GetLanguagesDictionary();
            return dict.Keys.OrderBy(p => p != "English").ThenBy(p => p.ToLower()).ToArray();
        }

        private static Dictionary<string, string> GetLanguagesDictionary()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "languages");
            Dictionary<string, string> languages = new Dictionary<string, string>();
            string[] files = Directory.GetFiles(path, "*.txt");
            foreach (string file in files)
            {
                string[] lines = File.ReadAllLines(file);
                foreach (string line in lines)
                {
                    if (line.StartsWith("Language"))
                    {
                        string language = line.Substring("Language".Length).TrimStart(new[] { ' ', '=' }).Trim();
                        languages.Add(language, file);
                        break;
                    }
                }
            }

            return languages;
        }

        public static void Load(string language)
        {
            var dict = GetLanguagesDictionary();
            if (dict.ContainsKey(language))
                LoadFile(dict[language]);
            else if (dict.ContainsKey("English"))
                LoadFile(dict["English"]);
            else if (dict.Count > 0)
                LoadFile(dict[dict.Keys.First()]);
            else
                throw new Exception("No language files found.");

            var handler = Changed;
            if (handler != null)
                handler(null, EventArgs.Empty);
        }

        private static void LoadFile(string path)
        {
            const BindingFlags sbf = BindingFlags.Public | BindingFlags.Static;
            const BindingFlags bf = BindingFlags.Public | BindingFlags.Instance;
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            Type sectionType = null;
            object section = null;
            List<PropertyInfo> sectionProperties = new List<PropertyInfo>();

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].Trim();
                if (string.IsNullOrEmpty(line))
                    continue;
                if (line.StartsWith(";"))
                    continue;

                if (line.StartsWith("###"))
                {
                    if (sectionProperties.Count != 0)
                    {
                        // TODO: use English as backup.
                    }

                    string className = line.Substring(4).Replace(" ", "");
                    PropertyInfo pi = typeof(Language).GetProperty(className, sbf);
                    sectionType = pi.GetGetMethod().ReturnType;
                    section = sectionType.GetConstructor(Type.EmptyTypes).Invoke(null);
                    pi.GetSetMethod(true).Invoke(null, new[] { section });

                    sectionProperties.Clear();
                    sectionProperties.AddRange(sectionType.GetProperties(bf));
                }
                else
                {
                    string propertyName = string.Empty;
                    int j;
                    for (j = 0; j < line.Length; j++)
                    {
                        if (line[j] == ' ')
                            break;
                        propertyName += line[j];
                    }
                    string value = line.Substring(j).TrimStart(new[] { ' ', '=' }).Trim().Replace("\\n", "\n");

                    PropertyInfo pi = sectionType.GetProperty(propertyName, bf);
                    if (pi != null)
                    {
                        sectionProperties.Remove(pi);
                        pi.GetSetMethod().Invoke(section, new[] {value});
                    }
                }
            }
        }
    }
}
