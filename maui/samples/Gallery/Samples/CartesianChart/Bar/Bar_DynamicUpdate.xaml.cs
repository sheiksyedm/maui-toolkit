﻿
namespace Syncfusion.Maui.ControlsGallery.CartesianChart.SfCartesianChart
{
    public partial class Bar_DynamicUpdate : SampleView
    {
        public Bar_DynamicUpdate()
        {
            InitializeComponent();

            if (!(BaseConfig.RunTimeDeviceLayout == SBLayout.Mobile))
                viewModel.StartTimer();
        }


        public override void OnAppearing()
        {
            base.OnAppearing();
            if (BaseConfig.RunTimeDeviceLayout == SBLayout.Mobile)
            {
                viewModel.StopTimer();
                viewModel.StartTimer();
            }
        }

        public override void OnDisappearing()
        {
            base.OnDisappearing();
            viewModel?.StopTimer();

            Chart4.Handler?.DisconnectHandler();
        }
    }
}