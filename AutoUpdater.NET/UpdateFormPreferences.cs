using Microsoft.Win32;
using ReaLTaiizor.Enum.Poison;

namespace AutoUpdaterDotNET;

internal sealed class UpdateFormPreferences
{
	/// <summary>
	///     Gets or sets whether the operating system app theme preference should be mirrored.
	/// </summary>
	public bool UseOperatingSystemTheme { get; set; } = false;

	/// <summary>
	///     Gets or sets whether dark theme should be used. Overrides <see cref="UseOperatingSystemTheme" /> if set.
	/// </summary>
	public bool UseDarkTheme { get; set; } = false;

	/// <summary>
	///     Gets the desired <see cref="ThemeStyle" />. If both <see cref="UseOperatingSystemTheme" /> and
	///     <see cref="UseDarkTheme" /> are set to false, the light theme is enforced.
	/// </summary>
	public ThemeStyle Theme
	{
		get
		{
			switch (UseDarkTheme)
			{
				case false when UseOperatingSystemTheme:
				{
					using var personalizeKey =
						Registry.CurrentUser.OpenSubKey(
							@"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize");

					var useLightTheme = personalizeKey?.GetValue("AppsUseLightTheme") as int?;

					return useLightTheme > 0 ? ThemeStyle.Light : ThemeStyle.Dark;
				}
				case true:
					return ThemeStyle.Dark;
				default:
					return ThemeStyle.Light;
			}
		}
	}
}