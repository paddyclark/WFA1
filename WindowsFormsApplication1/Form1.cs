using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

using System.Web.Http.SelfHost.Channels;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var registeredChannels = ChannelServices.RegisteredChannels;
            Text = registeredChannels.ToString();
        }
    }
}
