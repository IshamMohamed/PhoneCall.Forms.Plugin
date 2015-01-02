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
