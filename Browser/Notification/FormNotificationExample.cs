﻿using System;
using System.Windows.Forms;
using TweetDuck.Controls;
using TweetLib.Browser.Interfaces;
using TweetLib.Core.Features.Notifications;
using TweetLib.Core.Features.Plugins;
using TweetLib.Core.Features.TweetDeck;
using TweetLib.Core.Resources;

namespace TweetDuck.Browser.Notification {
	sealed class FormNotificationExample : FormNotificationMain {
		private static NotificationBrowser CreateBrowserImpl(IBrowserComponent browserComponent, INotificationInterface notificationInterface, ITweetDeckInterface tweetDeckInterface, PluginManager pluginManager) {
			return new NotificationBrowser.Example(browserComponent, notificationInterface, tweetDeckInterface, pluginManager);
		}

		public override bool RequiresResize => true;
		protected override bool CanDragWindow => Config.NotificationPosition == DesktopNotification.Position.Custom;

		protected override FormBorderStyle NotificationBorderStyle {
			get {
				if (Config.NotificationSize == DesktopNotification.Size.Custom) {
					switch (base.NotificationBorderStyle) {
						case FormBorderStyle.FixedSingle: return FormBorderStyle.Sizable;
						case FormBorderStyle.FixedToolWindow: return FormBorderStyle.SizableToolWindow;
					}
				}

				return base.NotificationBorderStyle;
			}
		}

		public event EventHandler Ready;

		private readonly DesktopNotification exampleNotification;

		public FormNotificationExample(FormBrowser owner, ITweetDeckInterface tweetDeckInterface, PluginManager pluginManager) : base(owner, (form, browserComponent) => CreateBrowserImpl(browserComponent, new NotificationInterfaceImpl(form), tweetDeckInterface, pluginManager)) {
			browserComponent.BrowserLoaded += (sender, args) => {
				Ready?.Invoke(this, EventArgs.Empty);
			};

			string exampleTweetHTML = ResourceUtils.ReadFileOrNull("notification/example/example.html") ?? string.Empty;

			#if DEBUG
			exampleTweetHTML = exampleTweetHTML.Replace("</p>", @"</p><div style='margin-top:256px'>Scrollbar test padding...</div>");
			#endif

			exampleNotification = new DesktopNotification(string.Empty, string.Empty, "Home", exampleTweetHTML, 176, string.Empty, string.Empty);
		}

		public override void HideNotification() {
			Location = ControlExtensions.InvisibleLocation;
		}

		public override void FinishCurrentNotification() {}

		public void ShowExampleNotification(bool reset) {
			if (reset) {
				LoadTweet(exampleNotification);
			}
			else {
				PrepareAndDisplayWindow();
			}

			UpdateTitle();
		}
	}
}