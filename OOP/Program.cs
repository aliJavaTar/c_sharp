using System.Globalization;
using OOP;
using OOP.service;


var persianCalendar = new PersianCalendar();
var addYears = persianCalendar.AddYears(DateTime.Today,1 );
Console.WriteLine(addYears);