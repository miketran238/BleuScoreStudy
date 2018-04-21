	// C# reference code: 
	public bool IsSimilar ( String name ) {
		int idx = name. IndexOf ( '[' );
		for ( String n : part ) {
			if (n. StartsWith ( name ) ) {
				return true;
			}
		}
		return false;
	}
	// C# code translated by mppSMT:
	public bool IsSimilar( String name ) {
		int idx = name. IndexOf ( '[' );
		for ( int k = 0; k < part. Count ; ++k ) 
			if ( part [ k ] . StartsWith ( name ) ) {
			return true;
			}
		}
		return false;
	}