# Bulky Book Web

Using .Net 8, I able to develop MVC website

# Preview

- Main Program is Program.cs inside sln
- There will be Models, Views, Controllers Folder
- Each Controllers have they own routing and the router is same as name of controller file name
- The routing will be `localhost/{controller name}/{name of function}`
- The routing function using `IActionResult` to render

## Example:

```c#
// localhost:{port}/
// filepath: Views/Home/Index.cshtml
public IActionResult Index()
{
    return View();
}
// localhost:{port}/privacy
// filepath: Views/Home/Privacy.cshtml
public IActionResult Privacy()
{
    return View();
}
```
