using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MRPZ3
{
    public class Eventt
    {
        public string Name { get; }
        public string StartDate { get; }
        public string EndDate { get; }
        public string Location { get; }

        public string status;

        public string Status
        {
            get => status;
            set
            {
                if (value == "Заплановано" || value == "Виконується" || value == "Завершено")                
                    status = value;
                
                else                
                    throw new ArgumentException("Невірний статус. Дозволені статуси: 'Заплановано', 'Виконується', 'Завершено'");                
            }
        }
        public Eventt(string name, string startDate, string location, string status)
        {
            Name = name;
            StartDate = startDate;
            Location = location;
            Status = status; 
        }
    }
}
