PhoneCall.Forms.Plugin
======================

PhoneCall.Forms.Plugin is a Xamarin Forms plugin gives the easiest way to launch the Phone dialer with single method call with a 
validated phone number.

```cs
MakeQuickCall("0491 570 156");
MakeQuickCall(TxtUserPhoneNo.Text);
```
does the magic for you. The Phone number is validated so the below are correct entries
* (+44)(0)20-12341234
* 02012341234
* +44 (0) 1234-1234

invalid entries are
* string words, names, places
* (44+)020-12341234 
* 12341234(+020)

On invalid enties feeded to the method, this will return an error dialog box.

How to use this plugin in Xamarin.Forms app
===========================================
In App.cs add the following lines in side Page to invoke this on a button click event
```cs
Button callButton = new Button { Text = "Call Sam" };
callButton.Clicked += (s, e) => QCall("+65 22456465");
```
```cs
private void QCall(string number)
{
	var notificator = DependencyService.Get<IPhoneCall>();
	notificator.MakeQuickCall (number);
}
```
And in Projects just use
```cs
Xamarin.Forms.Forms.Init (this, bundle);
PhoneCallImplementation.Init ();
```

For a detailed description visit here, http://programmium.wordpress.com/2015/01/05/how-to-implement-a-xamarin-forms-app-with-xamarin-plugins/
