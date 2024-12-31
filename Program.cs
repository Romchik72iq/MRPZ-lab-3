using MRPZ3;

Route route = new("Літня подорож", "01-07-2024", "15-07-2024");

// Додаємо події
Eventt event1 = new("Відвідування музею", "02-07-2024", "Львів", "Заплановано");
Eventt event2 = new("Екскурсія в гори", "05-07-2024", "Карпати", "Заплановано");

route.AddEventt(event1);
route.AddEventt(event2);

// Оновлення статусу події
route.UpdateEventStatus("Відвідування музею", "Виконується");

// Виведення інформації про маршрут і події
Console.WriteLine($"Маршрут: {route.Name}");
Console.WriteLine($"Початок: {route.StartDate}, Кінець: {route.EndDate}");
Console.WriteLine("Події:");

foreach (Eventt ev in route.Eventss)
{
    Console.WriteLine($"Назва: {ev.Name}, Дата початку: {ev.StartDate}, Місцезнаходження: {ev.Location}, Статус: {ev.Status}");
}