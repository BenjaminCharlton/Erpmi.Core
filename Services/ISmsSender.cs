using System.Threading.Tasks;

namespace Erpmi.Core.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
