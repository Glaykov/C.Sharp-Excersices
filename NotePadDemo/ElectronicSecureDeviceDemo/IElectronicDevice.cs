namespace ElectronicSecureDeviceDemo
{
    public interface IElectronicDevice
    {
        void Start();
        void Stop();
        bool IsStarted { get; }
    }
}
