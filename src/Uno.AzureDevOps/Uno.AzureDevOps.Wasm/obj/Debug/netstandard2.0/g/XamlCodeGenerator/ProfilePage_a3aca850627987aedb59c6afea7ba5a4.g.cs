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
	public sealed partial class ProfilePage : Windows.UI.Xaml.Controls.Page
	{
		private void InitializeComponent()
		{
			var nameScope = new global::Windows.UI.Xaml.NameScope();
			NameScope.SetNameScope(this, nameScope);
			// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 1:2)
			Content = 			new global::Windows.UI.Xaml.Controls.Grid
			{
				RowDefinitions = 
				{
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(0f, Windows.UI.Xaml.GridUnitType.Auto),
						// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 11:5)
					}
					,
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Star),
						// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 12:5)
					}
					,
				}
				,
				// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 9:3)
				Children = 
				{
					new global::Windows.UI.Xaml.Controls.CommandBar
					{
						Content = @"Profile",
						// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 31:4)
					}
					,
					new global::Windows.UI.Xaml.Controls.Grid
					{
						// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 34:4)
						Children = 
						{
							new global::Windows.UI.Xaml.Controls.StackPanel
							{
								VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center,
								HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center,
								// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 37:5)
								Children = 
								{
									new global::Windows.UI.Xaml.Controls.ProgressRing
									{
										Height = 20d,
										Width = 20d,
										HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center,
										VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center,
										Margin = new global::Windows.UI.Xaml.Thickness(0,12),
										// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 41:6)
									}
									.ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply((ProfilePage_a3aca850627987aedb59c6afea7ba5a4XamlApplyExtensions.XamlApplyHandler2)(c3 => 
									{
										c3.SetBinding(global::Windows.UI.Xaml.Controls.ProgressRing.IsActiveProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"User.IsExecuting" });
																				c3.Foreground = ((Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color03Brush);
										
									}
									))
									,
									new global::Windows.UI.Xaml.Controls.TextBlock
									{
										Style = ((Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Typo11)
										,
										Text = "Loading...",
										// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 50:6)
									}
									,
								}
							}
							,
						}
					}
					.ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply((ProfilePage_a3aca850627987aedb59c6afea7ba5a4XamlApplyExtensions.XamlApplyHandler5)(c6 => 
					{
						c6.SetBinding(global::Windows.UI.Xaml.Controls.Grid.VisibilityProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"User.IsExecuting", Converter = (Windows.UI.Xaml.Data.IValueConverter)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.TrueToVisible, FallbackValue = @"Collapsed" });
												c6.Background = ((Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color02Brush);
						
						global::Windows.UI.Xaml.Controls.Grid.SetRow(c6, 1);
					}
					))
					,
					new global::Windows.UI.Xaml.Controls.Grid
					{
						// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 56:4)
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
								// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 61:5)
							}
							,
							new global::Windows.UI.Xaml.Controls.Button
							{
								Style = ((Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.ReloadButtonStyle)
								,
								Content = @"Reload",
								VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Bottom,
								Margin = new global::Windows.UI.Xaml.Thickness(16,22),
								// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 68:5)
							}
							.ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply((ProfilePage_a3aca850627987aedb59c6afea7ba5a4XamlApplyExtensions.XamlApplyHandler6)(c8 => 
							{
								c8.SetBinding(global::Windows.UI.Xaml.Controls.Button.CommandProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"ReloadPage" });
															}
							))
							,
						}
					}
					.ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply((ProfilePage_a3aca850627987aedb59c6afea7ba5a4XamlApplyExtensions.XamlApplyHandler5)(c9 => 
					{
						c9.SetBinding(global::Windows.UI.Xaml.Controls.Grid.VisibilityProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"User.IsFaulted", Converter = (Windows.UI.Xaml.Data.IValueConverter)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.TrueToVisible, FallbackValue = @"Collapsed" });
												c9.Background = ((Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color07Brush);
						
						global::Windows.UI.Xaml.Controls.Grid.SetRow(c9, 1);
					}
					))
					,
					new global::Windows.UI.Xaml.Controls.Grid
					{
						// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 76:4)
						Children = 
						{
							new global::Windows.UI.Xaml.Controls.Grid
							{
								Name = "RootLayout",
								RowDefinitions = 
								{
									new global::Windows.UI.Xaml.Controls.RowDefinition
									{
										Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Star),
										// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 81:7)
									}
									,
									new global::Windows.UI.Xaml.Controls.RowDefinition
									{
										Height = new Windows.UI.Xaml.GridLength(0f, Windows.UI.Xaml.GridUnitType.Auto),
										// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 82:7)
									}
									,
								}
								,
								// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 79:5)
								Children = 
								{
									new global::Windows.UI.Xaml.Controls.StackPanel
									{
										// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 85:6)
										Children = 
										{
											new global::Windows.UI.Xaml.Controls.Grid
											{
												Height = 60d,
												ColumnDefinitions = 
												{
													new global::Windows.UI.Xaml.Controls.ColumnDefinition
													{
														Width = new Windows.UI.Xaml.GridLength(0f, Windows.UI.Xaml.GridUnitType.Auto),
														// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 89:9)
													}
													,
													new global::Windows.UI.Xaml.Controls.ColumnDefinition
													{
														Width = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Star),
														// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 90:9)
													}
													,
												}
												,
												// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 87:7)
												Children = 
												{
													new global::Windows.UI.Xaml.Controls.Grid
													{
														CornerRadius = new Windows.UI.Xaml.CornerRadius(16),
														Height = 32d,
														Width = 32d,
														Margin = new global::Windows.UI.Xaml.Thickness(16,0,0,0),
														// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 93:8)
														Children = 
														{
															new global::Windows.UI.Xaml.Controls.TextBlock
															{
																Style = ((Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.MemberInitialsTextBlock)
																,
																// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 100:9)
															}
															.ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply((ProfilePage_a3aca850627987aedb59c6afea7ba5a4XamlApplyExtensions.XamlApplyHandler3)(c14 => 
															{
																c14.SetBinding(global::Windows.UI.Xaml.Controls.TextBlock.TextProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"User.Result.Name", Converter = (Windows.UI.Xaml.Data.IValueConverter)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.MemberInitials });
																															}
															))
															,
															new global::Windows.UI.Xaml.Controls.Grid
															{
																CornerRadius = new Windows.UI.Xaml.CornerRadius(16),
																Height = 32d,
																Width = 32d,
																Background = 																new global::Windows.UI.Xaml.Media.ImageBrush
																{
																	// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 108:11)
																}
																.ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply((ProfilePage_a3aca850627987aedb59c6afea7ba5a4XamlApplyExtensions.XamlApplyHandler8)(c15 => 
																{
																	c15.SetBinding(global::Uno.AzureDevOps.Views.Behaviors.ImageBrushStreamSourceBehavior.SourceProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"User.Result.Image" });
																																	}
																))
																,
																// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 104:9)
															}
															,
														}
													}
													.ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply((ProfilePage_a3aca850627987aedb59c6afea7ba5a4XamlApplyExtensions.XamlApplyHandler5)(c17 => 
													{
														c17.Background = ((Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color07Brush);
														
													}
													))
													,
													new global::Windows.UI.Xaml.Controls.StackPanel
													{
														Margin = new global::Windows.UI.Xaml.Thickness(11,12,16,0),
														VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Top,
														// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 114:8)
														Children = 
														{
															new global::Windows.UI.Xaml.Controls.TextBlock
															{
																Style = ((Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Typo08)
																,
																TextWrapping = Windows.UI.Xaml.TextWrapping.NoWrap,
																// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 119:9)
															}
															.ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply((ProfilePage_a3aca850627987aedb59c6afea7ba5a4XamlApplyExtensions.XamlApplyHandler3)(c18 => 
															{
																c18.SetBinding(global::Windows.UI.Xaml.Controls.TextBlock.TextProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"User.Result.Name" });
																															}
															))
															,
															new global::Windows.UI.Xaml.Controls.TextBlock
															{
																Style = ((Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Typo18)
																,
																TextWrapping = Windows.UI.Xaml.TextWrapping.NoWrap,
																Margin = new global::Windows.UI.Xaml.Thickness(0,-2,0,0),
																// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 124:9)
															}
															.ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply((ProfilePage_a3aca850627987aedb59c6afea7ba5a4XamlApplyExtensions.XamlApplyHandler3)(c19 => 
															{
																c19.SetBinding(global::Windows.UI.Xaml.Controls.TextBlock.TextProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"User.Result.Email" });
																															}
															))
															,
														}
													}
													.ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply((ProfilePage_a3aca850627987aedb59c6afea7ba5a4XamlApplyExtensions.XamlApplyHandler4)(c20 => 
													{
														global::Windows.UI.Xaml.Controls.Grid.SetColumn(c20, 1);
													}
													))
													,
												}
											}
											,
											new global::Windows.UI.Xaml.Shapes.Rectangle
											{
												Height = 1d,
												// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 132:7)
											}
											.ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply((ProfilePage_a3aca850627987aedb59c6afea7ba5a4XamlApplyExtensions.XamlApplyHandler9)(c22 => 
											{
												c22.Fill = ((Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color07Brush);
												
											}
											))
											,
											new global::Windows.UI.Xaml.Controls.Button
											{
												Style = ((Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.ListItemButtonStyle)
												,
												Content = @"About Us",
												// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 136:7)
											}
											.ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply((ProfilePage_a3aca850627987aedb59c6afea7ba5a4XamlApplyExtensions.XamlApplyHandler6)(c23 => 
											{
												c23.SetBinding(global::Windows.UI.Xaml.Controls.Button.CommandProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"ToAboutPage" });
																							}
											))
											,
										}
									}
									,
									new global::Windows.UI.Xaml.Controls.StackPanel
									{
										// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 142:6)
										Children = 
										{
											new global::Windows.UI.Xaml.Controls.TextBlock
											{
												Style = ((Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Typo13)
												,
												Text = "Source Code available at",
												HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center,
												// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 145:7)
											}
											,
											new global::Windows.UI.Xaml.Controls.HyperlinkButton
											{
												Content = @"https://github.com/nventive/uno.azuredevops",
												HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center,
												Margin = new global::Windows.UI.Xaml.Thickness(0,-6,0,32),
												// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 150:7)
											}
											.ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply((ProfilePage_a3aca850627987aedb59c6afea7ba5a4XamlApplyExtensions.XamlApplyHandler10)(c25 => 
											{
												c25.SetBinding(global::Windows.UI.Xaml.Controls.HyperlinkButton.CommandProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"NavigateToSourceCode" });
																							}
											))
											,
											new global::Windows.UI.Xaml.Controls.Button
											{
												Style = ((Windows.UI.Xaml.Style)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.PrimaryButtonStyle)
												,
												Content = @"Log Out",
												Margin = new global::Windows.UI.Xaml.Thickness(16,0,16,24),
												// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 156:7)
											}
											.ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply((ProfilePage_a3aca850627987aedb59c6afea7ba5a4XamlApplyExtensions.XamlApplyHandler6)(c26 => 
											{
												c26.SetBinding(global::Windows.UI.Xaml.Controls.Button.CommandProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"Logout" });
																							}
											))
											,
										}
									}
									.ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply((ProfilePage_a3aca850627987aedb59c6afea7ba5a4XamlApplyExtensions.XamlApplyHandler4)(c27 => 
									{
										global::Windows.UI.Xaml.Controls.Grid.SetRow(c27, 1);
									}
									))
									,
								}
							}
							.ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply((ProfilePage_a3aca850627987aedb59c6afea7ba5a4XamlApplyExtensions.XamlApplyHandler5)(c28 => 
							{
								nameScope.RegisterName("RootLayout", c28);
								this.RootLayout = c28;
							}
							))
							,
						}
					}
					.ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply((ProfilePage_a3aca850627987aedb59c6afea7ba5a4XamlApplyExtensions.XamlApplyHandler5)(c29 => 
					{
						c29.SetBinding(global::Windows.UI.Xaml.Controls.Grid.VisibilityProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"User.IsSuccess", Converter = (Windows.UI.Xaml.Data.IValueConverter)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.TrueToVisible, FallbackValue = @"Visible" });
												global::Windows.UI.Xaml.Controls.Grid.SetRow(c29, 1);
					}
					))
					,
				}
			}
			.ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply((ProfilePage_a3aca850627987aedb59c6afea7ba5a4XamlApplyExtensions.XamlApplyHandler5)(c30 => 
			{
				c30.Background = ((Windows.UI.Xaml.Media.Brush)global::Uno.AzureDevOps.Wasm.GlobalStaticResources.Color02Brush);
				
				global::Windows.UI.Xaml.VisualStateManager.SetVisualStateGroups(c30, 
				new[]
				{
					new global::Windows.UI.Xaml.VisualStateGroup
					{
						// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 16:5)
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
										// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 21:8)
									}
									,
								}
								,
								// Empty collection
								// Source ..\..\..\..\..\..\..\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 18:6)
							}
							.ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply((ProfilePage_a3aca850627987aedb59c6afea7ba5a4XamlApplyExtensions.XamlApplyHandler12)(c32 => 
							{
								nameScope.RegisterName("wide", c32);
								this.wide = c32;
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
			.Apply((c33 => 
			{
				// Source C:\src\Uno.AzureDevOps\src\Uno.AzureDevOps\Uno.AzureDevOps.Views\Content\ProfilePage.xaml (Line 1:2)
			}
			))
			.Apply((c34 => 
			{
				// Class Uno.AzureDevOps.Views.Content.ProfilePage
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
	static class ProfilePage_a3aca850627987aedb59c6afea7ba5a4XamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Windows.UI.Xaml.Controls.RowDefinition instance);
		public static global::Windows.UI.Xaml.Controls.RowDefinition ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply(this global::Windows.UI.Xaml.Controls.RowDefinition instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler1(global::Windows.UI.Xaml.Controls.CommandBar instance);
		public static global::Windows.UI.Xaml.Controls.CommandBar ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply(this global::Windows.UI.Xaml.Controls.CommandBar instance, XamlApplyHandler1 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler2(global::Windows.UI.Xaml.Controls.ProgressRing instance);
		public static global::Windows.UI.Xaml.Controls.ProgressRing ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply(this global::Windows.UI.Xaml.Controls.ProgressRing instance, XamlApplyHandler2 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler3(global::Windows.UI.Xaml.Controls.TextBlock instance);
		public static global::Windows.UI.Xaml.Controls.TextBlock ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply(this global::Windows.UI.Xaml.Controls.TextBlock instance, XamlApplyHandler3 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler4(global::Windows.UI.Xaml.Controls.StackPanel instance);
		public static global::Windows.UI.Xaml.Controls.StackPanel ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply(this global::Windows.UI.Xaml.Controls.StackPanel instance, XamlApplyHandler4 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler5(global::Windows.UI.Xaml.Controls.Grid instance);
		public static global::Windows.UI.Xaml.Controls.Grid ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply(this global::Windows.UI.Xaml.Controls.Grid instance, XamlApplyHandler5 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler6(global::Windows.UI.Xaml.Controls.Button instance);
		public static global::Windows.UI.Xaml.Controls.Button ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply(this global::Windows.UI.Xaml.Controls.Button instance, XamlApplyHandler6 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler7(global::Windows.UI.Xaml.Controls.ColumnDefinition instance);
		public static global::Windows.UI.Xaml.Controls.ColumnDefinition ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply(this global::Windows.UI.Xaml.Controls.ColumnDefinition instance, XamlApplyHandler7 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler8(global::Windows.UI.Xaml.Media.ImageBrush instance);
		public static global::Windows.UI.Xaml.Media.ImageBrush ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply(this global::Windows.UI.Xaml.Media.ImageBrush instance, XamlApplyHandler8 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler9(global::Windows.UI.Xaml.Shapes.Rectangle instance);
		public static global::Windows.UI.Xaml.Shapes.Rectangle ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply(this global::Windows.UI.Xaml.Shapes.Rectangle instance, XamlApplyHandler9 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler10(global::Windows.UI.Xaml.Controls.HyperlinkButton instance);
		public static global::Windows.UI.Xaml.Controls.HyperlinkButton ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply(this global::Windows.UI.Xaml.Controls.HyperlinkButton instance, XamlApplyHandler10 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler11(global::Windows.UI.Xaml.AdaptiveTrigger instance);
		public static global::Windows.UI.Xaml.AdaptiveTrigger ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply(this global::Windows.UI.Xaml.AdaptiveTrigger instance, XamlApplyHandler11 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler12(global::Windows.UI.Xaml.VisualState instance);
		public static global::Windows.UI.Xaml.VisualState ProfilePage_a3aca850627987aedb59c6afea7ba5a4_XamlApply(this global::Windows.UI.Xaml.VisualState instance, XamlApplyHandler12 handler)
		{
			handler(instance);
			return instance;
		}
	}
}
