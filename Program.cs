using System;
using System.Threading;
using Humanizer;
using Spectre.Console;

// 1. Animated status bar (Spinner)
AnsiConsole.Status()
    .Spinner(Spinner.Known.BouncingBar)
    .SpinnerStyle(Style.Parse("fuchsia"))
    .Start("Getting ready for the lab...", ctx => 
    {
        ctx.Status("Learning .NET SDK...");
        Thread.Sleep(1500); 
        
        ctx.Status("Reading MSBuild docs...");
        Thread.Sleep(1500);
        
        ctx.Status("Thinking of good answers for the teacher...");
        Thread.Sleep(1500);
    });

AnsiConsole.Clear(); 

// 2. Beautiful rule/separator
var rule = new Rule("[fuchsia]Lab 1: .NET CLI and Platform[/]");
rule.Justification = Justify.Center;
AnsiConsole.Write(rule);

// 3. Bar chart for metrics
var chart = new BarChart()
    .Width(60)
    .Label("[green bold]Student Status[/]")
    .CenterLabel()
    .AddItem("Cups of coffee", 12, Color.Yellow)
    .AddItem("Code errors", 45, Color.Red)
    .AddItem("Understanding of CLI (%)", 99, Color.Blue);

AnsiConsole.Write(chart);

// 4. Calculate dynamic deadline (19:00 today)
DateTime now = DateTime.Now;
DateTime deadline = new DateTime(now.Year, now.Month, now.Day, 19, 0, 0);

if (now > deadline)
{
    deadline = deadline.AddDays(1);
}

TimeSpan timeToDeadline = deadline - now;

// 5. Results panel with Humanizer integration
var panel = new Panel($"""
    [bold white]Student:[/] Ready to pass!
    [bold white]Time left:[/] [yellow]{timeToDeadline.Humanize(precision: 2)}[/]
    [bold white]SDK used:[/] [green].NET 10 / .NET 8[/]
    """)
    .Header("[bold fuchsia]System Info[/]")
    .Border(BoxBorder.Double);

AnsiConsole.Write(panel);
AnsiConsole.WriteLine();