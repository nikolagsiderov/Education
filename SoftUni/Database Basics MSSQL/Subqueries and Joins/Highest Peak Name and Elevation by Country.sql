SELECT
	[CountryName] AS [Country],
	ISNULL(peak.[PeakName], '(no highest peak)') AS [Highest Peak Name],
	ISNULL(MAX(ALL peak.[Elevation]), 0) AS [Highest Peak Elevation],
	ISNULL(mount.[MountainRange], '(no mountain)') AS [Mountain]
FROM [dbo].[Countries] AS country
	LEFT JOIN [dbo].[MountainsCountries] AS mountcount ON country.[CountryCode] = mountcount.[CountryCode]
	LEFT JOIN [dbo].[Mountains] AS mount ON mountcount.[MountainId] = mount.[Id]
	LEFT JOIN [dbo].[Peaks] AS peak ON mount.[Id] = peak.[MountainId]
GROUP BY country.[CountryName], peak.[PeakName], mount.[MountainRange]
ORDER BY country.[CountryName] ASC, peak.[PeakName] ASC