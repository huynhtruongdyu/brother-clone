using System.Globalization;
using System.Text;

using Brother.Application.Models;

namespace Brother.Application.Services;

public class BreadcrumbService : IBreadcrumbService {
    private static readonly Dictionary<string, string> TitleOverrides = new(StringComparer.OrdinalIgnoreCase) {
        ["Privacy"] = "Privacy Policy"
    };

    public IReadOnlyCollection<BreadcrumbItem> GetBreadcrumbs(string currentPath) {
        ArgumentNullException.ThrowIfNull(currentPath);

        var items = new List<BreadcrumbItem>
        {
            new() { Title = "Home", Url = "/" }
        };

        var segments = currentPath.Trim('/').Split('/', StringSplitOptions.RemoveEmptyEntries);

        var sb = new StringBuilder();
        for (var i = 0; i < segments.Length; i++) {
            sb.Append('/');
            sb.Append(segments[i]);

            if (string.Equals(segments[i], "Home", StringComparison.OrdinalIgnoreCase) && i == 0)
                continue;

            if (string.Equals(segments[i], "Index", StringComparison.OrdinalIgnoreCase) && i == segments.Length - 1)
                continue;

            items.Add(new BreadcrumbItem {
                Title = FormatTitle(segments[i]),
                Url = i == segments.Length - 1 ? null : sb.ToString()
            });
        }

        return items.AsReadOnly();
    }

    private static string FormatTitle(string segment) {
        if (TitleOverrides.TryGetValue(segment, out var overridden))
            return overridden;

        return string.Join(' ', segment.Split('-').Select(s =>
            char.ToUpper(s[0], CultureInfo.InvariantCulture) + s[1..]));
    }
}