// <autogenerated />
// Xaml Source Generation is using the System Xaml Parser
#pragma warning disable 618 // Ignore obsolete members warnings
#pragma warning disable 105 // Ignore duplicate namespaces
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Uno.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Text;
using Uno.Extensions;
using Uno;
using Uno.AzureDevOps.Wasm;

#if __ANDROID__
using _View = Android.Views.View;
#elif __IOS__
using _View = UIKit.UIView;
#elif __MACOS__
using _View = AppKit.NSView;
#elif __WASM__
using _View = Windows.UI.Xaml.UIElement;
#elif NET461
using _View = Windows.UI.Xaml.UIElement;
#endif

namespace Uno.AzureDevOps.Wasm
{
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0056", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0058", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV1003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0085", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2001", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2004", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2005", Justification="Generated code")]
	public sealed partial class GlobalStaticResources
	{
		// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Styles\Controls\TextBlock.xaml (Line 16:3)
		private static bool _DefaultTextBlockStyleInitialized = false;
		private static global::Windows.UI.Xaml.Style __DefaultTextBlockStyleBackingField;

		public static global::Windows.UI.Xaml.Style DefaultTextBlockStyle
		{
			get
			{
				if(!_DefaultTextBlockStyleInitialized)
				{
					__DefaultTextBlockStyleBackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
						{
							Setters = 
							{
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.LineStackingStrategyProperty, (Windows.UI.Xaml.LineStackingStrategy)Windows.UI.Xaml.LineStackingStrategy.BlockLineHeight),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.TextTrimmingProperty, (Windows.UI.Xaml.TextTrimming)Windows.UI.Xaml.TextTrimming.CharacterEllipsis),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.TextWrappingProperty, (Windows.UI.Xaml.TextWrapping)Windows.UI.Xaml.TextWrapping.Wrap),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontFamilyProperty, () => (Windows.UI.Xaml.Media.FontFamily)
								(Windows.UI.Xaml.Media.FontFamily)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.FontFamily01
								),
							}
						}
						;
					_DefaultTextBlockStyleInitialized = true;
				}
				return __DefaultTextBlockStyleBackingField;
			}
		}

		// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Styles\Controls\TextBlock.xaml (Line 34:3)
		private static bool _Typo01Initialized = false;
		private static global::Windows.UI.Xaml.Style __Typo01BackingField;

		public static global::Windows.UI.Xaml.Style Typo01
		{
			get
			{
				if(!_Typo01Initialized)
				{
					__Typo01BackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
						{
							BasedOn = (global::Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.DefaultTextBlockStyle,
							Setters = 
							{
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.CharacterSpacingProperty, (int)42),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontSizeProperty, (double)17d),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontWeightProperty, (Windows.UI.Text.FontWeight)FontWeights.Bold),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.ForegroundProperty, () => (Windows.UI.Xaml.Media.Brush)
								(Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color02Brush
								),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontFamilyProperty, () => (Windows.UI.Xaml.Media.FontFamily)
								(Windows.UI.Xaml.Media.FontFamily)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.FontFamily01Bold
								),
							}
						}
						;
					_Typo01Initialized = true;
				}
				return __Typo01BackingField;
			}
		}

		// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Styles\Controls\TextBlock.xaml (Line 49:3)
		private static bool _Typo02Initialized = false;
		private static global::Windows.UI.Xaml.Style __Typo02BackingField;

		public static global::Windows.UI.Xaml.Style Typo02
		{
			get
			{
				if(!_Typo02Initialized)
				{
					__Typo02BackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
						{
							BasedOn = (global::Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.DefaultTextBlockStyle,
							Setters = 
							{
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontSizeProperty, (double)16d),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontWeightProperty, (Windows.UI.Text.FontWeight)FontWeights.Bold),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.ForegroundProperty, () => (Windows.UI.Xaml.Media.Brush)
								(Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color01Brush
								),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontFamilyProperty, () => (Windows.UI.Xaml.Media.FontFamily)
								(Windows.UI.Xaml.Media.FontFamily)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.FontFamily01Bold
								),
							}
						}
						;
					_Typo02Initialized = true;
				}
				return __Typo02BackingField;
			}
		}

		// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Styles\Controls\TextBlock.xaml (Line 62:3)
		private static bool _Typo03Initialized = false;
		private static global::Windows.UI.Xaml.Style __Typo03BackingField;

		public static global::Windows.UI.Xaml.Style Typo03
		{
			get
			{
				if(!_Typo03Initialized)
				{
					__Typo03BackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
						{
							BasedOn = (global::Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.DefaultTextBlockStyle,
							Setters = 
							{
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontSizeProperty, (double)16d),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontWeightProperty, (Windows.UI.Text.FontWeight)FontWeights.Bold),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.ForegroundProperty, () => (Windows.UI.Xaml.Media.Brush)
								(Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color01Brush
								),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontFamilyProperty, () => (Windows.UI.Xaml.Media.FontFamily)
								(Windows.UI.Xaml.Media.FontFamily)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.FontFamily01Bold
								),
							}
						}
						;
					_Typo03Initialized = true;
				}
				return __Typo03BackingField;
			}
		}

		// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Styles\Controls\TextBlock.xaml (Line 75:3)
		private static bool _Typo04Initialized = false;
		private static global::Windows.UI.Xaml.Style __Typo04BackingField;

		public static global::Windows.UI.Xaml.Style Typo04
		{
			get
			{
				if(!_Typo04Initialized)
				{
					__Typo04BackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
						{
							BasedOn = (global::Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.DefaultTextBlockStyle,
							Setters = 
							{
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontSizeProperty, (double)16d),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontWeightProperty, (Windows.UI.Text.FontWeight)FontWeights.Bold),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.ForegroundProperty, () => (Windows.UI.Xaml.Media.Brush)
								(Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color03Brush
								),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontFamilyProperty, () => (Windows.UI.Xaml.Media.FontFamily)
								(Windows.UI.Xaml.Media.FontFamily)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.FontFamily01Bold
								),
							}
						}
						;
					_Typo04Initialized = true;
				}
				return __Typo04BackingField;
			}
		}

		// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Styles\Controls\TextBlock.xaml (Line 88:3)
		private static bool _Typo05Initialized = false;
		private static global::Windows.UI.Xaml.Style __Typo05BackingField;

		public static global::Windows.UI.Xaml.Style Typo05
		{
			get
			{
				if(!_Typo05Initialized)
				{
					__Typo05BackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
						{
							BasedOn = (global::Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.DefaultTextBlockStyle,
							Setters = 
							{
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontSizeProperty, (double)16d),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontWeightProperty, (Windows.UI.Text.FontWeight)FontWeights.SemiBold),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.ForegroundProperty, () => (Windows.UI.Xaml.Media.Brush)
								(Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color01Brush
								),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontFamilyProperty, () => (Windows.UI.Xaml.Media.FontFamily)
								(Windows.UI.Xaml.Media.FontFamily)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.FontFamily01SemiBold
								),
							}
						}
						;
					_Typo05Initialized = true;
				}
				return __Typo05BackingField;
			}
		}

		// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Styles\Controls\TextBlock.xaml (Line 101:3)
		private static bool _Typo06Initialized = false;
		private static global::Windows.UI.Xaml.Style __Typo06BackingField;

		public static global::Windows.UI.Xaml.Style Typo06
		{
			get
			{
				if(!_Typo06Initialized)
				{
					__Typo06BackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
						{
							BasedOn = (global::Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.DefaultTextBlockStyle,
							Setters = 
							{
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontSizeProperty, (double)16d),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontWeightProperty, (Windows.UI.Text.FontWeight)FontWeights.SemiBold),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.ForegroundProperty, () => (Windows.UI.Xaml.Media.Brush)
								(Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color05Brush
								),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontFamilyProperty, () => (Windows.UI.Xaml.Media.FontFamily)
								(Windows.UI.Xaml.Media.FontFamily)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.FontFamily01SemiBold
								),
							}
						}
						;
					_Typo06Initialized = true;
				}
				return __Typo06BackingField;
			}
		}

		// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Styles\Controls\TextBlock.xaml (Line 114:3)
		private static bool _Typo07Initialized = false;
		private static global::Windows.UI.Xaml.Style __Typo07BackingField;

		public static global::Windows.UI.Xaml.Style Typo07
		{
			get
			{
				if(!_Typo07Initialized)
				{
					__Typo07BackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
						{
							BasedOn = (global::Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.DefaultTextBlockStyle,
							Setters = 
							{
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontSizeProperty, (double)16d),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontWeightProperty, (Windows.UI.Text.FontWeight)FontWeights.SemiBold),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.ForegroundProperty, () => (Windows.UI.Xaml.Media.Brush)
								(Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color07Brush
								),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontFamilyProperty, () => (Windows.UI.Xaml.Media.FontFamily)
								(Windows.UI.Xaml.Media.FontFamily)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.FontFamily01SemiBold
								),
							}
						}
						;
					_Typo07Initialized = true;
				}
				return __Typo07BackingField;
			}
		}

		// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Styles\Controls\TextBlock.xaml (Line 127:3)
		private static bool _Typo08Initialized = false;
		private static global::Windows.UI.Xaml.Style __Typo08BackingField;

		public static global::Windows.UI.Xaml.Style Typo08
		{
			get
			{
				if(!_Typo08Initialized)
				{
					__Typo08BackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
						{
							BasedOn = (global::Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.DefaultTextBlockStyle,
							Setters = 
							{
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontSizeProperty, (double)16d),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.ForegroundProperty, () => (Windows.UI.Xaml.Media.Brush)
								(Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color01Brush
								),
							}
						}
						;
					_Typo08Initialized = true;
				}
				return __Typo08BackingField;
			}
		}

		// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Styles\Controls\TextBlock.xaml (Line 136:3)
		private static bool _Typo09Initialized = false;
		private static global::Windows.UI.Xaml.Style __Typo09BackingField;

		public static global::Windows.UI.Xaml.Style Typo09
		{
			get
			{
				if(!_Typo09Initialized)
				{
					__Typo09BackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
						{
							BasedOn = (global::Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.DefaultTextBlockStyle,
							Setters = 
							{
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.CharacterSpacingProperty, (int)83),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontSizeProperty, (double)12d),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontWeightProperty, (Windows.UI.Text.FontWeight)FontWeights.Bold),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.ForegroundProperty, () => (Windows.UI.Xaml.Media.Brush)
								(Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color04Brush
								),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontFamilyProperty, () => (Windows.UI.Xaml.Media.FontFamily)
								(Windows.UI.Xaml.Media.FontFamily)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.FontFamily01Bold
								),
							}
						}
						;
					_Typo09Initialized = true;
				}
				return __Typo09BackingField;
			}
		}

		// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Styles\Controls\TextBlock.xaml (Line 151:3)
		private static bool _Typo10Initialized = false;
		private static global::Windows.UI.Xaml.Style __Typo10BackingField;

		public static global::Windows.UI.Xaml.Style Typo10
		{
			get
			{
				if(!_Typo10Initialized)
				{
					__Typo10BackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
						{
							BasedOn = (global::Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.DefaultTextBlockStyle,
							Setters = 
							{
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.CharacterSpacingProperty, (int)42),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontSizeProperty, (double)17d),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontWeightProperty, (Windows.UI.Text.FontWeight)FontWeights.Bold),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.ForegroundProperty, () => (Windows.UI.Xaml.Media.Brush)
								(Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color01Brush
								),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontFamilyProperty, () => (Windows.UI.Xaml.Media.FontFamily)
								(Windows.UI.Xaml.Media.FontFamily)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.FontFamily01Bold
								),
							}
						}
						;
					_Typo10Initialized = true;
				}
				return __Typo10BackingField;
			}
		}

		// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Styles\Controls\TextBlock.xaml (Line 166:3)
		private static bool _Typo11Initialized = false;
		private static global::Windows.UI.Xaml.Style __Typo11BackingField;

		public static global::Windows.UI.Xaml.Style Typo11
		{
			get
			{
				if(!_Typo11Initialized)
				{
					__Typo11BackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
						{
							BasedOn = (global::Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.DefaultTextBlockStyle,
							Setters = 
							{
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.CharacterSpacingProperty, (int)42),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontSizeProperty, (double)17d),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.ForegroundProperty, () => (Windows.UI.Xaml.Media.Brush)
								(Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color01Brush
								),
							}
						}
						;
					_Typo11Initialized = true;
				}
				return __Typo11BackingField;
			}
		}

		// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Styles\Controls\TextBlock.xaml (Line 177:3)
		private static bool _Typo12Initialized = false;
		private static global::Windows.UI.Xaml.Style __Typo12BackingField;

		public static global::Windows.UI.Xaml.Style Typo12
		{
			get
			{
				if(!_Typo12Initialized)
				{
					__Typo12BackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
						{
							BasedOn = (global::Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.DefaultTextBlockStyle,
							Setters = 
							{
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontSizeProperty, (double)14d),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.ForegroundProperty, () => (Windows.UI.Xaml.Media.Brush)
								(Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color05Brush
								),
							}
						}
						;
					_Typo12Initialized = true;
				}
				return __Typo12BackingField;
			}
		}

		// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Styles\Controls\TextBlock.xaml (Line 186:3)
		private static bool _Typo13Initialized = false;
		private static global::Windows.UI.Xaml.Style __Typo13BackingField;

		public static global::Windows.UI.Xaml.Style Typo13
		{
			get
			{
				if(!_Typo13Initialized)
				{
					__Typo13BackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
						{
							BasedOn = (global::Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.DefaultTextBlockStyle,
							Setters = 
							{
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontSizeProperty, (double)16d),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontWeightProperty, (Windows.UI.Text.FontWeight)FontWeights.SemiBold),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.ForegroundProperty, () => (Windows.UI.Xaml.Media.Brush)
								(Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color05Brush
								),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontFamilyProperty, () => (Windows.UI.Xaml.Media.FontFamily)
								(Windows.UI.Xaml.Media.FontFamily)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.FontFamily01SemiBold
								),
							}
						}
						;
					_Typo13Initialized = true;
				}
				return __Typo13BackingField;
			}
		}

		// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Styles\Controls\TextBlock.xaml (Line 199:3)
		private static bool _Typo14Initialized = false;
		private static global::Windows.UI.Xaml.Style __Typo14BackingField;

		public static global::Windows.UI.Xaml.Style Typo14
		{
			get
			{
				if(!_Typo14Initialized)
				{
					__Typo14BackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
						{
							BasedOn = (global::Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.DefaultTextBlockStyle,
							Setters = 
							{
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontSizeProperty, (double)14d),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.ForegroundProperty, () => (Windows.UI.Xaml.Media.Brush)
								(Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color03Brush
								),
							}
						}
						;
					_Typo14Initialized = true;
				}
				return __Typo14BackingField;
			}
		}

		// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Styles\Controls\TextBlock.xaml (Line 208:3)
		private static bool _Typo15Initialized = false;
		private static global::Windows.UI.Xaml.Style __Typo15BackingField;

		public static global::Windows.UI.Xaml.Style Typo15
		{
			get
			{
				if(!_Typo15Initialized)
				{
					__Typo15BackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
						{
							BasedOn = (global::Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.DefaultTextBlockStyle,
							Setters = 
							{
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontSizeProperty, (double)16d),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.ForegroundProperty, () => (Windows.UI.Xaml.Media.Brush)
								(Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color06Brush
								),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontFamilyProperty, () => (Windows.UI.Xaml.Media.FontFamily)
								(Windows.UI.Xaml.Media.FontFamily)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.FontFamily01Bold
								),
							}
						}
						;
					_Typo15Initialized = true;
				}
				return __Typo15BackingField;
			}
		}

		// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Styles\Controls\TextBlock.xaml (Line 219:3)
		private static bool _Typo16Initialized = false;
		private static global::Windows.UI.Xaml.Style __Typo16BackingField;

		public static global::Windows.UI.Xaml.Style Typo16
		{
			get
			{
				if(!_Typo16Initialized)
				{
					__Typo16BackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
						{
							BasedOn = (global::Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.DefaultTextBlockStyle,
							Setters = 
							{
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontSizeProperty, (double)14d),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.ForegroundProperty, () => (Windows.UI.Xaml.Media.Brush)
								(Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color05Brush
								),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontWeightProperty, (Windows.UI.Text.FontWeight)FontWeights.Bold),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontFamilyProperty, () => (Windows.UI.Xaml.Media.FontFamily)
								(Windows.UI.Xaml.Media.FontFamily)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.FontFamily01Bold
								),
							}
						}
						;
					_Typo16Initialized = true;
				}
				return __Typo16BackingField;
			}
		}

		// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Styles\Controls\TextBlock.xaml (Line 232:3)
		private static bool _Typo17Initialized = false;
		private static global::Windows.UI.Xaml.Style __Typo17BackingField;

		public static global::Windows.UI.Xaml.Style Typo17
		{
			get
			{
				if(!_Typo17Initialized)
				{
					__Typo17BackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
						{
							BasedOn = (global::Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.DefaultTextBlockStyle,
							Setters = 
							{
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontSizeProperty, (double)14d),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.ForegroundProperty, () => (Windows.UI.Xaml.Media.Brush)
								(Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color05Brush
								),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontWeightProperty, (Windows.UI.Text.FontWeight)FontWeights.SemiBold),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontFamilyProperty, () => (Windows.UI.Xaml.Media.FontFamily)
								(Windows.UI.Xaml.Media.FontFamily)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.FontFamily01SemiBold
								),
							}
						}
						;
					_Typo17Initialized = true;
				}
				return __Typo17BackingField;
			}
		}

		// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Styles\Controls\TextBlock.xaml (Line 245:3)
		private static bool _Typo18Initialized = false;
		private static global::Windows.UI.Xaml.Style __Typo18BackingField;

		public static global::Windows.UI.Xaml.Style Typo18
		{
			get
			{
				if(!_Typo18Initialized)
				{
					__Typo18BackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
						{
							BasedOn = (global::Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.DefaultTextBlockStyle,
							Setters = 
							{
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontSizeProperty, (double)14d),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.ForegroundProperty, () => (Windows.UI.Xaml.Media.Brush)
								(Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color05Brush
								),
							}
						}
						;
					_Typo18Initialized = true;
				}
				return __Typo18BackingField;
			}
		}

		// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Styles\Controls\TextBlock.xaml (Line 254:3)
		private static bool _HtmlTextBlockInitialized = false;
		private static global::Windows.UI.Xaml.Style __HtmlTextBlockBackingField;

		public static global::Windows.UI.Xaml.Style HtmlTextBlock
		{
			get
			{
				if(!_HtmlTextBlockInitialized)
				{
					__HtmlTextBlockBackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
						{
							BasedOn = (global::Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.DefaultTextBlockStyle,
							Setters = 
							{
								new global::Windows.UI.Xaml.Setter(global::Uno.AzureDevOps.Views.Behaviors.HtmlTextBlockBehavior.DisableLinksProperty, (bool)true),
								new global::Windows.UI.Xaml.Setter(global::Uno.AzureDevOps.Views.Behaviors.HtmlTextBlockBehavior.HeaderFontSizeProperty, (int)15),
								new global::Windows.UI.Xaml.Setter(global::Uno.AzureDevOps.Views.Behaviors.HtmlTextBlockBehavior.BoldFontFamilyProperty, () => (Windows.UI.Xaml.Media.FontFamily)
								(Windows.UI.Xaml.Media.FontFamily)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.FontFamily01Bold
								),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.ForegroundProperty, () => (Windows.UI.Xaml.Media.Brush)
								(Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color01Brush
								),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontSizeProperty, (double)16d),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontWeightProperty, (Windows.UI.Text.FontWeight)FontWeights.Light),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontFamilyProperty, () => (Windows.UI.Xaml.Media.FontFamily)
								(Windows.UI.Xaml.Media.FontFamily)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.FontFamily01
								),
							}
						}
						;
					_HtmlTextBlockInitialized = true;
				}
				return __HtmlTextBlockBackingField;
			}
		}

		// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Styles\Controls\TextBlock.xaml (Line 274:3)
		private static bool _MemberInitialsTextBlockInitialized = false;
		private static global::Windows.UI.Xaml.Style __MemberInitialsTextBlockBackingField;

		public static global::Windows.UI.Xaml.Style MemberInitialsTextBlock
		{
			get
			{
				if(!_MemberInitialsTextBlockInitialized)
				{
					__MemberInitialsTextBlockBackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
						{
							BasedOn = (global::Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Typo08,
							Setters = 
							{
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontSizeProperty, (double)14d),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.HorizontalAlignmentProperty, (Windows.UI.Xaml.HorizontalAlignment)Windows.UI.Xaml.HorizontalAlignment.Center),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.VerticalAlignmentProperty, (Windows.UI.Xaml.VerticalAlignment)Windows.UI.Xaml.VerticalAlignment.Center),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.OpacityProperty, (double)0.4d),
							}
						}
						;
					_MemberInitialsTextBlockInitialized = true;
				}
				return __MemberInitialsTextBlockBackingField;
			}
		}

		// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Styles\Controls\TextBlock.xaml (Line 287:3)
		private static bool _ProjectInitialsTextBlockInitialized = false;
		private static global::Windows.UI.Xaml.Style __ProjectInitialsTextBlockBackingField;

		public static global::Windows.UI.Xaml.Style ProjectInitialsTextBlock
		{
			get
			{
				if(!_ProjectInitialsTextBlockInitialized)
				{
					__ProjectInitialsTextBlockBackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
						{
							BasedOn = (global::Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.MemberInitialsTextBlock,
							Setters = 
							{
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.ForegroundProperty, () => (Windows.UI.Xaml.Media.Brush)
								(Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color02Brush
								),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.OpacityProperty, (double)1d),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontSizeProperty, (double)12d),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontWeightProperty, (Windows.UI.Text.FontWeight)FontWeights.Bold),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontFamilyProperty, () => (Windows.UI.Xaml.Media.FontFamily)
								(Windows.UI.Xaml.Media.FontFamily)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.FontFamily01Bold
								),
							}
						}
						;
					_ProjectInitialsTextBlockInitialized = true;
				}
				return __ProjectInitialsTextBlockBackingField;
			}
		}

		// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Styles\Controls\TextBlock.xaml (Line 303:3)
		private static bool ___ImplicitStyle_Windows_UI_Xaml_Controls_TextBlockInitialized = false;
		private static global::Windows.UI.Xaml.Style ____ImplicitStyle_Windows_UI_Xaml_Controls_TextBlockBackingField;

		public static global::Windows.UI.Xaml.Style __ImplicitStyle_Windows_UI_Xaml_Controls_TextBlock
		{
			get
			{
				if(!___ImplicitStyle_Windows_UI_Xaml_Controls_TextBlockInitialized)
				{
					____ImplicitStyle_Windows_UI_Xaml_Controls_TextBlockBackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
						{
							BasedOn = (global::Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.DefaultTextBlockStyle,
							Setters = 
							{
							}
						}
						;
					___ImplicitStyle_Windows_UI_Xaml_Controls_TextBlockInitialized = true;
				}
				return ____ImplicitStyle_Windows_UI_Xaml_Controls_TextBlockBackingField;
			}
		}

		static partial void RegisterResources_TextBlock_9dc42aecf7329460fa0999a2d3e1f454()
		{
			AddResolver(name =>
			{
				switch(name)
				{
					case "DefaultTextBlockStyle":
						return DefaultTextBlockStyle;
					case "Typo01":
						return Typo01;
					case "Typo02":
						return Typo02;
					case "Typo03":
						return Typo03;
					case "Typo04":
						return Typo04;
					case "Typo05":
						return Typo05;
					case "Typo06":
						return Typo06;
					case "Typo07":
						return Typo07;
					case "Typo08":
						return Typo08;
					case "Typo09":
						return Typo09;
					case "Typo10":
						return Typo10;
					case "Typo11":
						return Typo11;
					case "Typo12":
						return Typo12;
					case "Typo13":
						return Typo13;
					case "Typo14":
						return Typo14;
					case "Typo15":
						return Typo15;
					case "Typo16":
						return Typo16;
					case "Typo17":
						return Typo17;
					case "Typo18":
						return Typo18;
					case "HtmlTextBlock":
						return HtmlTextBlock;
					case "MemberInitialsTextBlock":
						return MemberInitialsTextBlock;
					case "ProjectInitialsTextBlock":
						return ProjectInitialsTextBlock;
					case "__ImplicitStyle_Windows_UI_Xaml_Controls_TextBlock":
						return __ImplicitStyle_Windows_UI_Xaml_Controls_TextBlock;
				}
				return null;
			}
			);
		}
		static partial void RegisterImplicitStylesResources_TextBlock_9dc42aecf7329460fa0999a2d3e1f454()
		{
			// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Styles\Controls\TextBlock.xaml (Line 303:3)
			Windows.UI.Xaml.Style.RegisterDefaultStyleForType(typeof(global::Windows.UI.Xaml.Controls.TextBlock), () => __ImplicitStyle_Windows_UI_Xaml_Controls_TextBlock);
		}
	}
}
namespace Uno.AzureDevOps.Wasm.__Resources
{
}
namespace Uno.AzureDevOps.Wasm
{
	static class TextBlock_9dc42aecf7329460fa0999a2d3e1f454XamlApplyExtensions
	{
	}
}