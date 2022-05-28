using System.Globalization;
using Microsoft.Maui.Dispatching;

namespace DragonArchiver.UnitTests;

// TODO: Implement this entire abstract class for more robust unit testing

// Honestly I do not know if I want to fully implement this but that will be decided later
public abstract class BaseTest : IDisposable 
{
    private readonly CultureInfo _defaultCulture, _defaultUICulture;

    private bool _isDisposed;

    protected BaseTest()
    {
        _defaultCulture = Thread.CurrentThread.CurrentCulture;
        _defaultUICulture = Thread.CurrentThread.CurrentUICulture;

        // May use this later but for now it remains commented out
        //DispatcherProvider.SetCurrent();
        //DeviceDisplay.SetCurrent(null);
    }

    ~BaseTest() => Dispose(false);

    public void Dispose() 
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool isDisposing)
    {
        if (_isDisposed)
        {
            return;
        }

        Thread.CurrentThread.CurrentCulture = _defaultCulture;
        Thread.CurrentThread.CurrentUICulture = _defaultUICulture;

        // May use this later but for now it remains commented out
        //DispatcherProvider.SetCurrent(null);
        //DeviceDisplay.SetCurrent(null);

        _isDisposed = true;
    }

    protected static Task<Stream> GetStreamFromImageSource(StreamImageSource imageSource, CancellationToken token)
        => imageSource.Stream(token);

    protected static bool StreamEquals(Stream a, Stream b)
    {
        if (a == b)
        {
            return true;
        }

        if (a.Length != b.Length)
        {
            return false;
        }

        for (var i = 0; i < a.Length; i++)
        {
            if (a.ReadByte() != b.ReadByte())
            {
                return false;
            }
        }

        return true;
    }
}