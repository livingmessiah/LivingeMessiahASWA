# Review this when using Blazore.TypeAhead

## NavVM
- Not currently being used

```csharp
namespace Client.Features.Sitemap;

public class NavVM
{
	public string? Index { get; set; }
	public string? Title { get; set; }
	public string? Icon { get; set; }
}

```

## Sitemap!Index 
- Not currently being used


```html
@if (!Links!.Any())
{
	<p>Loading some links...</p>
}
else
{
	<div class="h5">

		<ul class="fa-ul">
			@foreach (var item in Nav.List.ToList()
				.Where(w => w.IsPartOfList(PageListType.SitemapPage))
				.OrderBy(o => o.Sort))
			{
				<li class="py-1">

					<span class="fa-li"><i class="@item.Icon"></i></span>
					<a href="@item.Index">
						@item.Title
					</a>

				</li>
			}
		</ul>

	</div>
}
```

@code {
```csharp
	public string SearchText = "";
	List<NavVM>? FilteredLinks = new();
	private List<NavVM>? Links = new();

	protected override void OnInitialized()
	{
		foreach (var item in Enums.Nav.List.Where(w => w.Value != Enums.Nav.Sitemap.Value).OrderBy(o => o.Sort))
		{
			Links!.Add
			(
				new NavVM { Index = item.Index, Icon = item.Icon, Title = item.Title }
			);
		}
		FilteredLinks = Links!.Where(w => w.Title!.ToLower().Contains(SearchText.ToLower())).ToList();
	}

	//List<NavVM>? FilteredLinks => Links!.Where(w => w.Text!.ToLower().Contains(SearchText.ToLower())).ToList();
}
```