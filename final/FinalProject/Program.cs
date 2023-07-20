
using System;
using FinalProject;



Expeditor expeditor = new();

bool isRunning = true;

while (isRunning)
{
    isRunning = expeditor.RunCatalog();
}

