namespace TASVideos.Data.Entity;

public enum OptimizationCriteria
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

public static class OptimizationCriteriaExtensions
{
	extension(OptimizationCriteria criteria)
	{
		public bool IsTime() =>
			criteria is OptimizationCriteria.TASTiming
				or OptimizationCriteria.RTATiming
				or OptimizationCriteria.InGameTiming;

		public bool IsScore() =>
			criteria is OptimizationCriteria.HighScore;

		public bool IsAscendingOrder() =>
			criteria is OptimizationCriteria.HighScore;

		public bool IsTimeOverride() =>
			criteria is not OptimizationCriteria.TASTiming;
	}
}
