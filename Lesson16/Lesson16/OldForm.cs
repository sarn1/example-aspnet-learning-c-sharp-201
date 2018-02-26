using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lesson16
{
    public partial class OldForm : Form
    {
        private readonly Dictionary<Button, bool> _tracker = 
            new Dictionary<Button, bool>(); 

        public OldForm()
        {
            InitializeComponent();

            InitButtons(button1, button2, button3);
        }

        protected void InitButtons(params Button[] buttons)
        {
            foreach (var button in buttons)
            {
                _tracker.Add(button, false);
                button.Click += ButtonClickHandler;
            }
        }

        protected void ButtonClickHandler(object sender, EventArgs e)
        {
            var button = (Button) sender;

            _tracker[button] = true;

            if (!_tracker.All(item => item.Value)) return;

            MessageBox.Show("All Clicked!");
            ResetTracker();
        }

        protected void ResetTracker()
        {
            var keys = _tracker.Keys.ToList();

            foreach (var key in keys)
            {
                _tracker[key] = false;
            }
        }
    }
}
