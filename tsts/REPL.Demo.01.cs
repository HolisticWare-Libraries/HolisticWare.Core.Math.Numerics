LoadAssembly("../source/HolisticWare.Core.Math.Statistics.Descriptive.Sequential.NetStandard10/bin/Debug/netstandard1.0/HolisticWare.Core.Math.Statistics.Descriptive.Sequential.dll"); 

using System.Diagnostics;

// namespace inclusion (using) necessary for LINQ Extension methods
using Core.Math.Statistics.Descriptive.Sequential;

//ShowUsing (); 

Stopwatch sw = null;

//----------------------------------------------------------------------------------------------------
List<int> data01 = new List<int>(){1,2,4,5};

sw = Stopwatch.StartNew();
double mean_arithmetic_01 = data01.MeanArithmetic();
Console.WriteLine($"mean_arithmetic_01 = {mean_arithmetic_01}");  
sw.Stop();
Console.WriteLine($"List<int>.Average() size={data01.Count} elapsed[ticks]={sw.ElapsedTicks}");
sw.Reset();

sw = Stopwatch.StartNew();
double mean_geometric_01 = data01.MeanGeometric();
sw.Stop();
Console.WriteLine($"List<int>.Average() size={data01.Count} elapsed[ticks]={sw.ElapsedTicks}");
sw.Reset();
//----------------------------------------------------------------------------------------------------

List<int> data02 = new List<int> { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };

//----------------------------------------------------------------------------------------------------
sw = Stopwatch.StartNew();
double mean01 = data01.Average();
sw.Stop();
Console.WriteLine($"List<int>.Average() size={data01.Count} elapsed[ticks]={sw.ElapsedTicks}");
sw.Reset();
//----------------------------------------------------------------------------------------------------


