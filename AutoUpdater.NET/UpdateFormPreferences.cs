using Microsoft.Win32;
using ReaLTaiizor.Enum.Poison;

namespace AutoUpdaterDotNET;

internal sealed class UpdateFormPreferences
{
	/// <summary>
	///     Gets or sets whether the operating system app theme preference should be mirrored.
	/// </summary>
	public bool UseOperatingSystemTheme { get; set; } = true;

	/// <summary>
	///     Gets or sets whether dark theme should be used. Overrides <see cref="UseOperatingSystemTheme" /> if set.
	/// </summary>
	public bool UseDarkTheme { get; set; } = false;

	/// <summary>
	///		Gets the desired <see cref="ThemeStyle"/>.
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

					if (bool.TryParse(personalizeKey?.GetValue("AppsUseLightTheme") as string, out var useLightTheme))
						return useLightTheme ? ThemeStyle.Light : ThemeStyle.Dark;

					return ThemeStyle.Default;
				}
				case true:
					return ThemeStyle.Dark;
				default:
					return ThemeStyle.Light;
			}
		}
	}
}