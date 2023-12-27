using KustomCart.Web.Models.Basics;
using Microsoft.AspNetCore.Components;

namespace KustomCart.Web.Views.Components.Basics
{
    public partial class BasicComponent : ComponentBase
    {
        [Parameter]
        public ComponentState ComponentState { get; set; }

        [Parameter]
        public RenderFragment Loading { get; set; }

        [Parameter]
        public RenderFragment Content { get; set; }

        [Parameter]
        public RenderFragment Error { get; set; }

        public RenderFragment GetFragment()
        {
            return ComponentState switch
            {
                ComponentState.Loading => Loading,
                ComponentState.Content => Content,
                _ => Error
            };
        }
    }
}
