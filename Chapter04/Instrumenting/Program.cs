﻿using System.Diagnostics;
using Microsoft.Extensions.Configuration;

string logPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\log.txt"));
Console.WriteLine($"Writing to: {logPath}");

TextWriterTraceListener logFile = new(File.CreateText(logPath));

Trace.Listeners.Add(logFile);

// text writer is buffered, so this option calls Flush() on all listeners after writing
Trace.AutoFlush = true;

Debug.WriteLine("Debug says, I am watching!");
Trace.WriteLine("Trace says, I am watching!");

Console.WriteLine($"Reading from appsettings.json in {Directory.GetCurrentDirectory()}");

ConfigurationBuilder builder = new();
builder.SetBasePath(Directory.GetCurrentDirectory());

builder.AddJsonFile("appsettings.json", true, true);

IConfigurationRoot configuration = builder.Build();

TraceSwitch ts = new("PacktSwitch", "This switch is set via a JSON config.");

configuration.GetSection("PacktSwitch").Bind(ts);

Trace.WriteLineIf(ts.TraceError, "Trace error");
Trace.WriteLineIf(ts.TraceWarning, "Trace warning");
Trace.WriteLineIf(ts.TraceInfo, "Trace information");
Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");

int unitsInStock = 12;
LogSourceDetails(unitsInStock > 10);

Console.ReadLine();