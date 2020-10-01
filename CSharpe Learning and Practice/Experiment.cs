using System.Data;
using System.Windows.Forms;

namespace CSharpe_Learning_and_Practice
{
    public partial class Experiment : Form
    {
        public Experiment(DataSet data)
        {
            InitializeComponent(data);
        }
    }
}
