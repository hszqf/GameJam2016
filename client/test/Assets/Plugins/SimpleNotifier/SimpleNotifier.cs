using System;

namespace UnitySimpleNotifier
{
	public class SimpleNotifier
	{
#if UNITY_IOS && !UNITY_EDITOR
		static SimpleNotifierImplementor impl = new SimpleNotifierIos();
#elif UNITY_ANDROID && !UNITY_EDITOR
		static SimpleNotifierImplementor impl = new SimpleNotifierAndroid();
#else
		static SimpleNotifierImplementor impl = new SimpleNotifierImplementor ();
#endif
		public static void ScheduleNotification (float delay, string title, string body)
		{
			DateTime dateTime = DateTime.UtcNow.AddSeconds(delay);
			SimpleNotifier.ScheduleNotification (dateTime, title, body);
		}

		public static void ScheduleNotification (DateTime dateTime, string title, string body)
		{
			impl.ScheduleNotification (dateTime, title, body);
		}
	
		public static void CancelAllSchedule ()
		{
			impl.CancelAllSchedule ();
		}

		public static void CancelAllNotifications ()
		{
			impl.CancelAllNotifications ();
		}
	}
}