using System;
using EpisodeNamespace;
using TvUtilitiesNamespace;

class Program
{
	static void Main(string[] args)
	{
		Episode ep1, ep2;
		ep1 = new Episode();
		ep2 = new Episode(10, 64.39, 8.7);
		int viewers = 10;
		for (int i = 0; i < viewers; i++)
		{

			ep1.AddView(TvUtilities.GenerateRandomScore());
			Console.WriteLine(TvUtilities.GenerateRandomScore());
		}
		if (ep1.GetAverageScore() > ep2.GetAverageScore())
		{
			Console.WriteLine($"Viewers: {ep1.GetViewerCount()}");
		}
		else
		{
			Console.WriteLine($"Viewers: {ep2.GetViewerCount()}");
		}
	}



}

