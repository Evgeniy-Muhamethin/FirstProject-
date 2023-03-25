namespace Assets.Scripts.Level
{
	internal struct DataLevel
	{
		private const int maxEnemyCountConst = 10;
		private int maxEnemyCount;

		public int MaxEnemyCountConst
		{
			get { return maxEnemyCountConst; }
		}

		public int MaxEnemyCount
		{
			get { return maxEnemyCount; }
			set { maxEnemyCount = value; }
		}
	}
}
