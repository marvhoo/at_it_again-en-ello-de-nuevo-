
using System;
using FinalProject;
using Library;



Expeditor expeditor = new();

bool isRunning = true;

while (isRunning)
{
    isRunning = expeditor.RunCatalog();
}