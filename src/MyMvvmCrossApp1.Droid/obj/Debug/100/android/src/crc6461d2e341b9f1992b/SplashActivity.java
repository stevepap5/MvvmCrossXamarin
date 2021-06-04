package crc6461d2e341b9f1992b;


public class SplashActivity
	extends crc6426126fc9ed8a1cca.MvxFormsSplashScreenActivity_3
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MyMvvmCrossApp1.Droid.Views.SplashActivity, MyMvvmCrossApp1.Android", SplashActivity.class, __md_methods);
	}


	public SplashActivity ()
	{
		super ();
		if (getClass () == SplashActivity.class)
			mono.android.TypeManager.Activate ("MyMvvmCrossApp1.Droid.Views.SplashActivity, MyMvvmCrossApp1.Android", "", this, new java.lang.Object[] {  });
	}


	public SplashActivity (int p0)
	{
		super (p0);
		if (getClass () == SplashActivity.class)
			mono.android.TypeManager.Activate ("MyMvvmCrossApp1.Droid.Views.SplashActivity, MyMvvmCrossApp1.Android", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
