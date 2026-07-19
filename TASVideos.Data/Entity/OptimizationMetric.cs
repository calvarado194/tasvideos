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
}

public static class OptimizationMetricExtensions
{
	extension(OptimizationMetric criteria)
	{
		public bool IsTime() =>
			criteria is OptimizationMetric.TASTiming
				or OptimizationMetric.RTATiming
				or OptimizationMetric.InGameTiming;

		public bool IsScore() =>
			criteria is OptimizationMetric.HighScore;

		public bool IsAscendingOrder() =>
			criteria is OptimizationMetric.HighScore;

		public bool IsTimeOverride() =>
			criteria is not OptimizationMetric.TASTiming;
	}
}
