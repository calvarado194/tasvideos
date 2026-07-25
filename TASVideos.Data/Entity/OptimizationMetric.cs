using System.Net.NetworkInformation;

namespace TASVideos.Data.Entity;

public enum OptimizationMetric
{
	[Display(Name = "TAS Timing")]
	TASTiming,

	[Display(Name = "RTA Timing")]
	RTATiming,

	[Display(Name = "In-game Timer")]
	InGameTiming,

	[Display(Name = "Maximum Score")]
	HighScore,
	[Display(Name = "Minimum Score")]
	LowScore,
}

public static class OptimizationMetricExtensions
{
	extension(OptimizationMetric metric)
	{
		public bool IsTime() =>
			metric is OptimizationMetric.TASTiming
				or OptimizationMetric.RTATiming
				or OptimizationMetric.InGameTiming;

		public bool IsScore() =>
			metric is OptimizationMetric.HighScore
				or OptimizationMetric.LowScore;

		public bool IsAscendingOrder() =>
			metric is OptimizationMetric.HighScore;

		public bool IsTimeOverride() =>
			metric is not OptimizationMetric.TASTiming;

		public string TitleTag()
		{
			if (metric == OptimizationMetric.RTATiming)
			{
				return "(RTA)";
			}
			else if (metric == OptimizationMetric.InGameTiming)
			{
				return "(IGT)";
			}

			return "";
		}
	}
}
