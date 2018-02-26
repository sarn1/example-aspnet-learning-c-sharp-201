using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson16
{
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();

            TrackAsync();
        }

        private async Task TrackAsync()
        {
            await Task.WhenAll(TrackClickAsync(button1),
                         TrackClickAsync(button2),
                         TrackClickAsync(button3));

            MessageBox.Show("All Clicked!");

            TrackAsync();
        }

        private async Task TrackClickAsync(Button button)
        {
            var taskSource = new TaskCompletionSource<bool>();

            EventHandler handler = (s, e) => taskSource.SetResult(true);

            button.Click += handler;

            await taskSource.Task;

            button.Click -= handler;
        }
    }
}
