using System.Diagnostics;

namespace Concurrency
{
    public partial class Form1 : Form
    {
        HttpClient httpClient = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        // No problem here using async and void, because it is an event.
        private async void btnBegin_Click(object sender, EventArgs e)
        {
            // The code is located in the "Code" folder.
        }
    }
}