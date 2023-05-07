using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.Model
{
    class Database
    {
        public string Search(string name) 
        {
            string filePath = "Book.txt";
            List<string> searchResults = new List<string>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.ToLower().Contains(name.ToLower()))
                    {
                        searchResults.Add(line);
                    }
                }
            }

            if (searchResults.Count > 0)
            {
                string resultString = string.Join(Environment.NewLine, searchResults);
                return resultString;
            }
            else
            {
                return null;
            }
        }

    }
}
