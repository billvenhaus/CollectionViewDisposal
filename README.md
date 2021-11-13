Xamarin Forms CollectionView Disposal 
================

The purpose of this repository is to demonstrate a bug in the latest version of [Xamarin Forms](https://github.com/xamarin/Xamarin.Forms) (5.0.0.2196)

On Android, the item renderers of a CollectionView never get disposed. The Dispose method is only called on the CollectionView renderer itself. Its children, the item renderers, are ignored.

This is not an issue on iOS or UWP. It's only an issue on Android. Dispose is called on the item renderers for iOS and UWP.

## Testing ##

- Place breakpoints in the Dispose method of MyCheckBoxRenderer.cs
- Click Open Test
- Click the Back button to return here
- Does the breakpoint halt the program? If so, good. The Dispose method was called.