using KustomCart.Web.Models.Basics;
using KustomCart.Web.Views.Bases;
using Microsoft.AspNetCore.Components;

namespace KustomCart.Web.Views.Components
{
    public partial class LoginFormComponent : ComponentBase
    {
        public TextBoxBase UserName { get; set; }
        public ComponentState ComponentState { get; set; }

        protected override void OnInitialized()
        {
            this.ComponentState = ComponentState.Content;

        }
    }
}
