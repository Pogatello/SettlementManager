﻿using System.ComponentModel.DataAnnotations;

namespace SettlementManager.Model
{
	public class Country
	{
		#region Properties

		[Key]
		public long Id { get; private set; }

		public string Name { get; private set; }

		#endregion
	}
}
