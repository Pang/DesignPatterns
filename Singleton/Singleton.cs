public class Singleton {
	private static Singleton firstInstance = null;
	
	// Constructor is private so it can't be instantiated
	private Singleton(){}
	
	public static Singleton getInstance() {
		// Check firstInstance exists, if not then create it.
		if (firstInstance == null) {
			firstInstance = new Singleton();
		}
		
		return firstInstance;
	}
}
