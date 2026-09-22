using System.Threading;
using Humanizer;
using Spectre.Console;

// 1. Анимированный статус-бар (Spinner)
AnsiConsole.Status()
    .Spinner(Spinner.Known.BouncingBar)
    .SpinnerStyle(Style.Parse("fuchsia"))
    .Start("Подготовка к приёмке лабы...", ctx => 
    {
        ctx.Status("Загрузка .NET SDK в мозг...");
        Thread.Sleep(1500); // Имитация бурной деятельности
        
        ctx.Status("Парсинг документации MSBuild...");
        Thread.Sleep(1500);
        
        ctx.Status("Генерация умных ответов для преподавателя...");
        Thread.Sleep(1500);
    });

AnsiConsole.Clear(); // Очищаем консоль после загрузки

// 2. Красивый разделитель
var rule = new Rule("[fuchsia]Лабораторная №1: .NET CLI & Платформа[/]");
rule.Justification = Justify.Center;
AnsiConsole.Write(rule);

// 3. Рисуем столбчатую диаграмму (BarChart)
var chart = new BarChart()
    .Width(60)
    .Label("[green bold]Метрики выживания студента[/]")
    .CenterLabel()
    .AddItem("Чашек кофе", 12, Color.Yellow)
    .AddItem("Ошибок компиляции", 45, Color.Red)
    .AddItem("Понимание CLI (%)", 99, Color.Blue);

AnsiConsole.Write(chart);

// 4. Панель с результатами и интеграцией Humanizer
var timeToDeadline = TimeSpan.FromHours(1).Add(TimeSpan.FromMinutes(15));
var panel = new Panel($"""
    [bold white]Студент:[/] К защите готов!
    [bold white]Дедлайн через:[/] [yellow]{timeToDeadline.Humanize(precision: 2)}[/]
    [bold white]Используемый SDK:[/] [green].NET 10 / .NET 8[/]
    """)
    .Header("[bold fuchsia]Статус системы[/]")
    .Border(BoxBorder.Double);

AnsiConsole.Write(panel);
AnsiConsole.WriteLine();