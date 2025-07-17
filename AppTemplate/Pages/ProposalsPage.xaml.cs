using PlutoFramework.Templates.PageTemplate;

namespace AppTemplate.Pages;

public partial class ProposalsPage : PageTemplate
{
	public ProposalsPage()
	{
		InitializeComponent();

		BindingContext = new ProposalsPageViewModel();
    }
}