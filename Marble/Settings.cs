﻿/*
 * Created by SharpDevelop.
 * User: smithjay
 * Date: 12/31/2014
 * Time: 8:52 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Marble
{
	/// <summary>
	/// Description of Settings.
	/// </summary>
	public static class Settings
	{
		static Settings()
		{
			UserName = Properties.Settings.Default.CalendarId;
			UserCalendar = Properties.Settings.Default.CalendarName;
		}
		
		public static string ApplicationName
		{
			get
			{
				return Properties.Settings.Default.ApplicationName;
			}
		}
		
		public static string DataStoreFolderName
		{
			get
			{
				return Properties.Settings.Default.DataStoreFolderName;
			}
		}
		
		public static string UserName 
		{ 
			get
			{
				return Properties.Settings.Default.CalendarId;
			}
			set
			{
				Properties.Settings.Default.CalendarId = value;
			}
		}
		
		public static string UserCalendar
		{ 
			get
			{
				return Properties.Settings.Default.CalendarName;
			}
			set
			{
				Properties.Settings.Default.CalendarName = value;
			}
		}
		
		public static void Save()
		{
			Properties.Settings.Default.Save();
		}
	}
}