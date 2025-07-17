using PlutoFramework.Templates.PageTemplate;

namespace AppTemplate.Pages;

public partial class CreateProposalPage : PageTemplate
{
	public CreateProposalPage()
	{
		InitializeComponent();

		BindingContext = new CreateProposalPageViewModel();
    }
}