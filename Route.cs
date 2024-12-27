using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MRPZ3
{
    public class Route
    {
        public string Name { get; }
        public string StartDate { get; }
        public string EndDate { get; }
        public List<string> Destinations { get; }
        public List<Eventt> Eventss { get; } = new();
        public Route(string name, string startDate, string endDate)
        {
            Eventss = new List<Eventt>();
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            Destinations = new List<string>();
        } 
        public void AddDestination(string destination)
        {   
            if (!Destinations.Contains(destination))
            {
                Destinations.Add(destination);
            }
        }
        public void RemoveDestination(string destination)
        {
            if (Destinations.Contains(destination))
            {
                Destinations.Remove(destination);
            }
        }
        public void AddEventt(Eventt ev)
        {
            if (!Eventss.Contains(ev))
            {
                Eventss.Add(ev);
            }          
        }
        public void UpdateEventStatus(string eventName, string newStatus)
        {            
            var eventt = Eventss.FirstOrDefault(e => e.Name == eventName);

            if (eventt == null)
            {
                throw new ArgumentException($"Подію з назвою '{eventName}' не знайдено.");
            }

            if (newStatus != "Заплановано" && newStatus != "Виконується" && newStatus != "Завершено")
            {
                throw new ArgumentException("Невірний статус. Дозволені статуси: 'Заплановано', 'Виконується', 'Завершено'.");
            }
            eventt.Status = newStatus;
        }

       
       
    }
}
