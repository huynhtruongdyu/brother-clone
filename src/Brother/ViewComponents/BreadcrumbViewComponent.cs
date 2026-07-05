using Microsoft.AspNetCore.Mvc;

namespace Brother.ViewComponents;

public class BreadcrumbViewComponent : ViewComponent {
    private readonly IBreadcrumbService _breadcrumbService;

    public BreadcrumbViewComponent(IBreadcrumbService breadcrumbService) {
        _breadcrumbService = breadcrumbService;
    }

    public IViewComponentResult Invoke() {
        var path = HttpContext.Request.Path.Value ?? "/";
        var items = _breadcrumbService.GetBreadcrumbs(path).ToList();
        return View(items);
    }
}