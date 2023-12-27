using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using KustomCart.Web.Models.Basics;
using KustomCart.Web.Views.Components;

namespace KustomCart.Web.Tests.Unit.Components
{
    public partial class LoginFormComponentTests
    {
        [Fact]
        public void ShouldInitializeComponent()
        {
            // given , when
            var InitialLoginComponent = new LoginFormComponent();

            // then 
            InitialLoginComponent.UserName.Should().BeNull();

        }

        [Fact]
        public void ShouldRenderComponent()
        {
            // given 
            ComponentState expectedState = ComponentState.Content;

            // when 
            this._renderedLoginFormComponent = RenderComponent<LoginFormComponent>();

            // then 
            this._renderedLoginFormComponent.Instance.ComponentState
                .Should().Be(expectedState);

            this._renderedLoginFormComponent.Instance.UserName.Should().NotBeNull();
            this._renderedLoginFormComponent.Instance.UserName.PlaceHolder.Should().BeEquivalentTo("Username");
        }
    }
}
