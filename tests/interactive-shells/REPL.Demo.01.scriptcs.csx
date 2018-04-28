// NOTE '\' instead of '/'

/*
It is psoobile reference other (loose) assemblies from  CSX script by using a #r directive. 
In order for the assembly to be allowed to be used in the CSX file, it needs to be copied into the bin
folder relative to the script path or be present in the GAC.
*/
// #r "..\..\source\HolisticWare.Core.Math.Statistics.Descriptive.Sequential.NetStandard10\bin\Debug\netstandard1.0\HolisticWare.Core.Math.Statistics.Descriptive.Sequential.dll"
#r "HolisticWare.Core.Math.Statistics.Descriptive.Sequential.dll"

using System;
using System.Linq;

// namespace inclusion (using) necessary for LINQ Extension methods
using Core.Math.Statistics.Descriptive.Sequential;

List<int> data01 = new List<int>(){1,2,4,5};

double mean_arithmetic_01 = data01.MeanArithmetic();
Console.WriteLine($"mean_arithmetic_01 = {mean_arithmetic_01}");  

double mean_geometric_01 = data01.MeanGeometric();
Console.WriteLine($"mean_arithmetic_01 = {mean_geometric_01}");  

