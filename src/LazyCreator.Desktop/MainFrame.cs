using LazyCreator.Engines;
using LazyCreator.Engines.Engines;
using LazyCreator.Interpreters.ConsoleInterpreter;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LazyCreator.Desktop
{
    public partial class MainFrame : Form
    {
        private string checkedButton;
        private IEngine _desktopEngine;

        public MainFrame(IEngine desktopEngine)
        {
            InitializeComponent();
            this._desktopEngine = desktopEngine;
        }

        private void EnablePathField()
        {
            this.PathBox.Enabled = true;
        }

        private void dotnetCLI_CheckedChanged(object sender, EventArgs e)
        {
            this.checkedButton = "console";
            this.EnablePathField();
        }

        private void ASPMVC_CheckedChanged(object sender, EventArgs e)
        {
            this.checkedButton = "webapp";

            this.EnablePathField();
        }

        private void API_CheckedChanged(object sender, EventArgs e)
        {
            this.checkedButton = "webapi";

            this.EnablePathField();
        }

        private void Symfony_CheckedChanged(object sender, EventArgs e)
        {
            this.checkedButton = "symfony";

            this.EnablePathField();
        }

        private void Node_CheckedChanged(object sender, EventArgs e)
        {
            this.checkedButton = "nodeexp";

            this.EnablePathField();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            var path = this.PathBox.Text;
            
            this._desktopEngine.Run(this.checkedButton, path);
        }
    }
}
