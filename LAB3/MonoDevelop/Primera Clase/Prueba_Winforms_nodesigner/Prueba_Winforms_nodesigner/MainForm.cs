using System.Windows.Forms;
namespace Prueba_Winforms_nodesigner
{
    public class MainForm : Form
    {
        Label label1 = new Label();

        public MainForm()
        {
            this.SuspendLayout();

            // Initialize your components here
            this.label1.Text = "Hello, World!";

            this.Controls.Add(label1);
            this.ResumeLayout();
            this.Name = "MainForm Name.";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm Title!";

        }

    }
}
