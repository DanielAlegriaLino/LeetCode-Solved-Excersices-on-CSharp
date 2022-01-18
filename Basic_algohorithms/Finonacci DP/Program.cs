using System.Diagnostics;

ulong[] nemo = new ulong[50001];
nemo[0] = 1;
nemo[1] = 1;

Stopwatch sw = new Stopwatch();
sw.Start();
Console.WriteLine(getFibbonacciValueIterative(10000));
Console.WriteLine(getFibbonacciValueIterative(20000));
Console.WriteLine(getFibbonacciValueIterative(30000));
Console.WriteLine(getFibbonacciValueIterative(40000));
Console.WriteLine(getFibbonacciValueIterative(50000));
Console.WriteLine(getFibbonacciValueIterative(10000));
Console.WriteLine(getFibbonacciValueIterative(20000));
Console.WriteLine(getFibbonacciValueIterative(30000));
Console.WriteLine(getFibbonacciValueIterative(40000));
Console.WriteLine(getFibbonacciValueIterative(50000));
Console.WriteLine(getFibbonacciValueIterative(10000));
Console.WriteLine(getFibbonacciValueIterative(20000));
Console.WriteLine(getFibbonacciValueIterative(30000));
Console.WriteLine(getFibbonacciValueIterative(40000));
Console.WriteLine(getFibbonacciValueIterative(50000));
Console.WriteLine(getFibbonacciValueIterative(10000));
Console.WriteLine(getFibbonacciValueIterative(20000));
Console.WriteLine(getFibbonacciValueIterative(30000));
Console.WriteLine(getFibbonacciValueIterative(40000));
Console.WriteLine(getFibbonacciValueIterative(50000));
sw.Stop();
Console.WriteLine(sw.Elapsed);

sw = new Stopwatch();

sw.Start();
Console.WriteLine(getFibbonacciValueDP(10000,nemo));
Console.WriteLine(getFibbonacciValueDP(20000, nemo));
Console.WriteLine(getFibbonacciValueDP(30000, nemo));
Console.WriteLine(getFibbonacciValueDP(40000, nemo));
Console.WriteLine(getFibbonacciValueDP(50000, nemo));
Console.WriteLine(getFibbonacciValueDP(10000, nemo));
Console.WriteLine(getFibbonacciValueDP(20000, nemo));
Console.WriteLine(getFibbonacciValueDP(30000, nemo));
Console.WriteLine(getFibbonacciValueDP(40000, nemo));
Console.WriteLine(getFibbonacciValueDP(50000, nemo));
Console.WriteLine(getFibbonacciValueDP(10000, nemo));
Console.WriteLine(getFibbonacciValueDP(20000, nemo));
Console.WriteLine(getFibbonacciValueDP(30000, nemo));
Console.WriteLine(getFibbonacciValueDP(40000, nemo));
Console.WriteLine(getFibbonacciValueDP(50000, nemo));
Console.WriteLine(getFibbonacciValueDP(10000, nemo));
Console.WriteLine(getFibbonacciValueDP(20000, nemo));
Console.WriteLine(getFibbonacciValueDP(30000, nemo));
Console.WriteLine(getFibbonacciValueDP(40000, nemo));
Console.WriteLine(getFibbonacciValueDP(50000, nemo));
sw.Stop();
Console.WriteLine(sw.Elapsed);


ulong getFibbonacciValueDP(int a_position2get, ulong[] a_nemo)
{
	if (a_nemo[a_position2get] == 0)
	{
		a_nemo[a_position2get] = getFibbonacciValueDP(a_position2get - 2, a_nemo) + getFibbonacciValueDP(a_position2get - 1, a_nemo);
		return a_nemo[a_position2get];
	}
	else { return a_nemo[a_position2get]; }
}

ulong getFibbonacciValueIterative(int a_position2get)
{
	ulong a = 1;
	ulong b = 1;
	ulong temp = 0;
	
	for(int i=1 ; i<a_position2get; i++) 
	{
		temp = b;
		b = a + b;
		a = temp;
	}
	return b;

}












