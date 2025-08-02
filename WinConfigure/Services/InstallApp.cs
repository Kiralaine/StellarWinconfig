namespace WinConfigure.Services;

public interface InstallApp
{
    Task<string> Install(string? location);
    Task<string> Uninstall(string? location);
}