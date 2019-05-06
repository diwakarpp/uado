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

namespace Uno.AzureDevOps.Views.Content
{
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0056", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0058", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV1003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0085", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2001", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2004", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2005", Justification="Generated code")]
	public sealed partial class OrganizationListPage : Windows.UI.Xaml.Controls.Page
	{
		private void InitializeComponent()
		{
			var nameScope = new global::Windows.UI.Xaml.NameScope();
			NameScope.SetNameScope(this, nameScope);
			// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 1:2)
			Content = 			new global::Windows.UI.Xaml.Controls.Grid
			{
				// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 8:3)
				Children = 
				{
					new global::Windows.UI.Xaml.Controls.Grid
					{
						Name = "RootLayout",
						RowDefinitions = 
						{
							new global::Windows.UI.Xaml.Controls.RowDefinition
							{
								Height = new Windows.UI.Xaml.GridLength(0f, Windows.UI.Xaml.GridUnitType.Auto),
								// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 27:6)
							}
							,
							new global::Windows.UI.Xaml.Controls.RowDefinition
							{
								Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Star),
								// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 28:6)
							}
							,
						}
						,
						// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 24:4)
						Children = 
						{
							new global::Windows.UI.Xaml.Controls.CommandBar
							{
								Content = @"My Organizations",
								PrimaryCommands = 
								{
									new global::Windows.UI.Xaml.Controls.AppBarButton
									{
										Style = ((Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.UserProfileButtonStyle)
										,
										// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 36:7)
									}
									.OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply((OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75XamlApplyExtensions.XamlApplyHandler1)(c2 => 
									{
										c2.SetBinding(global::Windows.UI.Xaml.Controls.AppBarButton.CommandProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"ToProfilePage" });
																			}
									))
									,
								}
								,
								// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 32:5)
							}
							,
							new global::Windows.UI.Xaml.Controls.Grid
							{
								// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 42:5)
								Children = 
								{
									new global::Windows.UI.Xaml.Controls.StackPanel
									{
										VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center,
										HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center,
										// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 46:6)
										Children = 
										{
											new global::Windows.UI.Xaml.Controls.ProgressRing
											{
												Height = 20d,
												Width = 20d,
												HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center,
												VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center,
												Margin = new global::Windows.UI.Xaml.Thickness(0,12),
												// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 50:7)
											}
											.OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply((OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75XamlApplyExtensions.XamlApplyHandler3)(c4 => 
											{
												c4.SetBinding(global::Windows.UI.Xaml.Controls.ProgressRing.IsActiveProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"Organizations.IsExecuting" });
																								c4.Foreground = ((Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color03Brush);
												
											}
											))
											,
											new global::Windows.UI.Xaml.Controls.TextBlock
											{
												Style = ((Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Typo08)
												,
												Text = "Loading...",
												// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 59:7)
											}
											,
										}
									}
									,
								}
							}
							.OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply((OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75XamlApplyExtensions.XamlApplyHandler6)(c7 => 
							{
								c7.SetBinding(global::Windows.UI.Xaml.Controls.Grid.VisibilityProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"Organizations.IsExecuting", Converter = (Windows.UI.Xaml.Data.IValueConverter)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.TrueToVisible, FallbackValue = @"Visible", TargetNullValue = @"Visible" });
																c7.Background = ((Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color02Brush);
								
								global::Windows.UI.Xaml.Controls.Grid.SetRow(c7, 1);
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.Grid
							{
								// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 65:5)
								Children = 
								{
									new global::Windows.UI.Xaml.Controls.TextBlock
									{
										Style = ((Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Typo10)
										,
										Text = "An error occurred, please reload to try again.",
										HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center,
										VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center,
										Margin = new global::Windows.UI.Xaml.Thickness(0,0,0,48),
										// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 70:6)
									}
									,
									new global::Windows.UI.Xaml.Controls.Button
									{
										Style = ((Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.ReloadButtonStyle)
										,
										Content = @"Reload",
										VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Bottom,
										Margin = new global::Windows.UI.Xaml.Thickness(16,22),
										// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 77:6)
									}
									.OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply((OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75XamlApplyExtensions.XamlApplyHandler7)(c9 => 
									{
										c9.SetBinding(global::Windows.UI.Xaml.Controls.Button.CommandProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"ReloadPage" });
																			}
									))
									,
								}
							}
							.OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply((OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75XamlApplyExtensions.XamlApplyHandler6)(c10 => 
							{
								c10.SetBinding(global::Windows.UI.Xaml.Controls.Grid.VisibilityProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"Organizations.IsFaulted", Converter = (Windows.UI.Xaml.Data.IValueConverter)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.TrueToVisible, FallbackValue = @"Collapsed" });
																c10.Background = ((Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color07Brush);
								
								global::Windows.UI.Xaml.Controls.Grid.SetRow(c10, 1);
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.Grid
							{
								RowDefinitions = 
								{
									new global::Windows.UI.Xaml.Controls.RowDefinition
									{
										Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Star),
										// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 89:7)
									}
									,
									new global::Windows.UI.Xaml.Controls.RowDefinition
									{
										Height = new Windows.UI.Xaml.GridLength(0f, Windows.UI.Xaml.GridUnitType.Auto),
										// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 90:7)
									}
									,
									new global::Windows.UI.Xaml.Controls.RowDefinition
									{
										Height = new Windows.UI.Xaml.GridLength(0f, Windows.UI.Xaml.GridUnitType.Auto),
										// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 91:7)
									}
									,
								}
								,
								// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 85:5)
								Children = 
								{
									new global::Windows.UI.Xaml.Controls.ListView
									{
										VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Top,
										IsItemClickEnabled = true,
										ItemTemplate = 										new global::Windows.UI.Xaml.DataTemplate(() => 										new _OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_UnoAzureDevOpsViewsContentOrganizationListPageSC0().Build()
										)										,
										// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 95:6)
									}
									.OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply((OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75XamlApplyExtensions.XamlApplyHandler8)(c14 => 
									{
										c14.SetBinding(global::Windows.UI.Xaml.Controls.ListView.ItemsSourceProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"Organizations.Result" });
																				var ItemClick_ListView_ItemClick_That = (this as global::Uno.UI.DataBinding.IWeakReferenceProvider).WeakReference;
										c14.ItemClick += (ListView_ItemClick_sender,ListView_ItemClick_e) => (ItemClick_ListView_ItemClick_That.Target as OrganizationListPage).ListView_ItemClick(ListView_ItemClick_sender,ListView_ItemClick_e);
									}
									))
									,
									new global::Windows.UI.Xaml.Controls.TextBlock
									{
										Style = ((Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Typo15)
										,
										Text = "No Organization associated with that email, please add organization to your account and come back.",
										Margin = new global::Windows.UI.Xaml.Thickness(16,12,16,0),
										// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 128:6)
									}
									.OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply((OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75XamlApplyExtensions.XamlApplyHandler4)(c15 => 
									{
										c15.SetBinding(global::Windows.UI.Xaml.Controls.TextBlock.VisibilityProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"Organizations.Result", Converter = (Windows.UI.Xaml.Data.IValueConverter)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.EnumerableHasAnyToCollapsed, FallbackValue = @"Collapsed" });
																			}
									))
									,
									new global::Windows.UI.Xaml.Controls.TextBlock
									{
										Style = ((Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Typo13)
										,
										Text = "Learn more about this app and get source code at",
										HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center,
										TextAlignment = Windows.UI.Xaml.TextAlignment.Center,
										TextWrapping = Windows.UI.Xaml.TextWrapping.Wrap,
										Margin = new global::Windows.UI.Xaml.Thickness(16,8),
										// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 134:6)
									}
									.OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply((OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75XamlApplyExtensions.XamlApplyHandler4)(c16 => 
									{
										global::Windows.UI.Xaml.Controls.Grid.SetRow(c16, 1);
									}
									))
									,
									new global::Windows.UI.Xaml.Controls.HyperlinkButton
									{
										Content = @"About Us Page",
										HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center,
										Margin = new global::Windows.UI.Xaml.Thickness(16,0,16,24),
										// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 143:6)
									}
									.OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply((OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75XamlApplyExtensions.XamlApplyHandler9)(c17 => 
									{
										c17.SetBinding(global::Windows.UI.Xaml.Controls.HyperlinkButton.CommandProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"ToAboutPage" });
																				global::Windows.UI.Xaml.Controls.Grid.SetRow(c17, 2);
									}
									))
									,
								}
							}
							.OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply((OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75XamlApplyExtensions.XamlApplyHandler6)(c18 => 
							{
								c18.SetBinding(global::Windows.UI.Xaml.Controls.Grid.VisibilityProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"Organizations.IsSuccess", Converter = (Windows.UI.Xaml.Data.IValueConverter)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.TrueToVisible, FallbackValue = @"Collapsed" });
																c18.Background = ((Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color02Brush);
								
								global::Windows.UI.Xaml.Controls.Grid.SetRow(c18, 1);
							}
							))
							,
						}
					}
					.OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply((OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75XamlApplyExtensions.XamlApplyHandler6)(c19 => 
					{
						nameScope.RegisterName("RootLayout", c19);
						this.RootLayout = c19;
						c19.Background = ((Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color02Brush);
						
					}
					))
					,
				}
			}
			.OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply((OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75XamlApplyExtensions.XamlApplyHandler6)(c20 => 
			{
				global::Windows.UI.Xaml.VisualStateManager.SetVisualStateGroups(c20, 
				new[]
				{
					new global::Windows.UI.Xaml.VisualStateGroup
					{
						// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 10:5)
						States = 
						{
							new global::Windows.UI.Xaml.VisualState
							{
								Name = "wide",
								StateTriggers = 
								{
									new global::Windows.UI.Xaml.AdaptiveTrigger
									{
										MinWindowWidth = 700d,
										// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 15:8)
									}
									,
								}
								,
								// Empty collection
								// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 12:6)
							}
							.OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply((OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75XamlApplyExtensions.XamlApplyHandler11)(c22 => 
							{
								nameScope.RegisterName("wide", c22);
								this.wide = c22;
							}
							))
							,
						}
					}
					,				}
				);
			}
			))
			;
			
			this
			.Apply((c23 => 
			{
				// Source C:\src\Uno.AzureDevOps\src\Uno.AzureDevOps\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 1:2)
			}
			))
			.Apply((c24 => 
			{
				// Class Uno.AzureDevOps.Views.Content.OrganizationListPage
			}
			))
			;
			OnInitializeCompleted();
			InitializeXamlOwner();
		}
		partial void OnInitializeCompleted();
		private global::Windows.UI.Xaml.Data.ElementNameSubject _RootLayoutSubject = new global::Windows.UI.Xaml.Data.ElementNameSubject();
		private global::Windows.UI.Xaml.Controls.Grid RootLayout
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.Grid)_RootLayoutSubject.ElementInstance;
			}
			set
			{
				_RootLayoutSubject.ElementInstance = value;
			}
		}
		private global::Windows.UI.Xaml.Data.ElementNameSubject _wideSubject = new global::Windows.UI.Xaml.Data.ElementNameSubject();
		private global::Windows.UI.Xaml.VisualState wide
		{
			get
			{
				return (global::Windows.UI.Xaml.VisualState)_wideSubject.ElementInstance;
			}
			set
			{
				_wideSubject.ElementInstance = value;
			}
		}
		private class _OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_UnoAzureDevOpsViewsContentOrganizationListPageSC0
		{
			public _View Build()
			{
				var nameScope = new global::Windows.UI.Xaml.NameScope();
				var child = 
				new global::Windows.UI.Xaml.Controls.Grid
				{
					Height = 44d,
					// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 101:9)
					Children = 
					{
						new global::Windows.UI.Xaml.Controls.TextBlock
						{
							Style = ((Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Typo08)
							,
							TextWrapping = Windows.UI.Xaml.TextWrapping.NoWrap,
							VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center,
							Margin = new global::Windows.UI.Xaml.Thickness(16,0,50,0),
							// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 104:10)
						}
						.OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply((OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75XamlApplyExtensions.XamlApplyHandler4)(c25 => 
						{
							c25.SetBinding(global::Windows.UI.Xaml.Controls.TextBlock.TextProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"AccountName" });
													}
						))
						,
						new global::Windows.UI.Xaml.Shapes.Rectangle
						{
							Height = 1d,
							VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Bottom,
							Margin = new global::Windows.UI.Xaml.Thickness(16,0,0,0),
							// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 111:10)
						}
						.OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply((OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75XamlApplyExtensions.XamlApplyHandler12)(c26 => 
						{
							c26.Fill = ((Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color07Brush);
							
						}
						))
						,
						new global::Windows.UI.Xaml.Shapes.Path
						{
							Data = @"M4.88756313,6 L0.256281566,1.46323438 C-0.0854271888,1.12849928 -0.0854271888,0.585786438 0.256281566,0.25105133 C0.597990322,-0.0836837768 1.15200968,-0.0836837768 1.49371843,0.25105133 L6.74371843,5.39390847 C7.08542719,5.72864358 7.08542719,6.27135642 6.74371843,6.60609153 L1.49371843,11.7489487 C1.15200968,12.0836838 0.597990322,12.0836838 0.256281566,11.7489487 C-0.0854271888,11.4142136 -0.0854271888,10.8715007 0.256281566,10.5367656 L4.88756313,6 Z",
							VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center,
							HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Right,
							Margin = new global::Windows.UI.Xaml.Thickness(0,0,26,0),
							// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\OrganizationListPage.xaml (Line 117:10)
						}
						.OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply((OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75XamlApplyExtensions.XamlApplyHandler13)(c27 => 
						{
							c27.Fill = ((Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color05Brush);
							
						}
						))
						,
					}
				}
				;
				if (child is DependencyObject d) Windows.UI.Xaml.NameScope.SetNameScope(d, nameScope);
				return child;
			}
		}
		class StaticResources
		{
		}
		private void InitializeXamlOwner()
		{
		}
	}
}
namespace Uno.AzureDevOps.Wasm
{
	static class OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75XamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Windows.UI.Xaml.Controls.RowDefinition instance);
		public static global::Windows.UI.Xaml.Controls.RowDefinition OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply(this global::Windows.UI.Xaml.Controls.RowDefinition instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler1(global::Windows.UI.Xaml.Controls.AppBarButton instance);
		public static global::Windows.UI.Xaml.Controls.AppBarButton OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply(this global::Windows.UI.Xaml.Controls.AppBarButton instance, XamlApplyHandler1 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler2(global::Windows.UI.Xaml.Controls.CommandBar instance);
		public static global::Windows.UI.Xaml.Controls.CommandBar OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply(this global::Windows.UI.Xaml.Controls.CommandBar instance, XamlApplyHandler2 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler3(global::Windows.UI.Xaml.Controls.ProgressRing instance);
		public static global::Windows.UI.Xaml.Controls.ProgressRing OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply(this global::Windows.UI.Xaml.Controls.ProgressRing instance, XamlApplyHandler3 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler4(global::Windows.UI.Xaml.Controls.TextBlock instance);
		public static global::Windows.UI.Xaml.Controls.TextBlock OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply(this global::Windows.UI.Xaml.Controls.TextBlock instance, XamlApplyHandler4 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler5(global::Windows.UI.Xaml.Controls.StackPanel instance);
		public static global::Windows.UI.Xaml.Controls.StackPanel OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply(this global::Windows.UI.Xaml.Controls.StackPanel instance, XamlApplyHandler5 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler6(global::Windows.UI.Xaml.Controls.Grid instance);
		public static global::Windows.UI.Xaml.Controls.Grid OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply(this global::Windows.UI.Xaml.Controls.Grid instance, XamlApplyHandler6 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler7(global::Windows.UI.Xaml.Controls.Button instance);
		public static global::Windows.UI.Xaml.Controls.Button OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply(this global::Windows.UI.Xaml.Controls.Button instance, XamlApplyHandler7 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler8(global::Windows.UI.Xaml.Controls.ListView instance);
		public static global::Windows.UI.Xaml.Controls.ListView OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply(this global::Windows.UI.Xaml.Controls.ListView instance, XamlApplyHandler8 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler9(global::Windows.UI.Xaml.Controls.HyperlinkButton instance);
		public static global::Windows.UI.Xaml.Controls.HyperlinkButton OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply(this global::Windows.UI.Xaml.Controls.HyperlinkButton instance, XamlApplyHandler9 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler10(global::Windows.UI.Xaml.AdaptiveTrigger instance);
		public static global::Windows.UI.Xaml.AdaptiveTrigger OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply(this global::Windows.UI.Xaml.AdaptiveTrigger instance, XamlApplyHandler10 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler11(global::Windows.UI.Xaml.VisualState instance);
		public static global::Windows.UI.Xaml.VisualState OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply(this global::Windows.UI.Xaml.VisualState instance, XamlApplyHandler11 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler12(global::Windows.UI.Xaml.Shapes.Rectangle instance);
		public static global::Windows.UI.Xaml.Shapes.Rectangle OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply(this global::Windows.UI.Xaml.Shapes.Rectangle instance, XamlApplyHandler12 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler13(global::Windows.UI.Xaml.Shapes.Path instance);
		public static global::Windows.UI.Xaml.Shapes.Path OrganizationListPage_955c1ef45edb287ca6e75d9f6a3f9b75_XamlApply(this global::Windows.UI.Xaml.Shapes.Path instance, XamlApplyHandler13 handler)
		{
			handler(instance);
			return instance;
		}
	}
}
