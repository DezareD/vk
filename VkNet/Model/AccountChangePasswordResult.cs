﻿using System;
using VkNet.Utils;

namespace VkNet.Model
{
	/// <summary>
	/// Результат метода account.changePassword
	/// </summary>
	[Serializable]
	public class AccountChangePasswordResult
	{
		/// <summary>
		/// Токен.
		/// </summary>
		public string Token { get; set; }

		/// <summary>
		/// secret в случае, если токен был nohttps.
		/// </summary>
		public string Secret { get; set; }
		

		/// <summary>
		/// Разобрать из json.
		/// </summary>
		/// <param name="response">Ответ сервера.</param>
		/// <returns></returns>
		public static AccountChangePasswordResult FromJson(VkResponse response)
		{
			var item = new AccountChangePasswordResult
			{
				Token = response["token"],
				Secret = response["secret"]
			};

			return item;
		}
	}
}