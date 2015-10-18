﻿using UnityEngine;

namespace SphericalCow
{
	[System.Serializable]
	public class BasicStatInstance : AbstractStatInstance 
	{
		//
		// Data
		//
		
		[System.NonSerialized] private BasicStat statReference;
		

		//
		// Constructor (Does not run on Deserialization)
		//

		public BasicStatInstance(BasicStat statData, RpgCharacterData characterData)
		{
			this.statReference = statData;
			this.character = characterData;
			this.StatId = "";	// TODO: Generate GUID as string
			this.SetStatName(this.statReference.StatName);
			this.SetLocalXpPool(0);		// Should the default XP be 0?
			this.SetNextLevelXp(100);	// TODO: Find a way to intelligently calculate this!
		}


		//
		// Methods
		//
		
		public override StatType GetStatType ()
		{
			return StatType.Basic;
		}
		
		protected override void SetupStatReference ()
		{
			// TODO: Setup BasicStatInstance is not implemented!
			throw new System.NotImplementedException ();
		}
		
	}
	
}