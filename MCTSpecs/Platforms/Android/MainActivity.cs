using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Util;

namespace MCTSpecs;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
	public static string GetSizeName(Context context)
	{
		var screenLayout = context.Resources.Configuration.ScreenLayout;
		screenLayout &= Android.Content.Res.ScreenLayout.SizeMask;

		return screenLayout switch
		{
			Android.Content.Res.ScreenLayout.SizeSmall => "small",
			Android.Content.Res.ScreenLayout.SizeNormal => "normal",
			Android.Content.Res.ScreenLayout.SizeLarge => "large",
			// Configuration.SCREENLAYOUT_SIZE_XLARGE is API >= 9
			Android.Content.Res.ScreenLayout.SizeXlarge => "xlarge",
			_ => "undefined",
		};
	}

	public static string GetDeviceDensity(Context context)
	{
		var density = context.Resources.DisplayMetrics.DensityDpi;
		return density switch
		{
			DisplayMetricsDensity.Medium => "MDPI",
			DisplayMetricsDensity.High => "HDPI",
			DisplayMetricsDensity.Low => "LDPI",
			DisplayMetricsDensity.Xhigh => "XHDPI",
			DisplayMetricsDensity.Tv => "TV",
			DisplayMetricsDensity.Xxhigh => "XXHDPI",
			DisplayMetricsDensity.Xxxhigh => "XXXHDPI",
			_ => "Unknown",
		};
	}
}
