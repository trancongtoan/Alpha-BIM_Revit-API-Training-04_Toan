using System;
using System.IO;
using System.Windows;
using System.Windows.Input;
using MaterialDesignThemes.Wpf;

namespace QApps
{
    public partial class VD1Window
    {
        private VD1ViewModel _viewModel;
        readonly DLQConstraint dlqConstraint = new DLQConstraint();

        public VD1Window(VD1ViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = viewModel;
            Icon = dlqConstraint.IconWindow;
            ShadowAssist.SetShadowDepth(this, ShadowDepth.Depth0);
        }
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {


            // "PickOption1" = true thì "textnode" k xuống hàng
            // "PickOption2" = true thì "textnode" xuống hàng
            if (_viewModel.PickOption1)

                // nếu "ToUpper" = true thì "testnode" viết hoa
                // "ToLower" = true thì"testnode" viết thường
                if (_viewModel.ClickToUpper)
                    System.Windows.Forms.MessageBox.Show("Name: "+_viewModel.textnode.ToUpper());
                else
                {
                    System.Windows.Forms.MessageBox.Show("Name: "+ _viewModel.textnode.ToUpper());
                }
            else
            {
                if (_viewModel.PickOption2)

                {
                    if (_viewModel.ClickToLower)
                        System.Windows.Forms.MessageBox.Show("Name: " + "\n"+  _viewModel.textnode.ToLower());
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Name: " + "\n" + _viewModel.textnode.ToLower());
                }

            }
            DialogResult = true;
            Close();
         MessageBox.Show("Rebar: "+ _viewModel.GetFamlily + "\n"+ "Rebar Ties: "+_viewModel.SetFamlily);
        }






        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
            MessageBox.Show("Exit",String.Empty,MessageBoxButton.OK,MessageBoxImage.Stop);
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
