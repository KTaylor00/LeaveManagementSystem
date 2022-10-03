using LeaveManagementSystem.UI.Models;

namespace LeaveManagementSystem.UI.Services;

public interface IGoogleService
{
    Task CreateEvent(object leave);
}
