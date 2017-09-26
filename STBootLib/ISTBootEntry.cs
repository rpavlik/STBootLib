
using System.IO.Ports;
namespace STBootLib
{
    public interface ISTBootEntry
    {
        void AssertReset(SerialPort port, bool asserted);
        void AssertBootloaderEntry(SerialPort port, bool asserted);
        void ResetWait();
    }
}
