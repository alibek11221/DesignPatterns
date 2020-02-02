namespace SingletonLibrary
{
    public class Singleton
    {
		public int Age { get; set; }
		public string Name { get; set; }

		private static Singleton _instance;
		private static readonly object _lock = new object();

		public static Singleton Instace
		{
			get
			{
				if (_instance==null)
				{
					lock (_lock)
					{
						if (_instance==null)
						{
							_instance = new Singleton();
						}
					}
				}
				return _instance;
			}
		}

		private Singleton() { }

	}
}
