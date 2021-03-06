﻿using UnityEngine;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SphericalCow
{
	/// <summary>
	/// 	Represents a collection of modifications applied onto select Stats, enhancing some and weakening others
	/// </summary>
	public class Ability : AbstractRpgDataType 
	{
		[SerializeField] private List<AbilityModifier> statModifiers = new List<AbilityModifier>();
		private ReadOnlyCollection<AbilityModifier> readonlyList = null;
		
		
		/// <summary>
		/// 	The list of AbilityModifiers linked to this Ability
		/// </summary>
		public ReadOnlyCollection<AbilityModifier> StatModifiers
		{
			get
			{
				if(this.readonlyList == null)
				{
					this.readonlyList = this.statModifiers.AsReadOnly();
				}
				
				return this.readonlyList;
			}
		}
		
	}
}
