﻿using System;

namespace Start9.Api.Modules
{
	[Serializable]
	public class Message
	{
		public Module Destination;

		public string MessageText;

		public Message(Module destination, string messageText)
		{
			MessageText = messageText;
			Destination = destination;
		}

		public virtual void Fire()
		{
			Destination.GetType().GetMethod("MessageReceived")?.Invoke(Destination, new[] {this});
		}
	}

	[Serializable]
	public class Message<T> : Message
	{
		public T Object;

		public Message(T o, Module destination, string messageText = "") : base(destination, messageText)
		{
			Object = o;
			MessageText = messageText;
			Destination = destination;
		}

		/// <inheritdoc />
		public override void Fire()
		{
			Destination.GetType().GetMethod("MessageReceived")?.MakeGenericMethod(typeof(T)).Invoke(Destination, new[] {this});
		}
	}
}