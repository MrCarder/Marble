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
			CalendarAccount = Properties.Settings.Default.CalendarAccount;
			CalendarId = Properties.Settings.Default.CalendarId;
		}
		
		public static string ApplicationName
		{
			get
			{
				return Properties.Settings.Default.ApplicationName;
			}
		}
		
		public static string DataStoreFolderNameCalendar
		{
			get
			{
				return Properties.Settings.Default.DataStoreFolderNameCalendar;
			}
		}
		
		public static string DataStoreFolderNameTasks
		{
			get
			{
				return Properties.Settings.Default.DataStoreFolderNameTasks;
			}
		}
		
		public static string ScopeCalendar
		{
			get
			{
				return Properties.Settings.Default.ScopeCalendar;
			}
		}

		public static string ScopeTasks
		{
			get
			{
				return Properties.Settings.Default.ScopeTasks;
			}
		}
		
		public static string CalendarId 
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
		
		public static string CalendarAccount
		{ 
			get
			{
				return Properties.Settings.Default.CalendarAccount;
			}
			set
			{
				Properties.Settings.Default.CalendarAccount = value;
			}
		}
		
		public static int CalendarDaysInThePast
		{
			get
			{
				return Properties.Settings.Default.CalendarDaysInPast;
			}
			set
			{
				Properties.Settings.Default.CalendarDaysInPast = value;
			}
		}
		
		public static int CalendarDaysInTheFuture
		{
			get
			{
				return Properties.Settings.Default.CalendarDaysInTheFuture;
			}
			set
			{
				Properties.Settings.Default.CalendarDaysInTheFuture = value;
			}
		}
		
		public static void Save()
		{
			Properties.Settings.Default.Save();
		}
	}
}
