using Brother.Application.Models;

namespace Brother.Application.Services;

public interface IBreadcrumbService
{
    IReadOnlyCollection<BreadcrumbItem> GetBreadcrumbs(string currentPath);
}
