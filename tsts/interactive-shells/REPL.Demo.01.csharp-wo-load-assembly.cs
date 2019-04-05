
// LoadAssembly("../../source/HolisticWare.Core.Math.Statistics.Descriptive.Sequential.NetStandard10/bin/Debug/netstandard1.0/HolisticWare.Core.Math.Statistics.Descriptive.Sequential.dll");

// namespace inclusion (using) necessary for LINQ Extension methods
using Core.Math.Statistics.Descriptive.Sequential;


ShowUsing (); 

List<int> data01 = new List<int>(){1,2,4,5};

double mean_arithmetic_01 = data01.MeanArithmetic();
Console.WriteLine($"mean_arithmetic_01 = {mean_arithmetic_01}");  

double mean_geometric_01 = data01.MeanGeometric();
Console.WriteLine($"mean_arithmetic_01 = {mean_geometric_01}");  

